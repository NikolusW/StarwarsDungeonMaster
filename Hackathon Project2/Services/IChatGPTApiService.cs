using Microsoft.AspNetCore.Mvc;

namespace Hackathon_Project2.Services
{
    public interface IChatGPTApiService
    {
        Task<string> UseChatGPT(string query);
    }
}