using System.Collections.Generic;

namespace DataTypeIO
{
    class Program
    {
        static void Main(string[] args)
        {
            var toyotaNoha = new Car(); // constructor chaining
            var toyotaPremio = new Car(10,"mridul");
            var toyotaPremioWithDriver = new Car(10, "mridul","driver");
        } 
    }
}
