from fastmcp import FastMCP
import os
from dotenv import load_dotenv
import requests

load_dotenv()

# Initialize MCP Server 

airline_services = FastMCP(name="AirlineServices")

@airline_services.tool()
async def search_flight():
    """
    Search for available flights based on user criteria.
    """
    
    serviceapi_url = "http://localhost:8080"

    response = requests.get(f"{serviceapi_url}/api/AirIndia/GetSearchFlights")
    
    print(f"Successfully retrieved item: {response}")

    # Check the response status code
    if response.status_code == 200:
        # Access the JSON response data
        item_data = response.json()
        print(f"Successfully retrieved item: {item_data}")
    else:
        print(f"Error retrieving item: {response.status_code} - {response.text}")
    
    return  {"responses" : item_data}


@airline_services.tool()
async def get_fightbooking():
    """
    Search for flight booking details.
    """
    
    serviceapi_url = "http://localhost:8080"

    response = requests.get(f"{serviceapi_url}/api/AirIndia/GetBookingDetails")
    
    print(f"Successfully retrieved item: {response}")

    # Check the response status code
    if response.status_code == 200:
        # Access the JSON response data
        item_data = response.json()
        print(f"Successfully retrieved item: {item_data}")
    else:
        print(f"Error retrieving item: {response.status_code} - {response.text}")
    
    return  {"responses" : item_data}





if __name__ == "__main__":
    # Set the port for the SSE server
    airline_services.run(transport="sse", host="0.0.0.0", port=5080)

