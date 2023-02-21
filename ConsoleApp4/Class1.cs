using System;


namespace ConsoleApp4
{
    public class Calculator
    {
        public void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Addition is:" + c);
        }
        public void Mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Multiplication is:" + c);
        }
        public void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Substraction is:" + c);
        }
        public void Div(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("Division is:" + c);
        }
            
    }
}
