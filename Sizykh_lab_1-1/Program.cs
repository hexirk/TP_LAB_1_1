using System.ComponentModel.Design.Serialization;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;

namespace Sizykh_lab_1_1
{
    public class Logic
    {
        public static string IsLucky(int number)
        {
            string outMessage = "";
            if (number >= 100000 && number <= 999999)
            {
                int d1 = number%1000000/100000;
                int d2 = number%100000/10000;
                int d3 = number%10000/1000;
                int d4 = number%1000/100;
                int d5 = number%100/10;
                int d6 = number%10;
                int sum1 = d1 + d2 + d3;
                int sum2 = d4 + d5 + d6;
                if (sum1 == sum2)
                {
                    outMessage = "Счастливое число";
                }
                else
                {
                    outMessage = "Обычное число";
                }
            }
            else
            {
                outMessage = "Число не шестизначное";
            }
            return outMessage;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            var number = int.Parse(Console.ReadLine());
            var outMessage = Logic.IsLucky(number);
            Console.WriteLine(outMessage);
            Console.ReadLine();
        }
    }
}