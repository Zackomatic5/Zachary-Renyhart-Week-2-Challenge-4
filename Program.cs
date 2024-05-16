using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zachary_Renyhart_Week_2_Challenge__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the width");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = width; i >= 1; i--) //This is subtracting
            {
                for (int j = 1; j <= i; j++) //This adds the counter
                {
                    Console.Write(num1);
                }
                Console.WriteLine();
        
            }   
        }        
    }
}
