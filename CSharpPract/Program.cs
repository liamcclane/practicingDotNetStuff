using System;
using System.Collections.Generic;
using SomethingImportant;
using BankyLib; // BankyLib has Humanizer imported 
using Humanizer;


namespace CSharpPract
{
    ///-----------------------------------------------------------------
    ///   Namespace:      CSharpPract
    ///   Class:          Program
    ///   Description:    This was my first try at C# and .NET
    ///   Author:         Lia McClane       Date: 07/09/2020 11:58AM
    ///   Notes:          Really messy, but was able to implement and make library
    ///                   Important links:
    ///                   YouTube tutorials ->  https://dotnet.microsoft.com/learn/videos
    ///                   Creating projects ->  https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code
    ///                   Connecting libraries to projects ->  https://docs.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code
    ///   Revision History:
    ///   Name: Lia       Date: 7/13/2020   Description: added package Humanizer to project
    ///   Name:        Date:    Description: 
    ///-----------------------------------------------------------------
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("car".Pluralize());
            Console.WriteLine("pant".Pluralize());
            Console.WriteLine("octopus".Pluralize());
            Console.WriteLine(1350.ToWords());
            Console.WriteLine("Hello World! We are running your program.\n*****************");

            BankAccount liaAccount = new BankAccount("Lia", 100);
            Console.WriteLine($"A new bank account for {liaAccount.Owner} was completed\n Balance : ${liaAccount.Balance}");
            // liaAccount.PrintInfo();
            liaAccount.MakeDeposit(200, "Money");
            liaAccount.MakeDeposit(200, "Mo Money");

            // creating a bank account with a negative withdrawl
            // try {
            //     BankAccount bAccount = new BankAccount("Brendan's Account", -200);
            // } catch (ArgumentOutOfRangeException e) {
            //     Console.WriteLine("CANNOT START WITH NEGATIVE ACCOUNT BALANCE");
            //     Console.WriteLine(e.ToString());
            // }


            // testing making a negative deposit
            // try {
            //     liaAccount.MakeDeposit(-1000, "cant work");
            // } catch (ArgumentOutOfRangeException e) {
            //     Console.WriteLine("CANNOT ADD negative money in a desposit");
            //     Console.WriteLine(e.ToString());
            // }


            liaAccount.MakeWithdrawl(50, "Video Game");
            liaAccount.MakeWithdrawl(150, "Groceries");

            liaAccount.PrintAllTransactions();

            practicingClasses();
            // PrintToNum(3);
            // FibFunction();
            // MicrosoftInputCopy();

            void practicingClasses()
            {
                // creating objects
                Car emptyCar = new Car();
                Car liaCar1 = new Car("Lia", "1234F5", 2002);
                Car liaCar2 = new Car("Lia", "678N9", 2012);


                // creating an array for all of Brendan's Cars
                string b = "Brendan";
                List<string> bLic = new List<string> { "1A", "2B", "3C" };
                List<int> bYear = new List<int> { 1990, 2000, 2016 };
                List<Car> brendansCars = new List<Car>();
                for (int i = 0; i < bYear.Count; i++)
                {
                    brendansCars.Add(new Car(b, bLic[i], bYear[i]));
                }

                brendansCars.Add(emptyCar);
                Car brendanNewestCar = findNewestCar(brendansCars);
                NameThisCar(brendanNewestCar, "     Bernadette    ");
                PrintAllCars(brendansCars);
                brendansCars.Sort((x, y) => x.CompareYears(y));
                Console.WriteLine("After the sort");
                PrintAllCars(brendansCars);

                SameYear(brendanNewestCar, liaCar1);
                Console.WriteLine("Total number of cars we have made are");
                Console.WriteLine(Car.TotalNumberOfCars);

                // all the methods called below
                void SameYear(Car car1, Car car2)
                {
                    string x;
                    var cName1 = car1.CarName == null ? car1.Owner + " " + car1.LicensePlateNum : car1.CarName;
                    var cName2 = car2.CarName == null ? car2.Owner + " " + car2.LicensePlateNum : car2.CarName;
                    if (car1.Year == car2.Year) x = "do";
                    else x = "do NOT";
                    Console.WriteLine($"{cName1} and {cName2} {x} have the same year");
                }
                void NameThisCar(Car car, string name)
                {
                    car.CarName = name.Trim();
                }
                void PrintAllCars(List<Car> arr)
                {
                    Console.WriteLine("We are Printing all cars in the array");
                    Console.WriteLine("Owner\t\tPlates\tYear\tMake\tModel");
                    foreach (Car c in arr)
                    {
                        if (c.CarName != null)
                        {
                            Console.WriteLine($"***{c.CarName}");
                        }
                        Console.WriteLine($"{c.Owner}\t\t{c.LicensePlateNum}\t{c.Year}\t{c.Make}\t{c.Model}");
                        Console.WriteLine();
                    }
                }
                Car findNewestCar(List<Car> arr)
                {
                    if (arr.Count == 0) { return null; }
                    Car found = arr[0];
                    int earliestYear = arr[0].Year;
                    foreach (Car c in arr)
                    {
                        if (c.Year > earliestYear)
                        {
                            earliestYear = c.Year;
                            found = c;
                        }
                    }
                    // Console.WriteLine("Found the newest Car\n*********");
                    // found.print();
                    // Console.WriteLine("*********");
                    return found;
                }
            }
            /// <summary>
            /// this function take a number as a parameter and then prints all the numbers
            /// 1 - num
            /// <pram
            /// </summary>
            // void PrintToNum(int num)
            // {
            //     for (int i = 1; i <= num; i++)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            /// <summary>
            /// this function created a list with the first 8 numbers of the fibonacci sequence 
            /// </summary>
            // void FibFunction()
            // {
            //     var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            //     int count = 0;
            //     foreach (int element in fibNumbers)
            //     {
            //         count++;
            //         Console.WriteLine($"Element #{count}: {element}");
            //     }
            //     Console.WriteLine($"Number of elements: {count}");
            // }
            /// <summary>
            /// copied this code off of the microsoft official docs, it waits for an input
            /// </summary>
            // void MicrosoftInputCopy()
            // {
            //     Console.WriteLine("Hello Please type your name: \n");
            //     var nameInput = Console.ReadLine();
            //     var date = DateTime.Now;
            //     Console.WriteLine($"\nHello, {nameInput}, on {date:d} at {date:t}!");
            //     Console.Write("\nPress any key to exit...");
            //     Console.ReadKey(true);
            // }
        }
    }
}
