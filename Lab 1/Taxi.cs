using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Taxi:Servicio
    {

        public float rate;
        public float kilometers;
        public string name;
        public int Id;
     

        public Taxi(float rate, float kilometers, int a, string n, int i) : base (a)
        {
            this.rate = rate;
            this.kilometers = kilometers;
            this.name = n;
            this.Id = i;
        }

        public override void print()
        {
            throw new NotImplementedException();
        }

        public void setRate ( int x) { rate = x; }
        public float getRate () { return rate; }
        public float getKilometers () { return kilometers; }
        public void setKilometers ( float x ) { kilometers = x; }
        public string getName() { return name; }
        public void setName ( string name ) { this.name = name; }
        
        public int getId() { return Id; }

        public override float Final_price()
        {
         float price = rate * kilometers;

            return price;
        }
    }
}
