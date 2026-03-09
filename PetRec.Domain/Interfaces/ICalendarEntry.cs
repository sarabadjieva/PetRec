namespace PetRec.Core.Interfaces;

public interface ICalendarEntry
{
    uint Id { get; set; }
    uint PetId { get; set; }
    DateTime? DateAndTime { get; set; }
    string Description { get; set; }
}