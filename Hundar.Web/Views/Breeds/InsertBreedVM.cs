﻿using System.ComponentModel.DataAnnotations;

namespace Hundar.Web.Views.Breeds;

public class InsertBreedVM
{
    public required int Id { get; set; }

    [Display(Name = "Breedtype", Prompt = "Enter breedtype(1-10)")]
    [Required(ErrorMessage = ("Breedtype is required"))]
    [Range(1, 10, ErrorMessage = ("Breedtype 1-10"))]
    public required int BreedType { get; set; }
 

    [Display(Name = "Breedname", Prompt = "Enter breedname")]
    [Required(ErrorMessage = ("Breedname is required"))]
    public required string BreedName { get; set; }


    [Display(Name = "Description", Prompt = "Enter a Description")]
    public required string? Description { get; set; }

    public required TypesVM[] BreedTypes { get; set; }
    public class TypesVM
    {
        public int Id { get; set; }
        public string BreedTypeName { get; set; } = null!;
    }
}
