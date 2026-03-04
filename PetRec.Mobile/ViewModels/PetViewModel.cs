using PetRec.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetRec.Mobile.ViewModels;

public class PetViewModel
{
    private readonly Pet pet;

    public uint Id => pet.Id;
    public string Name => pet.Name ?? "Unknown";
    PetType PetType => pet.Type;

    public PetViewModel(Pet pet)
    {
        this.pet = pet;
    }
}
