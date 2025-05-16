using Hundar.Web.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Hundar.Web.Services;

public class BreedService
{

    /* Rasgrupper
    1 Grupp 1 - Vall-, boskaps- och herdehundar
    2 Grupp 2 - Schnauzer och pinscher, molosser och bergshundar samt sennenhundar
    3 Grupp 3 - Terrier
    4 Grupp 4 - Taxar
    5 Grupp 5 - Spetsar och raser av urhundstyp
    6 Grupp 6 - Drivande hundar samt sök- och spårhundar
    7 Grupp 7 - Stående fågelhundar
    8 Grupp 8 - Stötande hundar, apporterande hundar och vattenhundar
    9 Grupp 9 - Sällskapshundar
   10 Grupp 10 - Vinthundar
     
    */
    List<Breed> breeds = [
    new Breed() { Id=10 , BreedType=1, BreedName="Collie, långhårig", Description="Massa mjuk päls, elegant, lättlärd och gillar aktiviteter" },
    new Breed() { Id=09 , BreedType=1, BreedName="Vit herdehud", Description="Livlig, lättlärd sällskapshund med behov av aktivitet" },
    new Breed() { Id=08 , BreedType=1, BreedName="Tysk schäferhund", Description="Samarbetsvillig, livlig och uppmärksam jobbkompis" },

    new Breed() { Id=23 , BreedType=2, BreedName="Boxer", Description="Alert, arbetsvillig och livsglad bästa vän" },
    new Breed() { Id=23 , BreedType=2, BreedName="Grand danois", Description="Trofast, stor, stark och pampig" },
    new Breed() { Id=23 , BreedType=2, BreedName="Leonberger", Description="Behaglig och följsam med behov av fast hand" },

    new Breed() { Id=36 , BreedType=3, BreedName="Bedlingtonterrier", Description="Annorlunda utseende, charmig med stark vilja." },

    new Breed() { Id=47 , BreedType=4, BreedName="Tax", Description="Vänlig, envis och uthållig trots sina korta ben" },

    new Breed() { Id=05 , BreedType=5, BreedName="Tysk spets/mittelspitz", Description="Livlig, lättlärd pälsboll som hänger med" },

    new Breed() { Id=66 , BreedType=6, BreedName="Basset hound", Description="Social, tillgiven kortbent spårexpert" },
    new Breed() { Id=66 , BreedType=6, BreedName="Beagle", Description="Envis, arbetsvillig och glad" },

    new Breed() { Id=71 , BreedType=7, BreedName="Engelsk setter", Description="Energisk och krävande med passion för fågeljakt" },

    new Breed() { Id=33 , BreedType=8, BreedName="Golden retriever", Description="Vänlig och aktiv med stor passion för vatten" },
    new Breed() { Id=33 , BreedType=8, BreedName="Labrador retriever", Description="Social och stark apportör som är duktig på det mesta" },

    new Breed() { Id=11 , BreedType=9, BreedName="Chihuahua, korthårig", Description="Liten och sällskaplig hund som kan ta ton (vill inte bli uppäten!)" },

    new Breed() { Id=14 , BreedType=10, BreedName="Afghanhund", Description="Självständig skönhet med böljande päls." },

    new Breed() { Id=12 , BreedType=10, BreedName="Greyhound", Description="Vänlig, envis, stor och specialist på kapplöpning." },


    ];
    static int nextId = 71;

    public Breed[] getAllBreeds()
    {
        return breeds.OrderBy(o => o.BreedName).ToArray();
    }

    public Breed getBreedById(int id)
    {
        return breeds.Single(o => o.Id == id);
    }

    public void addBreed(Breed breed)
    {
        if (breed.Id < nextId)
            breed.Id = nextId++;
        breeds.Add(breed);
    }
}
