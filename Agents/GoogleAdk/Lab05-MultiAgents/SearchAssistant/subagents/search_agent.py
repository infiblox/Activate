from google.adk.agents import Agent
from google.adk.tools import google_search

searchAgent = Agent(
    name="WebSearchAgent",
    model="gemini-2.0-flash",
    description="Find information on the internet using Google Search.",
    instruction="Use the google_search tool to find accurate, up-to-date information.",
    tools=[google_search]
)
