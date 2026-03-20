using PetRec.Core.Interfaces;
using PetRec.Infrastructure.Records;

namespace PetRec.Infrastructure.Repositories;

public interface ICalendarRepository : IRepository<ICalendarEntry>
{
}

internal class CalendarRepository(IDatabase db)
    : RepositoryBase<ICalendarEntry, CalendarRecord>(db), ICalendarRepository
{
    protected override CalendarRecord ToRecord(ICalendarEntry domain) =>
    new() 
    {
        //Id = domain.Id,
        PetId = domain.PetId,
        DateAndTime = domain.DateAndTime,
        Description = domain.Description
    };
}
