﻿namespace VirtuellGarasje_JS_C_
{
    public class Car : IVehicle
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Year { get; set; }


        public Car(string brand, string name, int speed, int year)
        {
            Brand = brand;
            Name = name;
            Speed = speed;
            Year = year;
        }
    }
}