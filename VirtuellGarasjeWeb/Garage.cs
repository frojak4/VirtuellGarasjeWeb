using System.Runtime.InteropServices.JavaScript;

namespace VirtuellGarasje_JS_C_
{
    public class Garage
    {
        private new List<IVehicle> _garage = new List<IVehicle>()
        {
            new Car("Ford", "Focus", 100, 1998),
            new Car("Porsche", "911", 100, 1),
            new Boat("Yamaha", "212X", 50, 2020),
            new Boat("Bayliner", "Element E18", 40, 2021),
            new Plane("Boeing", "737 MAX", 590, 2018),
            new Plane("Airbus", "A320neo", 580, 2020)
        };


        public List<IVehicle> GetVehicles()
        {
            return _garage;
        }

    }
}
