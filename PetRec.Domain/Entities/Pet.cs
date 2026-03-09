using PetRec.Core.Enums;
using PetRec.Core.Interfaces;

namespace PetRec.Core.Entities;

public class Pet : IPet
{
    public uint Id { get; set; }
    public string Name { get; set; } = "Undefined";
    public PetType Type { get; set; }
    public DateTime? BirthDate { get; set; }

    // TODO test
    public string ImagePath { get; set; } = "dotnet_bot.png";
}
