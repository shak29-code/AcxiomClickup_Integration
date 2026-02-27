using System;
using System.Collections.Generic;

namespace AcxiomClickup.Core.Entities;

public class TaskItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Assignee { get; set; }
    public string? Status { get; set; }
    public int Priority { get; set; }
    public DateTime? DueDate { get; set; }
    public List<Comment> Comments { get; set; } = new();
}
