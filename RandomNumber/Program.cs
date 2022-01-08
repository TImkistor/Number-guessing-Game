Random r = new Random();
int a = 0;
int c = 0;
bool b = false;

int range = 0;
int clue11 = 0;
int clue12 = 0;
int clue21 = 0;
int clue22 = 0;

Console.WriteLine("Select a range");
range = Convert.ToInt32(Console.ReadLine());

int Number = r.Next(1, range);

Console.WriteLine("Choose plus");
clue11 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose minus");
clue12 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose plus");
clue21 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose minus");
clue22 = Convert.ToInt32(Console.ReadLine());


while (b == false)
{
    Console.WriteLine("Lead a number from 1 do "+ range);
    a = Convert.ToInt32(Console.ReadLine());
   if ( a == Number)
    {
        Console.WriteLine("You win");
        b = true;
        c = 0;
        Console.ReadLine();

    }
    if (c == 7)
    {
        Console.WriteLine("You lose the hidden number is " + Number);
        b = true;
        c = 0;
        Console.ReadLine();
    }
    if (a != Number && b == false)
    {
        Console.WriteLine("You miss");
        c++;
    }
    if (c == 3)
    {
        int g, h;
        g = Number - clue12;
        h = Number + clue11;
        if (g < 0)
        {
            g = 0;
        }
        if (h > range)
        {
            h = range;
        }
        Console.WriteLine("The hidden number from " + g + " to " + h);
    }
    if (c == 5)
    {
        int g, h;
        g = Number - clue22;
        h = Number + clue21;
        if (g < 0)
        {
            g = 0;
        }
        if (h > range)
        {
            h = range;
        }
        Console.WriteLine("The hidden number from " + g + " to " + h);
    }
}

