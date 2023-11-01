using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class User
{
    public string Id { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime? Dob { get; set; }

    public bool Gender { get; set; }

    public bool Isactive { get; set; }

    public bool Isban { get; set; }

    public string Role { get; set; } = null!;

    public virtual ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual ICollection<React> Reacts { get; set; } = new List<React>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
