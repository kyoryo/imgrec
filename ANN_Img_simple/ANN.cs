using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;
using System.Configuration;
using System.Threading;
using ANN_Img_simple.Lib;

namespace ANN_Img_simple
{
    public partial class ANN : Form
    {
        //Neural Network Object With output type string
        private NeuralNetwork<string> neuralNetwork = null;

        //Data members requiret 4 neuralnet
        private Dictionary<string, double[]> TrainingSet = null;
        private int av_ImageHeight = 0;
        private int av_ImageWidth = 0;
        private int NumOfPatterns = 0;

        //for asynchronized programming , instead of handling threads
        private delegate bool TrainingCallBack();
        private AsyncCallback asyCallBack = null;
        private IAsyncResult res = null;
        private ManualResetEvent ManualReset = null;

        private DateTime DTStart;

        public ANN()
        {
            InitializeComponent();
            InitializeSettings();

            GenerateTrainingSet();
            CreateNeuralNetwork();

            asyCallBack = new AsyncCallback(TrainingCompleted);
            ManualReset = new ManualResetEvent(false);          
            

        }
        void neuralNetwork_IterationChanged(object o, NeuralEventArgs args)
        {
            UpdateError(args.CurrentError);
            UpdateIteration(args.CurrentIteration);

            if (ManualReset.WaitOne(0, true))
                args.Stop = true;
        }
        

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            UpdateState("Began Training Proccess..\r\n");
            SetButtons(false);
            ManualReset.Reset();

            TrainingCallBack TR = new TrainingCallBack(neuralNetwork.Train);
            res = TR.BeginInvoke(asyCallBack, TR);
            DTStart = DateTime.Now;
            timer1.Start();
        }
        private void TrainingCompleted(IAsyncResult result)
        {
            if (result.AsyncState is TrainingCallBack)
            {
                TrainingCallBack TR = (TrainingCallBack)result.AsyncState;
                bool isSuccess = TR.EndInvoke(res);
                if (isSuccess)
                    UpdateState("Training Process Completed Successfully\r\n");
                else
                    UpdateState("Training Process is Aborted or Exceed Maximum Iteration\r\n");

                SetButtons(true);
                timer1.Stop();
            }
        }
        private void buttonRecognize_Click(object sender, EventArgs e)
        {
            string MatchedHigh = "?", MatchedLow = "?";
            double OutputValueHight = 0, OutputValueLow = 0;

            double[] input = ImageProcessing.ToMatrix(drawingPanel1.ImageOnPanel,
                av_ImageHeight, av_ImageWidth);

            neuralNetwork.Recognize(input, ref MatchedHigh, ref OutputValueHight,
                ref MatchedLow, ref OutputValueLow);

            ShowRecognitionResults(MatchedHigh, MatchedLow, OutputValueHight, OutputValueLow);
        }
        private void ShowRecognitionResults(string MatchedHigh, string MatchedLow, double OutputValueHight, double OutputValueLow)
        {
            labelMatchedHigh.Text = "High: " + MatchedHigh + " (%" + ((int)100 * OutputValueHight).ToString("##") + ")";
            labelMatchedLow.Text = "Low: " + MatchedLow + " (%" + ((int)100 * OutputValueLow).ToString("##") + ")";

            pictureBoxInput.Image = new Bitmap(drawingPanel1.ImageOnPanel,
                pictureBoxInput.Width, pictureBoxInput.Height);

            if (MatchedHigh != "?")
                pictureBoxMatchedHigh.Image = new Bitmap(new Bitmap(textBoxTrainingBrowse.Text + "\\" + MatchedHigh + ".bmp"),
                    pictureBoxMatchedHigh.Width, pictureBoxMatchedHigh.Height);
            if (MatchedLow != "?")
                pictureBoxMatchedLow.Image = new Bitmap(new Bitmap(textBoxTrainingBrowse.Text + "\\" + MatchedLow + ".bmp"),
                    pictureBoxMatchedLow.Width, pictureBoxMatchedLow.Height);
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            drawingPanel1.Clear();
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            FD.Filter = "Bitmap Image(*.bmp)|*.bmp";
            FD.InitialDirectory = textBoxTrainingBrowse.Text;

            if (FD.ShowDialog() == DialogResult.OK)
            {
                string FileName = FD.FileName;
                if (Path.GetExtension(FileName) == ".bmp")
                {
                    textBoxBrowse.Text = FileName;
                    drawingPanel1.ImageOnPanel = new Bitmap(new Bitmap(FileName),
                        drawingPanel1.Width, drawingPanel1.Height);
                }
            }
            FD.Dispose();
        }
        private void buttonTraingBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FD = new FolderBrowserDialog();
            FD.SelectedPath = textBoxTrainingBrowse.Text;

            if (FD.ShowDialog() == DialogResult.OK)
            {
                textBoxTrainingBrowse.Text = FD.SelectedPath;
            }
            FD.Dispose();
        }


        private void GenerateTrainingSet()
        {
            textBoxState.AppendText("Generating Training Set...");

            string[] Patterns = Directory.GetFiles(textBoxTrainingBrowse.Text, "*.bmp");

            TrainingSet = new Dictionary<string, double[]>(Patterns.Length);
            foreach (string s in Patterns)
            {
                Bitmap Temp = new Bitmap(s);
                TrainingSet.Add(Path.GetFileNameWithoutExtension(s),
                    ImageProcessing.ToMatrix(Temp, av_ImageHeight, av_ImageWidth));
                Temp.Dispose();
            }
            textBoxState.AppendText("Done!!\r\n");
        }
        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            textBoxState.AppendText("Saving Settings...");

            string[] Images = Directory.GetFiles(textBoxTrainingBrowse.Text, "*.bmp");
            NumOfPatterns = Images.Length;

            av_ImageHeight = 0;
            av_ImageWidth = 0;

            foreach (string s in Images)
            {
                Bitmap Temp = new Bitmap(s);
                av_ImageHeight += Temp.Height;
                av_ImageWidth += Temp.Width;
                Temp.Dispose();
            }
            av_ImageHeight /= NumOfPatterns;
            av_ImageWidth /= NumOfPatterns;

            int networkInput = av_ImageHeight * av_ImageWidth;
            //textBoxInputUnit.Text = ((int)((double)(networkInput + NumOfPatterns) * .5)).ToString();
            //textBoxHiddenUnit.Text = ((int)((double)(networkInput + NumOfPatterns) * .3)).ToString();
            textBoxOutputUnit.Text = NumOfPatterns.ToString();

            buttonRecognize.Enabled = false;
            buttonSave.Enabled = false;

            textBoxState.AppendText("Done!!!\r\n");

            GenerateTrainingSet();
            CreateNeuralNetwork();

        }

        private void InitializeSettings()
        {
            textBoxState.AppendText("Initializing Settings...");
            try
            {
                NameValueCollection AppSettings = ConfigurationManager.AppSettings;

                comboBoxLayer.SelectedIndex = (Int16.Parse(AppSettings["NumOFLayers"]) - 1);
                textBoxTrainingBrowse.Text = Path.GetFullPath(AppSettings["PatternsDirectory"]);
                textBoxMaxError.Text = AppSettings["MaxError"];

                string[] Images = Directory.GetFiles(textBoxTrainingBrowse.Text, "*.bmp");
                NumOfPatterns = Images.Length;

                av_ImageHeight = 0;
                av_ImageWidth = 0;

                foreach (string s in Images)
                {
                    Bitmap Temp = new Bitmap(s);
                    av_ImageHeight += Temp.Height;
                    av_ImageWidth += Temp.Width;
                    Temp.Dispose();
                }
                av_ImageHeight /= NumOfPatterns;
                av_ImageWidth /= NumOfPatterns;

                int networkInput = av_ImageHeight * av_ImageWidth;

                textBoxInputUnit.Text = ((int)((double)(networkInput + NumOfPatterns) * .33)).ToString();
                textBoxHiddenUnit.Text = ((int)((double)(networkInput + NumOfPatterns) * .11)).ToString();
                textBoxOutputUnit.Text = NumOfPatterns.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Initializing Settings: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxState.AppendText("Done!!!!\r\n");
        }
        private void CreateNeuralNetwork()
        {
            if (TrainingSet == null)
                throw new Exception("Unable to Create Neural Network As There is No Data to Train...");
            if (comboBoxLayer.SelectedIndex == 0)
            {
                neuralNetwork = new NeuralNetwork<string>
                       (new ANN_1Layer<string>(av_ImageHeight * av_ImageWidth, NumOfPatterns), TrainingSet);
            }
            else if (comboBoxLayer.SelectedIndex == 1)
            {
                int InputNum = Int16.Parse(textBoxInputUnit.Text);

                neuralNetwork = new NeuralNetwork<string>
                    (new ANN_2Layer<string>(av_ImageHeight * av_ImageWidth, InputNum, NumOfPatterns), TrainingSet);
            }
            else if (comboBoxLayer.SelectedIndex == 2)
            {
                int InputNum = Int16.Parse(textBoxInputUnit.Text);
                int HiddenNum = Int16.Parse(textBoxHiddenUnit.Text);

                neuralNetwork = new NeuralNetwork<string>
                    (new ANN_3Layer<string>(av_ImageHeight * av_ImageWidth, InputNum, HiddenNum, NumOfPatterns), TrainingSet);
            }

            neuralNetwork.IterationChanged +=
                new NeuralNetwork<string>.IterationChangedCallBack(neuralNetwork_IterationChanged);

            neuralNetwork.MaximumError = Double.Parse(textBoxMaxError.Text);
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            ManualReset.Set();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TSElapsed = DateTime.Now.Subtract(DTStart);
            UpdateTimer(TSElapsed.Hours.ToString("D2") + ":" +
                TSElapsed.Minutes.ToString("D2") + ":" +
                TSElapsed.Seconds.ToString("D2"));
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Network File(*.net)|*.net";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                neuralNetwork.SaveNetwork(fd.FileName);
            }
            fd.Dispose();
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Network File(*.net)|*.net";
            fd.InitialDirectory = Application.StartupPath;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                neuralNetwork.LoadNetwork(fd.FileName);
            }
            buttonRecognize.Enabled = true;
            buttonSave.Enabled = true;

            fd.Dispose();
        }

        #region methods to invoke UI Components
        private delegate void UpdateUI(object o);
        private void SetButtons(object o)
        {
            //if invoke is required for a control, sure, it is also required for others
            //then, it is not needed to check all controls
            if (buttonStop.InvokeRequired)
            {
                buttonStop.Invoke(new UpdateUI(SetButtons), o);
            }
            else
            {
                bool b = (bool)o;
                buttonStop.Enabled = !b;
                buttonRecognize.Enabled = b;
                buttonTrain.Enabled = b;
                buttonLoad.Enabled = b;
                buttonSave.Enabled = b;
            }
        }
        private void UpdateError(object o)
        {
            if (labelError.InvokeRequired)
            {
                labelError.Invoke(new UpdateUI(UpdateError), o);
            }
            else
            {
                labelError.Text = "Error: " + ((double)o).ToString(".###");
            }
        }
        private void UpdateIteration(object o)
        {
            if (labelIteration.InvokeRequired)
            {
                labelIteration.Invoke(new UpdateUI(UpdateIteration), o);
            }
            else
            {
                labelIteration.Text = "Iteration: " + ((int)o).ToString();
            }
        }
        private void UpdateState(object o)
        {
            if (textBoxState.InvokeRequired)
            {
                textBoxState.Invoke(new UpdateUI(UpdateState), o);
            }
            else
            {
                textBoxState.AppendText((string)o);
            }
        }
        private void UpdateTimer(object o)
        {
            if (labelTimer.InvokeRequired)
            {
                labelTimer.Invoke(new UpdateUI(UpdateTimer), o); 
            }
            else
            {
                labelTimer.Text = (string)o;
            }
        }

        #endregion

        #region RadioButton and CheckBox Event Handlers- Ignore Plz
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBrowse.Checked)
            {
                textBoxBrowse.Enabled = true;
                buttonBrowse.Enabled = true;
                drawingPanel1.Enabled = false;
            }
            else
            {
                textBoxBrowse.Enabled = false;
                buttonBrowse.Enabled = false;
                drawingPanel1.Enabled = true;
            }

        }
        private void comboBoxLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLayer.SelectedIndex == 0)
            {
                textBoxInputUnit.Enabled = false;
                textBoxHiddenUnit.Enabled = false;
            }
            else if (comboBoxLayer.SelectedIndex == 1)
            {
                textBoxInputUnit.Enabled = true;
                textBoxHiddenUnit.Enabled = false;
            }
            else if (comboBoxLayer.SelectedIndex == 2)
            {
                textBoxInputUnit.Enabled = true;
                textBoxHiddenUnit.Enabled = true;
            }
        }

        #endregion


 















    }
}
