namespace Lab_1
{

    public class TaxisAgency
    {

        private List<Taxi> taxis;
        
        public int getCount { get { return taxis.Count; } }

        public TaxisAgency()
        {
         taxis = new List<Taxi>();
         
        }

        public TaxisAgency( List<Taxi> t)
        {
           this.taxis = t;
        }

        public void AddTaxi(float rate, float kilometers, int a, string n, int i)
        {
            var taxi = new Taxi(rate, kilometers, a, n, i)
            {
                rate = rate,
                kilometers = kilometers,
                name = n,
                Id = i
                
            };

            taxis.Add(taxi);
        }

    }
}
