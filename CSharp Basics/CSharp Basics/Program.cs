using System;

//Namespace
namespace CSharp_Basics
{
    //Class
    internal class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            //Ask for user to input name
            Console.WriteLine("Please input your name: ");
            string userName = Console.ReadLine();

            //Ask for user to input age
            Console.WriteLine("Please input your age: ");
            string userAgeInput = Console.ReadLine();

            //Convert userAgeInput to an int
            int userAge = convertToInt(userAgeInput);

            //If username is rupert then print "You input Rupert. That's the name of my taxidermied cat."
            if (userName == "Rupert")
            {
                //Console output
                Console.WriteLine("You input Rupert. That's the name of my taxidermied cat.");
            }
            else
            {
                // Console output
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("You did not input Rupert but your name is " + userName + " and your age is " + userAge);
                }
            }

            DisplayMenu();
            menu();
        }
        
        //Method to convert userAgeInput to an int
        static int convertToInt(string userAgeInput)
        {
            //Convert userAgeInput to an int
            return Convert.ToInt32(userAgeInput);

        }

        //Method for menu
        static void menu()
        {
            //Gets user input
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "1":
                    //Display a menu to convert to a shoe size
                    Console.Clear(); //Clear console
                    Console.WriteLine("Shoe Size Converter Menu:");
                    Console.WriteLine("1. Convert to US Size");
                    Console.WriteLine("2. Convert to European Size");
                    Console.WriteLine("3. Convert to UK Size");
                    Console.WriteLine("Type 'exit' to exit the converter.");
                    Console.Write("Please select an option: ");

                    switch (userInput.ToLower())
                    {
                        case "1":
                            //Convert to US Shoe Size Method
                            convertToUS();
                            break;
                        case "2":
                            //Convert to European Shoe Size Method
                            convertToEuropean();
                            break;
                        case "3":
                            //Convert to UK Shoe Size Method
                            convertToUK();
                            break;
                        case "exit":
                            //Exit case
                            Console.WriteLine("Exiting... Goodbye!");
                            return;
                        default:
                            //Default output
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                    }
                    break;
                case "2":
                    bool myBool = true;

                    //List of all the letters in the alphabet
                    char myChar1 = 'a';
                    char myChar2 = 'b';
                    char myChar3 = 'c';
                    char myChar4 = 'd';
                    char myChar5 = 'e';
                    char myChar6 = 'f';
                    char myChar7 = 'g';
                    char myChar8 = 'h';
                    char myChar9 = 'i';
                    char myChar10 = 'j';
                    char myChar11 = 'k';
                    char myChar12 = 'l';
                    char myChar13 = 'm';
                    char myChar14 = 'n';
                    char myChar15 = 'o';
                    char myChar16 = 'p';
                    char myChar17 = 'q';
                    char myChar18 = 'r';
                    char myChar19 = 's';
                    char myChar20 = 't';
                    char myChar21 = 'u';
                    char myChar22 = 'v';
                    char myChar23 = 'w';
                    char myChar24 = 'x';
                    char myChar25 = 'y';
                    char myChar26 = 'z';

                    do
                    {
                        //Print out all the letters in the alphabet 26 times individually and infinitely
                        for (int i = 0; i < 26; i++)
                        {
                            Console.WriteLine(myChar1);
                            Console.WriteLine(myChar2);
                            Console.WriteLine(myChar3);
                            Console.WriteLine(myChar4);
                            Console.WriteLine(myChar5);
                            Console.WriteLine(myChar6);
                            Console.WriteLine(myChar7);
                            Console.WriteLine(myChar8);
                            Console.WriteLine(myChar9);
                            Console.WriteLine(myChar10);
                            Console.WriteLine(myChar11);
                            Console.WriteLine(myChar12);
                            Console.WriteLine(myChar13);
                            Console.WriteLine(myChar14);
                            Console.WriteLine(myChar15);
                            Console.WriteLine(myChar16);
                            Console.WriteLine(myChar17);
                            Console.WriteLine(myChar18);
                            Console.WriteLine(myChar19);
                            Console.WriteLine(myChar20);
                            Console.WriteLine(myChar21);
                            Console.WriteLine(myChar22);
                            Console.WriteLine(myChar23);
                            Console.WriteLine(myChar24);
                            Console.WriteLine(myChar25);
                            Console.WriteLine(myChar26);


                        }
                    } while (myBool = true);

                    break;
                case "3":
                    describeVariables();
                    break;
                case "exit":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return; 
                    //Default output
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
        //Method to display menu
        static void DisplayMenu()
        {
            Console.Clear(); //Clear the console for a cleaner menu appearance
            Console.WriteLine("Menu:"); //Display the menu options
            Console.WriteLine("1. Shoe Size Converter");
            Console.WriteLine("2. Infinite Alphabet");
            Console.WriteLine("3. ");
            Console.WriteLine("Type 'exit' to exit the program.");
            Console.Write("Please select an option: "); //Prompt the user to select an option
        }

        //Convert to US Shoe Size
        static void convertToUS()
        {
            //Ask for user input
            Console.Write("Enter the European shoe size: ");
            double europeanSize = Convert.ToDouble(Console.ReadLine());

            //Conversion formula
            double usSize = europeanSize * 1.5;

            Console.WriteLine($"The equivalent US shoe size is: {usSize}");
        }

        //Convert to European Shoe Size
        static void convertToEuropean()
        {
            //Ask for user input
            Console.Write("Enter the US shoe size: ");
            double usSize = Convert.ToDouble(Console.ReadLine());

            //COnversion formula
            double europeanSize = usSize / 1.5;

            Console.WriteLine($"The equivalent European shoe size is: {europeanSize}");
        }

        //Convert to UK Shoe Size
        static void convertToUK()
        {
            //Ask for user input
            Console.Write("Enter the US shoe size: ");
            double usSize = Convert.ToDouble(Console.ReadLine());

            //Conversion formula 
            double ukSize = usSize - 1.5;

            Console.WriteLine($"The equivalent UK shoe size is: {ukSize}");
        }

        //Describe Variables (Bool, Float, Long)
        static void describeVariables()
        {
            //Example usage:
            bool boolValue = true;
            float floatValue = 3.14f;
            long longValue = 1234567890;

            //Call the function with different types
            processBool(boolValue);
            processFloat(floatValue);
            processLong(longValue);
        }

        //Write statements to print descriptions of Bool, Float, and Long
        static void processBool(bool value)
        {
            Console.WriteLine("Boolean has 1 of 2 possible values, true or false: " + value);
        }

        static void processFloat(float value)
        {
            Console.WriteLine("Float is used to define values with floating decimal points: " + value);
        }

        static void processLong(long value)
        {
            Console.WriteLine("Long is used to represent 64 bit integers: " + value);
        }
    }
}
