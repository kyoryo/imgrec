﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace ANN_Img_simple.Lib
{
    [Serializable]
    class ANN_1Layer<T>: IBackPropagation<T> where T: IComparable<T>
    {
        private int PreInputNum;
        private int OutputNum;

        private PreInput[] PreInputLayer;
        private Output<T>[] OutputLayer;

        private double learingRate = 0.2;

        public ANN_1Layer(int preInputNum, int outputNum)
        {
            PreInputNum = preInputNum;
            OutputNum = outputNum;

            PreInputLayer = new PreInput[PreInputNum];
            OutputLayer = new Output<T>[OutputNum];

        }
        #region IBackPropagation<T> Members

        public void BackPropagate()
        {
            //update 1st layer's weights
            for (int j = 0; j < OutputNum; j++)
            {
                for (int i = 0; i < PreInputNum; i++)
                {
                    PreInputLayer[i].Weights[j] += learingRate * (OutputLayer[j].Error) * PreInputLayer[i].Value;
                }
            }
        }
        public double F(double x)
        { return (1 / (1 + Math.Exp(-x))); }

        public void ForwardPropagate(double[] pattern, T output)
        {
            int i,j;
            double total = 0.0;

            //apply input to network
            for(i=0;i<PreInputNum;i++)
            {PreInputLayer[i].Value = pattern[i];}

            //calc 1st(output) layer's inputs, outputs, targets & errors
            for (i = 0; i < OutputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < PreInputNum; j++)
                {
                    total += PreInputLayer[j].Value * PreInputLayer[j].Weights[i];
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
            Random rand = new Random();
            for (int i = 0; i < PreInputNum; i++)
            {
                PreInputLayer[i].Weights = new double[OutputNum];
                for (int j = 0; j < OutputNum; j++)
                {
                    PreInputLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 2) / 100);
                }
            }
            int k = 0;
            foreach (KeyValuePair<T, double[]> p in TrainingSet)
            {
                OutputLayer[k++].Value = p.Key;
            }
        }
        public void Recognize(double[] Input, ref T MatchedHigh, ref double OutputValueHight,
            ref T MatchedLow, ref double OutputValueLow)
        {
            int i, j;
            double total = 0.0;
            double max = -1;

            //apply input to network
            for (i = 0; i < PreInputNum; i++)
            { PreInputLayer[i].Value = Input[i]; }

            //find [two] highest outputs
            for (i = 0; i < OutputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < PreInputNum; j++)
                {
                    total += PreInputLayer[j].Value * PreInputLayer[j].Weights[i];
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
            get { return learingRate; }
            set { learingRate = value; }
        }
                
    }
}
