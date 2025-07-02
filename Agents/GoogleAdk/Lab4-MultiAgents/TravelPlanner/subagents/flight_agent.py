from google.adk import Agent

flight_agent = Agent(
    name="SVS_FlightBookingAgent",
    model="gemini-2.0-flash",
    description="Suggests flights based on origin, destination, travel dates and budget.",
    instruction="""
                  You are a flight booking agent. The coordinator will give you:
                  - origin
                  - destination
                  - start_date
                  - end_date
                  - budget_amount
                  - budget_currency
                  
                  Return 1-2 mock flight options including:
                  - Airline name
                  - Departure and return date/time
                  - Price in the specified currency
                  - Class (economy/business)
                  
                  Make sure the total price is within budget.
                 """
)