using System.Text.Json.Serialization;

namespace Application.Models
{
    internal class TeamDetails
    {
        [JsonPropertyName("teams")]
        public List<Team>? Teams { get; set; }
    }

    public class Team
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("color")]
        public string? Color { get; set; }

        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        [JsonPropertyName("members")]
        public List<Member>? Members { get; set; }
    }

    public class Member
    {
        [JsonPropertyName("user")]
        public User? User { get; set; }

        [JsonPropertyName("invited_by")]
        public InvitedBy? InvitedBy { get; set; }
    }

    public class User
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("color")]
        public string? Color { get; set; }

        [JsonPropertyName("profilePicture")]
        public string? ProfilePicture { get; set; }

        [JsonPropertyName("initials")]
        public string? Initials { get; set; }

        [JsonPropertyName("role")]
        public int Role { get; set; }

        [JsonPropertyName("role_subtype")]
        public int RoleSubtype { get; set; }

        [JsonPropertyName("role_key")]
        public string? RoleKey { get; set; }

        [JsonPropertyName("custom_role")]
        public string? CustomRole { get; set; }

        [JsonPropertyName("last_active")]
        public string? LastActive { get; set; }

        [JsonPropertyName("date_joined")]
        public string? DateJoined { get; set; }

        [JsonPropertyName("date_invited")]
        public string? DateInvited { get; set; }
    }

    public class InvitedBy
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyName("color")]
        public string? Color { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("initials")]
        public string? Initials { get; set; }

        [JsonPropertyName("profilePicture")]
        public string? ProfilePicture { get; set; }

        [JsonPropertyName("banned_date")]
        public string? BannedDate { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}

