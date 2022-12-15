using Lab_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ITaxiRepository : IRepository
    {
        Taxi CreateTaxi(float rate, float kilometers, int entry, string name, int id);

        void UpdateTaxi(Taxi Taxi);

        void DeleteTaxi(Taxi Taxi);

        Taxi FindTaxi(string name);

        Taxi GetTaxi(int id);

        List<Taxi> GetTaxis();
    }

}
