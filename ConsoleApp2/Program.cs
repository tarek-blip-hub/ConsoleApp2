using System.Transactions;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           float score1, score2, average;
            Console.WriteLine("Enter first score:");

           score1= Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("enter second score:");

           score2= Convert.ToSingle(Console.ReadLine());

            average = score1 + score2 / 2;

            Console.WriteLine("The average is = " + average );
        }
    }
}
