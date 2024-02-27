using System.Buffers;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;

namespace StringMethodsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Hello, World!");

            //    Console.WriteLine("1ci ededi daxil et");
            //int x= Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("chari daxil et");
            //char c= Convert.ToChar(Console.ReadLine());
            //    Console.WriteLine("ikinci ededi daxil et");
            //int y = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(Task1(x,y,c));

            // FindWordNumber("   saaaaalaaammmm    ");

            //Console.WriteLine(SumOfNumbers(2,3,4,5,3,2,4,5,3));
            //MinusNumbersChangePlus(-1, -44, -55, 44, 55, -7);
            Console.WriteLine(ChangeOppositeWord("Salam Muellim"));


        }

        #region task1
        static int Task1 (int x , int y, char c)
        {   int result = 0;
            if (c== '+')
            {
                result=x+y;
                
            }
            if (c == '-')
            {
                result= x - y;
            }
            if (c == '*')
            {
                result= x * y;
                
            }
            if (c== '/')
            {
                result= x / y;
            }
        return result;
        }
        #endregion

        #region task3
        static void FindWordNumber (string s ) 
        {
            string result = string.Empty;
        for (int i = 0; i < s.Length; i++)
            {
                result += s[i];

            }

            Console.WriteLine(result.Length);
        }
        #endregion

        #region task 4
        static int SumOfNumbers (params int[] numbers)
        {
            int result =0;
           for (int i = 0;i < numbers.Length;i++)
            {
                result += numbers[i];
            }
            return result;
        }

        #endregion

        #region task 6
        static void MinusNumbersChangePlus(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {       
                if (numbers[i] < 0)
                {
                    numbers[i] *= -1;
                }
                
            }
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region task7
        static string ChangeOppositeWord(string word)
        {   StringBuilder sb = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {

                sb.Append(word[i]);
                
            }
        return sb.ToString();
        }
        #endregion




    }
}
