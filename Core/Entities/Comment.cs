using System;

namespace AcxiomClickup.Core.Entities;

public class Comment
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Author { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
