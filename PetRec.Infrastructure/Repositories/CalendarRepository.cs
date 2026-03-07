using PetRec.Application;
using PetRec.Domain;
using PetRec.Infrastructure.Records;

namespace PetRec.Infrastructure.Repositories;

public interface ICalendarRepository : IRepository<CalendarEntry>
{
}

internal class CalendarRepository : RepositoryBase<CalendarEntry, CalendarRecord>, ICalendarRepository
{
    public CalendarRepository(IDatabase db) : base(db)
    {
    }

    protected override CalendarEntry ToDomain(CalendarRecord record)
    {
        throw new NotImplementedException();
    }

    protected override CalendarRecord ToRecord(CalendarEntry domain)
    {
        throw new NotImplementedException();
    }
}
