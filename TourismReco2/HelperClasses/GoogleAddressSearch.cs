using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace TourismReco2.HelperClasses
{
    public static class GoogleAddressSearch
    {
        private const string ApiKey = "AIzaSyCLFaQCbq_K4T_YWKD7Dv_JNGPSOpLK1bY";

        public static async Task<AddressSearchEntry> SearchAsync(string address)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var requestUri = new Uri(string.Format("https://maps.googleapis.com/maps/api/geocode/json?&address={0}&sensor=false&key={1}&region=nz", Uri.EscapeDataString(address), ApiKey));

                    HttpResponseMessage response = await httpClient.GetAsync(requestUri);

                    string responseJsonString = await response.Content.ReadAsStringAsync();

                    var resp = JsonConvert.DeserializeObject<GoogleGeoCodeResponse>(responseJsonString);

                    if (resp.status == "ZERO_RESULTS")
                    {
                        return null;
                    }

                    if (resp.status != "OK")
                    {
                        throw new Exception("API Error " + resp.status);
                    }

                    return Convert(resp.results.FirstOrDefault());

                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private static AddressSearchEntry Convert(results item)
        {
            return new AddressSearchEntry()
            {
                Address = item.formatted_address,
                Latitude = item.geometry.location.lat,
                Longitude = item.geometry.location.lng,
            };
        }

        private class GoogleGeoCodeResponse
        {

            public string status { get; set; }
            public results[] results { get; set; }

        }

        private class results
        {
            public string formatted_address { get; set; }
            public geometry geometry { get; set; }
            public string[] types { get; set; }
            public address_component[] address_components { get; set; }
        }

        private class geometry
        {
            public string location_type { get; set; }
            public location location { get; set; }
        }

        private class location
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        private class address_component
        {
            public string long_name { get; set; }
            public string short_name { get; set; }
            public string[] types { get; set; }
        }
    }

    public class AddressSearchEntry
    {
        public string Address { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }

}