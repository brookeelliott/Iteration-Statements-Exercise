namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        
        
        //Write a method that will print to the console all numbers 1000 through - 1000

    public  TwoThousandNums()
        {
            Console.WriteLine("Sorry, I'm about to blow up your terminal printing all these numbers.");
            int i = 1000;
            do
            {
                Console.WriteLine($"{i}");
                i--;

            } while (i >= -1000);
        }    
        
        //Write a method that will print to the console numbers 3 through 999 by 3 each time

    public int CountByThree()
        {
            Console.WriteLine("More numbers aaaaaggggghhhhhhh!!!");
            int j = 3;
            while (j <= 999)
            {
                Console.WriteLine($"{j}");
                j = j + 3;
            }
        }        
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
    public var IsEqual()
        {
            Console.WriteLine("Give me a first integer.");
            var num1 = int.TryParse(Console.Readline());

            Console.WriteLine("Give me a second integer.");
            var num2 = int.TryParse(Console.Readline());

            bool areEqual;
            if(num1 = num2 ? areEqual = true : areEqual = false);
            if(areEqual = true ? Console.WriteLine("The numbers are equal!") : Console.Writeline("The numbers are not equal."));
        }    
        
        //Write a method to check whether a given number is even or odd
    public var IsEven(var UserNum)
        {
            bool EvenOddBool;
            if(UserNum % 2 > 0 ? EvenOddBool = true : EvenOddBool = fasle);
            if(EvenOddBool = True ? Console.WriteLine("The number is even!") : Console.WriteLine("The number is odd!"));

        }

        
        //Write a method to check whether a given number is positive or negative
    public var PosOrNeg(var InputNum)
        {
            bool PosOrNegBool;
            if(InputNum >= 0 ? PosOrNeg = true : PosOrNeg = false);
            if(PosOrNegBool = True ? Console.WriteLine("The number is positive!") : Console.WriteLine("The number is negative!"));
        }
    
        
        
        //Write a method to read the age of a candidate and determine whether they can vote.
    public int VotingAge(int UserAge)
        {
            bool CanVote;
            if(UserAge >= 18 ? CanVote = true : CanVote = fasle);
            if(CanVote = True ? Console.WriteLine("You can vote!") : Console.WriteLine("You cannot vote :("));
        }
        
        
        
        
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        
        //Parse()
        
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
    public int TenNumRange()
        {
         Console.WriteLine("Give me a whole number(integer please).");
         var UserNum = int.TryParse(Console.Readline());

         if (UserNum >= -10 && UserNum <= 10)
            {
                Console.WriteLine("The number is between -10 and 10!!!!");
            }   
            else
            {
                Console.WriteLine("The number is outside of the accepted range (-10 to 10)... sorry :(");
            }
        }

        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
    public int NumtiplicationTableFunTimes()
        {
        Console.WriteLine("Give me any integer!!!");
        var MultNum = int.TryParse(Console.Readline());

        Console.WriteLine("Multiplication table (1 through 12)");
        for(int y = 1; y < 13; y++)
            {
                var Product = MultNum * y;
                Console.WriteLine($"{y} times {MultNum} = {product}");
            }


        }




        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            TwoThousandNums();
            CountByThree();
            IsEqual();
            IsEven(7);
            PosOrNeg(-4);
            VotingAge(21);
            TenNumRange();
            NumtiplicationTableFunTimes();


        }
    }
}
