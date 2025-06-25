## Additional Goals 
Few Labs for additional learning. 

Each lab includes:
- 🎯 Goal
- 🛠️ What to Build
- 🔧 Instructions to Define
- 💬 Sample Prompts to Test

## Lab 1: Google Search Agent
- 🎯 Goal: Enable an agent to fetch web search results for any query.
- 🛠️ What to Build: Use the built-in google_search tool.
- 🔧 Instructions:
        Import google_search from google.adk.tools.
        Register it with an agent using the tools argument.
        Write the agent description indicating it uses Google search.
        Run prompts asking for current events, facts, or data.

💬 Sample Prompts:
        “Top 10 universities in the US”
        “Latest news on climate change”

## Lab 2: Current Time Agent
🎯 Goal: Build an agent that returns the current time or time in a specific timezone.
🛠️ What to Build: Custom tool that uses datetime.now() and pytz.
🔧 Instructions:
        Define a tool class with a method that returns the current time.
        Use datetime.now() and format the output.
        Register the tool with a meaningful name like get_current_time.
        Mention time format (e.g., YYYY-MM-DD HH:MM:SS) in the tool description.

💬 Sample Prompts:
        “What time is it now?”
        “Give me the current time in Tokyo”

## Lab 3: Joke Teller Agent
🎯 Goal: Deliver a random joke for entertainment.
🛠️ What to Build: A static tool returning a random joke from a list.
🔧 Instructions:
        Create a tool that returns a string from a predefined list of jokes.
        Use Python's random.choice().
        Register it as tell_joke or similar.
        Mention that it returns a clean, friendly joke.

💬 Sample Prompts:
    “Tell me a tech joke”
    “I need a laugh”

## Lab 4: Currency Converter Agent
🎯 Goal: Convert currency amounts using mock or live exchange rates.
🛠️ What to Build: A tool that parses input and applies a conversion rate.
🔧 Instructions:
        Use a dictionary of static conversion rates or integrate a currency API.
        Parse input for amount, source, and target currency.
        Return the converted value as a string.
        Name it currency_converter.

💬 Sample Prompts:
        “Convert 100 USD to INR”
        “What is 50 Euros in Yen?”

## Lab 5: To-Do Manager Agent
🎯 Goal: Manage a simple list of tasks using an in-memory list.
🛠️ What to Build: A tool that supports adding, listing, and removing tasks.
🔧 Instructions:
        Create a class with a task list stored in memory.
        Handle three operations: add, list, and remove.
        Parse input for intent (e.g., using basic keyword checks).
        Register as todo_manager.

💬 Sample Prompts:
        “Add ‘buy milk’ to my to-do list”
        “Show my tasks”
        “Remove ‘buy milk’”

## Lab 6: Fun Facts Agent
🎯 Goal: Return a random or topic-based fun fact.
🛠️ What to Build: A tool that selects a fact from a list.
🔧 Instructions:
        Create a dictionary of categories (e.g., space, science).
        Use random.choice() to return facts.
        Allow optional keyword/topic in input.
        Register the tool as fun_fact_provider.

💬 Sample Prompts:
        “Give me a random fun fact”
        “Tell me a fact about animals”

## Lab 7: Calculator Agent
🎯 Goal: Safely evaluate math expressions and return results.
🛠️ What to Build: A calculator tool using eval() (with care) or numexpr.
🔧 Instructions:
        Parse and sanitize user input.
        Support basic math: +, -, *, /, %, **.
        Return results in a formatted string.
        Register as calculator_tool.

💬 Sample Prompts:
        “What is 25 + 17?”
        “Calculate 20% of 500”

## Lab 8: Language Translator Agent
🎯 Goal: Translate a phrase from English to another language.
🛠️ What to Build: A mock translation tool or use a free translation API.
🔧 Instructions:
        Parse input to identify target language.
        Return translated text using a predefined dictionary or API.
        Register it as translator_tool.

💬 Sample Prompts:
        “Translate ‘hello’ to French”
        “Say ‘thank you’ in German”

## Lab 9: Dictionary Lookup Agent
🎯 Goal: Define words and provide usage or synonyms.
🛠️ What to Build: A dictionary lookup tool using a static JSON file or dictionary API.
🔧 Instructions:
        Accept input word, return definition and optionally synonyms.
        Use a mock dictionary (e.g., {"synergy": "working together..."}).
        Register as dictionary_tool.

💬 Sample Prompts:
        “Define the word ‘synergy’”
        “What is the meaning of resilient?”

## Lab 10: Affirmation Agent
🎯 Goal: Deliver a motivational quote or positive affirmation.
🛠️ What to Build: A tool that returns quotes from a static list or API.
🔧 Instructions:
        Create a list of affirmations or quotes.
        Randomly return one or filter by category if provided.
        Register as affirmation_tool.

💬 Sample Prompts:
        “Give me a positive affirmation”
        “Motivate me to stay focused”

