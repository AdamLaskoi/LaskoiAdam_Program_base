/*
 
 Console.WriteLine("Hello Unity");

//elágazások

int ammo = 10;
bool isInAir = false;

if(ammo > 0 && !isInAir)        //van ammo és nem lebeg a karakter
{
    Console.WriteLine("BUMMM");
    ammo--;
}

bool isGrounded = !isInAir;
bool haveAmmo = ammo > 0;

bool canShoot = haveAmmo && isGrounded;   //tudok löni
if (canShoot)
{
    Console.WriteLine("BUMMM");
}
else 
{
    Console.WriteLine("KLICK");

}

//--------------------------------------------------------------------------------------------

Console.WriteLine("írj be egy egész számot");
string line = Console.ReadLine();
int number = int.Parse(line);

Console.WriteLine("A szám duplája:");
Console.WriteLine( number * 2 );
//--------------------------------------------------------------------------------------------




Console.WriteLine("írj be egy egész számot!");
string line = Console.ReadLine();
int number = int.Parse(line);
int eredmeny = number / 2;
Console.WriteLine( eredmeny);
if ( eredmeny >= 0)
{
    Console.WriteLine("Páratlan");
}
else
{
    Console.WriteLine("Páros");
}


//Páros vagy páratlan

 
 
 */
/*
Console.WriteLine("írj be egy egész számot!");
string line = Console.ReadLine();

int number = int.Parse(line);


bool isEven = (number % 2) == 0;

if (isEven)
{
    Console.WriteLine("Páratlan");
}
else
{
    Console.WriteLine("Páratlan");
}


//------------------------------------------------
// Pozitiv, negatív

Console.WriteLine("írj be egy egész számot!");
string line = Console.ReadLine();
int number = int.Parse(line);

if(number > 0)
{
    Console.WriteLine("Pozitív");

}else
{
    if (number < 0)
    {
        Console.WriteLine("Negattív");
    }
    else 
    {
        Console.WriteLine("Nulla");
    }
    
}

//----------------------------------------


Console.WriteLine("írj be egy egész számot!");
string line = Console.ReadLine();
int number = int.Parse(line);

if (number > 0)
{
    Console.WriteLine("Pozitív");

}
else if (number < 0)//külömben HA
{

    Console.WriteLine("Negattív");
}
else
{
    Console.WriteLine("Nulla");
}


// Kerek / Nem kerek

Console.WriteLine("írj be egy egész számot!");

string line = Console.ReadLine();
int number = int.Parse(line);
// 3 operandusu müvelet feltételes érték adás operator
string text = number % 10 == 0 ? "KEREK" : "NEM kerek";
Console.WriteLine(text);


//----------------------CIKLUSOK--------------------------------


int i = 1;

while (i <= 100)  //amig
{
    Console.WriteLine(i);
    i++;
}

//számláló ciklusok

for(int j = 1; j<=100; j++)
{
    Console.WriteLine(j);
}

//írjuk ki az első 10 számot ami ösztható 3-al

// megoldas

for (int i = 1; i<=10; i++)
{
    Console.WriteLine(i * 3);
}


//írjlyuk ki az első olyan számot ami osztható 5 el de nem osztható 7 el

Console.WriteLine("Írj be egy egész számot!");
string line = Console.ReadLine();

int n = int.Parse(line);

for (int i = 1; i <= 10; i++)
{
 
    if (n % 5 == 0  && n % 7 == 0)
    {
        Console.WriteLine(n);
    }

}

using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Írj be egy egész számot!");
string line = Console.ReadLine();
int n = int.Parse(line);

int x = 5;
int count = 0;

for (int i = 1; i <= n; i++)
{
    int numbertToWrite = i * x;
    bool devisiblewith7 = numbertToWrite % 7 == 0;

    if (!devisiblewith7)
    {
        Console.WriteLine(numbertToWrite);
        count++;
    }
}


// szorzotábla
// 1 * 1 = 1
// 1*  2 = 2
//...
// 1* 10 = 10
// 2* 1 = 1
// 10 *10 = 100

for (int a = 1; a <= 10; a++)
{
    for (int i = 1; i <= 10; i++)
    {
        int result = a * i;
        Console.WriteLine(i + " * " + a + " = " + result);
    }


}

*/

//-------
//metodusok
/*
double f1 = 12.5f;
double f2 = 3;

double power = Math.Pow(f1,f2);
double power2 = Math.Pow(45, 11.5);

double f3 = Math.Abs(f1);
*/