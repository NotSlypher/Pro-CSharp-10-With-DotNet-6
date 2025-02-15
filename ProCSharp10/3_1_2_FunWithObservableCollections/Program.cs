using _3_1_3_FunWithObservableCollections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

ObservableCollection<Person> people = new ObservableCollection<Person>()
{
    new Person{ Age=12, FirstName="Ayu", LastName="Tom"},
    new Person{ Age=12, FirstName="Ayu", LastName="Com"},
};

people.CollectionChanged += People_CollectionChanged;

// Now add a new item.
people.Add(new Person("Fred", "Smith", 32)); 
// Remove an item.
people.RemoveAt(0);

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

