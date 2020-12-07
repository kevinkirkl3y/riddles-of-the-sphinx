using System;

class Program
{
    
  static void Main()
  {
    Console.WriteLine("You have entered the lair of the Mighty Sphinx, in order to survive you must correctly answer their riddles... If you understand the rules of the lair type 'y'.");
    string answer1 = Console.ReadLine();
    bool correct1 = answer1 == "y";
    if (correct1)
    {
      Console.WriteLine("Good! Your second question is: What is 2+2?");
    }
    else 
    {
      Console.WriteLine("You are incorrect, the Mighty Sphinx pulls out knife and fork for supper...");
      Main();
    }
    string answer2 = Console.ReadLine();
    bool correct2 = answer2 == "4";
    if (correct2)
    {
      Console.WriteLine("Good! Your third question is: What is the first letter of the English alphabet?");
    }
    else 
    {
      Console.WriteLine("You are incorrect, the Mighty Sphinx pulls out knife and fork for supper...");
      Main();
    }
    string answer3 = Console.ReadLine();
    bool correct3 = answer3 == "a" || answer3 == "A";
    if (correct3)
    {
      Console.WriteLine("Very Nice! Your fourth question is: What is the air speed of an unladen swallow?");
    }
    else 
    {
      Console.WriteLine("You are incorrect, the Mighty Sphinx pulls out knife and fork for supper...");
      Main();
    }
    string answer4 = Console.ReadLine();
    bool correct4 = answer4 == "What do you mean? African or European swallow?";
    if (correct4)
    {
      Console.WriteLine("What, I dunno?! **The Sphinx is jettisoned to hell! You WIN!!!**");
    }
    else 
    {
      Console.WriteLine("You are incorrect, the Mighty Sphinx pulls out knife and fork for supper...");
      Main();
    }
  }
}