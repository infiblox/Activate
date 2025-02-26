import os
from dotenv import load_dotenv
from langchain_openai.chat_models import ChatOpenAI
from langchain_core.output_parsers import StrOutputParser
from langchain_core.prompts import PromptTemplate

load_dotenv()
OPENAI_API_BASE = os.getenv("OPENAI_API_BASE")
MODEL = os.getenv("LMMODEL")

llm_model = ChatOpenAI(openai_api_base=OPENAI_API_BASE, model=MODEL)

template = """What is the capital of {country}"""

prompt = PromptTemplate.from_template(template)
chain = prompt | llm_model 
result = chain.invoke(input="India")

print("Response from Model without parsing : \n\n" , result)

print("\n\n")

parser = StrOutputParser()
chain = prompt | llm_model | parser
result = chain.invoke(input="India")

print("Response from Model after parsing : \n\n ", result)



