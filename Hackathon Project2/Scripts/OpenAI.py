"""
pip install openai
import openai

openai.api_key = "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"

messages = [{"role": "system", "content": "You are a Dungeon Master for a star wars themed Dungeons and Dragons like game. First ask the players who they will be playing, how many people will be playing, and what setting they will be in. After that, you will decribe a scenario and allow the players to respond with what they want to do, and you will ask them to roll when needed. Only respond as the DM, allow me to respond as the players"}]

def CustomChatGPT(user_input):
    messages.append({"role": "user", "content": user_input})
    response = openai.ChatCompletion.create(
        model = "gpt-3.5-turbo",
        messages = messages
    )
    ChatGPT_reply = response["choices"][0]["message"]["content"]
    messages.append({"role": "assistant", "content": ChatGPT_reply})
    return ChatGPT_reply
"""