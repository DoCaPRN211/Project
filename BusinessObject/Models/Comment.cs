using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Comment
{
    public string Id { get; set; } = null!;

    public string Content { get; set; } = null!;

    public bool Isactive { get; set; }

    public DateTime? Createtime { get; set; }

    public string Postid { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public virtual Post Post { get; set; } = null!;

    public virtual ICollection<React> Reacts { get; set; } = new List<React>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual User User { get; set; } = null!;
}
