using System;
using System.Collections.Generic;

class Program
{
    void CountWords()
    {
        List<string> Words = new List<string>();

       foreach (var word in Words)
        {
            Console.Write("Enter a word add or full stop if finished: "); 
            Words.Add(Console.ReadLine());  //adds words to list

            if (Console.ReadLine() == ".")   //allows users to stop the loop. 
            {
                break;
                  return Words.Count;  //returns the number of words in the list.
                Console.WriteLine("Number of words:", Words.Count);  //counts the number of words in the list.

            }
       
            
        }

       
    }
        
}