using AirlinesData.Entities;
using AirlinesData.MockResponses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesData.Helpers
{
    public static class BritishAirlinesLoadJson
    {
        public static List<SearchFlightsModel> LoadBritishAirlinesSearchFlightJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\BritishAirlines\BritishAirlines.json"))
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
                string json = JsonValues.BritishAirlines;
                List<SearchFlightsModel>? items = JsonConvert.DeserializeObject<List<SearchFlightsModel>>(json);

                if (items == null)
                {
                    throw new InvalidOperationException("Deserialization resulted in a null value.");
                }
                return items;
            }
        }

        public static List<FlightCostModel> LoadBritishAirlinesFlightCostJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\BritishAirlines\BritishAirlinesbookFlight.json"))
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
                string json = JsonValues.BritishAirlinesBookFlight;
                List<FlightCostModel>? items = JsonConvert.DeserializeObject<List<FlightCostModel>>(json);

                if (items == null)
                {
                    throw new InvalidOperationException("Deserialization resulted in a null value.");
                }
                return items;
            }
        }

        public static List<BookingDetailsModel> LoadBritishAirlinesBookingDetailsJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\BritishAirlines\BritishAirlinesbookingDetails.json"))
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
                string json = JsonValues.BritishAirlinesBookingDetails;
                List<BookingDetailsModel>? items = JsonConvert.DeserializeObject<List<BookingDetailsModel>>(json);
                if (items == null)
                {
                    throw new InvalidOperationException("Deserialization resulted in a null value.");
                }
                return items;
            }
        }

        public static List<BookFlightModel> LoadBritishAirlinesBookFlightJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\BritishAirlines\BritishAirlinesbookFlight.json"))
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
                string json = JsonValues.BritishAirlinesBookFlight;
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
