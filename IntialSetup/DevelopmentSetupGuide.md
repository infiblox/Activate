**Laptop Configuration** 
======================

RAM
    Minimum 8 GB 
    Recommended 16 GB and above 
DISK SPACE  
    100 GB Free Space 

**Software Requirements**
=========================

Download and Install Visual Studio Code for Python Development 
URL: https://code.visualstudio.com/

Download and Install LM Studio to run the LLM Models locally 
URL: https://lmstudio.ai/

Download Python Latest Libraries 
URL: https://www.python.org

**If you getting this error (Make sure you configure your user.name and user.email in git) while commit/sync with remote git repo, do the following** 
git config --global user.name "John Doe"
git config --global user.email "johndoe@email.com"


**First Program Setup Guide**
====================================

* Step 1 : Install Python Latest Version (URL: https://www.python.org/)

* Step 2 : Install VS Code (URL:  https://code.visualstudio.com/)

* Step 3 : Install LM Studio (URL: https://lmstudio.ai/)

* Step 4 : Start LM Studio with a Model (Meta Llama 3 / any compatible model) 

* Step 5 : Create a folder in VS Code and start hello world program 

* Step 6 : Sample Program Setup 

* a. Create .env file and add below Keys

        OPENAI_API_KEY=lm-studio
        OPENAI_API_BASE=http://localhost:8088/v1
        Note: The above url is from the configuration section from LMStudio. By default, the port will 1234. 
		
* b. Create requirements.txt file and add the below libraries

	    python-dotenv
        langchain
        langchain-community
        langchain-openai
        
* c. Import the libraries based on requirements.txt file 
        
        ctrl + shift + p 
        create python environment 
        select .venv
        select python path 
        import will begin 
        you may get error based on libraries or packages
        
        once environment is created,then proceed with step d
            
* d. Create HelloWorld.py file 
            
        import os
        from dotenv import load_dotenv
        from langchain_openai.chat_models import ChatOpenAI
        from langchain_core.output_parsers import StrOutputParser
        from langchain_core.prompts import PromptTemplate

        load_dotenv()
        OPENAI_API_BASE = os.getenv("OPENAI_API_BASE")
        MODEL = "lmstudio-community/Meta-Llama-3-8B-Instruct-GGUF"
        llm_model = ChatOpenAI(openai_api_base=OPENAI_API_BASE, model=MODEL)
        template = """What is the capital of {country}"""

        prompt = PromptTemplate.from_template(template)
        chain = prompt | llm_model 
        result = chain.invoke(input="India")
        print(result)
    
        parser = StrOutputParser()
        chain = prompt | llm_model | parser
        result = chain.invoke(input="India")
        print(result)
