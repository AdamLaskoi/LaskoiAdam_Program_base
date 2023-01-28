using System.Runtime.InteropServices;

double x = 3;

double p = Math.Pow(x, 5);

float y = Math.Abs(-4);

float z = Abs(4);

//ez egyfügvény
float Abs (float input)
{
    if (input < 0)
        input = input * -1;
    return input;

}
// Ez egy eljárás
void WriteNumbers(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i);
    }
}

bool IsPrime(int number)
{

    for (int i = 2; i <= number / 2; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;

}

WriteFirstNPrime(100);
void WriteFirstNPrime(int n)
{
    int found = 0;
    for (int i = 2; found <= n; i++)
    {
        if (IsPrime(i))
        {
            Console.WriteLine();
            found++;
        }
    }

}