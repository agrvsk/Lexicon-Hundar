﻿//using System.ComponentModel.DataAnnotations;

namespace Hundar.Web.Models;

public class Breed
{
    public int Id { get; set; }

    public int BreedType { get; set; }

    public string BreedName { get; set; } = null!;

    public string? Description { get; set; }



}
