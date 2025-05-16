
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OceanBluePayPal.Controllers
{
    public class PaymentController : Controller
    {
        private static async Task<string> GetAccessToken()
        {
            var clientId = "TU_CLIENT_ID";
            var secret = "TU_SECRET";
            var client = new HttpClient();
            var byteArray = System.Text.Encoding.UTF8.GetBytes($"{clientId}:{secret}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", System.Convert.ToBase64String(byteArray));

            var dict = new Dictionary<string, string> { ["grant_type"] = "client_credentials" };
            var req = new FormUrlEncodedContent(dict);
            var res = await client.PostAsync("https://api-m.sandbox.paypal.com/v1/oauth2/token", req);
            var body = await res.Content.ReadAsStringAsync();
            var json = JsonDocument.Parse(body);
            return json.RootElement.GetProperty("access_token").GetString();
        }

        [HttpPost]
        public async Task<JsonResult> Capture(string orderId)
        {
            var token = await GetAccessToken();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.PostAsync($"https://api-m.sandbox.paypal.com/v2/checkout/orders/{orderId}/capture", null);
            var body = await response.Content.ReadAsStringAsync();
            return Json(body);
        }
    }
}
