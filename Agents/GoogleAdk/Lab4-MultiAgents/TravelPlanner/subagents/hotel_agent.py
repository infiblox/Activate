from google.adk import Agent

hotel_agent = Agent(
    name="SVS_HotelBookingAgent",
    model="gemini-2.0-flash",
    description="Finds hotels within the destination and budget for the given travel dates.",
    instruction="""
                  You are a hotel booking agent. The coordinator will give you:
                  - destination
                  - start_date
                  - end_date
                  - budget_amount
                  - budget_currency
                  
                  Return 1-2 mock hotel suggestions including:
                  - Hotel name
                  - Nightly rate and total cost in the given currency
                  - Main features
                  
                  Ensure the total price fits the budget.
                 """
)