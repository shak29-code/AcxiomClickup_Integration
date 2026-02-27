using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    internal interface ICLickUpService
    {

        Task<string> GetTeamID(string emailID, string action);
    }
}
