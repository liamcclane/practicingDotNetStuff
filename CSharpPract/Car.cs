using System;
using System.Collections.Generic;
using System.Text;

namespace SomethingImportant
{
    ///-----------------------------------------------------------------
    ///   Namespace:      SomethingImportant
    ///   Class:          Car
    ///   Description:    This was my first try at C# and .NET and I didn't know what to name the namespace
    ///   Author:         Lia McClane       Date: 07/09/2020 11:58AM
    ///   Notes:          Rough and simple outline of Car objects
    ///   Revision History:
    ///   Name:           Date:        Description:
    ///   Name:           Date:        Description:
    ///   Name:           Date:        Description:
    ///   Name:           Date:        Description:
    ///-----------------------------------------------------------------
    public class Car
    {
        public static int TotalNumberOfCars = 0;
        //key word static here means it is class specific
        public string LicensePlateNum;
        public string CarName;
        public string Owner;
        public string Make;
        public string Model;
        public int Year;

        public Car()
        {
            Owner = "Ownerless";
            LicensePlateNum = "unknown";
            Year = 0;
        }
        public Car(string owner, string license, int year)
        {
            Owner = owner;
            LicensePlateNum = license;
            Year = year;
            TotalNumberOfCars++;
        }
        public Car(string owner, string license, int year, string carName)
        {
            Owner = owner;
            LicensePlateNum = license;
            Year = year;
            CarName = carName;
            TotalNumberOfCars++;
        }
        public Car(string owner, string license, int year, string carName, string make, string model)
        {
            // Owner = owner;
            // LicensePlateNum = license;
            // Year = year;
            // Make = make;
            // Model = model;
            // CarName = carName;
            // TotalNumberOfCars++;
            Owner = owner == null ? "Ownerless" : owner;
            LicensePlateNum = license == null ? "Unknown" : license;
            Year = String.IsNullOrEmpty(year.ToString()) ? 0 : year;
            Make = make == null ? null : make;
            Model = model == null ? null : model;
            CarName = carName == null ? null : carName;
            TotalNumberOfCars++;
        }
        // below is weird and doesn't work if it is the only constructor
        /**
        public Car(string owner, string license, int year, string carName, string make, string model){
            Owner = owner == null ? "Ownerless" : owner;
            LicensePlateNum = license == null ? "License Unknown" : license;
            Year = String.IsNullOrEmpty(year.ToString()) ? 0 : year;
            Make = make == null ? null: make;
            Model = model == null ? null : model;
            CarName = carName == null? null: carName;
            TotalNumberOfCars++;
        }
        */

        public Car print()
        {
            if (CarName != null)
            {
                Console.WriteLine(CarName);
            }
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"LicensePlate: {LicensePlateNum}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            return this;
        }
        public int CompareYears(Car otherCar)
        {
            if (Year > otherCar.Year) { return 1; };
            if (Year < otherCar.Year) { return -1; };
            return 0;
        }
    }
}