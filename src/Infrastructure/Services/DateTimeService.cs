using eShop.Application.Common.Interfaces;

namespace eShop.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
