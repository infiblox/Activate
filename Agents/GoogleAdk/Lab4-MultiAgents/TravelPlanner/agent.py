from google.adk import Agent
from .subagents.flight_agent import flight_agent
from .subagents.hotel_agent import hotel_agent
from .tools.schemas import TravelInfo
from datetime import datetime, timedelta

today = datetime.today().date()

coordinator_agent = Agent(
    name="SVS_TravelCoordinator",
    model="gemini-2.0-flash",
    description="Main coordinator agent that gathers travel preferences and queries sub-agents.",
    instruction=f"""
                    You are a travel planning coordinator.
                    Your task is to gather travel preferences from the user and coordinate with sub-agents to provide flight, hotel suggestions with day plans.
                    You will receive user input in natural language and need to extract the following details:
                    
                    Note that maximum budget should be used for both flight and hotel suggestions, it should not be exceeded when combined.
                    if the user doesn't specify a start_date, but something like "Next week", "Next month", or "Next year", convert it to a date format by taking today's date as {today}.
                    
                    Step 1: Extract the following details from the user's input:
                    - origin (departure location)
                    - destination
                    - start_date (format: YYYY-MM-DD)
                    - end_date (format: YYYY-MM-DD)
                    - budget_amount (number)
                    - budget_currency (e.g., USD, LKR, $)
                    
                    Step 2: If any of these details are missing or unclear:
                    - For the start_date: If the user doesn't provide it, ask if they would like to use {today} or specify a preferred start date.
                    - For the end_date: If the user only provides the number of days, calculate the end_date based on {today} or the provided start_date. 
                      If no start_date is provided, ask the user to specify a preferred date or default to today’s date.
                    - If the user does not provide a budget currency, assume "USD" by default, unless stated otherwise.
                    
                    Step 3: Once all details are gathered:
                    - Confirm the travel preferences with the user (origin, destination, start_date, end_date, budget).
                    - If there is any ambiguity, ask the user to confirm.
                    
                    Step 4: Send the data to the respective agents:
                    - `flight_agent` for flight suggestions
                    - `hotel_agent` for hotel suggestions
                    
                    Step 5:  Present a final resullts combining the results from both agents and a day plan including:
                    - Trip summary with all details (origin, destination, start date, end date, budget)
                    - Note that maximum budget should be used for flight and hotel suggestions. it should not be exceeded when combined.
                    - Flight suggestions
                    - Hotel suggestions
                    - Total estimated cost
                    - A suggested day plan for the trip, including activities and places to visit in the destination.
                    
                    Be concise, clear, and friendly in guiding the user. If you encounter any missing information, ask the user for clarification.
                 """,
    sub_agents=[flight_agent, hotel_agent]
)

root_agent = coordinator_agent