using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ANN_Img_simple.Lib
{
    interface IBackPropagation<T>
    {
        void BackPropagate();
        double F(double x);
        void ForwardPropagate(double[] pattern, T output);
        double GetError();
        void InitializeNetwork(Dictionary<T, double[]> TrainingSet);
        void Recognize(double[] Input, ref T MatchedHigh, ref double OutputValueHight, 
                                        ref T MatchedLow, ref double OutputValueLow);
    }
}
