using Microsoft.AspNetCore.Mvc;
//using OpenAI_API.Completions;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Models;
using SharpTrooper.Entities;
using System.Collections.Immutable;

namespace Hackathon_Project2.Services
{
    /*
    public IList<ChatMessage> messages = new List<ChatMessage>()
    {
        new ChatMessage()
            {
                Role = ChatMessageRole.System,
                Content = "\"You are a Dungeon Master for a star wars themed Dungeons and Dragons like game. First ask the player for some general information on the players. After that, you will decribe a scenario and allow the players to respond with what they want to do, and you will ask them to roll when needed, and tell the player when a roll is expected. Only respond as the DM, allow me to respond as the players\""
            }
    };
    */
    public class ChatGPTApiService : IChatGPTApiService
    {
        
        // current problem this message list is constantly getting reset
        private IList<ChatMessage> messages = new List<ChatMessage>()
        {
            new ChatMessage()
            {
                Role = ChatMessageRole.System,
                Content = "You are a Dungeon Master for a star wars themed Dungeons and Dragons like game. You will describe a scenario and allow the player to respond with what they want to do, " +
                "and you will ask them to roll when needed, and tell the player when a roll is expected." +
                " Only respond as the DM, allow me to respond as the player. Do not speak for the players and keep" +
                "your responses limited to 4 sentences."
            }
        };

        //public IList<ChatMessage> messages;

        public async Task<string> UseChatGPT(string query)
        {
            messages.Add(new ChatMessage()
            {
                Role = ChatMessageRole.User,
                Content = query
            });
            

            string OutPutResult = "";
            var api = new OpenAIAPI(new APIAuthentication(""));
            var chat = api.Chat.CreateConversation();


            var result = await api.Chat.CreateChatCompletionAsync(new OpenAI_API.Chat.ChatRequest()
            {
                Model = Model.ChatGPTTurbo,
                Messages = messages
            });

            var reply = result.Choices[0].Message.Content;
            messages.Add(new ChatMessage()
            {
                Role = ChatMessageRole.User,
                Content = reply
            });
            return reply;



            //chat.AppendSystemMessage(query);
            //OutPutResult = await chat.GetResponseFromChatbot();
            
            /*
            CompletionRequest completionRequest = new CompletionRequest();
            completionRequest.Prompt = query;
            completionRequest.Model = OpenAI_API.Models.Model.ChatGPTTurbo;

            var completions = openai.Completions.CreateCompletionAsync(completionRequest);

            foreach (var completion in completions.Result.Completions)
            {
                OutPutResult += completion.Text;
            }
            */

            //return OutPutResult;
        }

        
    }
}
