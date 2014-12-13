namespace ANN_Img_simple
{
    partial class ANN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ANN));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRecognize = new System.Windows.Forms.Button();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxMatchedLow = new System.Windows.Forms.PictureBox();
            this.pictureBoxMatchedHigh = new System.Windows.Forms.PictureBox();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.labelMatchedLow = new System.Windows.Forms.Label();
            this.labelMatchedHigh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelIteration = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxBrowse = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBrowse = new System.Windows.Forms.RadioButton();
            this.radioButtonDraw = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonTraingBrowse = new System.Windows.Forms.Button();
            this.textBoxTrainingBrowse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxOutputUnit = new System.Windows.Forms.TextBox();
            this.textBoxHiddenUnit = new System.Windows.Forms.TextBox();
            this.textBoxInputUnit = new System.Windows.Forms.TextBox();
            this.textBoxMaxError = new System.Windows.Forms.TextBox();
            this.comboBoxLayer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.drawingPanel1 = new ANN_Img_simple.DrawingPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchedLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchedHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 344);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonStop);
            this.tabPage1.Controls.Add(this.buttonRecognize);
            this.tabPage1.Controls.Add(this.buttonTrain);
            this.tabPage1.Controls.Add(this.buttonLoad);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.labelTimer);
            this.tabPage1.Controls.Add(this.labelIteration);
            this.tabPage1.Controls.Add(this.labelError);
            this.tabPage1.Controls.Add(this.textBoxState);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.buttonBrowse);
            this.tabPage1.Controls.Add(this.textBoxBrowse);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.radioButtonBrowse);
            this.tabPage1.Controls.Add(this.radioButtonDraw);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(507, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(426, 145);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 17;
            this.buttonStop.Text = "Stop Training";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonRecognize
            // 
            this.buttonRecognize.Enabled = false;
            this.buttonRecognize.Location = new System.Drawing.Point(426, 292);
            this.buttonRecognize.Name = "buttonRecognize";
            this.buttonRecognize.Size = new System.Drawing.Size(75, 23);
            this.buttonRecognize.TabIndex = 16;
            this.buttonRecognize.Text = "Recognize";
            this.buttonRecognize.UseVisualStyleBackColor = true;
            this.buttonRecognize.Click += new System.EventHandler(this.buttonRecognize_Click);
            // 
            // buttonTrain
            // 
            this.buttonTrain.Location = new System.Drawing.Point(305, 292);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(86, 23);
            this.buttonTrain.TabIndex = 15;
            this.buttonTrain.Text = "Train Network";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(196, 291);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(84, 23);
            this.buttonLoad.TabIndex = 14;
            this.buttonLoad.Text = "Load Network";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxMatchedLow);
            this.groupBox2.Controls.Add(this.pictureBoxMatchedHigh);
            this.groupBox2.Controls.Add(this.pictureBoxInput);
            this.groupBox2.Controls.Add(this.labelMatchedLow);
            this.groupBox2.Controls.Add(this.labelMatchedHigh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(196, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 109);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matched Patterns";
            // 
            // pictureBoxMatchedLow
            // 
            this.pictureBoxMatchedLow.Location = new System.Drawing.Point(194, 36);
            this.pictureBoxMatchedLow.Name = "pictureBoxMatchedLow";
            this.pictureBoxMatchedLow.Size = new System.Drawing.Size(30, 45);
            this.pictureBoxMatchedLow.TabIndex = 5;
            this.pictureBoxMatchedLow.TabStop = false;
            // 
            // pictureBoxMatchedHigh
            // 
            this.pictureBoxMatchedHigh.Location = new System.Drawing.Point(86, 37);
            this.pictureBoxMatchedHigh.Name = "pictureBoxMatchedHigh";
            this.pictureBoxMatchedHigh.Size = new System.Drawing.Size(30, 45);
            this.pictureBoxMatchedHigh.TabIndex = 4;
            this.pictureBoxMatchedHigh.TabStop = false;
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Location = new System.Drawing.Point(10, 37);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(31, 45);
            this.pictureBoxInput.TabIndex = 3;
            this.pictureBoxInput.TabStop = false;
            // 
            // labelMatchedLow
            // 
            this.labelMatchedLow.AutoSize = true;
            this.labelMatchedLow.Location = new System.Drawing.Point(194, 20);
            this.labelMatchedLow.Name = "labelMatchedLow";
            this.labelMatchedLow.Size = new System.Drawing.Size(72, 13);
            this.labelMatchedLow.TabIndex = 2;
            this.labelMatchedLow.Text = "MatchedLow:";
            // 
            // labelMatchedHigh
            // 
            this.labelMatchedHigh.AutoSize = true;
            this.labelMatchedHigh.Location = new System.Drawing.Point(83, 20);
            this.labelMatchedHigh.Name = "labelMatchedHigh";
            this.labelMatchedHigh.Size = new System.Drawing.Size(74, 13);
            this.labelMatchedHigh.TabIndex = 1;
            this.labelMatchedHigh.Text = "Matched High";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(371, 150);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(49, 13);
            this.labelTimer.TabIndex = 12;
            this.labelTimer.Text = "00:00:00";
            // 
            // labelIteration
            // 
            this.labelIteration.AutoSize = true;
            this.labelIteration.Location = new System.Drawing.Point(268, 145);
            this.labelIteration.Name = "labelIteration";
            this.labelIteration.Size = new System.Drawing.Size(45, 13);
            this.labelIteration.TabIndex = 11;
            this.labelIteration.Text = "Iteration";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(196, 155);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(32, 13);
            this.labelError.TabIndex = 10;
            this.labelError.Text = "Error:";
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(196, 81);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxState.Size = new System.Drawing.Size(305, 60);
            this.textBoxState.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "State :";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(87, 292);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(89, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save Network";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(6, 292);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(440, 40);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(61, 23);
            this.buttonBrowse.TabIndex = 5;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxBrowse
            // 
            this.textBoxBrowse.Location = new System.Drawing.Point(196, 42);
            this.textBoxBrowse.Name = "textBoxBrowse";
            this.textBoxBrowse.Size = new System.Drawing.Size(238, 20);
            this.textBoxBrowse.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drawingPanel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 249);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing Area";
            // 
            // radioButtonBrowse
            // 
            this.radioButtonBrowse.AutoSize = true;
            this.radioButtonBrowse.Location = new System.Drawing.Point(196, 19);
            this.radioButtonBrowse.Name = "radioButtonBrowse";
            this.radioButtonBrowse.Size = new System.Drawing.Size(99, 17);
            this.radioButtonBrowse.TabIndex = 1;
            this.radioButtonBrowse.Text = "Choose Image:";
            this.radioButtonBrowse.UseVisualStyleBackColor = true;
            this.radioButtonBrowse.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonDraw
            // 
            this.radioButtonDraw.AutoSize = true;
            this.radioButtonDraw.Checked = true;
            this.radioButtonDraw.Location = new System.Drawing.Point(6, 19);
            this.radioButtonDraw.Name = "radioButtonDraw";
            this.radioButtonDraw.Size = new System.Drawing.Size(110, 17);
            this.radioButtonDraw.TabIndex = 0;
            this.radioButtonDraw.TabStop = true;
            this.radioButtonDraw.Text = "Draw Characters:";
            this.radioButtonDraw.UseVisualStyleBackColor = true;
            this.radioButtonDraw.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.buttonSaveSettings);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Saving the settings requires to load network";
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(20, 266);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSettings.TabIndex = 2;
            this.buttonSaveSettings.Text = "SaveSettings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonTraingBrowse);
            this.groupBox4.Controls.Add(this.textBoxTrainingBrowse);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(7, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(494, 93);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Training Images Properties";
            // 
            // buttonTraingBrowse
            // 
            this.buttonTraingBrowse.Location = new System.Drawing.Point(399, 48);
            this.buttonTraingBrowse.Name = "buttonTraingBrowse";
            this.buttonTraingBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonTraingBrowse.TabIndex = 2;
            this.buttonTraingBrowse.Text = "Browse";
            this.buttonTraingBrowse.UseVisualStyleBackColor = true;
            this.buttonTraingBrowse.Click += new System.EventHandler(this.buttonTraingBrowse_Click);
            // 
            // textBoxTrainingBrowse
            // 
            this.textBoxTrainingBrowse.Location = new System.Drawing.Point(13, 48);
            this.textBoxTrainingBrowse.Name = "textBoxTrainingBrowse";
            this.textBoxTrainingBrowse.Size = new System.Drawing.Size(380, 20);
            this.textBoxTrainingBrowse.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Directory of Training Images";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxOutputUnit);
            this.groupBox3.Controls.Add(this.textBoxHiddenUnit);
            this.groupBox3.Controls.Add(this.textBoxInputUnit);
            this.groupBox3.Controls.Add(this.textBoxMaxError);
            this.groupBox3.Controls.Add(this.comboBoxLayer);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 153);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Properties";
            // 
            // textBoxOutputUnit
            // 
            this.textBoxOutputUnit.Location = new System.Drawing.Point(372, 104);
            this.textBoxOutputUnit.Name = "textBoxOutputUnit";
            this.textBoxOutputUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxOutputUnit.TabIndex = 9;
            // 
            // textBoxHiddenUnit
            // 
            this.textBoxHiddenUnit.Location = new System.Drawing.Point(372, 78);
            this.textBoxHiddenUnit.Name = "textBoxHiddenUnit";
            this.textBoxHiddenUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxHiddenUnit.TabIndex = 8;
            // 
            // textBoxInputUnit
            // 
            this.textBoxInputUnit.Location = new System.Drawing.Point(372, 51);
            this.textBoxInputUnit.Name = "textBoxInputUnit";
            this.textBoxInputUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxInputUnit.TabIndex = 7;
            // 
            // textBoxMaxError
            // 
            this.textBoxMaxError.Location = new System.Drawing.Point(372, 13);
            this.textBoxMaxError.Name = "textBoxMaxError";
            this.textBoxMaxError.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxError.TabIndex = 6;
            // 
            // comboBoxLayer
            // 
            this.comboBoxLayer.FormattingEnabled = true;
            this.comboBoxLayer.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxLayer.Location = new System.Drawing.Point(147, 20);
            this.comboBoxLayer.Name = "comboBoxLayer";
            this.comboBoxLayer.Size = new System.Drawing.Size(78, 21);
            this.comboBoxLayer.TabIndex = 5;
            this.comboBoxLayer.SelectedIndexChanged += new System.EventHandler(this.comboBoxLayer_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Maximum Error:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Number of Output Unit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Number of Hidden Unit (Three Layer)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of Input Unit (Two of Three Layer)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of Layers:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "github.com/kyoryo";
            // 
            // drawingPanel1
            // 
            this.drawingPanel1.BackColor = System.Drawing.Color.White;
            this.drawingPanel1.ImageOnPanel = ((System.Drawing.Bitmap)(resources.GetObject("drawingPanel1.ImageOnPanel")));
            this.drawingPanel1.Location = new System.Drawing.Point(7, 19);
            this.drawingPanel1.Name = "drawingPanel1";
            this.drawingPanel1.PointSize = 18;
            this.drawingPanel1.Size = new System.Drawing.Size(157, 224);
            this.drawingPanel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "v0.9";
            // 
            // ANN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 375);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ANN";
            this.Text = "ANN Simple Sample";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchedLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchedHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButtonBrowse;
        private System.Windows.Forms.RadioButton radioButtonDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private DrawingPanel drawingPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelIteration;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxBrowse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonRecognize;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.PictureBox pictureBoxMatchedLow;
        private System.Windows.Forms.PictureBox pictureBoxMatchedHigh;
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.Label labelMatchedLow;
        private System.Windows.Forms.Label labelMatchedHigh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonTraingBrowse;
        private System.Windows.Forms.TextBox textBoxTrainingBrowse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOutputUnit;
        private System.Windows.Forms.TextBox textBoxHiddenUnit;
        private System.Windows.Forms.TextBox textBoxInputUnit;
        private System.Windows.Forms.TextBox textBoxMaxError;
        private System.Windows.Forms.ComboBox comboBoxLayer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;

    }
}

