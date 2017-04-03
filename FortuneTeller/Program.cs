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
        {   //ask user for first name 

            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine().ToUpper();

            //ask user for last name

            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine().ToUpper();


            //ask the user for the users age

            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());


            //ask user for birth month int

            Console.WriteLine("Please enter your birth month as a one digit number");
            int birthMonth = int.Parse(Console.ReadLine());


            // ask user for fav ROYGBIV color

            //If they do not know what ROYGBIV is ask for help
            Console.WriteLine("Do you know what colors are associated with ROYGBIV? If you do please type \"Yes\"If you do not please type \"Help\":");
            string help1 = Console.ReadLine();
            if (help1 == "Help")
            {
                Console.WriteLine("Red\n Orange\n Yellow\n Green\n Blue\n Indigo\n Violet\n");
            }
            else  if (help1 == "Yes")
            {
                
                Console.WriteLine("Great lets move on!");
            }
            else
            {
                Console.WriteLine();
            }
           
            //FOR SOME REASON I COULD NOT GET .TOUPPER OR .TOLOWER TO WORK ON THIS LINE OF CODE. 
            Console.WriteLine("Please enter your favorite ROYBIV color,\nCapitalizing the first letter of the color:");
            string favColor = Console.ReadLine();



            //ask the user for the number of siblings


            Console.WriteLine("Please enter how many sibling you have");
            int siblings = int.Parse(Console.ReadLine());

            //If the users age is an odd number, then they will retire in 25 years if the age is even they will retire in 20 years.


            if (age % 3 == 0)
                
            {
                string retire = "25";
                Console.WriteLine(firstName + "\t" + lastName + "" + " will retire in " + retire + " years ");
           }
            else  
            {
                string retire = "30";
                Console.WriteLine(firstName + "\t" + lastName + "" + " will retire in " + retire + " years ");
            }
           
            
            // assingning birth month to money in the bank
            

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                string money1 = "$50,000.00";
                Console.WriteLine(" with " + "" + money1 + "" + " in the bank,");
            }

          else  if (birthMonth >= 5 && birthMonth <= 8)
            {
                string money2 = "$100,000.00";
                Console.WriteLine(" with " + "" + money2 + "" + " in the bank,");
            }

           else if (birthMonth >= 9 && birthMonth <= 12)
            {
                string money3 = "$25,000.00";
                Console.WriteLine(" with " + "" + money3 + "" + " in the bank,");
            }

            else
            {
                string money4 = "$0.00";
                Console.WriteLine(" with " + "" + money4 + "" + " in the bank, ");

            }


           //If the users sibling is 0 vacation home in , 1 vacation in , 2 vacation in , 3 Vacation in, 3 or more Aruba. 0 or less bad

            string vacay1 = "Dubai";
            string vacay2 = "London";
            string vacay3 = "Aruba";
            string vacay4 = "Brazil";
            string vacay5 = "Mexico";
            string vacay6 = "Cleveland";

            if (siblings == 0)
            { 
                Console.WriteLine(" a vacation home in " + "" + vacay1);
            }
            else if (siblings == 1)
            { 
                Console.WriteLine(" a vacation home in " + "" + vacay2);
            }
            else if (siblings == 2)
            { 
                Console.WriteLine(" a vacation home in " +"" + vacay3 + ",");
            }
            else if (siblings == 3)
            { 
                Console.WriteLine(" a vacation home in " + "" + vacay4 + ",");
            }
            else if (siblings > 3)
            {
                
                Console.WriteLine(" a vacation home in " + "" + vacay5 + ",");
            }
            else
            {
                
                Console.WriteLine(" a vacation home in " + "" + vacay6 + ",");
            }

            //Depending on what ROYGBIV color is the fav the user will have a specific mode of transportation

            
            if (favColor == "Help")

            {
                Console.WriteLine("Red\n Orange\n Yellow\n Green\n Blue\n Indigo\n Violet\n");
            }


           else if (favColor == "Red")
            {
                string trans1 = "Boat";
                Console.WriteLine(" and a " + "" + trans1 + "" + " for transportation. ");
            }

          else  if (favColor == "Orange")
            {
                string trans2 = "Car";
                Console.WriteLine(" and a " + "" + trans2 + "" + " for transportation. ");
            }

           else if (favColor == "Yellow")
            {
                string trans3 = "Plane";
                Console.WriteLine(" and a " + "" +trans3 + "" + " for transportation. ");
            }

           else if (favColor == "Green")
            {
                string trans4 = "Scooter";
                Console.WriteLine(" and a " + "" + trans4 + "" + " for transportation. ");
            }

          else  if (favColor == "Blue")
            {
                string trans5 = "Moped";
                Console.WriteLine(" and a " + "" + trans5 + "" + " for transportation. ");
            }

           else if (favColor == "Indigo")
            {
                string trans6 = "Motorcycle";
                Console.WriteLine("and a" + "" + trans6 + "" + " for transportation. ");
            }

          else  if (favColor == "Violet")
            {
                string trans7 = "Motorhome";
                Console.WriteLine(" and a " + "" + trans7 + "" + " for transportation. ");
            }
            else
            { Console.WriteLine();
            }


            

                       


           
            
        }
    }
}
