using PetRec.Core.Interfaces;

namespace PetRec.Mobile.Calendar;

public class CalendarEntry : ICalendarEntry
{
    public uint Id { get; set; }
    public uint PetId { get; set; }
    public DateTime? DateAndTime { get; set; }
    public string Description { get; set; } = string.Empty;
}

public class CalendarEntryViewModel(ICalendarEntry entry)
    : ICalendarEntry
{
    public uint Id => entry.Id;
    public uint PetId => entry.PetId;
    public DateTime? DateAndTime => entry.DateAndTime;
    public string Description => entry.Description;
}