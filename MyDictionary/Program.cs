using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(0, "Engin");
            myDictionary.Add(1, "Kerem");
            myDictionary.Add(2, "Halil");
            myDictionary.Add(3, "İlker");



            Console.ReadLine();
        }
    }
}
