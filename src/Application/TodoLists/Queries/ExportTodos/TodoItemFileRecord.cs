using eShop.Application.Common.Mappings;
using eShop.Domain.Entities;

namespace eShop.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
