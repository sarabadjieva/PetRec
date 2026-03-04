using System.Runtime.InteropServices.Marshalling;
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
    public string? Name { get; set; }

    [DataMember]
    public PetType Type { get; set; }

    [DataMember]
    public uint Age { get; set; }
}
