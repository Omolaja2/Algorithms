
using Alogrithm;

List<int> positions = Alogrithms.GetVowelPositions("Hello WORLD!");

foreach(int position in positions)
{
    Console.Write($"Index: {position} ");

}


Console.WriteLine(" ");



var name = "Omolaja";
var result = Alogrithms.ShiftLetters(name);
Console.WriteLine($"Letters Shifted : {result}");


Console.WriteLine(" ");

var names = "Mamun";
var characters = Alogrithms.TransformCase(names);
Console.WriteLine($"Case : {characters}");

Console.WriteLine(" ");


var Text = "Mamzy";
var Input = Alogrithms.SwapPairs(Text);
Console.WriteLine($"Letters Swapped : {Input}");

Console.WriteLine(" ");


var Insert ="Hello";
char c1 = 'o';
char c2 = 'a';
var chars = Alogrithms.ReplaceCharacter(Insert, c1, c2);
Console.WriteLine($"{chars}");
