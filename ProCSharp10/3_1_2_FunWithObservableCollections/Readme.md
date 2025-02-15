## Observable Collections

- Observable collections are a type of collection that notifies when items are added, removed, or updated.

1. **ObservableCollection<T>**: Represents a dynamic data collection that provides notifications when items are added, removed, or updated.
1. **ReadOnlyObservableCollection<T>**: Represents a read-only wrapper around an ObservableCollection<T>. It provides read-only access to the collection.

### NotifyCollectionChangedEventArgs

- The NotifyCollectionChangedEventArgs class provides 2 important properties:
  1. **OldItems**: Gets the list of items affected by a Replace, Remove, or Move action.
  1. **NewItems**: Gets the list of new items involved in the change.
  1. **Action**: Gets the action that caused the event.

- However you need to know under which circumstances these properties are populated:
  1. **Add**: OldItems is null and NewItems contains the items that were added.
  1. **Remove**: OldItems contains the items that were removed and NewItems is null.
  1. **Replace**: OldItems contains the items that were replaced and NewItems contains the new items.
  1. **Move**: OldItems contains the items that were moved and NewItems contains the new items.
  1. **Reset**: OldItems is null and NewItems is null.

```csharp
public enum NotifyCollectionChangedAction {
	Add = 0,
	Remove = 1,
	Replace = 2,
	Move = 3,
	Reset = 4,
}
```

### NotifyCollectionChangedEventHandler

- The NotifyCollectionChangedEventHandler delegate is used to handle the CollectionChanged event of the ObservableCollection<T> class.

```csharp
ObservableCollection<Person> people = new ObservableCollection<Person>()
{
    new Person{ Age=12, FirstName="Ayu", LastName="Tom"},
    new Person{ Age=12, FirstName="Ayu", LastName="Com"},
};

people.CollectionChanged += People_CollectionChanged;

void People_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine("action for this event: {0}", e.Action);

    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
    {
        Console.WriteLine("Here are the new items:");
        foreach (Person p in e.NewItems)
        {
            Console.WriteLine(p.ToString());
        }
    }

    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
    {
        Console.WriteLine("Here are the old items:");
        foreach (Person p in e.OldItems)
        {
            Console.WriteLine(p.ToString());
        }
    }
}
```