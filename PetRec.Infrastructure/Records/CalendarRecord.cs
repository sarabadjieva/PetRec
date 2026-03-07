using PetRec.Application;
using PetRec.Domain;
using SQLite;

namespace PetRec.Infrastructure.Records;

[Table("Calendar")]
internal class CalendarRecord : IDatabaseRecord, ICalendarEntry
{
    [PrimaryKey, AutoIncrement]
    public uint Id { get; set; }

    public uint PetId { get;set; }

    public DateTime? DateAndTime { get; set; }

    public string Description { get; set; } = string.Empty;
}
