namespace PetRec.Domain;

public enum PetType
{
    Other,
    Dog,
    Cat,
    Bird,
    Fish,
    Reptile
}

public interface IPet
{
    uint Id { get; set; }
    string Name { get; set; }
    PetType Type { get; set; }
    DateTime? BirthDate { get; set; }
}

public class Pet : IPet
{
    public uint Id { get; set; }
    public string Name { get; set; } = "Undefined";
    public PetType Type { get; set; }
    public DateTime? BirthDate { get; set; }
}
