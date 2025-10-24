// See https://aka.ms/new-console-template for more information

using DuckDuckGoDotNet;

var d = new DuckDuckGoSearch();
var search = await d.TextAsync("Iran");
foreach (var item in search)
{
    var a = item.Title;
    Console.WriteLine(a);
}

Console.ReadLine();