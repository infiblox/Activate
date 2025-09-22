import asyncio
from google.adk.tools.mcp_tool.mcp_toolset import MCPToolset
from google.adk.agents.llm_agent import LlmAgent

async def build_agent_async():
    """Factory function to create the agent with MCP tools."""
    mcp_toolset = MCPToolset(url="http://localhost:5080/sse")
    await mcp_toolset.async_initialize()
    tools = mcp_toolset.get_tools()

    print("Fetched tools:")
    for tool in tools:
        print(f"- {tool.name}")

    agent = LlmAgent(
        model="gemini-2.0-flash",
        name="AirlinesAgent",
        instruction="""   # <-- singular
            You are an expert travel assistant specializing in airlines and flight information.
            Your task is to assist users with travel-related queries such as bookings, policies,
            baggage, and recommendations. Always use the Airlines Tool for real-time data.
        """,
        tools=tools,
    )
    return agent

# Expose a synchronous entrypoint for ADK
def build_agent():
    return asyncio.get_event_loop().run_until_complete(build_agent_async())
