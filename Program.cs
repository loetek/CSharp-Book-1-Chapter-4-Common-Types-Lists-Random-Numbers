using System;
using System.Collections.Generic;
using System.Linq;

namespace randomNumbers_List
{
    class Program
    {
        static void Main(string[] args)
        {
        Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
        };

       // numbers.ForEach(num =>Console.WriteLine($"Testing Rando {num}"));

//!!Two solutions for this problem. I compared each number to the index position.
    numbers.ForEach(num => {
       //Console.WriteLine (numbers.IndexOf(num));
            if(numbers.IndexOf(num) == num){
                Console.WriteLine($"Test1: numbers list contains {num}");
            }
            else{
                Console.WriteLine($"Test1: numbers list does not contain {num}");
            }
    });

//!! This method compares the current index to all numbers in the list.
    for(int i =0; i < numbers.Count; i++){
       //Console.WriteLine (numbers.IndexOf(num));
            if(numbers.Exists(num1 => num1 == i)){
                Console.WriteLine($"numbers list contains {i}");
            }
            else{
                Console.WriteLine($"numbers list does not contain {i}");
            }
    };

        }

    }
}
