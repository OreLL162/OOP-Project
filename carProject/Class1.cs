using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace carProject
{
    [Serializable]

    class Class1
    {
        [Serializable]
        public class Vehicle
        {
            public string _color { get; set; }
            public string _gear { get; set; }
            public string _licensPlate { get; set; }
            public int _year { get; set; }
        }
        [Serializable]
        public class Car : Vehicle
        {
            public int _doors { get; set; }
        }
        [Serializable]
        public class Motorcycl : Vehicle
        {

            public string _handlebar { get; set; }
            public string _windshield { get; set; }

            public override string ToString()
            {
                string output = string.Empty;
                string carType = "Motorcycl Details: Licens Plate Number; ";
                string carType2 = "Handlebar: ";
                output += carType;
                output += String.Format("{0},  {1},", _licensPlate, _year);
                output += String.Format("{0},  {1},  {2},  {3},  {4}   ", _color, _windshield, _gear, carType2, _handlebar);
                return output;
            }
        }
        [Serializable]
        public class Suv : Car
        {
            public double _height { get; set; }
            public static Suv[] _suvarray = new Suv[0];
            public override string ToString()
            {
                string output = string.Empty;
                string carType = "Suv Details: Licens Plate Number; ";
                string carType2 = "Height: ";
                output += carType;
                output += String.Format("{0},  {1},", _licensPlate, _year);
                output += String.Format("{0},  {1},  {2},  {3},  {4}   ", _color, _doors, _gear, carType2, _height);
                return output;
            }
        }
        [Serializable]
        public class Sedan : Car
        {
            public string _sunroof { get; set; }
            public override string ToString()
            {
                string output = string.Empty;
                string carType = "Suv Details: Licens Plate Number; ";
                string carType2 = "Sunroof: ";
                output += carType;
                output += String.Format("{0},  {1},", _licensPlate, _year);
                output += String.Format("{0},  {1},  {2},  {3},  {4}   ", _color, _doors, _gear, carType2, _sunroof);
                return output;
            }
        }
     
    
    }
}
