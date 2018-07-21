using DevOps.Portal.Application.SolutionCreation;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace DevOps.Portal.Web.Hubs
{
    [HubName("solutioncreator")]
    public class SolutionCreationHub : Hub
    {
        public string StartConnection()
        {
            return Context.ConnectionId;
        }

        public void UpdateProgress(CreateSolutionModel model, string message)
        {
            Clients.Client(model.ConnectionId).progress(model);
        }
    }
}