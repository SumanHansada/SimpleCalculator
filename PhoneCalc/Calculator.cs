using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SimpleCalculator
{
    class Calculator
    {
        static double firstNum;
        static double secondNum;
        static double result;
        public static string Sum(string num1, string num2)
        {
            try
            {
                if (num1.Contains("."))
                {
                    firstNum = Convert.ToDouble(num1);
                    secondNum = Convert.ToDouble(num2);
                    result = firstNum + secondNum;
                }
                else
                {
                    firstNum = Convert.ToInt64(num1);
                    secondNum = Convert.ToInt64(num2);
                    result = Convert.ToInt64(firstNum + secondNum);
                }
                return Convert.ToString(result);
            }
            catch(OverflowException)
            {
                return "Overflow Error";
            }
        }
        public static string Difference(string num1, string num2)
        {
            try
            {
                if (num1.Contains("."))
                {
                    firstNum = Convert.ToDouble(num1);
                    secondNum = Convert.ToDouble(num2);
                    result = firstNum - secondNum;
                }
                else
                {
                    firstNum = Convert.ToInt64(num1);
                    secondNum = Convert.ToInt64(num2);
                    result = Convert.ToInt64(firstNum - secondNum);
                }
                return Convert.ToString(result);
            }
            catch (OverflowException)
            {
                return "Overflow Error";
            }
        }
            public static string Product(string num1, string num2)
        {
            try
            {
                if (num1.Contains("."))
                {
                    firstNum = Convert.ToDouble(num1);
                    secondNum = Convert.ToDouble(num2);
                    result = firstNum * secondNum;
                }
                else
                {
                    firstNum = Convert.ToInt64(num1);
                    secondNum = Convert.ToInt64(num2);
                    result = Convert.ToInt64(firstNum * secondNum);
                }
                return Convert.ToString(result);
            }
            catch (OverflowException)
            {
                return "Overflow Error";
            }
        }
        public static string Division(string num1, string num2)
        {
            try
            {
                if (num1.Contains("."))
                {
                    firstNum = Convert.ToDouble(num1);
                    secondNum = Convert.ToDouble(num2);
                    result = firstNum / secondNum;
                }
                else
                {
                    firstNum = Convert.ToInt64(num1);
                    secondNum = Convert.ToInt64(num2);
                    result = Convert.ToInt64(firstNum / secondNum);
                }
                return Convert.ToString(result);
            }
            catch (OverflowException)
            {
                return "Overflow Error";
            }
            catch (DivideByZeroException)
            {
                return "Cannot Divide By Zero";
            }

        }

        public static string Percent(string num)
        {
            if (!num.Contains(' '))
            {
                double temp = Convert.ToDouble(num) / 100.00;
                return Convert.ToString(temp);
            }
            else
            {
                int lastIndex = num.LastIndexOf(' ');
                double number = Convert.ToDouble(num.Substring(lastIndex));
                double result = number / 100.00;
                num = num.Remove(lastIndex);
                return num + Convert.ToString(result);
            }
        }
        
    }
}