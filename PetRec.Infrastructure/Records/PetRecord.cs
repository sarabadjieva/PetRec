using PetRec.Application;
using PetRec.Domain;
using SQLite;

namespace PetRec.Infrastructure.Records;

[Table("Pets")]
internal class PetRecord : IDatabaseRecord, IPet
{
    [PrimaryKey, AutoIncrement]
    public uint Id { get; set; }

    public string Name { get; set; } = string.Empty;
    
    public PetType Type { get; set; }

    public DateTime? BirthDate { get; set; }
}