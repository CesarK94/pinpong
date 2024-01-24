// See https://aka.ms/new-console-template for more information
using pinpong;

Console.WriteLine("Hello, World!");
Console.WriteLine("Es la misma instancia" + (Game.Instance == Game.Instance));
Game.Instance.OnPlay();