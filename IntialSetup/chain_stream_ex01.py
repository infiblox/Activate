import os
from dotenv import load_dotenv

from langchain_openai import ChatOpenAI
from langchain_core.prompts import PromptTemplate
from langchain_core.output_parsers import StrOutputParser

# Instantiate the ChatOpenAI model.
load_dotenv()
OPENAI_API_BASE = os.getenv("OPENAI_API_BASE")
MODEL = os.getenv("LMMODEL")


llm_model = ChatOpenAI(openai_api_base=OPENAI_API_BASE, model=MODEL)

# Create a prompt template that asks for jokes on a given topic.
prompt = PromptTemplate.from_template("Describe the {topic} in 3 sentences.")

# Connect the prompt and model to create a conversation chain.
chain = prompt | llm_model | StrOutputParser()

# Use the chain.stream method to create a stream of data for a given topic, iterating over it and immediately outputting the content of each piece of data. 

for token in chain.stream({"topic": "multimodal"}):
    # Output the content of each piece of data without newlines.
    print(token, end="", flush=True)
