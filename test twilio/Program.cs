using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace test_twilio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account SID and Auth Token at twilio.com/console
            // and set the environment variables. See http://twil.io/secure
            string accountSid = "*****";
            string authToken = "******";

            TwilioClient.Init(accountSid, authToken);
            var requestValidator = new Twilio.Security.RequestValidator(authToken);
            var ss  = requestValidator.GetHashCode();
            var message = MessageResource.Create(
                body: "NON",
                from: new Twilio.Types.PhoneNumber("+1**********"),
                to: new Twilio.Types.PhoneNumber("+1**********")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
