using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class__Constructor
{
    public class Building
    {

        public string name;
        public byte height;
        public byte area;
        public string address;

        public Building(string name, byte height, byte area)
        {
            this.name = name;   
            this.height = height;   
                this.area = area;
        }


        public string GetVolume()
        {
            return $"Result equal = {height * area}";


        }
    }
}

