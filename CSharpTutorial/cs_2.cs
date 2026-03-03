using System;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.InteropServices;
/* 
This program tests the usage of random, for loops,
mathematical operations, loops, and a timer (stopwatch)
*/
class Program2 {
    static void Main(string[] args) {
        Random rand = new Random();
        int score = 0;
        int quizLength = 10;
        Stopwatch timer = new Stopwatch();
        timer.Start();
        for(int i = 0; i < quizLength; ++i)
        {
            int numOne = rand.Next(1, 20);
            int numTwo = rand.Next(1, 20);
            int operation = rand.Next(1, 5);
            int result = 0;
            switch(operation) {
                case 1: // Addition
                    Console.Write($"{numOne} + {numTwo} = ");
                    result = numOne + numTwo;
                    break;
                case 2:
                    Console.Write($"{numOne} - {numTwo} = ");
                    result = numOne - numTwo;
                    break;
                case 3:
                    Console.Write($"{numOne} * {numTwo} = ");
                    result = numOne * numTwo;
                    break;
                case 4:
                    Console.Write($"{numOne} / {numTwo} = ");
                    result = (int)(numOne / numTwo);
                    break;
            }
            int userInput = Convert.ToInt16(Console.ReadLine());
            if(userInput == result) {
                score++;
            }
        }
        timer.Stop();
        Console.WriteLine($"You made a {score}/10! Time ellapsed: {timer.ElapsedMilliseconds / 1000} seconds.");
    }
}