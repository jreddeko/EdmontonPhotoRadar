using PhotoRadarMap.Models.EnforcementZones.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace PhotoRadarMap.Models.EnforcementZones.Factories
{
    public class EnforcementZonesSerializer
    {

        public EnforcementZonesSerializer()
        {
        }

        public ICollection<EnforcementZoneModel> PrepareEnforcementZoneModel(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(String.Empty).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var downloadString = response.Content.ReadAsStringAsync().Result;
                var serializer = new DataContractJsonSerializer(typeof(RootObject));
                var ms = new MemoryStream(Encoding.Unicode.GetBytes(downloadString));
                var dataObject = serializer.ReadObject(ms) as RootObject;
                var enforcementZones = new List<EnforcementZoneModel>();
                foreach (var e in dataObject.data)
                {
                    var enforcementZone = new EnforcementZoneModel();
                    foreach (var item in dataObject.meta.view.columns)
                    {
                        PropertyInfo prop = enforcementZone.GetType().GetProperty(item.fieldName.Replace(":", ""));
                        if (prop !=null)
                            prop.SetValue(enforcementZone, e[dataObject.meta.view.columns.IndexOf(item)]);
                    }
                    enforcementZones.Add(enforcementZone);
                }
                return enforcementZones;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            return null;
        }
    }
}