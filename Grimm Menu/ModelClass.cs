using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grimm_Menu
{
    class ModelClass
    {
        private string date;
        private string make;
        private string model;
        private string milage;
        private string service;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
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
        public string Milage
        {
            get { return milage; }
            set { milage = value; }
        }
        public string Service
        {
            get { return service; }
            set { service = value; }
        }


        public ModelClass()
        {
            Date = "";
            Make = "";
            Model = "";
            Milage = "";
            Service = "";
        }
        public ModelClass(string date, string make, string model, string milage, string service)
        {
            Date = date;
            Make = make;
            Model = model;
            Milage = milage;
            Service = service;
        }

        public string formatedService()  
        {
            return ("\n\nOn " + date + ".\nThe " + Make + " " + Model + " was serviced.\nThe service was completed at " + Milage + " Miles.\nThe service completed was\n" + service);
        }

        public override string ToString()
        {
            return String.Format("Make = {0}, Model = {1}, Milage = {2}, Service = {3}", Make, Model, Milage, Service);
        }
    }
}
