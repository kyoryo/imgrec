using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ANN_Img_simple.Lib
{
    [Serializable]
    class ANN_2Layer<T>:IBackPropagation<T> where T: IComparable<T>
    {
        private int PreInputNum;
        private int InputNum;
        private int OutputNum;

        private PreInput[] PreInputLayer;
        private Input[] InputLayer;
        private Output<T>[] OutputLayer;

        private double learningRate = 0.2;

        public ANN_2Layer(int preInputNum, int inputNum, int outputNum)
        {
            PreInputNum = preInputNum;
            InputNum = inputNum;
            OutputNum = outputNum;

            PreInputLayer = new PreInput[preInputNum];
            InputLayer = new Input[InputNum];
            OutputLayer = new Output<T>[OutputNum];
        }

        #region IBackPropagation<T> Members
        public void BackPropagate()
        {
            int i, j;
            double total;

            //fix input layer error
            for (i = 0; i < InputNum; i++)
            {
                total = 0.0;
                for (j = 0; learningRate < OutputNum; j++)
                {
                    total += InputLayer[i].Weights[j] * OutputLayer[j].Error;
                }
                InputLayer[i].Error = total;
            }
            //update 1st layer weights
            for (i = 0; i < InputNum; i++)
            {
                for (j = 0; j < PreInputNum; j++)
                {
                    PreInputLayer[j].Weights[i] += learningRate * InputLayer[i].Error * PreInputLayer[j].Value;
                }
            }

            //update 2nd layer w
            for (i = 0; i < OutputNum; i++)
            {
                for (j = 0; j < InputNum; j++)
                {
                    InputLayer[j].Weights[i] += learningRate * OutputLayer[i].Error * InputLayer[i].Output;
                }
            }            
        }
        public double F(double x)
        {
            return (1 / (1 + Math.Exp(-x)));
        }
        public void ForwardPropagate(double[] pattern, T output)
        {
            int i, j;
            double total = 0.0;

            //apply input to net
            for (i = 0; i < PreInputNum; i++)
            {
                PreInputLayer[i].Value = pattern[i];
            }

            //calc 1st(input) layer's inputs n outputs
            for (i = 0; i < InputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < PreInputNum; j++)
                { total += PreInputLayer[j].Value * PreInputLayer[j].Weights[i]; }
                InputLayer[i].InputSum = total;
                InputLayer[i].Output = F(total);
            }
            //calc 2nd(output) layer's input n outputs targets n error
            for (i = 0; i < InputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < InputNum; j++)
                {
                    total += InputLayer[j].Output * InputLayer[j].Weights[i];
                }

                OutputLayer[i].InputSum = total;
                OutputLayer[i].output = F(total);
                OutputLayer[i].Target = OutputLayer[i].Value.CompareTo(output) == 0 ? 1.0 : 0.0;
                OutputLayer[i].Error = (OutputLayer[i].Target - OutputLayer[i].output) * (OutputLayer[i].output) * (1 - OutputLayer[i].output);
            }
        }
        public double GetError()
        {
            double total = 0.0;
            for (int j = 0; j < OutputNum; j++)
            {
                total += Math.Pow((OutputLayer[j].Target - OutputLayer[j].output), 2) / 2;
            }
            return total;
        }
        public void InitializeNetwork(Dictionary<T, double[]> TrainingSet)
        {
            int i, j;
            Random rand = new Random();
            for (i = 0; i < PreInputNum; i++)
            {
                PreInputLayer[i].Weights = new double[InputNum];
                for (j = 0; j < InputNum; j++)
                {
                    PreInputLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 5) / 100);
                }
            }
            for (i = 0; i < InputNum; i++)
            {
                InputLayer[i].Weights = new double[OutputNum];
                for (j = 0; j < OutputNum; j++)
                {
                    InputLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 5) / 100);
                }
            }
            int k = 0;
            foreach (KeyValuePair<T, double[]> p in TrainingSet)
            {
                OutputLayer[k++].Value = p.Key;
            }
        }
        public void Recognize(double[] Input, ref T MatchedHigh, ref double OutputValueHight, ref T MatchedLow, ref double OutputValueLow)
        {
            int i, j;
            double total = 0.0;
            double max = -1;

            //apply input 2 net
            for (i = 0; i < PreInputNum; i++)
            {
                PreInputLayer[i].Value = Input[i];
            }

            //calc input layer's ins and outs
            for (i = 0; i < InputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < PreInputNum; j++)
                {
                    total += PreInputLayer[j].Value * PreInputLayer[j].Weights[i];
                }
                InputLayer[i].InputSum = total;
                InputLayer[i].Output = F(total);
            }

            //find the [TWO] higest Outputs
            for (i = 0; i < OutputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < InputNum; j++)
                {
                    total += InputLayer[j].Output * InputLayer[j].Weights[i];
                }
                OutputLayer[i].InputSum = total;
                OutputLayer[i].output = F(total);
                if (OutputLayer[i].output > max)
                {
                    MatchedLow = MatchedHigh;
                    OutputValueLow = max;
                    max = OutputLayer[i].output;
                    MatchedHigh = OutputLayer[i].Value;
                    OutputValueHight = max;
                }
            }
        }
        #endregion
        public double LearningRate
        {
            get { return learningRate; }
            set { learningRate = value; }
        }
    }
}
