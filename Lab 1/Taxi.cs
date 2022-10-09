using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Taxi:Servicio
    {

        private float rate;
        private float kilometers;

        public Taxi(float rate, float kilometers, int a) : base (a)
        {
            this.rate = rate;
            this.kilometers = kilometers;
        }

        public override void print()
        {
            throw new NotImplementedException();
        }

        public void setRate ( int x) { rate = x; }
        public float getRate () { return rate; }
        public float getKilometers () { return kilometers; }
        public void setKilometers ( float x ) { kilometers = x; }

        public override float Final_price()
        {
         float price = rate * kilometers;

            return price;
        }
    }
}
