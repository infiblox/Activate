using AirlinesData.Entities;
using AirlinesData.MockResponses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AirlinesData.Helpers
{
    public static class AmericanAirlinesLoadJson
    {
        //private static readonly string MockResponseJsonPath = @"C:\Users\vikne\source\repos\AirlinesAPI\AirlinesData\bin\Debug\net9.0\MockResponses\AmericanAirlines\";

        public static List<SearchFlightsModel> LoadAmericanAirlinesSearchFlightJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\AmericanAirlines\AmericanAirlines.json"))
                {
                    string json = r.ReadToEnd();
                    List<SearchFlightsModel>? items = JsonConvert.DeserializeObject<List<SearchFlightsModel>>(json);
                    if (items == null)
                    {
                        throw new InvalidOperationException("Deserialization resulted in a null value.");
                    }
                    return items;
                }
            }
            else
            {
                               string json = JsonValues.AmericanAirlines; // Assuming you have a static JSON string in JsonValues
                List<SearchFlightsModel>? items = JsonConvert.DeserializeObject<List<SearchFlightsModel>>(json);
                if (items == null)
                {
                    throw new InvalidOperationException("Deserialization resulted in a null value.");
                }
                return items;
            }
        }

        public static List<FlightCostModel> LoadAmericanAirlinesFlightCostJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic) {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\AmericanAirlines\AmericanAirlinesbookFlight.json"))
                {
                    string json = r.ReadToEnd();
                    List<FlightCostModel>? items = JsonConvert.DeserializeObject<List<FlightCostModel>>(json);
                    if (items == null)
                    {
                        throw new InvalidOperationException("Deserialization resulted in a null value.");
                    }
                    return items;
                }
            }
            else
            {
                string json = JsonValues.AmericanAirlinesBookFlight; // Assuming you have a static JSON string in JsonValues
                List<FlightCostModel>? items = JsonConvert.DeserializeObject<List<FlightCostModel>>(json);
                if (items == null)
                {
                    throw new InvalidOperationException("Deserialization resulted in a null value.");
                }
                return items;
            }
        }

        public static List<BookingDetailsModel> LoadAmericanAirlinesBookingDetailsJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic)
            {

                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\AmericanAirlines\AmericanAirlinesbookingDetails.json"))
                {
                    string json = r.ReadToEnd();
                    List<BookingDetailsModel>? items = JsonConvert.DeserializeObject<List<BookingDetailsModel>>(json);

                    if (items == null)
                    {
                        throw new InvalidOperationException("Deserialization resulted in a null value.");
                    }
                    return items;
                }
            }   
                else
                {
                    string json = JsonValues.AmericanAirlinesBookingDetails; // Assuming you have a static JSON string in JsonValues
                    List<BookingDetailsModel>? items = JsonConvert.DeserializeObject<List<BookingDetailsModel>>(json);
                    if (items == null)
                    {
                        throw new InvalidOperationException("Deserialization resulted in a null value.");
                    }
                    return items;
            }
        }

        public static List<BookFlightModel> LoadAmericanAirlinesBookFlightJson(string MockResponseJsonPath, bool FromStatic = true  )
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\AmericanAirlines\AmericanAirlinesbookFlight.json"))
                {
                    string json = r.ReadToEnd();
                    List<BookFlightModel>? items = JsonConvert.DeserializeObject<List<BookFlightModel>>(json);

                    if (items == null)
                    {
                        throw new InvalidOperationException("Deserialization resulted in a null value.");
                    }
                    return items;
                }
            }
            else
            {
                string json = JsonValues.AmericanAirlinesBookFlight;
                List<BookFlightModel>? items = JsonConvert.DeserializeObject<List<BookFlightModel>>(json);

                if (items == null)
                {
                    throw new InvalidOperationException("Deserialization resulted in a null value.");
                }
                return items;
            }
                
        }

        
        
    }
}
