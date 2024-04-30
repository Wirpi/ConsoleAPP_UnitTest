using System;
namespace Aboba
{
     public class Program
    {
        void Main(string[] args)
        {

            int result = AddNumbers(5, 7);
            Console.WriteLine("��������� ��������: " + result);

            string reversed = ReverseString("Hello");
            Console.WriteLine("������������ ������: " + reversed);

            int factorial = CalculateFactorial(5);
            Console.WriteLine("��������� ����� 5: " + factorial);
        }


        public  static int AddNumbers(int a, int b)
        {
            return a + b;
        }


        public static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        public   static int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }
    }
}