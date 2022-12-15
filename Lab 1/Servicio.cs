using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    abstract public class Servicio
    {
     
     protected float entry;
                
        public Servicio ( float a)
        {
            entry = a; 
        } 

        public float getEntry (  ) { return entry; } 
        public void setEntry ( float a ) { entry = a; }
        public abstract  void print ();
        public abstract float Final_price();
                      
        
    }
}
