// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5

System.Console.WriteLine("Напишите трехзначное число");
int number = int.Parse(System.Console.ReadLine());
if( 99 < number && number < 1000){
    int number1 = number/10;
    int number2 = number1%10;
    System.Console.WriteLine($"second number = {number2}"); 
}
else{
    System.Console.WriteLine("ERROR");
}