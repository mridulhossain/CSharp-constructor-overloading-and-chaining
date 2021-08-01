using System;

namespace DataTypeIO
{
    public class Car
    {
        public int Fuel;
        public string Key;
        public string Driver;

        //-------constructor chaining--------
        public Car() : this(1, "tanjib")
        {

        }

        //-------end--------

        // when constructor calling a constructor that is constructor chaining
        // and in a class constructor is More than one it's called constructor over loading

        public Car(int fuel, string key)
        {
            this.Fuel = fuel;
            this.Key = key;
            Console.WriteLine(this.Fuel + "," + this.Key);
        }


        public Car(int fuel, string key, string driver)
        {
            this.Fuel = fuel;
            this.Key = key;
            this.Driver = driver;
            Console.WriteLine(this.Fuel + "," + this.Key+","+this.Driver);
        }

    }
}
