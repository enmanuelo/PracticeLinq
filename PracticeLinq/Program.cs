using System;
using System.Linq;

/* DONE - Create a new console app and name it PracticeLinq.
   DONE - Create a list of video game names...
   DONE - Order the list of games by length of the game name.
   DONE - Use the lambda expression in this exercise as well.

        use Method Syntax for this exercise
*/


List<string> videoGames = new List<string>() {"Madden", "NBA 2K 2022", "GTA", "Mario"};

IEnumerable<string> orderGames =
    videoGames.OrderBy(x => x.Length);

foreach (var item in orderGames)
{
    Console.WriteLine(item);
}

