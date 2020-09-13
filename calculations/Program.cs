using System;

namespace calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height:");
            int height = int.Parse(Console.ReadLine()); //int.Parse changes the variable type to an integer
                                                        //because the Console Reads inputs as a string.
            Console.WriteLine("Enter the width:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("The volume of the cuboid is {0}cm cubed.", height * width * length); //placeholders to input variables.
                                                                                                    // * operator multiplies the integer values.


            Console.WriteLine("Enter a number:"); 
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < 6; i++) // for loop repeats the code 5 times, increasing the number to multiply with by 1.
            {
                Console.WriteLine("{0} times {1} is {2}", i, number, i * number);
            }


            Console.WriteLine("How many children are there?");
            int children = int.Parse(Console.ReadLine());
            Console.WriteLine("How many sweets do they each have?");
            int sweets = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ducks were there?");
            int ducks = int.Parse(Console.ReadLine());
            Console.WriteLine("How many sweets did each child give each duck?");
            int sweets2 = int.Parse(Console.ReadLine());
            int pile = (sweets * children) - (sweets2 * ducks * children) - children; //a calculation made after reading the text and working out
                                                                                      //how to solve it.
            Console.WriteLine("There were {0} children each with a bag containing {1} sweets." +
                "  They walked past {2} ducks. " +
                " Each child gave {3} sweets to each of the ducks and ate one themself." +
                " They decided to put the rest into a pile." +
                "They counted the pile and found it contained {4} sweets.", children, sweets, ducks, sweets2, pile); 
            



        }
    }
}
