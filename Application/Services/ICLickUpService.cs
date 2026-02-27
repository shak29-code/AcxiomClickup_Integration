

namespace Application.Services
{
    public interface IClickUpService
    {
        Task<string> GetTeamID(string emailID, string action);
    }
}
