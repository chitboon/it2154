using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your gender (m or f):");
            char gender = Convert.ToChar(Console.Read());
            if (gender == 'm') {
                Console.WriteLine("Hello Mr " + name + "!");
            } 
            else if (gender == 'f') {
                Console.WriteLine("Hello Ms " + name + "!");
            } 
	    else { 
		Console.WriteLine("Hello " + name + "!");
            } 


        }
    }
}
