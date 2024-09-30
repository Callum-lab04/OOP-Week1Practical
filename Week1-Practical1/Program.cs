LeapYearChecker();

void AgeAndName()
{
    String name;
    int age;

    Console.WriteLine("Please enter your name");
    name = Console.ReadLine();

    Console.WriteLine("Please enter your age");
    age = Convert.ToInt32(Console.ReadLine());

    age += 5;

    Console.WriteLine("Hello {0}, you will be {1} in 5 years.", name, age);
}

void AgeDetermination()
{
    int age;
    Console.WriteLine("Please enter your age");
    age = Convert.ToInt32(Console.ReadLine());

    if (age < 0 || age > 110)
    {
        Console.WriteLine("Invalid age");
    }
    else if (age <= 13)
    {
        Console.WriteLine("You are a child");
    }
    else if (age > 13 && age <= 19)
    {
        Console.WriteLine("You are an Teenager");
    }
    else
    {
        Console.WriteLine("You are an adult");
    }
    
}

void PositiveNegativeZero()
{
    int number;
    Console.WriteLine("Please enter a number");
    number = Convert.ToInt32(Console.ReadLine());

    if (number < 0)
    {
        Console.WriteLine("This is a negative number");
    }
    else if (number == 0)
    {
        Console.WriteLine("This is zero");
    }
    else
    {
        Console.WriteLine("This is a positive number");
    }
}

void LeapYearChecker()
{
    int year;

    Console.WriteLine("Enter a Year");
    year = Convert.ToInt32(Console.ReadLine());

    if (year <= 0)
    {
        Console.WriteLine("Invalid year");
    }
    else if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
    {
        Console.WriteLine("{0} is a leap year", year);
    }
    else
    {
        Console.WriteLine("{0} is not a leap year", year);
    }
}


