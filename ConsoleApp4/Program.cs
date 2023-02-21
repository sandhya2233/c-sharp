using System;

namespace ConsoleApp4
{
    public delegate void calDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Calculator Cal = new Calculator();
            calDelegate myDelegate;
            myDelegate = Cal.Add;
            myDelegate += Cal.Mul;
            myDelegate += Cal.Sub;
            myDelegate += Cal.Div;

            myDelegate.Invoke(9, 4);
        }
    }
}




