using Microsoft.AspNet.SignalR;
using GzyConcept.Core.Entities;

namespace GzyConcept.Hubs
{
    public class CommentHub : Hub
    {
        public void AddNewComment(Comment comment, SiteUser siteUser)
        {
            Clients.All.addNewComment();
        }
    }
}