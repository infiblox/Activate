using AirlinesData.Entities;
using AirlinesData.MockResponses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AirlinesData.Helpers
{
    public static class loadJson
    {
        public static List<SearchFlightsModel> LoadAirIndiaSearchFlightJson(string MockResponseJsonPath,bool FromStatic)
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\AirIndia\AirIndia.json"))
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
                string json = JsonValues.AirIndia;
                List<SearchFlightsModel>? items = JsonConvert.DeserializeObject<List<SearchFlightsModel>>(json);

                if (items == null)
                {
                    throw new InvalidOperationException("Deserialization resulted in a null value.");
                }
                return items;
            }
                
        }

        public static List<FlightCostModel> LoadAirIndiaFlightCostJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\AirIndia\AirIndiabookFlight.json"))
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
                string json = JsonValues.AirIndiaBookFlight;
                List<FlightCostModel>? items = JsonConvert.DeserializeObject<List<FlightCostModel>>(json);

                if (items == null)
                {
                    throw new InvalidOperationException("Deserialization resulted in a null value.");
                }
                return items;
            }
        }

        public static List<BookingDetailsModel> LoadAirIndiaBookingDetailsJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\AirIndia\AirIndiabookingDetails.json"))
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
            {
                string json = JsonValues.AirIndiaBookingDetails;
                List<BookingDetailsModel>? items = JsonConvert.DeserializeObject<List<BookingDetailsModel>>(json);

                if (items == null)
                {
                    throw new InvalidOperationException("Deserialization resulted in a null value.");
                }
                return items;
            }
        }

        public static List<BookFlightModel> LoadAirIndiaBookFlightJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\AirIndia\AirIndiabookFlight.json"))
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
                string json = JsonValues.AirIndiaBookFlight;
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
