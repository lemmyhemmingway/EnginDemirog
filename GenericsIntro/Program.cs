// See https://aka.ms/new-console-template for more information

using GenericsIntro;


/*
MyList<string> myList = new MyList<string>();

myList.Add("hahuhahuh");
myList.Add("huaoehuhaehuhh");
myList.Add("ahehuhahehuaoehuhaehuhahoeuh");
Console.WriteLine(myList);
*/

MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
myDictionary.Add("test", "test");
myDictionary.Add("anothertest", "anothertest");
var value = myDictionary.Get("test");
Console.WriteLine(value);
Console.WriteLine(myDictionary);
