using Lab_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository
{
    public partial class DBRepository : ITaxiRepository
    {
        public Taxi CreateTaxi(float rate, float kilometers, int entry, string name, int id)
        {
            var taxi = new Taxi(rate , kilometers, entry, name, id);
            Add(taxi);
            return taxi;
        }

        public void UpdateTaxi(Taxi taxi)
        {
            Update(taxi);
        }

        public void DeleteTaxi(Taxi taxi)
        {
            Delete(taxi);
        }

        public Taxi FindTaxi(string name)
        {
            return Get<Taxi>(w => w.name == name).First();
        }

        public Taxi GetTaxi(int id)
        {
            return GetByID<Taxi>(id);
        }

        public List<Taxi> GetTaxis()
        {
            return Get<Taxi>();
        }

    }
}
