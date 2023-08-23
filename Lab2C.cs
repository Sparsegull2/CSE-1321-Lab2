/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: ... 
*/

using System;

class Lab2C{
    public static void Main(string[] args){
        Console.Write("Enter a width: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Enter a height: ");
        int height = int.Parse(Console.ReadLine());

        int area = width * height;
        int perimeter = 2* (width + height);

        Console.WriteLine("The area is " + area);
        Console.WriteLine("The perimeter is " + perimeter);

    }
}
