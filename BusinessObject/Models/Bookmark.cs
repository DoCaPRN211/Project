using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Bookmark
{
    public string Postid { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public int Id { get; set; }

    public DateTime? Createtime { get; set; }

    public bool Isactive { get; set; }

    public virtual Post Post { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
