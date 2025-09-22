using AirlinesData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesData.MockResponses
{
    public static class JsonValues
    {
        public const string AirIndia =
        @"[
    {
    ""flightId"": ""FL12345"",
    ""airline"": ""Airways International"",
    ""departure"": {
      ""airport"": ""JFK International Airport"",
      ""time"": ""2025-10-01T14:30:00Z""
    },
    ""arrival"": {
      ""airport"": ""LAX International Airport"",
      ""time"": ""2025-10-01T17:00:00Z""
    },
    ""duration"": ""5h 30m"",
    ""price"": 299.99,
    ""stops"": 1,
    ""aircraftType"": ""Boeing 737""
  },
  {
    ""flightId"": ""FL67890"",
    ""airline"": ""Sky High Airlines"",
    ""departure"": {
      ""airport"": ""LAX International Airport"",
      ""time"": ""2025-10-01T18:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""ORD International Airport"",
      ""time"": ""2025-10-01T23:00:00Z""
    },
    ""duration"": ""4h 0m"",
    ""price"": 199.99,
    ""stops"": 0,
    ""aircraftType"": ""Airbus A320""
  },
  {
    ""flightId"": ""FL54321"",
    ""airline"": ""Global Wings"",
    ""departure"": {
      ""airport"": ""ORD International Airport"",
      ""time"": ""2025-10-02T08:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""ATL International Airport"",
      ""time"": ""2025-10-02T10:30:00Z""
    },
    ""duration"": ""2h 30m"",
    ""price"": 149.99,
    ""stops"": 0,
    ""aircraftType"": ""Boeing 777""
  },
  {
    ""flightId"": ""FL98765"",
    ""airline"": ""Jet Stream Airlines"",
    ""departure"": {
      ""airport"": ""ATL International Airport"",
      ""time"": ""2025-10-02T12:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""MIA International Airport"",
      ""time"": ""2025-10-02T14:30:00Z""
    },
    ""duration"": ""2h 30m"",
    ""price"": 179.99,
    ""stops"": 0,
    ""aircraftType"": ""Boeing 787""
  },
  {
    ""flightId"": ""FL11223"",
    ""airline"": ""Pacific Air Lines"",
    ""departure"": {
      ""airport"": ""MIA International Airport"",
      ""time"": ""2025-10-02T16:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""SEA International Airport"",
      ""time"": ""2025-10-02T20:00:00Z""
    },
    ""duration"": ""6h 0m"",
    ""price"": 349.99,
    ""stops"": 1,
    ""aircraftType"": ""Boeing 767""
  },
  {
    ""flightId"": ""FL33445"",
    ""airline"": ""Northern Skies Airlines"",
    ""departure"": {
      ""airport"": ""SEA International Airport"",
      ""time"": ""2025-10-02T21:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""DEN International Airport"",
      ""time"": ""2025-10-02T23:30:00Z""
    },
    ""duration"": ""2h 30m"",
    ""price"": 129.99,
    ""stops"": 0,
    ""aircraftType"": ""Airbus A330""
  },
  {
    ""flightId"": ""FL55667"",
    ""airline"": ""Eastern Wings"",
    ""departure"": {
      ""airport"": ""DEN International Airport"",
      ""time"": ""2025-10-03T01:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""BOS International Airport"",
      ""time"": ""2025-10-03T05:00:00Z""
    },
    ""duration"": ""4h 0m"",
    ""price"": 219.99,
    ""stops"": 0,
    ""aircraftType"": ""Boeing 747""
  },
  {
    ""flightId"": ""FL77889"",
    ""airline"": ""Southern Breeze Airlines"",
    ""departure"": {
      ""airport"": ""BOS International Airport"",
      ""time"": ""2025-10-03T07:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""PHL International Airport"",
      ""time"": ""2025-10-03T09:00:00Z""
    },
    ""duration"": ""2h 0m"",
    ""price"": 99.99,
    ""stops"": 0,
    ""aircraftType"": ""Airbus A350""
  }
]
";
        public const string AirIndiaBookFlight = @"[
  {
    ""flightId"": ""FL12345"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL67890"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL54321"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL98765"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL24680"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL13579"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL86420"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL97531"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL11122"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL33344"",
    ""flightavailable"": false
  },
  {
    ""flightId"": ""FL55566"",
    ""flightavailable"": false
  },
  {
    ""flightId"": ""FL77788"",
    ""flightavailable"": true
  },

]";

        public const string AirIndiaFlightCost = @"[
  {
    ""flightId"": ""FL12345"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 299.99
  },
  {
    ""flightId"": ""FL67890"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 199.99

  },
  {
    ""flightId"": ""FL54321"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 149.99
  },
  {
    ""flightId"": ""FL98765"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 179.99
  },
  {
    ""flightId"": ""FL24680"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 220.00
  },
  {
    ""flightId"": ""FL13579"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 310.50
  },
  {
    ""flightId"": ""FL86420"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 275.75
  },
  {
    ""flightId"": ""FL97531"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 185.00
  },
  {
    ""flightId"": ""FL11122"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 230.00
  },
  {
    ""flightId"": ""FL33344"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 150.00
  },
  {
    ""flightId"": ""FL55566"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 290.00
  },
  {
    ""flightId"": ""FL77788"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 320.00
  }

]
  ";

        public const string AirIndiaBookingDetails = @"[
  {
    ""bookingId"": ""12345-abcde-67890-fghij"",
    ""bookingStatus"": ""Confirmed"",
    ""bookingDate"": ""2025-10-01T12:00:00Z"",
    ""passengerName"": ""John Doe"",
    ""flightNumber"": ""AA1234"",
    ""flightClass"": ""Economy"",
    ""departureDate"": ""2025-10-15T10:00:00Z"",
    ""arrivalDate"": ""2025-10-15T12:00:00Z""
  }, 
  {
    ""bookingId"": ""54321-zyxwv-09876-lmnop"",
    ""bookingStatus"": ""Pending"",
    ""bookingDate"": ""2025-10-02T14:30:00Z"",
    ""passengerName"": ""Jane Smith"",
    ""flightNumber"": ""BA5678"",
    ""flightClass"": ""Business"",
    ""departureDate"": ""2025-10-20T15:00:00Z"",
    ""arrivalDate"": ""2025-10-20T17:30:00Z ""
  },
  {
    ""bookingId"": ""67890-pqrst-12345-uvwxy"",
    ""bookingStatus"": ""Cancelled"",
    ""bookingDate"": ""2025-10-03T09:00:00Z"",
    ""passengerName"": ""Alice Johnson"",
    ""flightNumber"": ""CA9101"",
    ""flightClass"": ""First Class"",
    ""departureDate"": ""2025-10-25T08:00:00Z"",
    ""arrivalDate"" : ""2025-10-25T10:30:00Z""
  },
  {
    ""bookingId"": ""09876-lmnop-54321-zyxwv"",
    ""bookingStatus"": ""Confirmed"",
    ""bookingDate"": ""2025-10-04T11:15:00Z"",
    ""passengerName"": ""Bob Brown"",
    ""flightNumber"": ""DA2345"",
    ""flightClass"": ""Economy"",
    ""departureDate"": ""2025-10-30T13:00:00Z "",
    ""arrivalDate"": ""2025-10-30T15:30:00Z ""
  },
  {
    ""bookingId"": ""11223-abcd-44556-efghh"",
    ""bookingStatus"": ""Pending"",
    ""bookingDate"": ""2025-10-05T16:45:00Z"",
    ""passengerName"": ""Charlie Davis"",
    ""flightNumber"": ""EA6789"",
    ""flightClass"": ""Business"",
    ""departureDate"": ""2025-11-01T09:00:00Z"",
    ""arrivalDate"": ""2025-11-01T11:30:00Z""
  }
]
";

        public const string AmericanAirlines =
        @"[
    {
    ""flightId"": ""FL12345"",
    ""airline"": ""Airways International"",
    ""departure"": {
      ""airport"": ""JFK International Airport"",
      ""time"": ""2025-10-01T14:30:00Z""
    },
    ""arrival"": {
      ""airport"": ""LAX International Airport"",
      ""time"": ""2025-10-01T17:00:00Z""
    },
    ""duration"": ""5h 30m"",
    ""price"": 299.99,
    ""stops"": 1,
    ""aircraftType"": ""Boeing 737""
  },
  {
    ""flightId"": ""FL67890"",
    ""airline"": ""Sky High Airlines"",
    ""departure"": {
      ""airport"": ""LAX International Airport"",
      ""time"": ""2025-10-01T18:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""ORD International Airport"",
      ""time"": ""2025-10-01T23:00:00Z""
    },
    ""duration"": ""4h 0m"",
    ""price"": 199.99,
    ""stops"": 0,
    ""aircraftType"": ""Airbus A320""
  },
  {
    ""flightId"": ""FL54321"",
    ""airline"": ""Global Wings"",
    ""departure"": {
      ""airport"": ""ORD International Airport"",
      ""time"": ""2025-10-02T08:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""ATL International Airport"",
      ""time"": ""2025-10-02T10:30:00Z""
    },
    ""duration"": ""2h 30m"",
    ""price"": 149.99,
    ""stops"": 0,
    ""aircraftType"": ""Boeing 777""
  },
  {
    ""flightId"": ""FL98765"",
    ""airline"": ""Jet Stream Airlines"",
    ""departure"": {
      ""airport"": ""ATL International Airport"",
      ""time"": ""2025-10-02T12:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""MIA International Airport"",
      ""time"": ""2025-10-02T14:30:00Z""
    },
    ""duration"": ""2h 30m"",
    ""price"": 179.99,
    ""stops"": 0,
    ""aircraftType"": ""Boeing 787""
  },
  {
    ""flightId"": ""FL11223"",
    ""airline"": ""Pacific Air Lines"",
    ""departure"": {
      ""airport"": ""MIA International Airport"",
      ""time"": ""2025-10-02T16:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""SEA International Airport"",
      ""time"": ""2025-10-02T20:00:00Z""
    },
    ""duration"": ""6h 0m"",
    ""price"": 349.99,
    ""stops"": 1,
    ""aircraftType"": ""Boeing 767""
  },
  {
    ""flightId"": ""FL33445"",
    ""airline"": ""Northern Skies Airlines"",
    ""departure"": {
      ""airport"": ""SEA International Airport"",
      ""time"": ""2025-10-02T21:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""DEN International Airport"",
      ""time"": ""2025-10-02T23:30:00Z""
    },
    ""duration"": ""2h 30m"",
    ""price"": 129.99,
    ""stops"": 0,
    ""aircraftType"": ""Airbus A330""
  },
  {
    ""flightId"": ""FL55667"",
    ""airline"": ""Eastern Wings"",
    ""departure"": {
      ""airport"": ""DEN International Airport"",
      ""time"": ""2025-10-03T01:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""BOS International Airport"",
      ""time"": ""2025-10-03T05:00:00Z""
    },
    ""duration"": ""4h 0m"",
    ""price"": 219.99,
    ""stops"": 0,
    ""aircraftType"": ""Boeing 747""
  },
  {
    ""flightId"": ""FL77889"",
    ""airline"": ""Southern Breeze Airlines"",
    ""departure"": {
      ""airport"": ""BOS International Airport"",
      ""time"": ""2025-10-03T07:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""PHL International Airport"",
      ""time"": ""2025-10-03T09:00:00Z""
    },
    ""duration"": ""2h 0m"",
    ""price"": 99.99,
    ""stops"": 0,
    ""aircraftType"": ""Airbus A350""
  }
]
";
        public const string AmericanAirlinesBookFlight = @"[
  {
    ""flightId"": ""FL12345"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL67890"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL54321"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL98765"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL24680"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL13579"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL86420"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL97531"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL11122"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL33344"",
    ""flightavailable"": false
  },
  {
    ""flightId"": ""FL55566"",
    ""flightavailable"": false
  },
  {
    ""flightId"": ""FL77788"",
    ""flightavailable"": true
  },

]";

        public const string AmericanAirlinesFlightCost = @"[
  {
    ""flightId"": ""FL12345"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 299.99
  },
  {
    ""flightId"": ""FL67890"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 199.99

  },
  {
    ""flightId"": ""FL54321"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 149.99
  },
  {
    ""flightId"": ""FL98765"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 179.99
  },
  {
    ""flightId"": ""FL24680"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 220.00
  },
  {
    ""flightId"": ""FL13579"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 310.50
  },
  {
    ""flightId"": ""FL86420"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 275.75
  },
  {
    ""flightId"": ""FL97531"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 185.00
  },
  {
    ""flightId"": ""FL11122"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 230.00
  },
  {
    ""flightId"": ""FL33344"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 150.00
  },
  {
    ""flightId"": ""FL55566"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 290.00
  },
  {
    ""flightId"": ""FL77788"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 320.00
  }

]
  ";

        public const string AmericanAirlinesBookingDetails = @"[
  {
    ""bookingId"": ""12345-abcde-67890-fghij"",
    ""bookingStatus"": ""Confirmed"",
    ""bookingDate"": ""2025-10-01T12:00:00Z"",
    ""passengerName"": ""John Doe"",
    ""flightNumber"": ""AA1234"",
    ""flightClass"": ""Economy"",
    ""departureDate"": ""2025-10-15T10:00:00Z"",
    ""arrivalDate"": ""2025-10-15T12:00:00Z""
  }, 
  {
    ""bookingId"": ""54321-zyxwv-09876-lmnop"",
    ""bookingStatus"": ""Pending"",
    ""bookingDate"": ""2025-10-02T14:30:00Z"",
    ""passengerName"": ""Jane Smith"",
    ""flightNumber"": ""BA5678"",
    ""flightClass"": ""Business"",
    ""departureDate"": ""2025-10-20T15:00:00Z"",
    ""arrivalDate"": ""2025-10-20T17:30:00Z ""
  },
  {
    ""bookingId"": ""67890-pqrst-12345-uvwxy"",
    ""bookingStatus"": ""Cancelled"",
    ""bookingDate"": ""2025-10-03T09:00:00Z"",
    ""passengerName"": ""Alice Johnson"",
    ""flightNumber"": ""CA9101"",
    ""flightClass"": ""First Class"",
    ""departureDate"": ""2025-10-25T08:00:00Z"",
    ""arrivalDate"" : ""2025-10-25T10:30:00Z""
  },
  {
    ""bookingId"": ""09876-lmnop-54321-zyxwv"",
    ""bookingStatus"": ""Confirmed"",
    ""bookingDate"": ""2025-10-04T11:15:00Z"",
    ""passengerName"": ""Bob Brown"",
    ""flightNumber"": ""DA2345"",
    ""flightClass"": ""Economy"",
    ""departureDate"": ""2025-10-30T13:00:00Z "",
    ""arrivalDate"": ""2025-10-30T15:30:00Z ""
  },
  {
    ""bookingId"": ""11223-abcd-44556-efghh"",
    ""bookingStatus"": ""Pending"",
    ""bookingDate"": ""2025-10-05T16:45:00Z"",
    ""passengerName"": ""Charlie Davis"",
    ""flightNumber"": ""EA6789"",
    ""flightClass"": ""Business"",
    ""departureDate"": ""2025-11-01T09:00:00Z"",
    ""arrivalDate"": ""2025-11-01T11:30:00Z""
  }
]
";

        public const string BritishAirlines =
        @"[
    {
    ""flightId"": ""FL12345"",
    ""airline"": ""Airways International"",
    ""departure"": {
      ""airport"": ""JFK International Airport"",
      ""time"": ""2025-10-01T14:30:00Z""
    },
    ""arrival"": {
      ""airport"": ""LAX International Airport"",
      ""time"": ""2025-10-01T17:00:00Z""
    },
    ""duration"": ""5h 30m"",
    ""price"": 299.99,
    ""stops"": 1,
    ""aircraftType"": ""Boeing 737""
  },
  {
    ""flightId"": ""FL67890"",
    ""airline"": ""Sky High Airlines"",
    ""departure"": {
      ""airport"": ""LAX International Airport"",
      ""time"": ""2025-10-01T18:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""ORD International Airport"",
      ""time"": ""2025-10-01T23:00:00Z""
    },
    ""duration"": ""4h 0m"",
    ""price"": 199.99,
    ""stops"": 0,
    ""aircraftType"": ""Airbus A320""
  },
  {
    ""flightId"": ""FL54321"",
    ""airline"": ""Global Wings"",
    ""departure"": {
      ""airport"": ""ORD International Airport"",
      ""time"": ""2025-10-02T08:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""ATL International Airport"",
      ""time"": ""2025-10-02T10:30:00Z""
    },
    ""duration"": ""2h 30m"",
    ""price"": 149.99,
    ""stops"": 0,
    ""aircraftType"": ""Boeing 777""
  },
  {
    ""flightId"": ""FL98765"",
    ""airline"": ""Jet Stream Airlines"",
    ""departure"": {
      ""airport"": ""ATL International Airport"",
      ""time"": ""2025-10-02T12:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""MIA International Airport"",
      ""time"": ""2025-10-02T14:30:00Z""
    },
    ""duration"": ""2h 30m"",
    ""price"": 179.99,
    ""stops"": 0,
    ""aircraftType"": ""Boeing 787""
  },
  {
    ""flightId"": ""FL11223"",
    ""airline"": ""Pacific Air Lines"",
    ""departure"": {
      ""airport"": ""MIA International Airport"",
      ""time"": ""2025-10-02T16:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""SEA International Airport"",
      ""time"": ""2025-10-02T20:00:00Z""
    },
    ""duration"": ""6h 0m"",
    ""price"": 349.99,
    ""stops"": 1,
    ""aircraftType"": ""Boeing 767""
  },
  {
    ""flightId"": ""FL33445"",
    ""airline"": ""Northern Skies Airlines"",
    ""departure"": {
      ""airport"": ""SEA International Airport"",
      ""time"": ""2025-10-02T21:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""DEN International Airport"",
      ""time"": ""2025-10-02T23:30:00Z""
    },
    ""duration"": ""2h 30m"",
    ""price"": 129.99,
    ""stops"": 0,
    ""aircraftType"": ""Airbus A330""
  },
  {
    ""flightId"": ""FL55667"",
    ""airline"": ""Eastern Wings"",
    ""departure"": {
      ""airport"": ""DEN International Airport"",
      ""time"": ""2025-10-03T01:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""BOS International Airport"",
      ""time"": ""2025-10-03T05:00:00Z""
    },
    ""duration"": ""4h 0m"",
    ""price"": 219.99,
    ""stops"": 0,
    ""aircraftType"": ""Boeing 747""
  },
  {
    ""flightId"": ""FL77889"",
    ""airline"": ""Southern Breeze Airlines"",
    ""departure"": {
      ""airport"": ""BOS International Airport"",
      ""time"": ""2025-10-03T07:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""PHL International Airport"",
      ""time"": ""2025-10-03T09:00:00Z""
    },
    ""duration"": ""2h 0m"",
    ""price"": 99.99,
    ""stops"": 0,
    ""aircraftType"": ""Airbus A350""
  }
]
";
        public const string BritishAirlinesBookFlight = @"[
  {
    ""flightId"": ""FL12345"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL67890"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL54321"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL98765"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL24680"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL13579"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL86420"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL97531"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL11122"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL33344"",
    ""flightavailable"": false
  },
  {
    ""flightId"": ""FL55566"",
    ""flightavailable"": false
  },
  {
    ""flightId"": ""FL77788"",
    ""flightavailable"": true
  },

]";

        public const string BritishAirlinesFlightCost = @"[
  {
    ""flightId"": ""FL12345"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 299.99
  },
  {
    ""flightId"": ""FL67890"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 199.99

  },
  {
    ""flightId"": ""FL54321"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 149.99
  },
  {
    ""flightId"": ""FL98765"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 179.99
  },
  {
    ""flightId"": ""FL24680"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 220.00
  },
  {
    ""flightId"": ""FL13579"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 310.50
  },
  {
    ""flightId"": ""FL86420"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 275.75
  },
  {
    ""flightId"": ""FL97531"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 185.00
  },
  {
    ""flightId"": ""FL11122"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 230.00
  },
  {
    ""flightId"": ""FL33344"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 150.00
  },
  {
    ""flightId"": ""FL55566"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 290.00
  },
  {
    ""flightId"": ""FL77788"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 320.00
  }

]
  ";

        public const string BritishAirlinesBookingDetails = @"[
  {
    ""bookingId"": ""12345-abcde-67890-fghij"",
    ""bookingStatus"": ""Confirmed"",
    ""bookingDate"": ""2025-10-01T12:00:00Z"",
    ""passengerName"": ""John Doe"",
    ""flightNumber"": ""AA1234"",
    ""flightClass"": ""Economy"",
    ""departureDate"": ""2025-10-15T10:00:00Z"",
    ""arrivalDate"": ""2025-10-15T12:00:00Z""
  }, 
  {
    ""bookingId"": ""54321-zyxwv-09876-lmnop"",
    ""bookingStatus"": ""Pending"",
    ""bookingDate"": ""2025-10-02T14:30:00Z"",
    ""passengerName"": ""Jane Smith"",
    ""flightNumber"": ""BA5678"",
    ""flightClass"": ""Business"",
    ""departureDate"": ""2025-10-20T15:00:00Z"",
    ""arrivalDate"": ""2025-10-20T17:30:00Z ""
  },
  {
    ""bookingId"": ""67890-pqrst-12345-uvwxy"",
    ""bookingStatus"": ""Cancelled"",
    ""bookingDate"": ""2025-10-03T09:00:00Z"",
    ""passengerName"": ""Alice Johnson"",
    ""flightNumber"": ""CA9101"",
    ""flightClass"": ""First Class"",
    ""departureDate"": ""2025-10-25T08:00:00Z"",
    ""arrivalDate"" : ""2025-10-25T10:30:00Z""
  },
  {
    ""bookingId"": ""09876-lmnop-54321-zyxwv"",
    ""bookingStatus"": ""Confirmed"",
    ""bookingDate"": ""2025-10-04T11:15:00Z"",
    ""passengerName"": ""Bob Brown"",
    ""flightNumber"": ""DA2345"",
    ""flightClass"": ""Economy"",
    ""departureDate"": ""2025-10-30T13:00:00Z "",
    ""arrivalDate"": ""2025-10-30T15:30:00Z ""
  },
  {
    ""bookingId"": ""11223-abcd-44556-efghh"",
    ""bookingStatus"": ""Pending"",
    ""bookingDate"": ""2025-10-05T16:45:00Z"",
    ""passengerName"": ""Charlie Davis"",
    ""flightNumber"": ""EA6789"",
    ""flightClass"": ""Business"",
    ""departureDate"": ""2025-11-01T09:00:00Z"",
    ""arrivalDate"": ""2025-11-01T11:30:00Z""
  }
]
";

        public const string EmiratesAirlines =
        @"[
    {
    ""flightId"": ""FL12345"",
    ""airline"": ""Airways International"",
    ""departure"": {
      ""airport"": ""JFK International Airport"",
      ""time"": ""2025-10-01T14:30:00Z""
    },
    ""arrival"": {
      ""airport"": ""LAX International Airport"",
      ""time"": ""2025-10-01T17:00:00Z""
    },
    ""duration"": ""5h 30m"",
    ""price"": 299.99,
    ""stops"": 1,
    ""aircraftType"": ""Boeing 737""
  },
  {
    ""flightId"": ""FL67890"",
    ""airline"": ""Sky High Airlines"",
    ""departure"": {
      ""airport"": ""LAX International Airport"",
      ""time"": ""2025-10-01T18:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""ORD International Airport"",
      ""time"": ""2025-10-01T23:00:00Z""
    },
    ""duration"": ""4h 0m"",
    ""price"": 199.99,
    ""stops"": 0,
    ""aircraftType"": ""Airbus A320""
  },
  {
    ""flightId"": ""FL54321"",
    ""airline"": ""Global Wings"",
    ""departure"": {
      ""airport"": ""ORD International Airport"",
      ""time"": ""2025-10-02T08:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""ATL International Airport"",
      ""time"": ""2025-10-02T10:30:00Z""
    },
    ""duration"": ""2h 30m"",
    ""price"": 149.99,
    ""stops"": 0,
    ""aircraftType"": ""Boeing 777""
  },
  {
    ""flightId"": ""FL98765"",
    ""airline"": ""Jet Stream Airlines"",
    ""departure"": {
      ""airport"": ""ATL International Airport"",
      ""time"": ""2025-10-02T12:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""MIA International Airport"",
      ""time"": ""2025-10-02T14:30:00Z""
    },
    ""duration"": ""2h 30m"",
    ""price"": 179.99,
    ""stops"": 0,
    ""aircraftType"": ""Boeing 787""
  },
  {
    ""flightId"": ""FL11223"",
    ""airline"": ""Pacific Air Lines"",
    ""departure"": {
      ""airport"": ""MIA International Airport"",
      ""time"": ""2025-10-02T16:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""SEA International Airport"",
      ""time"": ""2025-10-02T20:00:00Z""
    },
    ""duration"": ""6h 0m"",
    ""price"": 349.99,
    ""stops"": 1,
    ""aircraftType"": ""Boeing 767""
  },
  {
    ""flightId"": ""FL33445"",
    ""airline"": ""Northern Skies Airlines"",
    ""departure"": {
      ""airport"": ""SEA International Airport"",
      ""time"": ""2025-10-02T21:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""DEN International Airport"",
      ""time"": ""2025-10-02T23:30:00Z""
    },
    ""duration"": ""2h 30m"",
    ""price"": 129.99,
    ""stops"": 0,
    ""aircraftType"": ""Airbus A330""
  },
  {
    ""flightId"": ""FL55667"",
    ""airline"": ""Eastern Wings"",
    ""departure"": {
      ""airport"": ""DEN International Airport"",
      ""time"": ""2025-10-03T01:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""BOS International Airport"",
      ""time"": ""2025-10-03T05:00:00Z""
    },
    ""duration"": ""4h 0m"",
    ""price"": 219.99,
    ""stops"": 0,
    ""aircraftType"": ""Boeing 747""
  },
  {
    ""flightId"": ""FL77889"",
    ""airline"": ""Southern Breeze Airlines"",
    ""departure"": {
      ""airport"": ""BOS International Airport"",
      ""time"": ""2025-10-03T07:00:00Z""
    },
    ""arrival"": {
      ""airport"": ""PHL International Airport"",
      ""time"": ""2025-10-03T09:00:00Z""
    },
    ""duration"": ""2h 0m"",
    ""price"": 99.99,
    ""stops"": 0,
    ""aircraftType"": ""Airbus A350""
  }
]
";
        public const string EmiratesAirlinesBookFlight = @"[
  {
    ""flightId"": ""FL12345"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL67890"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL54321"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL98765"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL24680"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL13579"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL86420"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL97531"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL11122"",
    ""flightavailable"": true
  },
  {
    ""flightId"": ""FL33344"",
    ""flightavailable"": false
  },
  {
    ""flightId"": ""FL55566"",
    ""flightavailable"": false
  },
  {
    ""flightId"": ""FL77788"",
    ""flightavailable"": true
  },

]";

        public const string EmiratesAirlinesFlightCost = @"[
  {
    ""flightId"": ""FL12345"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 299.99
  },
  {
    ""flightId"": ""FL67890"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 199.99

  },
  {
    ""flightId"": ""FL54321"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 149.99
  },
  {
    ""flightId"": ""FL98765"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 179.99
  },
  {
    ""flightId"": ""FL24680"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 220.00
  },
  {
    ""flightId"": ""FL13579"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 310.50
  },
  {
    ""flightId"": ""FL86420"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 275.75
  },
  {
    ""flightId"": ""FL97531"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 185.00
  },
  {
    ""flightId"": ""FL11122"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 230.00
  },
  {
    ""flightId"": ""FL33344"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 150.00
  },
  {
    ""flightId"": ""FL55566"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 290.00
  },
  {
    ""flightId"": ""FL77788"",
    ""flightName"": ""AirIndia"",
    ""flightcost"": 320.00
  }

]
  ";

        public const string EmiratesAirlinesBookingDetails = @"[
  {
    ""bookingId"": ""12345-abcde-67890-fghij"",
    ""bookingStatus"": ""Confirmed"",
    ""bookingDate"": ""2025-10-01T12:00:00Z"",
    ""passengerName"": ""John Doe"",
    ""flightNumber"": ""AA1234"",
    ""flightClass"": ""Economy"",
    ""departureDate"": ""2025-10-15T10:00:00Z"",
    ""arrivalDate"": ""2025-10-15T12:00:00Z""
  }, 
  {
    ""bookingId"": ""54321-zyxwv-09876-lmnop"",
    ""bookingStatus"": ""Pending"",
    ""bookingDate"": ""2025-10-02T14:30:00Z"",
    ""passengerName"": ""Jane Smith"",
    ""flightNumber"": ""BA5678"",
    ""flightClass"": ""Business"",
    ""departureDate"": ""2025-10-20T15:00:00Z"",
    ""arrivalDate"": ""2025-10-20T17:30:00Z ""
  },
  {
    ""bookingId"": ""67890-pqrst-12345-uvwxy"",
    ""bookingStatus"": ""Cancelled"",
    ""bookingDate"": ""2025-10-03T09:00:00Z"",
    ""passengerName"": ""Alice Johnson"",
    ""flightNumber"": ""CA9101"",
    ""flightClass"": ""First Class"",
    ""departureDate"": ""2025-10-25T08:00:00Z"",
    ""arrivalDate"" : ""2025-10-25T10:30:00Z""
  },
  {
    ""bookingId"": ""09876-lmnop-54321-zyxwv"",
    ""bookingStatus"": ""Confirmed"",
    ""bookingDate"": ""2025-10-04T11:15:00Z"",
    ""passengerName"": ""Bob Brown"",
    ""flightNumber"": ""DA2345"",
    ""flightClass"": ""Economy"",
    ""departureDate"": ""2025-10-30T13:00:00Z "",
    ""arrivalDate"": ""2025-10-30T15:30:00Z ""
  },
  {
    ""bookingId"": ""11223-abcd-44556-efghh"",
    ""bookingStatus"": ""Pending"",
    ""bookingDate"": ""2025-10-05T16:45:00Z"",
    ""passengerName"": ""Charlie Davis"",
    ""flightNumber"": ""EA6789"",
    ""flightClass"": ""Business"",
    ""departureDate"": ""2025-11-01T09:00:00Z"",
    ""arrivalDate"": ""2025-11-01T11:30:00Z""
  }
]
";
    } 
}
