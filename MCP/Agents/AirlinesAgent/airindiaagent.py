import asyncio
from dotenv import load_dotenv
from langchain_ollama import ChatOllama
from mcp_use import MCPAgent, MCPClient

async def main():
    """Run the example using a configuration file."""
    # Load environment variables
    load_dotenv()

    config = {
        "mcpServers": {
            "AirlineServices": {
                "url": "http://localhost:5080/sse"
            },
        }
    }

    # Create MCPClient from config file
    client = MCPClient.from_dict(config)

    # Create LLM
    llm = ChatOllama(model="llama4")

    # Prompt for the LLM
    prompt = """ You are a helpful assistant with access to tools that call external APIs.  
        Your goal is to always use the available tools to retrieve fresh and accurate information before answering the user’s query.  
        Instructions:  
            1. Parse the user’s query carefully to understand what information is required.  
            2. Call the appropriate tool to fetch results from the API.  
            3. Scan and analyze the results to extract the most relevant and correct answer.  
            4. Provide a clear, concise, and direct response to the user.  
            5. If the information is not available in the tool results, state that you could not find a definitive answer.  
          """

    # Create agent with the client
    agent = MCPAgent(llm=llm, client=client)


    #userqery = "Find the available flights for next 3 weeks?"
    # from New York to Bangalore on Air India and also cost of travel and available date?"
    userqery = "Find the flight booking for passenger John Doe "
    query = userqery

    # Run the query
    result = await agent.run(query)
    
    print(f"\nResult: {result}")


if __name__ == "__main__":
    # Run the appropriate example
    asyncio.run(main())