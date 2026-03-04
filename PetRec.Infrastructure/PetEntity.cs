using PetRec.Domain;
using SQLite;

namespace PetRec.Infrastructure;

[Table("Pets")]
public class PetEntity
{
    [PrimaryKey, AutoIncrement]
    public uint Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public PetType Type { get; set; }

    public DateTime? BirthDate { get; set; }
}