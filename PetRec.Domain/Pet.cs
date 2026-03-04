using System.Runtime.Serialization;

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

[DataContract]
public class Pet : IExtensibleDataObject
{
    public ExtensionDataObject? ExtensionData { get; set ; }
    
    [DataMember]
    public uint Id { get; set; }

    [DataMember]
    public string Name { get; set; } = "Ündefined";

    [DataMember]
    public PetType Type { get; set; }

    public DateTime? BirthDate { get; set; }
}
