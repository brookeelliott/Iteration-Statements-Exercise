namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below


        //Write a method that will print to the console all numbers 1000 through - 1000

        static void TwoThousandNums()
        {
            Console.WriteLine("Sorry, I'm about to blow up your terminal printing all these numbers.");
            int i = 1000;
            do
            {
                Console.WriteLine($"{i}");
                i--;

            } while (i > -1001);

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        static void CountByThree()
        {
            Console.WriteLine("More numbers aaaaaggggghhhhhhh!!!");
            int j = 3;
            while (j <= 999)
            {
                Console.WriteLine($"{j}");
                j += 3;
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not

        static void IsEqual(int num1, int num2)
        {
            //bool res1;
            //bool res2;

            //Console.WriteLine("Give me a first integer.");
            //res1 = int.TryParse(Console.ReadLine(), out int num1);

            //Console.WriteLine("Give me a second integer.");
            //res2 = int.TryParse(Console.ReadLine(), out int num2);

            //if (res1 || res2 == false)
            //{
            //    Console.WriteLine("This isnt an integer");
            //}
            //else
            //{
            if (num1 != num2)
            {
                Console.WriteLine("The numbers are not equal.");
            }

            Console.WriteLine("The numbers are equal!");
        }



        //Write a method to check whether a given number is even or odd
        static void IsEven(int UserNum)
        {
            bool EvenOddBool;
            if (UserNum % 2 != 0)
            {
                EvenOddBool = true;
            }
            else
            {
                EvenOddBool = false;
            }

            if (EvenOddBool == true)
            { Console.WriteLine("The number is even!"); }
            else
            { Console.WriteLine("The number is odd!"); }


        }


        //Write a method to check whether a given number is positive or negative
        static void PosOrNeg(int InputNum)
        {

            if (InputNum >= 0)
            {
                Console.WriteLine("The number is positive!");
            }
            else
            {
                Console.WriteLine("The number is negative!");
            }
        }



        //Write a method to read the age of a candidate and determine whether they can vote.
        static void VotingAge(int UserAge)
        {
            Console.WriteLine((UserAge >= 18) ? "You can vote!" : "You cannot vote :(");
        }




        //Hint: Use Parse or the safer TryParse() for an extra challenge

        //Parse()

        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static void TenNumRange()
        {
            Console.WriteLine("Give me a whole number(integer please).");
            var userNum = int.TryParse(Console.ReadLine(), out int intNum);

            if (userNum == false)
            {
                Console.WriteLine("This isnt an integer!! Try Again Please.");
            }

            if (intNum >= -10 && intNum <= 10)
            {
                Console.WriteLine("The number is between -10 and 10!!!!");
            }
            else
            {
                Console.WriteLine("The number is outside of the accepted range (-10 to 10)... sorry :(");
            }
        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void NumtiplicationTableFunTimes()
        {
            Console.WriteLine("Give me any integer!!!");
            var multNum = int.TryParse(Console.ReadLine(), out int multiplyMe);

            if (multNum == false)
            {
                Console.WriteLine("This isnt an integer!! Try Again Please.");
            }

            Console.WriteLine("Multiplication table (1 through 12)");

            for (int y = 1; y < 13; y++)
            {
                var Product = multiplyMe * y;
                Console.WriteLine($"{y} times {multiplyMe} = {Product}");
            }


        }




        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            TwoThousandNums();
            CountByThree();
            IsEqual(4, 5);
            IsEven(7);
            PosOrNeg(-4);
            VotingAge(21);
            TenNumRange();
            NumtiplicationTableFunTimes();



        }
    }
 }
