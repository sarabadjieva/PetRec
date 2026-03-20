using PetRec.Core.Enums;
using PetRec.Core.Interfaces;

namespace PetRec.Mobile.Main;

public class Pet : IPet
{
    public uint Id { get; set; }
    public string Name { get; set; } = "Undefined";
    public PetType Type { get; set; }
    public DateTime? BirthDate { get; set; }

    // TODO test
    public string ImagePath { get; set; } = "dotnet_bot.png";
}

public class PetViewModel(IPet pet)
    : IPet
{
    public uint Id => pet.Id;
    public PetType Type => pet.Type;
    public string Name => pet.Name;
    public DateTime? BirthDate => pet.BirthDate;
    public string ImagePath => pet.ImagePath;

    public ImageSource? Image => !string.IsNullOrWhiteSpace(pet.ImagePath)
        ? ImageSource.FromFile(pet.ImagePath)
        : null;
}
