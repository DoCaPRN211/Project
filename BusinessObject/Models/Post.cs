using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Post
{
    public string Id { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public bool Isactive { get; set; }

    public DateTime? Createtime { get; set; }

    public string Userid { get; set; } = null!;

    public int Categoryid { get; set; }

    public virtual ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<PetBreed> PetBreeds { get; set; } = new List<PetBreed>();

    public virtual ICollection<React> Reacts { get; set; } = new List<React>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual User User { get; set; } = null!;
}
