using System.Drawing;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Print Number

            Console.Write("Enter Number : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);

            #endregion

            #region 2-Convert string

            int val = 3;
            string name = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(name));

            // Can not convert string cotains non-numeric characters to an integer it gives runtime error


            #endregion

            #region 3-operation with float

            float p = float.Parse(Console.ReadLine());
            Console.WriteLine(p++);
            Console.WriteLine(p + 1);

            // can not use unary operation but you can use binary operation 

            #endregion

            #region 4-Substring

            string myString = "Hello";
            Console.WriteLine(myString.Substring(0, 3));

            #endregion

            #region 5-Value type 

            int x;
            x = 2;
            Console.WriteLine(x);//2
            Int32 y = 4;
            Console.WriteLine(y);//4
            y = x;
            Console.WriteLine(x);//2
            Console.WriteLine(y);//2

            x++;
            Console.WriteLine(x);//3
            Console.WriteLine(y);//2

            #endregion

            #region 6-Refernce type

            string name1 = "Ali";
            string name2 = "Adam";
            name2 = name1;// Ali

            name1 = "Nader";

            Console.WriteLine(name1);//Nader
            Console.WriteLine(name2);//Ali


            #endregion

            #region 7-brint 2 strings in 1

            Console.Write("Enter First Sentence : ");
            string firsts = Console.ReadLine();
            Console.Write("Enter Second Sentence : ");
            string seconds = Console.ReadLine();
            Console.WriteLine(($"{firsts} {seconds}"));

            #endregion

            #region 8-Calc Interest
            Console.Write("Enter principal : ");
            double principal = double.Parse(Console.ReadLine());
            Console.Write("Enter rate : ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Enter time : ");
            double time = double.Parse(Console.ReadLine());

            double interest = (principal * rate * time) / 100;
            Console.WriteLine($"The Simple Interest is : {interest}");

            #endregion

            #region 9-Calc BMI

            Console.Write("Enter Weight in kg : ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Enter Height in meters : ");
            double height = double.Parse(Console.ReadLine());

            double bmi = (weight) / (height * height);
            Console.WriteLine($"BMI is : {bmi}");


            #endregion

            #region 10-Tempreature Check

            Console.Write("Enter Temperature : ");
            int temp = int.Parse(Console.ReadLine());
            if (temp < 10)
            {
                Console.WriteLine("Just Cold");
            }
            else if (temp > 30)
            {
                Console.WriteLine("Just Hot");
            }
            else
            {
                Console.WriteLine("Just Good");
            }

            #endregion

            #region 11-

            #endregion

            #region 12-Divided by 3 & 4

            Console.Write("Enter Number : ");
            int dnum = int.Parse(Console.ReadLine());
            if (dnum % 3 == 0 && dnum % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            #endregion

            #region 13-Number Check

            Console.Write("Enter Number : ");
            int cnum = int.Parse(Console.ReadLine());
            if (cnum < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }

            #endregion

            #region 14-Max & Min

            Console.Write("Enter first Number : ");
            int num_1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second Number : ");
            int num_2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third Number : ");
            int num_3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Max Number is : " + Math.Max(num_1, Math.Max(num_2, num_3)));
            Console.WriteLine("Min Number is : " + Math.Min(num_1, Math.Min(num_2, num_3)));

            #endregion

            #region 14-Even or Odd

            Console.Write("Enter Number : ");
            int eoNum = int.Parse(Console.ReadLine());
            if (eoNum % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            #endregion

            #region 15-Vowel or Consonant

            Console.Write("Enter character : ");
            Char ch = char.Parse(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'o' || ch == 'u' || ch == 'i')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }

            #endregion

            #region 16-Days of Month

            Console.Write("Enter month number (1 - 12) : ");
            int monthNum = int.Parse(Console.ReadLine());

            switch (monthNum)
            {
                case 2:
                    Console.WriteLine("Days in month is 28");
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Days in month is 31");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Days in month is 30");
                    break;
                default:
                    Console.WriteLine("Enter valid month number");
                    break;

            }

            #endregion

            #region 17-Simple Calculator

            Console.Write("Enter first number : ");
            double cNum_1 = double.Parse(Console.ReadLine());
            Console.Write("Enter operation ( + , - , * , / ) : ");
            char operation = char.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            double cNum_2 = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine(cNum_1 + cNum_2);
                    break;

                case '-':
                    Console.WriteLine(cNum_1 - cNum_2);
                    break;

                case '*':
                    Console.WriteLine(cNum_1 * cNum_2);
                    break;

                case '/':
                    Console.WriteLine(cNum_1 / cNum_2);
                    break;

                default:
                    Console.WriteLine("Enter valid operation");
                    break;

            }

            #endregion

            #region 18-print 1 to number

            Console.Write("Enter number : ");
            int beNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= beNum; i++)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region 19-Multi Table 12

            Console.Write("Enter number : ");
            int multiNum = int.Parse(Console.ReadLine());

            for (int e = 1; e <= 12; e++)
            {
                Console.WriteLine(multiNum * e);
            }

            #endregion

            #region 20-Even between 1-num

            Console.Write("Enter number : ");
            int evNum = int.Parse(Console.ReadLine());

            for (int a = 1; a <= evNum; a++)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
            }

            #endregion

            #region 21-Calc power

            Console.Write("Enter first number : ");
            int pNum_1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            int pNum_2 = int.Parse(Console.ReadLine());
            int power = 1;

            for (int o = 1; o <= pNum_2; o++)
            {
                power = pNum_1 * power;

            }
            Console.WriteLine(power);

            #endregion

            #region 22-

            #endregion

            #region 23-


            #endregion

            #region 24-

            #endregion

            #region 25-Sum of Array elements

            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int asum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                asum += nums[i];
            }
            Console.WriteLine(asum);


            #endregion
        }
    }
}
