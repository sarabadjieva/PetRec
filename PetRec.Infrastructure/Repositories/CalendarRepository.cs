using PetRec.Core.Interfaces;
using PetRec.Infrastructure.Records;

namespace PetRec.Infrastructure.Repositories;

public interface ICalendarRepository : IRepository<ICalendarEntry>
{
}

internal class CalendarRepository : RepositoryBase<ICalendarEntry, CalendarRecord>, ICalendarRepository
{
    public CalendarRepository(IDatabase db) : base(db)
    {
    }

    protected override ICalendarEntry ToDomain(CalendarRecord record)
    {
        throw new NotImplementedException();
    }

    protected override CalendarRecord ToRecord(ICalendarEntry domain)
    {
        throw new NotImplementedException();
    }
}
