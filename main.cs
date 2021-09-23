using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("How many cars in total?");
       int cars = Convert.ToInt32(Console.ReadLine());
     int counter = 1;
     double total = 0;
     while (counter<=cars){
    Console.WriteLine("Enter the distance covered by car " + counter + " in miles.");
    double distance = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the time taken by car " + counter + " in hours.");
    double time = Convert.ToDouble(Console.ReadLine());
    double speed = distance/time;
    Console.WriteLine("The speed of this car is " + speed + " miles per hour.");
     total=total+speed;
   counter++;}
double average = total/cars;
  Console.WriteLine("The average speed of the cars is " + average + " miles per hour.");
  }
}