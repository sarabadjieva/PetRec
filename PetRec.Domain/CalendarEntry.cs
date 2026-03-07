namespace PetRec.Domain;

public interface ICalendarEntry
{
    uint Id { get; set; }
    uint PetId { get; set; }
    DateTime? DateAndTime { get; set; }
    string Description { get; set; }
}

public class CalendarEntry : ICalendarEntry
{
    public uint Id { get; set; }

    public uint PetId { get; set; }

    public DateTime? DateAndTime { get; set; }

    public string Description { get; set; } = string.Empty;
}
