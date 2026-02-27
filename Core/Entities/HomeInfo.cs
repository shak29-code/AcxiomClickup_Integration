using System.Collections.Generic;

namespace AcxiomClickup.Core.Entities;

public class HomeInfo
{
    public string? Title { get; set; }
    public string? Message { get; set; }
    public List<TaskItem> Tasks { get; set; } = new();
}
