using System;
using System.Runtime.Serialization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan Time;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            int hours1 = 0;
            int minutes1 = 0;
            int seconds1 = 0;

            do
            {
                try
                {
                    Console.WriteLine("Введите часы: ");
                    hours1 = Convert.ToInt32(Console.ReadLine());
                    if (23 < hours1 || hours1 < 0)
                    {
                        throw new Exception("часы больше 24 или меньше 0");
                        hours1 = 0;
                    }            
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            
            }
            while (23 < hours1 || hours1 < 0);
            hours = hours1;          

            do
            {
                try
                {
                    Console.WriteLine("Введите минуты: ");
                    tt = Convert.ToInt32(Console.ReadLine());
                    if (59 < minutes1 || minutes1 < 0)
                    {
                        throw new Exception("минуты больше 60 или меньше 0");
                        minutes1 = 0;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }
            while (59 < minutes1 || minutes1 < 0);
            minutes = minutes1;

            do
            {
                try
                {
                    Console.WriteLine("Введите секунды: ");
                    seconds1 = Convert.ToInt32(Console.ReadLine());
                    if (59 < seconds1 || seconds1 < 0)
                    {
                        throw new Exception("секунды больше 60 или меньше 0");
                        seconds1 = 0;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }
            while (59 < seconds1 || seconds1 < 0);
            seconds = seconds1;

            Time = new TimeSpan(hours, minutes, seconds);
            Console.WriteLine("Введенное время: {0}, В секундах: {1}", Time, Time.TotalSeconds);
        }
    }
}

    
