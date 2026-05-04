namespace IterationStatements
{
    public class Program
    {


        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            Console.WriteLine("\nGoing to count down from 1k to -1k!");
            PrintNumbers();
            
            Console.WriteLine("\nTime to print every 3rd number!");
            PrintEveryThirdNumber();
            
            Console.WriteLine("\n\nOk so now I need you to give me two numbers and I will tell you if they are equal!");
            
            bool equalNumberOneValid = false;
            bool equalNumberTwoValid = false;
            do
            {
                Console.Write("\nNumber one: ");
                string? equalNumberStringOne = Console.ReadLine();
                if (!int.TryParse(equalNumberStringOne, out int equalNumberOne))
                {
                    Console.WriteLine("Numbers one is invalid!");
                    equalNumberOneValid = false;
                }
                else
                {
                    equalNumberOneValid = true;
                }
                
                Console.Write("\nNumber Two: ");
                string? equalNumberStringTwo = Console.ReadLine();
                if (!int.TryParse(equalNumberStringTwo, out int equalNumberTwo))
                {
                    Console.WriteLine("Number two is invalid!");
                    equalNumberTwoValid = false;
                }
                else
                {
                    equalNumberTwoValid = true;
                }

                if (equalNumberOneValid && equalNumberTwoValid)
                {
                    AreNumbersEqual(equalNumberOne, equalNumberTwo);
                }
            
                
            } while (!equalNumberOneValid || !equalNumberTwoValid);
            
            Console.WriteLine("\nAlright, let's try to determine even or odd!");

            bool evenOddValid = false;
            do
            {
                string? evenOddString = Console.ReadLine();
                if (!int.TryParse(evenOddString, out int evenOddInt))
                {
                    Console.WriteLine("let's try a number this time...");
                    evenOddValid = false;
                }
                else
                {
                    evenOddValid = true;
                    IsEven(evenOddInt);
                }
            } while (!evenOddValid);
            
            
            Console.WriteLine("\nOn to the next one! Time to find out if things are Positive!");
            bool posiCheckNumberValid = false;
            do
            {
                string? posiCheckNumberString = Console.ReadLine();
                if (!int.TryParse(posiCheckNumberString, out int posiCheckNumberInt))
                {
                    Console.WriteLine("Swing and a miss. Try a number there hotshot.");
                    posiCheckNumberValid = false;
                }
                else
                {
                    IsPositive(posiCheckNumberInt);
                    posiCheckNumberValid = true;
                }

            } while (!posiCheckNumberValid);
            
            Console.WriteLine("\nLet's find out if you can vote.\nHow old are you?");
            bool voteCheckNumberValid = false;
            do
            {
                string? voteCheckNumberString = Console.ReadLine();
                if (!int.TryParse(voteCheckNumberString, out int voteCheckNumberInt))
                {
                    Console.WriteLine("Why must you fail me so often. Use numbers please.");
                    voteCheckNumberValid = false;
                }
                else
                {
                    CanVote(voteCheckNumberInt);
                    voteCheckNumberValid = true;
                }
                
            }while (!voteCheckNumberValid);
            
            Console.WriteLine("\nRange Check!\nTell me a number and I will see if it's in range between -10 and 10.");
            bool rangeCheckNumberValid = false;
            do
            {
                string? rangeCheckString = Console.ReadLine();
                if (!int.TryParse(rangeCheckString, out int rangeCheckNumberInt))
                {
                    Console.WriteLine("Narp. Gotta be a number mate.");
                    rangeCheckNumberValid = false;
                }
                else
                {
                    IsInRange(rangeCheckNumberInt);
                    rangeCheckNumberValid = true;
                }
                
            }while (!rangeCheckNumberValid);
            
            
            Console.WriteLine("And last and maybe least lets show a number against a multiplication table 1-12.");
            bool multiplicationTableNumberValid = false;
            do
            {
                string? multiplicationTableNumberString = Console.ReadLine();
                if (!int.TryParse(multiplicationTableNumberString, out int multiplicationTableNumberInt))
                {
                    Console.WriteLine("Oi....where's the number? Do it again.");
                    multiplicationTableNumberValid = false;
                }
                else
                {
                    DisplayMultiplicationTable(multiplicationTableNumberInt);
                    multiplicationTableNumberValid = true;
                }

            } while (!multiplicationTableNumberValid);


        }
        
        //methods
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()

        public static void PrintNumbers()
        {
            for (int i = 1000; i > -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void PrintEveryThirdNumber()
        {
            for (int i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static bool AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Oh yeah...it's all coming together. (Equal)");
                return true;
            }
            else
            {
                Console.WriteLine("Oh no baby what is you doing?! Those aren't the same at all!");
                return false;
            }
            
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Alright we're even.");
                return true;
            }
            else
            {
                Console.WriteLine("Alright we're odd.");
                return false;
            }
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static bool IsPositive(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("It is positive!");
                return true;
            }
            else
            {
                Console.WriteLine("It is negative!");
                return false;
            }
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static bool CanVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are old enough. Let's hope you are informed enough!");
                return true;
            }
            else
            {
                Console.WriteLine("Can't vote yet! Though if I have to tell you that you have a lot of reading to do. ");
                return false;
            }
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static bool IsInRange(int num)
        {
            if (num >= -10 && num <= 10)
            {
                Console.WriteLine("Hmmm yes...this is in the expected range.");
                return true;
            }
            else
            {
                Console.WriteLine("How about....no.");
                return false;
            }
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void DisplayMultiplicationTable(int number)
        {
            int[] multiTable = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            foreach (int i in multiTable)
            {
                Console.WriteLine($"{i} * {number} =  { i * number}");    
            }
            
        }
        
        
        
        
    }
}
