using eShop.Application.TodoLists.Queries.ExportTodos;

namespace eShop.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
