import asyncio
from google.adk.tools.mcp_tool.mcp_toolset import MCPToolset
from google.adk.tools.mcp_tool.mcp_session_manager import SseConnectionParams
from google.adk.agents.llm_agent import LlmAgent
import nest_asyncio

nest_asyncio.apply()

async def build_agent_async():
    # Corrected instantiation
    mcp_toolset = MCPToolset(
        connection_params=SseConnectionParams(
            url="http://localhost:5080/sse"
        )
    )
    await mcp_toolset.async_initialize()
    tools = mcp_toolset.get_tools()

    print("Fetched tools:")
    for t in tools:
        print(f"- {t.name}")

    return LlmAgent(
        model="gemini-2.0-flash",
        name="AirlinesAgent",
        instruction="""
        You are an expert travel assistant specializing in airlines and flight information.
        Your task is to assist users with travel-related queries such as bookings, policies, baggage,
        and recommendations. Always use the Airlines Tool for real-time data.
        """,
        tools=tools
    )

# Expose root_agent for ADK
try:
    root_agent = asyncio.get_event_loop().run_until_complete(build_agent_async())
except RuntimeError:
    # If loop is already running, fallback alternative:
    import nest_asyncio
    nest_asyncio.apply()
    root_agent = asyncio.get_event_loop().run_until_complete(build_agent_async())
