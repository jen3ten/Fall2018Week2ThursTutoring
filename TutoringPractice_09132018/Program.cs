using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringPractice_09132018
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specifications for this exercise:
            //Fill a list with the names of all the people in the room
            //Print the list of names to the screen followed by the number of characters in the name
            
            //Practice:
            //We compared different ways to create and add values to a List
            //We compared different types of loops to print the output to the user
            
            //Declare list version 1 and add values with .Add() method
            //
            //List<string> names = new List<string>();
            //names.Add("Kayti");
            //
            //etc...  We moved on to version 2 before filling the entire list this way

            //Declare list version 2 and add values in same line
            //
            List<string> names = new List<string>() { "Kayti", "Pete", "Maggie", "Ken", "Neko", "Jen" };
            //
            //Like a method, {curly braces} define the scope (aka body)
            //in the background each of these items are saved in the list

            //Loop example with foreach
            //We used variable name 'a' to show this is defined by us and can be anything
            //
            //foreach(string a in names)  
            //{
            //    Console.WriteLine(a);  //We did not print the character count here
            //}

            //Loop example with for loop
            //We used 'index' instead of the usual 'i' to show that you can use a variable name that makes 
            //sense for the purpose of your code
            //
            //for(int index = 0; index < names.Count; index++) 
            //{
            //    Console.WriteLine(names[index]); //We did not print the character count here
            //}

            //Loop example with While loop
            //
            int index = 0;  //to define a counting index and set its initial value to 0
            while (index < names.Count)
            {
                Console.WriteLine(names[index] + " " + names[index].Length);
                index++; //to increment index by 1
            }

        }
    }
}
