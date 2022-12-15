using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_1
{
    public class Renta_de_autos:Servicio
    {

        private int days;
        private float rate;
        private string tuition;
        public Renta_de_autos (int x, float y, int a, string z ) : base(a)
        {
            days = x;
            rate = y;
            tuition = z;
        }

        public override void print()
        {
            throw new NotImplementedException();
        }

        public void setDays ( int x) { this.days = x;}
        public int getDays() { return this.days; }
        public float getRate() { return this.rate; }
        public void setRate ( float rate ) { this.rate = rate;}
        public string gettuition() { return this.tuition; }
        public void settuition (string z) { this.tuition = z;}


        public override float Final_price()
        {
            float price = rate * (float)days;

            return price;
        }
    }
}
