Random r = new Random();
int Number = r.Next(0,300);
int a = 0;
int c = 0;
bool b = false;

while (b == false)
{
    Console.WriteLine("Lead a number from 1 to 300");
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
        g = Number - 20;
        h = Number + 20;
        if (g < 0)
        {
            g = 0;
        }
        if (h > 300)
        {
            h = 300;
        }
        Console.WriteLine("The hidden number from " + g + " to " + h);
    }
    if (c == 5)
    {
        int g, h;
        g = Number - 10;
        h = Number + 10;
        if (g < 0)
        {
            g = 0;
        }
        if (h > 300)
        {
            h = 300;
        }
        Console.WriteLine("The hidden number from " + g + " to " + h);
    }
}

