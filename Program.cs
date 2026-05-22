WorkingwithIntegers();
OrderPrecedence();

void WorkingwithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
int a = 5;
int b = 4;
int c = 2;
int d = (a + b) * c - (5 *2) - 3;
Console.WriteLine(d);
}