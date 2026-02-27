using AcxiomClickup.Application.Services;
using AcxiomClickup.Core.Entities;


namespace AcxiomClickup.Infrastructure.Services;

public class HomeService : IHomeService
{
    public Task<HomeInfo> GetHomeInfoAsync()
    {
        var tasks = new List<TaskItem>
        {
            new TaskItem
            {
                Title = "Design landing page",
                Description = "Create responsive landing page for marketing and signup.",
                Assignee = "Alice",
                Status = "In Progress",
                Priority = 2,
                DueDate = DateTime.UtcNow.AddDays(5),
                Comments = new List<Comment>
                {
                    new Comment { Author = "Bob", Text = "Love the hero section, consider bigger CTA." },
                    new Comment { Author = "Alice", Text = "I'll update the CTA color today." }
                }
            },
            new TaskItem
            {
                Title = "Integrate OAuth",
                Description = "Add OAuth login with Google and Microsoft.",
                Assignee = "Carlos",
                Status = "Todo",
                Priority = 1,
                DueDate = DateTime.UtcNow.AddDays(14),
                Comments = new List<Comment>
                {
                    new Comment { Author = "Eve", Text = "Remember to store provider id mapping." }
                }
            },
            new TaskItem
            {
                Title = "Setup CI/CD",
                Description = "Configure GitHub Actions to build and deploy to Azure.",
                Assignee = "Dana",
                Status = "Review",
                Priority = 3,
                DueDate = DateTime.UtcNow.AddDays(2),
            }
        };

        var info = new HomeInfo
        {
            Title = "Tasks",
            Message = "Project tasks — interactive task cards with comments.",
            Tasks = tasks
        };

        return Task.FromResult(info);
    }
}
