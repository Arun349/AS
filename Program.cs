using System;
class Program{
static void Main()
{
LinkedList <string> list = new LinkedList<string>();
list.AddLast("Ruban");
    list.AddLast("Sanjai");
    list.AddLast("Asha");
    var NodeGo = list.AddLast("Karnisha");
var friend= list.AddFirst("Arun");
list.AddBefore(friend,"Sindhu");
    Console.WriteLine("Initial list");
    foreach (string i in list)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Array afer updation");
    list.AddAfter(NodeGo,"Kathir");

    foreach(string i in list){
        Console.WriteLine(i);
    }


LinkedList <int> list1 = new LinkedList <int>();
list1.AddLast(1);
foreach(int i in list1){
Console.WriteLine(i);}
}
}