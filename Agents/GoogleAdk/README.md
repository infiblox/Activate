# Agent Development Kit (ADK)

This repository contains examples for learning Google's Agent Development Kit (ADK), a powerful framework for building LLM-powered agents.

## Getting Started

### Setup Environment

You only need to create one virtual environment for all examples in this course. Follow these steps to set it up:

# Create virtual environment in the root directory
Navigate to Agents\GoogleAdk folder

Run the below command

    python -m venv .venv

# Activate (each new terminal)

# Windows CMD:
.venv\Scripts\activate.bat

# Install dependencies
pip install -r requirements.txt
```

Once set up, this single environment will work for all examples in the repository.

### Setting Up API Keys

1. Create an account in Google Cloud - https://cloud.google.com/?hl=en   (Sign in with your Google account if not signed in)
    - Go to the Console menu (top right).
    - Create a new project :
      Click -> "Select a project" which opens a popup.  Give a Project Name ex: Active.
2. Create an API key - https://aistudio.google.com/apikey
        - Click on "Create API Key"
        - Do Not select any popup optins - "Use Google AI studio" or "Build with Gemini API"
        - Accept the Terms of Service and Privacy Policy.
        - Assign the key to the project created in https://cloud.google.com/?hl=en
        - Your API key will be generated and shown on the screen. Copy and save it.

Each example folder contains a `.env.example` file. For each project you want to run:

1. Navigate to the example folder
2. Rename `.env.example` to `.env` 
3. Open the `.env` file and replace the placeholder with your API key:
   ```
   GOOGLE_API_KEY=your_api_key_here
   ```

You'll need to repeat this for each example project you want to run.

## Examples Overview

Here's what you can learn from each example folder:

### Lab01-BasicAgent
Introduction to the simplest form of ADK agents. Learn how to create a basic agent that can respond to user queries.

### Lab02-AgentwithToolsNFunctions
Learn how to enhance agents with tools that allow them to perform actions beyond just generating text.

### Lab03-LiteLLMAgent
Example of using LiteLLM to abstract away LLM provider details and easily switch between different models.

### Lab04-Structured Outputs
Learn how to use Pydantic models with `output_schema` to ensure consistent, structured responses from your agents.

## Official Documentation

For more detailed information, check out the official ADK documentation:
- https://google.github.io/adk-docs/get-started/quickstart

