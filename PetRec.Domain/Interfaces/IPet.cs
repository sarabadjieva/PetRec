using PetRec.Core.Enums;

namespace PetRec.Core.Interfaces;

public interface IPet
{
    uint Id { get; }
    string Name { get; }
    PetType Type { get; }
    DateTime? BirthDate { get; }
    string ImagePath { get; }
}
