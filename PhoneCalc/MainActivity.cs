using System;
using Android.App;
using Android.Widget;
using Android.OS;
using NCalc;
using Android.Content;
using Android.Runtime;
using Android.Views;

namespace SimpleCalculator
{
    [Activity(Label = "Simple Calculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            TextView display = FindViewById<TextView>(Resource.Id.display);
            Button number0 = FindViewById<Button>(Resource.Id.number0);
            Button number1 = FindViewById<Button>(Resource.Id.number1);
            Button number2 = FindViewById<Button>(Resource.Id.number2);
            Button number3 = FindViewById<Button>(Resource.Id.number3);
            Button number4 = FindViewById<Button>(Resource.Id.number4);
            Button number5 = FindViewById<Button>(Resource.Id.number5);
            Button number6 = FindViewById<Button>(Resource.Id.number6);
            Button number7 = FindViewById<Button>(Resource.Id.number7);
            Button number8 = FindViewById<Button>(Resource.Id.number8);
            Button number9 = FindViewById<Button>(Resource.Id.number9);
            Button dot = FindViewById<Button>(Resource.Id.dot);
            Button add = FindViewById<Button>(Resource.Id.add);
            Button subtract = FindViewById<Button>(Resource.Id.subtract);
            Button multiply = FindViewById<Button>(Resource.Id.multiply);
            Button divide = FindViewById<Button>(Resource.Id.divide);
            Button sign = FindViewById<Button>(Resource.Id.sign);
            Button percent = FindViewById<Button>(Resource.Id.percent);
            Button equal = FindViewById<Button>(Resource.Id.equal);
            Button clear = FindViewById<Button>(Resource.Id.clear);
            Button delete = FindViewById<Button>(Resource.Id.delete);

            display.Text = "0";

            string displayedNumber = string.Empty;
            string firstNumber = string.Empty;
            string secondNumber = string.Empty;
            string operand = string.Empty;
            string formula = string.Empty;

            number0.Click += (object sender, EventArgs e) =>
            {
                displayedNumber = "0";
                if (display.Text == "0")
                {
                    display.Text = displayedNumber;
                }
                else
                {
                    display.Text = display.Text + displayedNumber;
                }
            };

            number1.Click += (object sender, EventArgs e) =>
            {
                displayedNumber = "1";
                if(display.Text == "0")
                {
                    display.Text = displayedNumber;
                }
                else
                {
                    display.Text = display.Text + displayedNumber;
                }
            };

            number2.Click += (object sender, EventArgs e) =>
            {
                displayedNumber = "2";
                if (display.Text == "0")
                {
                    display.Text = displayedNumber;
                }
                else
                {
                    display.Text = display.Text + displayedNumber;
                }
            };

            number3.Click += (object sender, EventArgs e) =>
            {
                displayedNumber = "3";
                if (display.Text == "0")
                {
                    display.Text = displayedNumber;
                }
                else
                {
                    display.Text = display.Text + displayedNumber;
                }
            };

            number4.Click += (object sender, EventArgs e) =>
            {
                displayedNumber = "4";
                if (display.Text == "0")
                {
                    display.Text = displayedNumber;
                }
                else
                {
                    display.Text = display.Text + displayedNumber;
                }
            };

            number5.Click += (object sender, EventArgs e) =>
            {
                displayedNumber = "5";
                if (display.Text == "0")
                {
                    display.Text = displayedNumber;
                }
                else
                {
                    display.Text = display.Text + displayedNumber;
                }
            };

            number6.Click += (object sender, EventArgs e) =>
            {
                displayedNumber = "6";
                if (display.Text == "0")
                {
                    display.Text = displayedNumber;
                }
                else
                {
                    display.Text = display.Text + displayedNumber;
                }
            };

            number7.Click += (object sender, EventArgs e) =>
            {
                displayedNumber = "7";
                if (display.Text == "0")
                {
                    display.Text = displayedNumber;
                }
                else
                {
                    display.Text = display.Text + displayedNumber;
                }
            };

            number8.Click += (object sender, EventArgs e) =>
            {
                displayedNumber = "8";
                if (display.Text == "0")
                {
                    display.Text = displayedNumber;
                }
                else
                {
                    display.Text = display.Text + displayedNumber;
                }
            };

            number9.Click += (object sender, EventArgs e) =>
            {
                displayedNumber = "9";
                if (display.Text == "0")
                {
                    display.Text = displayedNumber;
                }
                else
                {
                    display.Text = display.Text + displayedNumber;
                }
            };

            dot.Click += (object sender, EventArgs e) =>
            {
                displayedNumber = ".";
                if (display.Text == "0")
                {
                    display.Text = displayedNumber;
                }
                else
                {
                    display.Text = display.Text + displayedNumber;
                }
            };

            percent.Click += (object sender, EventArgs e) =>
            {
                string result = Calculator.Percent(display.Text);
                display.Text = result;

            };

            sign.Click += (object sender, EventArgs e) =>
            {
                if (display.Text.EndsWith(")"))
                {
                    string tempText = display.Text; 
                    tempText = tempText.Remove(tempText.IndexOf("("), 1);
                    tempText = tempText.Remove(tempText.IndexOf("-"), 1);
                    tempText = tempText.Remove(tempText.IndexOf(")"), 1);
                    display.Text = tempText;
                }
                else
                {
                    displayedNumber = "(-";
                    int lastIndex = display.Text.LastIndexOf(' ');
                    string newText = display.Text.Insert(lastIndex + 1, displayedNumber);

                    int textLength = newText.Length;
                    newText = newText.Insert(textLength, ")");
                    display.Text = newText;
                }
            };

            /* MISTAKES I HAD COMMITED EARLIER */

            add.Click += (object sender, EventArgs e) =>
            {
                display.Text = display.Text + " + ";
                /*operand = "-";
                firstNumber = display.Text;
                display.Text = String.Empty;
                */
            };

            subtract.Click += (object sender, EventArgs e) =>
            {
                display.Text = display.Text + " - ";
                /*operand = "-";
                firstNumber = display.Text;
                display.Text = String.Empty;
                */
            };

            multiply.Click += (object sender, EventArgs e) =>
            {
                display.Text = display.Text + " * ";
                /*operand = "x";
                firstNumber = display.Text;
                display.Text = String.Empty;
                */
            };

            divide.Click += (object sender, EventArgs e) =>
            {
                display.Text = display.Text + " / ";
                /*operand = "/";
                firstNumber = display.Text;
                display.Text = String.Empty;
                */
            };

            clear.Click += (object sender, EventArgs e) =>
            {
                //firstNumber = String.Empty;
                //secondNumber = String.Empty;
                display.Text = "0";
            };

            delete.Click += (object sender, EventArgs e) =>
            {
                if(display.Text.Length == 0)
                {
                    display.Text = "0";
                }
                else if (display.Text.Contains("+") || display.Text.Contains("-") || display.Text.Contains("*") || display.Text.Contains("/"))
                {
                    int length = display.Text.Length;
                    display.Text = display.Text.Remove(length - 1);
                    display.Text = display.Text.Remove(length - 2);
                }
                else
                {
                    int length = display.Text.Length;
                    display.Text = display.Text.Remove(length - 1);
                }

            };

            equal.Click += (object sender, EventArgs e) =>
            {
                try
                {
                    Expression ex = new Expression(display.Text);
                    if (!ex.HasErrors())
                    {
                        display.Text = Convert.ToString(ex.Evaluate());

                    }
                }
                catch (EvaluationException)
                {
                    display.Text = "Error";
                }
                catch (OverflowException)
                {
                    display.Text = "Overflow Error";
                }
                catch (DivideByZeroException)
                {
                    display.Text = "Cannot Divide by Zero";
                }
                
                /*if (operand == "+")
                {
                    Expression e = new Expression(display.Text);

                }
                else if (operand == "-")
                {
                    secondNumber = display.Text;
                    display.Text = Calculator.Difference(firstNumber, secondNumber);
                    firstNumber = secondNumber;
                }
                else if (operand == "x")
                {
                    secondNumber = display.Text;
                    display.Text = Calculator.Product(firstNumber, secondNumber);
                    firstNumber = secondNumber;
                }
                else if (operand == "/")
                {
                    secondNumber = display.Text;
                    display.Text = Calculator.Division(firstNumber, secondNumber);
                    firstNumber = secondNumber;
                }*/
            };
        }
    }
}

