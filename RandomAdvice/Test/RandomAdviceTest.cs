using RestSharp;
using RandomAdvice.Models;
using NUnit.Framework;
using System.Net;

namespace RandomAdvice.Tests
{
    [Binding]
    public class RandomAdviceTest
    {
        private RestClient client = new RestClient(" https://api.adviceslip.com/");
        private IRestResponse<Slip> response;

        [When(@"send a request to read random advice")]
        public void WhenSendARequestToReadRandomAdvice()
        {
            RestRequest request = new RestRequest("/advice", Method.GET);
            response = client.Execute<Slip>(request);
        }

        [Then(@"response status code should be OK")]
        public void ThenResponseStatusCodeShouldBeOK()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
