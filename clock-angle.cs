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
    GetHourAngle();
    GetMinAngle();
  }

  public void GetHourAngle() // does not require return value
  // public double GetHourAngle() // requires return value
  {
    if (HourHand >= 12)
    {
      HourHand = HourHand - 12;
    }
    HourAngle = 0.5 * (60 * HourHand + MinHand);
  }

  public void GetMinAngle()
  {
    MinAngle = 6 * MinHand;
  }

  public bool BiggerHourAngle()
  {
    return (HourAngle >= MinAngle);
  }

  public double BiggerThan180(double result)
  {
    if (result >= 180)
    {
      return 360 - result;
    }
    else
    {
      return result;
    }
  }

  public double CalculateAngle()
  {
    double result;
    if (BiggerHourAngle())
    {
      result = HourAngle - MinAngle;
      return BiggerThan180(result);
    }
    else
    {
      result = MinAngle - HourAngle;
      return BiggerThan180(result);
    }
  }

}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a time:");
    string input = Console.ReadLine();
    Clock inputClock = new Clock(input);
    Console.WriteLine("The distance between the hour and minute hands on an analog clock is " + inputClock.CalculateAngle());
  }

}