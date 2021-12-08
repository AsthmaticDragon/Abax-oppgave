using System;

namespace Abax
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Initialise objects
            var bil1 = new Car("NF123456", 147, "Bil", 200, "Grønn", "Lett kjøretøy");
            var bil2 = new Car("NF654321", 150, "bil", 195, "blå", "lett kjøretøy");
            var fly = new Plane("LN1234", 1000, "fly", 30, 2, 10, "Jetfly");
            var boat = new Boat("ABC123", 100, "båt",500, 30);
            

            
            bil1.Show();
            bil2.Show();
            fly.Show();
            boat.Show();
            Console.WriteLine("");
            bil1.CompareCars(bil2);
            fly.Go();
            bil1.Go();
        }




        
    }
}
