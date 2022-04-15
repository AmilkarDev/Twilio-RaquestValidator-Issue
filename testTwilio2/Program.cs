using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Security;
namespace testTwilio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string accountSid = "*******";
            string authToken = "******";

            TwilioClient.Init(accountSid, authToken);
            var requestValidator = new RequestValidator(authToken);
             var ss = requestValidator.GetHashCode();
            var message = MessageResource.Create(
                body: "NON",
                from: new Twilio.Types.PhoneNumber("+1*******"),
                to: new Twilio.Types.PhoneNumber("+1******")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
