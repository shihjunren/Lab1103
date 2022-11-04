using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1103
{
    internal class Math
    {
        //internal static int Abs(int Value)  //整數絕對值 
        //{
        //    return Value >= 0 ? Value : -Value;
        //}
        //internal static double Abs(double Value)   //小數
        //{
        //    return Value >= 0 ? Value : -Value;
        //}

        internal static dynamic Abs(dynamic Value)  //動態語言絕對值 (類泛型)
        {
            return Value >= 0 ? Value : -Value;
        }
    }
}
