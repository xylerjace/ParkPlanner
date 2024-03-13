using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPlanner.res
{
    internal class VehicleBrands
    {
   
        public List<string> getMotorcyleBrands() {
            List<string> list = new List<string> { "Rusi", "Yamaha", "Honda", "Kawasaki", "Ducati" };
            return list;
        }
        public List<String> getSuvBrands()
        {
            List<string> list = new List<string> { "Toyota", "Ford", "Chevrolet", "Honda", "Suzuki" };
            return list;
        }
        public List<String> getSedanBrands()
        {
            List<string> list = new List<string> { "Audi", "Toyota", "BMW", "Mercedes", "Rolls Royce" };
            return list;
        }
    }
}
