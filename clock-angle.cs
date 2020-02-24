using System;
using System.Collections.Generic;

public class Clock
{
  public string InputTime;
  public string[] TimeArr;
  public double HourHand;
  public double MinHand;
  public double HourAngle;
  public double MinAngle;

  // Constructor ======================
  public Clock(string inputTime)
  {
    InputTime = inputTime;
    TimeArr = inputTime.Split(":");
    HourHand = Convert.ToDouble(TimeArr[0]);
    MinHand = Convert.ToDouble(TimeArr[1]);
    StartAngle();
  }

  public void StartAngle() // does not require return value
  // public int StartAngle() // requires return value
  {
    HourAngle = 0.5 * (60 * HourHand + MinHand);
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
    Console.WriteLine(inputClock.HourAngle);

  }

}