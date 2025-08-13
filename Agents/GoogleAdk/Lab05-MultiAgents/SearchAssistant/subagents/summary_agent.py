from google.adk.agents import Agent

summaryAgent = Agent(
    model="gemini-2.0-flash",
    name="SummaryAgent",
    description="Summarize text into a concise, clear answer.",
    instruction="Take the search results and summarize them into a short, factual paragraph."
)