using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class React
{
    public string Id { get; set; } = null!;

    public bool Isactive { get; set; }

    public DateTime? Createtime { get; set; }

    public string? Postid { get; set; }

    public string Userid { get; set; } = null!;

    public string? Commentid { get; set; }

    public virtual Comment? Comment { get; set; }

    public virtual Post? Post { get; set; }

    public virtual User User { get; set; } = null!;
}
