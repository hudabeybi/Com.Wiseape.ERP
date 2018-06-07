using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Wiseape.Utility.ThirdParty.Google
{
    public class GoogleCaptchaVerfication
    {
        public static string GoogleCaptchaVerificationUrl = "https://www.google.com/recaptcha/api/siteverify";
        public static Com.Wiseape.Utility.ThirdParty.Google.CaptchaResponse Verify(string googleCaptchaSecret, string responseToken)
        {
            Com.Wiseape.Utility.ListUtility.Parameters parameters = new ListUtility.Parameters();
            parameters = parameters.Add("secret", googleCaptchaSecret).Add("response", responseToken);
            string json = Com.Wiseape.Utility.HttpUtility.WebClient.Post(GoogleCaptchaVerificationUrl, parameters);
            Com.Wiseape.Utility.ThirdParty.Google.CaptchaResponse response = Com.Wiseape.Utility.Serializer.Json.Deserialize<Com.Wiseape.Utility.ThirdParty.Google.CaptchaResponse>(json);
            return response;
        }
    }
}
