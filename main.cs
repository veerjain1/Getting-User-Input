using System;

class Program {
  public static void Main (string[] args) {
    //how to store user inout into a readline
    string whipcream;

    Console.Write(" Have you ever swam in a pool of whip cream?>>");
    //store name as readline
    whipcream = Console.ReadLine();//saved user input

    Console.WriteLine("You are so weird I didnt think you would say " +whipcream+ " to my question!");
    Console.ReadLine();


    //------------NEXT QUESTION

    //how to store user input and convert into an integer
    string numberString;

    int number;

    Console.Write("How many times have you stuck your toes in peanutbutter??>>");
    numberString = Console.ReadLine();
    //use int.Parse() to convert the string to an int
    number = int.Parse(numberString);
    Console.WriteLine("HAHHAA ONLY " + number+ " TIMES?!?! UR SUCH A LOSER!");
    Console.ReadLine();

    //----------------NEXT  QUESTION

    string cleaning;

    Console.Write(" Would you rather vaccum the carpet or mop the hardwood?>>");
    //store answer as readline
    cleaning = Console.ReadLine();//saved user input

    Console.WriteLine("Makes sense, " +cleaning+ " seems a lot easier");
    Console.ReadLine();

    //-------------- NEXT QUESTION

    string covid;

    Console.Write(" Have you experienced more harsh symptoms in the last 14 days?>>");
    //store name as readline
    covid = Console.ReadLine();//saved user input

    Console.WriteLine("I dont know if I can trust you even though you said " +covid+ " to my question...");
    Console.ReadLine();

    //NEXT QUESTION-----------------------

    string vsnet;

    Console.Write(" Do you love our vs.net teacher?>>");
    //store name as readline
    vsnet = Console.ReadLine();//saved user input

    Console.WriteLine("Oh really?? Since you said " +vsnet+ " to my question, PROVE IT!");
    Console.ReadLine();


  }
}