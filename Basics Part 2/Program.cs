// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//3
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Numbers:" + i);
}
int countDown = 5;
while(countDown > 0)
{
    Console.WriteLine(countDown);
    countDown--;
}

//4
string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday ", " Sunday", " Thursday" };
for (  int i = 0;i < daysOfWeek.Length; i++)
{
    Console.WriteLine(daysOfWeek[i]);

}


// 4 challenge 2:
int[] numb
    = { 1,2,3,4,5 };
int final = 0;
for (int x = 1; x <=numb.Length; x++)
{
    final +=  x;

}
Console.WriteLine( "final result :" + final);

// second bouns 
// its useful when we want to make a table with row and colums and matrex