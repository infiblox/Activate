import os
from dotenv import load_dotenv
from langchain_openai.chat_models import ChatOpenAI
from langchain_core.output_parsers import StrOutputParser
from langchain_core.prompts import PromptTemplate

load_dotenv()
OPENAI_API_BASE = os.getenv("OPENAI_API_BASE")
MODEL = os.getenv("LMMODEL")

llm_model = ChatOpenAI(openai_api_base=OPENAI_API_BASE, model=MODEL)

prompt = PromptTemplate.from_template("""Translate the text {text} from English to Spanish""")
chain = prompt | llm_model | StrOutputParser()
result = chain.invoke(input="How are you?")

print("Response  : \n\n" , result)
