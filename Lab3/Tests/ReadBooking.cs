using Lab_3.Models;
using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace Lab3.Tests
{
    [Binding]
    public class ReadBooking
    {
        private RestClient client = new RestClient("https://restful-booker.herokuapp.com/");
        private IRestResponse response;

        [When(@"send read  request")]
        public void WhenSendReadRequest()
        {
            RestRequest request = new RestRequest("booking", Method.GET);
            response = client.Execute<BookingModel>(request);
        }

        [Then(@"expected OK response")]
        public void ThenExpectedOKResponse()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
