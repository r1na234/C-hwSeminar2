//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5

System.Console.WriteLine("enter the number: ");
int number = int.Parse(Console.ReadLine());

if((number/10)<99){
    System.Console.WriteLine($"Третьей цифры нет"); 
}
else{
    while((number/10)>99){
       number = (number / 10);
    }
    System.Console.WriteLine($"Третья цифра = {number%10}");
}
