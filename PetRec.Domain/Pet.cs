using System.Runtime.InteropServices.Marshalling;

namespace PetRec.Domain;

public class Pet
{
    uint Id { get; set; }
    string Name { get; set; }
    string Type { get; set; }
    uint Age { get; set; }
}
