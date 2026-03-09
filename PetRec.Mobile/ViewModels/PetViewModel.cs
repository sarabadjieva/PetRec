using PetRec.Core.Enums;
using PetRec.Core.Interfaces;

namespace PetRec.Mobile.ViewModels;

public class PetViewModel
{
    private readonly IPet pet;

    public uint Id => pet.Id;
    public string Name => pet.Name;
    public PetType PetType => pet.Type;
    public ImageSource? Image => !string.IsNullOrWhiteSpace(pet.ImagePath)
        ? ImageSource.FromFile(pet.ImagePath)
        : null;

    public PetViewModel(IPet pet)
    {
        this.pet = pet;
    }
}
