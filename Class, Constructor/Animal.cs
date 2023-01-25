using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class__Constructor
{
    public class Animal
    {
        public string name;
        public string breed;
        public string color;
        public byte age;


        public string GetInfo()
        {
            return $"Your animal has some quality: {name} {breed} {age}";
        }
    }

}
