using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Diagnostics; // Import the System.Diagnostics namespace
using System.Net.Http;
using UserCard.Models;

namespace UserCard.Controllers
{
    public class PaymentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromBody] PaymentData paymentData)
        {
            if (paymentData != null)
            {
                string cardholderName = paymentData.Name;
                string cardNumber = paymentData.CardNumber;
                string expiry = paymentData.ExpirationDate;
                string cvv = paymentData.CVV;
                string billingAddress = paymentData.BillingAddress;
                string cardType = paymentData.CardType;
                string amount = paymentData.Amount;


                // Log or process the data as needed
                System.Console.WriteLine($"Name: {cardholderName}, Card Number: {cardNumber}, Expiration Date: {expiry},CVV/CVC:{cvv},Billing Address:{billingAddress}, Card Type:{cardType}, Amount: {amount}");

                // Create an anonymous object with the data
                var responseData = new
                {
                    Name = cardholderName,
                    CardNumber = cardNumber,
                    ExpirationDate = expiry,
                    CVV = cvv,
                    BillingAddress = billingAddress,
                    CardType = cardType,
                    Amount = amount


                };

                // Return the data as JSON
                return Json(responseData);
            }

            return BadRequest(new { Message = "Invalid data received." });
        }

    }
}
