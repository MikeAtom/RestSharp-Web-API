using Lab_3.Models;
using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace Lab3.Tests
{
    [Binding]
    public class CreateBooking
    {
        BookingModel bookingModel = new BookingModel();
        private RestClient client = new RestClient("https://restful-booker.herokuapp.com/");
        private IRestResponse response;

        [Given(@"firstname ""([^""]*)""")]
        public void GivenFirstname(string firstname)
        {
            bookingModel.firstname = firstname;
        }

        [Given(@"set lastname ""([^""]*)""")]
        public void GivenSetLastname(string lastname)
        {
            bookingModel.lastname = lastname;
        }

        [Given(@"set a total price at ""([^""]*)""")]
        public void GivenSetATotalPriceAt(int totalprice)
        {
            bookingModel.totalprice = totalprice;
        }

        [Given(@"set depositpaid as ""([^""]*)""")]
        public void GivenSetDepositpaidAs(bool depositispaid)
        {
            bookingModel.depositpaid = depositispaid;
        }

        [Given(@"set the booking dates  checkin in ""([^""]*)"" and checkout in ""([^""]*)""")]
        public void GivenSetTheBookingDatesCheckinInAndCheckoutIn(string checkin, string checkout)
        {
            bookingModel.bookingdates.checkin = checkin;
            bookingModel.bookingdates.checkout = checkout;
        }

        [Given(@"set ""([^""]*)"" as additional needs")]
        public void GivenSetAsAdditionalNeeds(string additionalneeds)
        {
            bookingModel.additionalneeds = additionalneeds;
        }

        [When(@"send create booking request")]
        public void WhenSendCreateBookingRequest()
        {
            RestRequest request = new RestRequest("booking", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(bookingModel);
            request.AddHeaders(new Dictionary<string, string>
            {
                { "Accept", "application/json" },
                { "Content-Type", "application/json" }
            });
            response = client.Execute<BookingModel>(request);
        }

        [Then(@"confirm that booking is created")]
        public void ThenConfirmThatBookingIsCreated()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
