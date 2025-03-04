import os
from dotenv import load_dotenv
import streamlit as sl
from langchain_openai import ChatOpenAI

load_dotenv()
OPENAI_API_BASE = os.getenv("OPENAI_API_BASE")
MODEL = os.getenv("LMMODEL")

sl.set_page_config(page_title="Chat Application")
sl.header("Chat Application") 
input_text=sl.chat_input("Add your prompt..")


llm_model = ChatOpenAI(openai_api_base=OPENAI_API_BASE, model=MODEL,temperature=0.7)

if input_text :
    sl.chat_message("user").write(input_text)
    output=llm_model.stream(input_text)

    ## sl.write(output.content)

    sl.write_stream(output)

