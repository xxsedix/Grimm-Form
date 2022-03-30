using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grimm_Menu
{
    class ModelClass
    {
        public class maintenance
        {
            private string make;
            private string model;
            private int milage;
            private string service;


            public string Make
            {
                get { return make; }
                set { make = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }
            public int Milage
            {
                get { return milage; }
                set { milage = value; }
            }
            public string Service
            {
                get { return service; }
                set { service = value; }
            }


            public maintenance()
            {
                Make = "";
                Model = "";
                Milage = 0;
                Service = "";
            }
            public maintenance(string make, string model, int milage, string service)
            {
                Make = make;
                Model = model;
                Milage = 0;
                Service = service;
            }

            public override string ToString()
            {
                return String.Format("Make = {0}, Model = {1}, Milage = {2}, Service = {3}", Make, Model, Milage, Service);
            }
        }
    }
}
