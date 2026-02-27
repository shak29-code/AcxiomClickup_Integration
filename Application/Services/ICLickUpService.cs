

namespace Application.Services
{
    internal interface IClickUpService
    {
        Task<string> GetTeamID(string emailID, string action);
    }
}
