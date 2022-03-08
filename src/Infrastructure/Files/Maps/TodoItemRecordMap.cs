using System.Globalization;
using eShop.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace eShop.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
