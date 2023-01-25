using Class__Constructor;
using System.Dynamic;

namespace ClassConstruction
{
    public class Pet
    {
        static void Main()
        {
            //var dog = new Animal();
            //dog.name = "Amiqo";
            //dog.breed = "Maltese";
            //dog.color = "white";
            //dog.age = 1;

            //Console.WriteLine(dog.GetInfo());


            //var cat = new Animal();
            //cat.name = "Murka";
            //cat.breed = "unknown";
            //cat.color = "white";
            //cat.age = 1;

            //Console.WriteLine(cat.GetInfo());




            var house = new Building("Akvarium", 100, 100);
            


            Console.WriteLine(house.GetVolume());


            var pinkHouse = new Building("My dream", 55, 100);
            
            Console.WriteLine(pinkHouse.GetVolume());   

        }
    }
}