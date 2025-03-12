import os
from dotenv import load_dotenv
from langchain_openai import ChatOpenAI
from langchain_core.prompts import PromptTemplate
from langchain_core.output_parsers import StrOutputParser

# Load environment variables from .env file
load_dotenv()

# Retrieve OpenAI API configurations
OPENAI_API_BASE = os.getenv("OPENAI_API_BASE")
MODEL_NAME = os.getenv("LMMODEL")

# Validate required environment variables
if not OPENAI_API_BASE or not MODEL_NAME:
    raise ValueError("Missing required environment variables: OPENAI_API_BASE or LMMODEL.")

llm = ChatOpenAI(openai_api_base=OPENAI_API_BASE, model=MODEL_NAME)

# Define a prompt template
prompt_template = PromptTemplate.from_template("Give me a motivational quote about {theme}.")

# Create a processing chain
quote_chain = prompt_template | llm | StrOutputParser()

def generate_quote(theme: str):
    try:
        print("\nGenerating motivational quote...\n")
        for token in quote_chain.stream({"theme": theme}):
            print(token, end="", flush=True)
        print("\n")  
    except Exception as e:
        print(f"\nError occurred: {e}")

if __name__ == "__main__":
    theme_input = "human"  
    generate_quote(theme_input)
