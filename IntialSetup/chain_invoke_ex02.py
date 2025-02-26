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

# Call the invoke method of the chain object, passing a dictionary with the topic 'ChatGPT'.
results = chain.invoke({"topic": "ChatGPT"})

print(results)