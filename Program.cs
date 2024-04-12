namespace Prog120_S24_L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Todays Topics

            // Call my FloatingPointTypeExample method
            // Short cuts to comment and uncomment code
            // Hotkey to comment
            // ctrl + k, c
            // To Uncomment
            // ctrl + k, u

            // If you highlight a selection of code it will do a multi line comment
            /* This is multiline*/
            //FloatingPointTypeExample();

            // Call our Mathmanipulation method
            //MathManipulation();

            //Try catch always has to be grouped together

            Question6();
            Console.ReadKey();
        } // Main

        public static void Question6()
        {
            //6.Write a program that prompts the user to input a length expressed in centimeters. The program should then convert the length to inches (to the nearest inch) and output the length expressed in yards, feet, and inches, in that order. For example, suppose the input for centimeters is 312. To the nearest inch, 312 centimeters is equal to 123 inches. 123 inches would thus be output as:

            // Advanced - While and TryParse

            //1. Ask user for length in centimeter.
            int centimeters = 0;
            try 
            {
                Console.Write("Enter a length in centimeters ");
                string userInput = Console.ReadLine();
                centimeters = int.Parse(userInput);

                //1a. Parse user length to number
                //1b. Wrap in a try /  catch
            }
            catch
            {
                Console.WriteLine("Your value was an invalid format");
            }



            //2. Get the conversion
            double convertedToInches = centimeters / 2.54;
            Console.WriteLine(convertedToInches);

            //2a. Convert users length to inches
            // 3 yard(s), 1 feet (foot), and 3 inch(es)

            //3. Convert to yards, feet, and inches
            int inchesInYard = 36;
            // Getting whole number yards
            int yards = (int)convertedToInches / 36;
            // Getting raming inches
            convertedToInches %= inchesInYard;

            // Getting the inches
            int inchesInFoot = 12;
            int feet = (int)convertedToInches / inchesInFoot;

            // Get remaining inches
            convertedToInches %= inchesInFoot;
            int inches = (int)convertedToInches;

            // 3 yard(s), 1 feet (foot), and 3 inch(es)
            Console.WriteLine($"{yards} yard(s), {feet} feet (foot), and {inches} inch(es)");

            Console.WriteLine(convertedToInches);

            //4. Display
        }

        public static void FloatingPointTypeExample()
        {
            // ---------------------------
            // Floating Point Types ( float and double )
            // Precision and Memory
            // Decimal Type
            // ---------------------------

            // A floating point type is a number that has a decimal
            // Float type - Single Precision type
            // We need to be explict when we declare a float value, by putting f after our value
            float floatValue = 1.2f;
           

            // Double type - Double Precision 
            double doubleValue = 1.245422353;

            // decimal type - has largest range, highest precision, and highest memory cost ( 16 bit )
            decimal decimalValue = 1.22638263m;

            // Cannot work with X type, please convert to String (If you see this error message)
            // To convert to string, you can call the .ToString() on any object
            Console.WriteLine(doubleValue);


        } // FloatingPointTypeExample()

        public static void MathManipulation()
        {
            // ---------------------------
            // Revisit Parsing
            // Casting
            // Math with Doubles
            // Rounding
            // ---------------------------

            //Console.Write("Enter number 1: ");
            //string usersString1 = Console.ReadLine();

            //Console.Write("Enter number 2: ");
            //string usersString2 = Console.ReadLine();

            // Parse the string into a number
            //try 
            //{
            //    double userNumber1 = double.Parse(usersString1);
            //    double userNumber2 = double.Parse(usersString2);
            //    double sum = userNumber1 + userNumber2;
            //    Console.WriteLine(sum);

            //}
            //catch
            //{
            //    Console.WriteLine("The number was invalid");
            //}

            // If we try to parse a stirng into a different type, and the type is invalid, you will receive and FormatException Error
            // Runtime
            // try / catch
            // To use a try catch, you declare a try block, followed by a catch block

            //Console.WriteLine("Enter a number: ");
            //double userNumber = 0;
            //try
            //{
            //    userNumber = double.Parse(Console.ReadLine());

            //    Console.WriteLine($"The users number is {userNumber}");
            //}
            //catch (FormatException fex)
            //{
            //    Console.WriteLine($"The number you entered was invalid");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("After our try catch block");

            // Console ReadKey waits for a single button input before moving on
            // This can help prevent your console from closing automatically
            //Console.ReadKey();

            // Casting
            //Implicit casting
            //double number1 = 1;
            //// Explictly Cast
            //// We have to give permission to lose data
            //// We cast but putting the type we want to convert to in parenthese in front of our data
            //int number2 = (int)1.08739543543323224;

            //int number1 = 10;
            //double number2 = 3;
            //double result = (double)(10 / 3);
            //Console.WriteLine(result);

            // Rounding
            // Math Library with the keyword... Math
            double numberToRound = 1.67398749299;
            double roundedNumber = Math.Round(numberToRound, 2);
            // .ToString() converts a value into a string
            // Pass in an argument that formats the value
            // "c" format will display the currency symbol and round the value to 2 decimal place (double check for percision)
            Console.WriteLine(roundedNumber.ToString("c"));
            



        } // MathManipulation()

        public static void HomeworkExample()
        {
            // ---------------------------
            // Question Examples
            // Homework
            // ----------------------------
        } // HomeworkExample()
    } // class

} // namespace
