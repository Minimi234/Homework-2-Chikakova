// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

void FindSecondDigit (int arg)
 {
    if (arg >= 100) {
        result = (num % 100) / 10;
        Console.WriteLine(result);
    }
    else {
        Console.WriteLine("number is not three digits");
    }
}
Console.WriteLine("Enter a three-digit number");
int = Convert.ToInt32(Console.ReadLine());

FindSecondDigit(num); 