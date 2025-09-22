using AirlinesData.Entities;
using AirlinesData.MockResponses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace AirlinesData.Helpers
{
    public static class EmiratesLoadJson
    {
        public static List<SearchFlightsModel> LoadEmiratesSearchFlightJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\Emirates\Emirates.json"))
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
                string json = JsonValues.EmiratesAirlines;
                List<SearchFlightsModel>? items = JsonConvert.DeserializeObject<List<SearchFlightsModel>>(json);

                if (items == null)
                {
                    throw new InvalidOperationException("Deserialization resulted in a null value.");
                }
                return items;
            }
            
        }

        public static List<FlightCostModel> LoadEmiratesFlightCostJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic){
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\Emirates\EmiratesflightCost.json"))
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
                string json = JsonValues.EmiratesAirlinesFlightCost;
                List<FlightCostModel>? items = JsonConvert.DeserializeObject<List<FlightCostModel>>(json);
                if (items == null)
                {
                    throw new InvalidOperationException("Deserialization resulted in a null value.");
                }
                return items;
            }
        }

        public static List<BookingDetailsModel> LoadEmiratesBookingDetailsJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\Emirates\EmiratesbookingDetails.json"))
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

                string json = JsonValues.EmiratesAirlinesBookingDetails;
                List<BookingDetailsModel>? items = JsonConvert.DeserializeObject<List<BookingDetailsModel>>(json);

                if (items == null)
                {
                    throw new InvalidOperationException("Deserialization resulted in a null value.");
                }
                return items;

            }   
        }

        public static List<BookFlightModel> LoadEmiratesBookFlightJson(string MockResponseJsonPath, bool FromStatic = true)
        {
            if (!FromStatic)
            {
                using (StreamReader r = new StreamReader(MockResponseJsonPath + @"\Emirates\EmiratesbookFlight.json"))
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
                string json = JsonValues.EmiratesAirlinesBookFlight;
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
