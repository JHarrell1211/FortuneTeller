using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            int age;
            int month;
            int retire;
            int siblings;
            string location = "";
            string color = "";
            string money = "";
            string car = "";

            Console.WriteLine("Enter your first name.");
            firstName = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter your last name. ");
            lastName = Console.ReadLine().ToUpper();
            Console.WriteLine("");

            Console.WriteLine("Enter your age using numbers only");
            age = int.Parse(Console.ReadLine());

            if ((age % 2) > 0)
            {
                retire = 22;
            }
            else
            {
                retire = 15;
            }

            Console.WriteLine("Enter your birth month using numbers 1 - 12. For example, March would be 3");
            Console.WriteLine("and December would be 12.");
            month = int.Parse(Console.ReadLine());

            if ((month >= 1) && (month <=4))
            {
                money = "$11,460.32";
            }
            else if ((month >= 5 ) && (month <= 8))
            {
                money = "$2,634,522.17";
            }
            else if ((month >= 9) && (month <= 12))
            {
                money = "$372,498.42";
            }
            else
            {
                money = "$0.00";
            }

            Console.WriteLine("How many siblings do you have?");
            siblings = int.Parse(Console.ReadLine());

            switch (siblings)
            {
                case 0:
                    location = "San Diego";
                    break;
                case 1:
                    location = "Miami";
                    break;
                case 2:
                    location = "Hawaii";
                    break;
                case 3:
                    location = "Tahiti";
                    break;
            }

            if (siblings < 0)
            {
                location = "Siberia";
            }
            else if (siblings > 3)
            {
                location = "Maui";
            }

            Console.WriteLine("Type the first letter of your favorite ROYGBIV color? If you do not know the acronym ROYGBIV type 'HELP'");
            color = Console.ReadLine().ToUpper();

            if (color == "HELP")
            {
                Console.WriteLine("");
                Console.WriteLine("ROYGBIV or Roy G. Biv is an acronym for the sequence of hues commonly described as making up a rainbow.");
                Console.WriteLine("R = Red"); Console.WriteLine("O = Orange"); Console.WriteLine("Y = Yellow"); Console.WriteLine("G = Green");
                Console.WriteLine("B = Blue"); Console.WriteLine("I = Indigo"); Console.WriteLine("V = Violet \n");

                Console.WriteLine("Type the first letter of your favorite ROYGBIV color?");
                color = Console.ReadLine().ToUpper();
            }

            switch (color) 
            {
                case "R":
                    car = "Chevy Tahoe";
                    break;
                case "O":
                    car = "Mercedes Benz S550";
                    break;
                case "Y":
                    car = "BMW M5";
                    break;
                case "G":
                    car = "Dodge Challenger SRT8";
                    break;
                case "B":
                    car = "Toyota Camry";
                    break;
                case "I":
                    car = "Lamborghini";
                    break;
                case "V":
                    car = "Ford Fusion";
                    break;
            }
            
            Console.WriteLine("");
            Console.Write(firstName + " " + lastName + " will retire in " + retire + " years with " + money + " in the bank, a vacation home in " );
            Console.WriteLine(location + " and a " + car);
        }
    }
}
