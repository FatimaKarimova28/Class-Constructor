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




            var house = new Building();
            house.name = "Akvarium";
            house.height = 100; 
            house.area= 100;


            Console.WriteLine(house.GetVolume());


            var pinkHouse = new Building();
            pinkHouse.name = "My dream";
            pinkHouse.height = 55;
            pinkHouse.area = 100;
            Console.WriteLine(pinkHouse.GetVolume());   

        }
    }
}