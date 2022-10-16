// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int x = 2;
Console.WriteLine(x);  // 2;
addTwo(x);
Console.WriteLine(x);  // nadal 2;

void addTwo(int i)
{
    i=i+1;
    Console.WriteLine(i); // 3;
}

// Kolejność wykonania instrukcji
// 2
// 3
// 2