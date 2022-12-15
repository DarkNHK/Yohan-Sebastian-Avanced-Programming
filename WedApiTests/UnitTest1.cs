using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_1;
using System.IO;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Net.Http.Formatting;


namespace WebAPITests
{
    [TestClass]
    public class TaxisAgencyTests
    {
        [TestMethod]
        public async Task Can_GetTaxis_Test()
        {
            // arrange
            HttpClient client = new HttpClient();
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://localhost:7224/");
            // Sets the Accept header to "application/json".Setting this header tells the server to send data in JSON format.
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            // act
            IEnumerable<Taxi> taxis = null;
            HttpResponseMessage response = await client.GetAsync(@"TaxisAgency/GetTaxis");
            if (response.IsSuccessStatusCode)
            {
                taxis = await response.Content.ReadAsAsync<IEnumerable<Taxi>>();
            }

            // assert
            Assert.IsNotNull(taxis);
        }
    }
}