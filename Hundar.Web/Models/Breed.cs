using System.ComponentModel.DataAnnotations;

namespace Hundar.Web.Models;

public class Breed
{
    public int Id { get; set; }

    [Display(Name = "Breedtype", Prompt ="Enter breedtype(1-10)" )]
    [Required(ErrorMessage = ("Breedtype is required"))]
    [Range(1,10,ErrorMessage =("Breedtype 1-10"))]
    public int BreedType { get; set; }

    [Display(Name ="Breedname", Prompt ="Enter breedname")]
    [Required(ErrorMessage = ("Breedname is required"))]
    public string BreedName { get; set; }

    [Display(Name ="Description", Prompt = "Enter a Description")]
    public string? Description { get; set; }



}
