//zad1

int i = 10;
   do
     {
       Console.WriteLine(i); 
       i--; 
     }
        while (i >= 0);

//zad2
string haslo;
     do
        {
            Console.WriteLine("Podaj hasło (wpisz 'koniec', aby zakończyć):");
            haslo = Console.ReadLine();

        } while (haslo != "koniec"); 
 Console.WriteLine("Koniec programu.");

//zad3

int j = 1;
while (j <= 100)
{
    if (j % 2 == 0)
    {
        Console.WriteLine(j);
    }
    j++;
}

//zad4

for (int n = 1; n <= 15; n++)
{
    Console.WriteLine(n * n);
}

//zad5
List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };
foreach (int number in numbers)
{
    if (number % 7 == 0)
    {
        Console.WriteLine(number);
    }
}

//zad6

List<int> numbers2 = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };
foreach (int number in numbers2)
{
    if (number % 7 == 0)
    {
        Console.WriteLine(number);
        break;
    }
}

//zad7

double[] pierwiastki = new double[20];
for (int m = 0; i < pierwiastki.Length; m++)
{
    pierwiastki[m] = Math.Sqrt(m + 1);
}
Console.WriteLine("Pierwiastki kolejnych liczb całkowitych:");
for (int m = 0; m < pierwiastki.Length; m++)
{
    Console.WriteLine($"Pierwiastek z {m + 1} to: {pierwiastki[m]}");
}

//zad8

int[,] macierz = new int[3, 4];

for (int a = 0; a < 3; a++)
{
    for (int b = 0; b < 4; b++)
    {
        macierz[a, b] = a * 4 + b + 1;
    }
}

Console.WriteLine("\nMacierz po transpozycji:");
for (int b = 0; b < 4; b++) 
{
    for (int a = 0; a < 3; a++) 
    {
        Console.Write($"{macierz[a, b]} ");
    }
    Console.WriteLine();
}
   
//zad9

void PrintUpperCase(string txt)
{
    Console.WriteLine(txt.ToUpper());
}


//zad10
static void Main()
{
    WypiszMacierz(4, 5);
}

static void WypiszMacierz(int X, int Y)
{
    char[,] macierz = new char[X, Y];
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            macierz[i, j] = '$';
        }
    }
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            Console.Write(macierz[i, j] + " ");
        }
        Console.WriteLine();
    }
}


//zad11
static void Main2()
{
    Console.WriteLine(CheckEvenOrOdd(4));  
    Console.WriteLine(CheckEvenOrOdd(7)); 
    Console.WriteLine(CheckEvenOrOdd(0));
}
static string CheckEvenOrOdd(int number)
{
    if (number % 2 == 0)
    {
        return "Even";
    }
    else
    {
        return "Odd";
    }
}


//zad12

static void Main3()
{
    int n = WczytajZKlawiatury("Podaj liczbę wierszy (n): ");
    int m = WczytajZKlawiatury("Podaj liczbę kolumn (m): ");

    char[,] tablica = WypelnijTablice(n, m);
    WyswietlTabliceNaEkran(tablica);
}

static int WczytajZKlawiatury(string komunikat)
{
    Console.Write(komunikat);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int wynik))
        {
            return wynik;
        }
        Console.WriteLine("Nieprawidłowa wartość, spróbuj ponownie.");
    }
}

static char[,] WypelnijTablice(int n, int m)
{
    char[,] tablica = new char[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
            {
                tablica[i, j] = '#';
            }
            else
            {
                tablica[i, j] = ' ';
            }
        }
    }

    return tablica;
}

static void WyswietlTabliceNaEkran(char[,] tablica)
{
    int n = tablica.GetLength(0);
    int m = tablica.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(tablica[i, j]);
        }
        Console.WriteLine();
    }
}

//zad13

static void Main4()
{
    double a = 1, b = -3, c = 2;
    double[] rozwiazania = RozwiazRownanieKwadratowe(a, b, c);
    Console.WriteLine("Rozwiązania równania:");
    foreach (var x in rozwiazania)
    {
        Console.WriteLine(x);
    }
}

static double[] RozwiazRownanieKwadratowe(double a, double b, double c)
{
    if (a == 0)
    {
        throw new ArgumentException("Współczynnik a nie może być równy 0 (to nie jest równanie kwadratowe).");
    }

    double delta = b * b - 4 * a * c;
    if (delta > 0)
    {
        double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        return new double[] { x1, x2 };
    }
    else if (delta == 0)
    {
        double x = -b / (2 * a);
        return new double[] { x };
    }
    else
    {
        return new double[] { };
    }
}