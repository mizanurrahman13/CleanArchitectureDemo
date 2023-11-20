using Ardalis.SharedKernel;
using CLEANARCHlTECTUREDEMO.Domain.Entities;

namespace CLEANARCHlTECTUREDEMO.Domain.Events;

public class ToDoItemCompletedEvent : DomainEventBase
{
    public ToDoItem CompletedItem { get; set; }

    public ToDoItemCompletedEvent(ToDoItem completedItem)
    {
        CompletedItem = completedItem;
    }
}
