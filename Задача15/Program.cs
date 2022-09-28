// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да

System.Console.WriteLine("enter the number from 1 to 7");
int dayofweek = int.Parse(System.Console.ReadLine());

if(dayofweek>=1 && dayofweek<=7){
  if(dayofweek>=6 && dayofweek <=7){
    System.Console.WriteLine("Выходной");
  }  
  else{
    System.Console.WriteLine("Будний");
  }
} 
else{
    System.Console.WriteLine("ERROR");
}
