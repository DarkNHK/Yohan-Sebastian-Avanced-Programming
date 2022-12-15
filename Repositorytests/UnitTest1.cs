using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_1;
using Repository;

namespace Repositoritests
{
    [TestClass]
    public class UnitTest1
    {
        ITaxiRepository _repository;

        [TestMethod]
        public void Can_CreateTaxi_Test()
        {

            int entry = 0;
            float rate = 56;
            float kilometers = 45;
            string name = "Roberto";
            int Id = 1;


            _repository.BeginTransaction();
            var taxi = _repository.CreateTaxi(rate, kilometers, entry, name, Id);
            _repository.CommitTransaction();

            Assert.IsNotNull(taxi);
            Assert.AreNotEqual(0, taxi.Id);
            Assert.AreEqual(name, taxi.name);
            Assert.AreEqual(kilometers, taxi.kilometers);
                                   
        }

        [TestMethod]

        public void Can_DeleteTaxi_Test()
        {
            _repository.BeginTransaction();
            var taxi = _repository.FindTaxi("Roberto");
            _repository.CommitTransaction();

            _repository.BeginTransaction();
            _repository.DeleteTaxi(taxi);
            _repository.PartialCommit();

            var deletedTaxi = _repository.GetTaxi(taxi.Id);
            _repository.CommitTransaction();
            Assert.IsNull(deletedTaxi);
        }

    }
}