/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab2A
*/

using System;

class Lab2A{
    public static void Main(string[] args){

        Console.Write("Enter a name: ");
        string name1 = Console.ReadLine();
        Console.Write("Enter another name: ");
        string name2 = Console.ReadLine();  
        Console.Write("Enter a verb: ");
        string verb = Console.ReadLine();
        Console.Write("Enter an adverb: ");
        string adverb = Console.ReadLine();
        Console.WriteLine("Once upon a time, there was a person named "+name1+" who had a child named "+name2+". This child would "+verb+" "+adverb+" while singing to strangers.");
    }
}
