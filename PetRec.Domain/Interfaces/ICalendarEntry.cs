namespace PetRec.Core.Interfaces;

public interface ICalendarEntry
{
    uint Id { get; }
    uint PetId { get; }
    DateTime? DateAndTime { get; }
    string Description { get; }
}