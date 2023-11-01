using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class PetBreed
{
    public string Id { get; set; } = null!;

    public string? Breedname { get; set; }

    public string Postid { get; set; } = null!;

    public string PetType { get; set; } = null!;

    public virtual Post Post { get; set; } = null!;
}
