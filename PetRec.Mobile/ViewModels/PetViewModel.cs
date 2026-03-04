using PetRec.Domain;

namespace PetRec.Mobile.ViewModels;

public class PetViewModel
{
    private readonly Pet pet;

    public uint Id => pet.Id;
    public string Name => pet.Name;
    public PetType PetType => pet.Type;

    public PetViewModel(Pet pet)
    {
        this.pet = pet;
    }
}
