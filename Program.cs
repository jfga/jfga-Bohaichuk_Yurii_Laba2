using System;
using System.Collections.Generic;
using System.Threading;

namespace Lab_2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int task = Convert.ToInt32(Console.ReadLine());
                if (task == 1)
                {
                    Car car = new Car();

                    car.GetInfo();
                    //do
                    //{
                    Console.WriteLine("Enter <start> 4 start ");
                    string str = Console.ReadLine();
                    if (str == "start")
                    {
                        car.Start();
                    }
                    //}
                    //while (true);
                }
                else
                {
                    List<Bus> buses = new List<Bus>()
                {
                 new Bus() { places = 30, fuel_consumption = 17, number = 1345 },
                 new Bus() { places = 35, fuel_consumption = 20, number = 1450 },
                 new Bus() {places = 40, fuel_consumption = 25, number = 1090},
                 new Bus() {places = 45, fuel_consumption = 27, number = 1080},
                 new Bus() {places = 20, fuel_consumption = 15, number = 1234 },
                 new Bus() {places = 43, fuel_consumption = 26, number = 1583},
                };
                    int i = 0;
                    foreach (Bus bus in buses)
                    {
                        i++;
                    }
                    Console.WriteLine(" numberr of bases:" + i);
                    Console.WriteLine(new string('-', 25));
                    Console.WriteLine("sort by places:");

                    buses.Sort(CompareBuses);
                    foreach (Bus bus in buses)
                    {
                        bus.GetInfo();
                    }
                    static int CompareBuses(Bus bus1, Bus bus2)
                    {
                        return bus1.places.CompareTo(bus2.places);
                    }


                    Console.WriteLine(new string('-', 25));
                    Console.WriteLine("serch by number:");

                    int num = Convert.ToInt32(Console.ReadLine());

                    
                        foreach (Bus bus in buses)
                        {
                            if (bus.number == num)
                            {
                                Console.WriteLine("The bus is found");
                                bus.GetInfo();
                                num = 0;
                            }
                        }
                        if (num != 0)
                        {
                            Console.WriteLine("bus wasn't found!");

                        }
                   


                    Console.WriteLine(new string('-', 25));
                    Console.WriteLine("serch by fuel consumption");

                    int fuel = Convert.ToInt32(Console.ReadLine());

                    foreach (Bus bus in buses)
                    {
                        if (bus.fuel_consumption == fuel)
                        {
                            Console.WriteLine("bus is found ");
                            bus.GetInfo();
                            fuel = 0;
                        }
                    }
                    if (fuel != 0)
                    {
                        Console.WriteLine(" Bus wan't found");
                    }
                }
            }
            catch
            {
                Console.WriteLine("unsapported format");
            }
        }
    }
    class Car
    {
        private string name = "     BMW"; 
        public void GetInfo()
        {
            Console.WriteLine(name);
        }
        
        int fuel = 0;
        public void Start()
        {
                int i = 0;
                Engine engine = new Engine();
                Wheel wheels = new Wheel();
                Console.WriteLine("Need refueling!");
                engine.Refuel();
                Console.WriteLine();

                Console.WriteLine("Start of engine");
                engine.StartOfEngine();
            do
            {
                i++;
                wheels.Change();
                engine.Refuel();

            }
            while (i != 4);
            Console.WriteLine("The car has overheated");
            


        }
        class Wheel
        {
            

            public void Change()
            {
                int i = 0;
                Console.WriteLine("Power reserve");                       // resours of wheels
                do
                {
                    i++;
                    Console.WriteLine("the resers of weels" + i);
                    Thread.Sleep(10);
                    Console.Clear();
                    
                   
                }
                while (i < 100);
                
                
                    Console.WriteLine("the wheels are should be changed");
                    Console.WriteLine("type change to change wheels");
                    
                    string ch = Console.ReadLine();
                
                
                if (ch == "change")
                {
                    i = 0;
                }
                else
                { 
                    Console.WriteLine("You should change wheels!");
                    string cha = Console.ReadLine();
                    if(cha == "change")
                    {
                        i = 0;
                        Console.WriteLine("wheels are changed");
                        
                        
                    }
                    else
                    {
                        Console.WriteLine("start of engine");
                        Thread.Sleep(200);
                        Console.WriteLine("wheels destroyed");
                        Thread.Sleep(200);
                        Console.WriteLine("car crashed");
                        
                    }
                   
                    
                }
              
               
            }
        }

        class Engine
        {
            int fuel = 0;
            
            public void Refuel()
            {
                do
                {

                    fuel  += 10;
                    Console.WriteLine($"the level of fuel {fuel}% / 100%");
                    Console.ReadKey();
                    Console.Clear();
                    
                }
                while (fuel != 100);
                fuel = 0;

            }

            public void StartOfEngine()
            {  
                    Console.WriteLine("Engine started to work");
                    Console.WriteLine($" fuel = {fuel}");      

            }
        }
    }



    class Bus
    {
        public int places { get; set; }
        public int fuel_consumption { get; set; }
        public int number { get; set; }
        public void GetInfo()
        {
            Console.WriteLine("places: " + places + " fuel_consumption: " + fuel_consumption + " Num:"+ number);
        }
    }
   


         
}
