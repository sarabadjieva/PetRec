using PetRec.Core.Enums;

namespace PetRec.Core.Interfaces;

public interface IPet
{
    uint Id { get; set; }
    string Name { get; set; }
    PetType Type { get; set; }
    DateTime? BirthDate { get; set; }
    string ImagePath { get; set; }
}
