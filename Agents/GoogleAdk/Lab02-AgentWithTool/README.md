## What is a Tool?

In the context of ADK, a Tool represents a specific capability provided to an AI agent, enabling it to perform actions and interact with the world beyond its core text generation and reasoning abilities. What distinguishes capable agents from basic language models is often their effective use of tools.

Technically, a tool is typically a modular code component—like a Python/ Java function, a class method, or even another specialized agent—designed to execute a distinct, predefined task. These tasks often involve interacting with external systems or data.

## Key Characteristics
Action-Oriented: Tools perform specific actions, such as:

 - Querying databases
 - Making API requests (e.g., fetching weather data, booking systems)
 - Searching the web
 - Executing code snippets
 - Retrieving information from documents (RAG)
 - Interacting with other software or services

** Extends Agent capabilities: **  They empower agents to access real-time information, affect external systems, and overcome the knowledge limitations inherent in their training data.

Execute predefined logic: Crucially, tools execute specific, developer-defined logic. They do not possess their own independent reasoning capabilities like the agent's core Large Language Model (LLM). The LLM reasons about which tool to use, when, and with what inputs, but the tool itself just executes its designated function.

More detail on Tools https://google.github.io/adk-docs/tools/#what-is-a-tool
