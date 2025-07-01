// check the palidrome or not
// store and reuse
//formal arguments(defintion) and actual argument;
//positional argument
//how can we accept number of arguments in the fucntion defintion 
//Recursion factorial 
//LIsts

using System;
class Program
{
    static void Main()
    {
        Dictionary<int, string> items = new Dictionary<int, string>();
        items[1] = "Apple";
        items[2] = "Orange";
        foreach (KeyValuePair<int, string> name in items)
        {
            Console.WriteLine(name.Value);
        }
    }
}

// wrtie a program to calculate the area of a rectangle given its length and width
// try and except block in c sharp
/* using System;
partial class Program
{
    static void Main()
    {
        int length, breadth;
        Console.WriteLine("Enter the length");
        length = Convert.ToInt32(Console.ReadLine());
        breadth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The area is {length * breadth}");
    }
}
 */

//Develop a program to convert temperature from Celsius to Fahrenheit.
/* using System;
class Program
{
    static void Main()
    {
        int temperature;
        Console.WriteLine("Enter the tempreature in celsius");
        temperature = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{temperature*1.8 + 32}");
    }
} */

//⿣ Create a program to calculate simple interest for a given principal, rate, and time.
/* using System;
class Program
{
    static void Main()
    {
        int Principal, Time, Rate;
        Console.WriteLine("Enter the principal, Time, Rate");
        Principal = Convert.ToInt32(Console.ReadLine());
        Time = Convert.ToInt32(Console.ReadLine());
        Rate = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The simple interest is {(Principal * Time * Rate) / 100}");
    }
} */

//Write a program that takes two numbers from the user and performs addition, subtraction, multiplication, and division using appropriate operators.
/* using System;
class Program
{
    static void Main()
    {
        var num1 = Convert.ToInt32(Console.ReadLine());
        var num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The addition of two number is {num1+num2} , subtraction of two number is {num1-num2} , multiplication of two number is {num1*num2}")
    }
} */

//⿥ Build a program to find the largest among three numbers using if-else.
/* using System;
class Program
{
    static void Main()
    {
        int a, b, c;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine($"{a} is the greatest number among three");
        }
        else if (b > c)
        {
            Console.WriteLine($"{b} is the greatest number");
        }
        else
        {
            Console.WriteLine($"{c} is the greatest number among these three");
        }
        
    }
}  */

//⿦ Write a program to check if an entered number is even or odd using if-else.
/* using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Even or Odd Checker");

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()!);

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.");
        }
    }
} */

//⿧ Design a program that takes a day number (1–7) and prints the day name using switch.
/* using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a day number between (1-7)");
        Console.Write("enter");
        int dayNumber = int.Parse(Console.ReadLine()!);
        switch (dayNumber)
        {
             case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
                break;
        }
    }
} */

// Create a program that takes a month number (1–12) and displays the number of days in that month using switch.

/* using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Month Days Checker");
        Console.Write("Enter a month number (1 to 12): ");

        int month = int.Parse(Console.ReadLine()!);

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("This month has 31 days.");
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("This month has 30 days.");
                break;

            case 2:
                Console.WriteLine("This month has 28 or 29 days (February).");
                break;

            default:
                Console.WriteLine("Invalid month number. Please enter a number from 1 to 12.");
                break;
        }
    }
}
 */

//⿩ Write a program to generate the multiplication table of a number (for example, 5) using a for loop.

/* using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number for multiplication table");
        int number = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number}*{i} = {number*i}");
        }
    }
} */

//🔟 Develop a program to find the sum of the first 100 natural numbers using a while loop.

/* using System;

class Program
{
    static void Main()
    {
        int number = 1;
        int sum = 0;

        while (number <= 100)
        {
            sum += number;
            number++;
        }

        Console.WriteLine("The sum of the first 100 natural numbers is: " + sum);
    }
} */
// to check leap year or not

/* using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a year for checking whether it is a leap year or not");
        int year = int.Parse(Console.ReadLine()!);
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 !=0))
        {
            Console.WriteLine("it is a leap year");
        }
     
        else
        {
            Console.WriteLine("it isnot a leap year");
        }

    }
}
 */

//Write a program to calculate the grade of a student based on average marks in five subjects, using if-else statements.

/* using System;

class Program
{
    static void Main()
    {
        int total = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter marks for subject {i}: ");
            total += int.Parse(Console.ReadLine()!);
        }

        float average = total / 5f;

        if (average >= 90)
            Console.WriteLine("Grade: A+");
        else if (average >= 80)
            Console.WriteLine("Grade: A");
        else if (average >= 70)
            Console.WriteLine("Grade: B+");
        else if (average >= 60)
            Console.WriteLine("Grade: B");
        else
            Console.WriteLine("Grade: C");
    }
}
 */

//  Create a program that accepts a character from the user and checks if it is a vowel or consonant using switch.
/* using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = char.ToLower(Console.ReadLine()![0]);
    
        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonant");
                break;
        }
    }
} */

//Build a program to reverse a given integer using a while loop.
/* using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()!);
        int reversed = 0;

        while (number != 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }

        Console.WriteLine("Reversed number: " + reversed);
    }
}
 */

// Print Odd Numbers 1 to 50
/*  using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 50; i += 2)
        {
            Console.Write(i + " ");
        }
    }
}
 */

//  Develop a program that simulates a basic ATM menu using switch (deposit, withdraw, check balance, exit).
/* using System;

class Program
{
    static void Main()
    {
        double balance = 1000;

        while (true)
        {
            Console.WriteLine("\n1. Deposit\n2. Withdraw\n3. Check Balance\n4. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    balance += double.Parse(Console.ReadLine()!);
                    break;
                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    double amount = double.Parse(Console.ReadLine()!);
                    if (amount <= balance)
                        balance -= amount;
                    else
                        Console.WriteLine("Insufficient funds.");
                    break;
                case 3:
                    Console.WriteLine("Current balance: " + balance);
                    break;
                case 4:
                    Console.WriteLine("Thank you!");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
 */

//⿡⿨ Create a program to count the number of digits in an integer using a while loop.

/*  using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine()!);
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        Console.WriteLine(count);
    }
 } */

//⿡⿩ Write a program that takes a number and determines whether it is positive, negative, or zero using if-else.
/* 
 using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine()!);

        if (num > 0)
            Console.WriteLine("Positive");
        else if (num < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
    }
}
 */

//  ⿢⿠ Design a program to find the sum of even numbers between 1 and 100 using a for loop.
/* using System;
class Program
{
    static void Main()
    {
        
        int sum = 0;
        for (int i = 2; i <= 100; i += 2)
            sum += i;

        Console.WriteLine("Sum of even numbers from 1 to 100: " + sum);
    }
} */

/* // create program menu loop
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

string menuSelection = "";
int maxPets = 8;
string? readResult;
string[,] ourAnimals = new string[maxPets, 6];
do
{
    Console.WriteLine("Enter the")
    readResult = Console.ReadLine();
    switch (readResult)
    {
        
        
    }


} while (menuSelection != "exit");
 */

