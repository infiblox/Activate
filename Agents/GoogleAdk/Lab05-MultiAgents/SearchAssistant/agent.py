from google.adk.agents import SequentialAgent, Agent
from google.adk.tools import agent_tool
from .subagents.search_agent import searchAgent
from .subagents.summary_agent import summaryAgent


searchAndSummarizeAgent = SequentialAgent(
    name="SearchAndSummarizeAgent",
    sub_agents=[searchAgent, summaryAgent],
    description="An agent that first searches for information and then summarizes the findings.")

search_tool = agent_tool.AgentTool(agent=searchAgent)
summary_tool = agent_tool.AgentTool(agent=summaryAgent)
search_summary_tool = agent_tool.AgentTool(agent=searchAndSummarizeAgent)   


root_agent = Agent(
    model="gemini-2.0-flash",
    name="RootOrchestrator",
    description="Receives user requests and coordinates specialized agents.",
    instruction="""
    Decide which tool to use based on the user query:
    - If the user just wants quick info, use WebSearchAgent.
    - If the user wants a concise answer from online info, use SearchThenSummarizeWorkflow.
    - If the user provides text to shorten, use SummaryAgent.
    Return the final result to the user.
    """,
    tools=[search_tool, summary_tool, search_summary_tool]
)
