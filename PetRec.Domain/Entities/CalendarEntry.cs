using PetRec.Core.Interfaces;

namespace PetRec.Core.Entities;

public class CalendarEntry : ICalendarEntry
{
    public uint Id { get; set; }
    public uint PetId { get; set; }
    public DateTime? DateAndTime { get; set; }
    public string Description { get; set; } = string.Empty;
}
