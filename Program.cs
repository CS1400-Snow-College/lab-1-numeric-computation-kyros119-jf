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

d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

int e = 7;
int f = 4;
int g = 3;
int h = (e + f) / g;
Console.WriteLine(h);
}

int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b ) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of intergers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An exmaple of overflow: {what}");


double k = 5;
double l = 3;
double m = 2;
double n = (k + l) /m;
Console.WriteLine(n);

double o = 19;
double p = 23;
double q = 8;
double r = (o + p) /q;
Console.WriteLine(r);

double maxdouble = double.MaxValue;
double mindouble = double.MinValue;
Console.WriteLine($"The Range of double is {mindouble} and {maxdouble}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

decimal mindecimal = decimal.MinValue;
decimal maxdecimal = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {mindecimal} and {maxdecimal}");

double s = 1.0;
double t = 3.0;
Console.WriteLine(s / t);

decimal u = 1.0M;
decimal v = 3.0M;
Console.WriteLine(u / v);

// This is my Own formula


int maincharhealthbar = 1000;
int maincharbasicattack = 10;
int attackpower = 10;
int powerbuff = 2;


int opponentattack = 2;
decimal opponentpowerbuff = .5M;
int opponenthealth = 500;

int specialmove = (maincharbasicattack + attackpower) * powerbuff;

Console.WriteLine(specialmove);

int opponenthurt = opponenthealth - specialmove;
Console.WriteLine(opponenthurt);