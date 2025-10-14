using System.Collections.Generic;
using System.Reflection;

//3.Queue
// Definition:
// What is a Queue ?

//A Queue is a special type of collection that stores elements in a First In, First Out (FIFO) order.
//That means:
//➡️ The first element added is the first one removed.

//Think of it like people waiting in a line at a ticket counter 🎟️
//The first person who joins the line gets the ticket first, and the last person has to wait.

//Important Queue Methods:

//Method                      Description
//Enqueue(item)	           Adds an item to the end of the queue
//Dequeue()	               Removes and returns the first item in the queue
//Peek()	               Returns the first item without removing it
//Count	                   Returns the number of elements in the queue
//Clear()	               Removes all elements from the queue

//Example
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> token = new Queue<string>();

        token.Enqueue("Token 1");
        token.Enqueue("Token 2");
        token.Enqueue("Token 3");

        Console.WriteLine("Total token: " + token.Count);

        Console.WriteLine("Processing: " + token.Dequeue());
        Console.WriteLine("Next token in line: " + token.Peek());
        Console.WriteLine("Remaining token: " + token.Count);
    }
}


// When to use:
// When you want first come, first served behavior.
//Example:  ticket queue, customer requests.