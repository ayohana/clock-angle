using System;
using System.Collections.Generic;

public class Clock
{
  // Constructor =====================
  public string InputTime;
  public string[] TimeArr;
  public int HourHand;
  public int MinHand;

  // Constructor Method ===============
  public Clock(string InputTime)
  {
    InputTime = InputTime;
    TimeArr = InputTime.Split(":");
    HourHand = int.Parse(TimeArr[0]);
    MinHand = int.Parse(TimeArr[1]);
  }
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a time:");
    string input = Console.ReadLine();
    Clock inputClock = new Clock(input);
    Console.WriteLine(inputClock.HourHand);

  }

}