using System;
class doubleAndDecimal
{
    static void Main()
    {
        Console.WriteLine("this is with float calculation");
        double firstNumber = 1.00f;
        double secondNumber = 0.33f;
        double thirdNumber = 1.33f;
        double realResult = firstNumber + secondNumber;
        bool result = (firstNumber + secondNumber == thirdNumber);
        Console.WriteLine("firstNumber is {0},\nsecondNumber is {1},\nther result is {2}"
            , firstNumber, secondNumber, thirdNumber);
        Console.WriteLine("and this is {0}", result);
        Console.WriteLine("they result shoud be {0}", realResult);
        Console.WriteLine();
        Console.WriteLine("this is with decimal calculation :");
        decimal a = 1.00m;
        decimal b = 0.33m;
        decimal c = 1.33m;
        decimal decResult = a + b;
        bool boolResult = (a + b) == c;
        Console.WriteLine("first number is {0}\nsecond number is {1}\nresult of them is {2}",
           a, b, decResult);
        Console.WriteLine("ant that is {0}", boolResult);
        Console.Read();

    }
}

