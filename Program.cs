// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

int ReadInt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool IsPalindrome(int number)
{
    int firstNumber = number;
    int reversedNumber = 0;
    while (firstNumber > 0)
    {
        reversedNumber = reversedNumber * 10 + firstNumber % 10;
        firstNumber /= 10;
    }
bool res = reversedNumber == number;
if(res)
{
    return true;
}
return false;
}

int number ReadInt("Input 5-digit number");
bool result IsPalindrome(number);
System.Console.WriteLine($"The number {number} is + (result == true ? "number is palindrome" : "number is not palindrome")");
