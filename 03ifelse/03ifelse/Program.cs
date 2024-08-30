void ÖvningEtt()
{
    
    Console.Write("Skriv in ett nummer:");

    int inputNummer = int.Parse(Console.ReadLine());

    if (inputNummer % 2  == 0)
    {
        Console.WriteLine("Talet är jämnt");
    }
    else
    {
        Console.WriteLine("Talet är udda");
    }
}

void ÖvningTvå()
{
    Console.Write("Ange din ålder:");
    int age = int.Parse(Console.ReadLine());

    if (age <= 13)
    {
        Console.WriteLine("Du är ett barn");
    }
    else if (age > 13 && age < 19)
    {
        Console.WriteLine("Du är en tonåring");
    }
    else
    {
        Console.WriteLine("Du är vuxen");
    }
}
void ÖvningTre()
{
    Console.Write("Skriv in din poäng");
    int score = int.Parse(Console.ReadLine());

    if (score >= 90)
    {
        Console.WriteLine("Betyg: A");
    }
    else if (score >= 80 && score <= 89)
    {
        Console.WriteLine("Betyg: B");
    }
    else if (score >= 70 && score <= 79)
    {
        Console.WriteLine("Betyg: C");
    } 
    else if (score >= 60 && score <= 69)
    {
        Console.WriteLine("Betyg: D");
    }
    else if (score < 60)
    {
        Console.WriteLine("Betyg: F");
    }
}

void ÖvningFyra()
{
    Console.Write("Ange ett årtal");
    int userYear = int.Parse(Console.ReadLine()); 

    if ((userYear % 4 == 0 && userYear % 100 != 0) || userYear % 400 == 0)
    {
        Console.WriteLine("Detta är ett skottår");
    }
    else
    {
        Console.WriteLine("Detta är inte ett skottår");
    }
}

void ÖvningFem()
{
    Console.WriteLine("Ange första talet");
    int talEtt = int.Parse(Console.ReadLine());
    Console.WriteLine("Ange andra talet");
    int talTvå = int.Parse(Console.ReadLine());
    Console.WriteLine("Ange tredje talet");
    int talTre = int.Parse(Console.ReadLine());

    if (talEtt > talTvå && talEtt > talTre)
    {
        Console.WriteLine(talEtt);
    }
    else if (talTvå > talEtt && talTvå > talTre)
    {
        Console.WriteLine(talTvå);
    }
    else
    {
        Console.WriteLine(talTre);
    }
}

void ÖvningSex()
{
    Console.WriteLine("Ange ett tal");
    int userTal = int.Parse(Console.ReadLine());

    if(userTal < 0)
    {
        Console.WriteLine("Ditt tal är negativt");
    }
    else if (userTal > 0)
    {
        Console.WriteLine("Ditt tal är positivt");
    }
    else
    {
        Console.WriteLine("Ditt tal är 0");
    }
}

void ÖvningSju()
{
    Console.WriteLine("Ange summan av köpet");
    double summa = double.Parse(Console.ReadLine());

    if (summa > 1000)
    {
        summa = summa * 0.9;
        Console.WriteLine("Totalpriset efter rabatt är: " + summa);
    }
    else if (summa <= 1000)
    {
        Console.WriteLine("Totalpriset är " + summa);
    }
}

void ÖvningÅtta()
{
    Console.WriteLine("Ange ett nummer från 1-7");
    int userNumber = int.Parse(Console.ReadLine());

    switch (userNumber)
    {
        case 1:
            Console.WriteLine("Måndag");
            break;

        case 2:
            Console.WriteLine("Tisdag");
            break;

        case 3:
            Console.WriteLine("Onsdag");
            break;

        case 4:
            Console.WriteLine("Torsdag");
            break;

        case 5:
            Console.WriteLine("Fredag");
            break;

        case 6:
            Console.WriteLine("Lördag");
            break;

        case 7:
            Console.WriteLine("Söndag");
            break;

        default:
            Console.WriteLine("FEL: Ogiltigt tal");
            break;
    }
}

void ÖvningNio()
{
    string password = "CSharp123";
    Console.WriteLine("Ange lösenordet");

    string userPassword = Console.ReadLine();

    if (password == userPassword)
    {
        Console.WriteLine("Godkänt lösenord");
    }
    else if (password != userPassword)
    {
        Console.WriteLine("Fel lösenord");
    }
}

void ÖvningTio()
{
    Console.WriteLine("Vilken konvertering vill du genomföra");
    Console.WriteLine("1: celcius till fahrenheit");
    Console.WriteLine("2: fahreheit till celcius");

    double userVal = double.Parse(Console.ReadLine());

    if (userVal == 1)
    {
        Console.WriteLine("Ange grader celcius");
        double userCel = double.Parse(Console.ReadLine());

        double fahrconv = (userCel * 1.8) + 32;
        Console.WriteLine("Det blir " + fahrconv + " grader fahrenheit");
    }
    else if (userVal == 2)
    {
        Console.WriteLine("Ange grader fahrenheit");
        double userFahr = double.Parse(Console.ReadLine());

        double celConv = (userFahr - 32) / 1.8;
        Console.WriteLine("Det blir " + celConv + " grader celcius");
    }

}

Console.WriteLine("Vilken övning vill du göra? 1-10");
int userChoice = int.Parse(Console.ReadLine());

switch (userChoice)
{
    case 1:
        ÖvningEtt();
        break;

    case 2:
        ÖvningTvå();
        break;

    case 3:
        ÖvningTre();
        break;
    case 4:
        ÖvningFyra();
        break;
    case 5:
        ÖvningFem();
        break;
    case 6:
        ÖvningSex();
        break;
    case 7:
        ÖvningSju();
        break;
    case 8:
        ÖvningÅtta();
        break;
    case 9:
        ÖvningNio();
        break;
    case 10:
        ÖvningTio();
        break;
}