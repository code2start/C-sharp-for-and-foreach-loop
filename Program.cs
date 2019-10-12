using System;

namespace forandforeachloop
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = {2,3,9,1};
           //string interpolation
           /* for(int i = 0 ;i < 4; i++){
               Console.WriteLine($" item {numbers[i]}");
           } */
           foreach(int number in numbers){
               Console.WriteLine($"Item {number}");
           }
           string[] courses = {"C#","ASP.net","PHP","Android"};
           foreach(string course in courses){
               Console.WriteLine(course);
           }
        }
    }
}
