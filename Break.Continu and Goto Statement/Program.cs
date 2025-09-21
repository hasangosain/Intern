

using System;
using System.Diagnostics;
//Break Statement
int j;
for (j = 1; j <= 5; j++)
{
    if (j == 5)
    {
        Console.WriteLine("Break here{0}", j);
        break;
    }
    Console.WriteLine("Iterate {0}", j);
}

Console.WriteLine();
//Continue Statement

int j;
for (j = 1; j <= 5; j++)
{
    if (j == 5)
    {
        Console.WriteLine("Break here{0}", j);
        break;
    }
    Console.WriteLine("Iterate {0}", j);
}
Console.WriteLine();

//Goto Statement
int count = 1;
labelGoto:
for (int k = 1; k <= 5; k++)
{
    if (k == 3 && count == 1)   
    {
        count++;
        Console.WriteLine("Goto Statement {0}", k);
        goto labelGoto;
    }
    Console.WriteLine("Iteration {0}", k);
}
