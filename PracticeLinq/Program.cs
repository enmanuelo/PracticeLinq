using System;
using System.Linq;

List<string> videoGames = new List<string>() {"Madden", "NBA 2K 2022", "GTA", "Mario"};

videoGames.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));

//IEnumerable<string> orderGames =
//    videoGames.OrderBy(x => x.Length);

//foreach (var item in orderGames)
//{
//    Console.WriteLine(item);
//}
