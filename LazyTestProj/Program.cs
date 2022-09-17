// See https://aka.ms/new-console-template for more information
using SimpleLazy;
using SimpleLazyTests;

SimpleLazy<Person> lazyPerson = new SimpleLazy<Person>();
Console.WriteLine(lazyPerson.isValueCreated());
var result = lazyPerson.Value;
Console.WriteLine(result.ToString());
Console.WriteLine(lazyPerson.isValueCreated());

SimpleLazy<Person> lazyPerson2 = new SimpleLazy<Person>(() => new Person(2, "popeye", 23));
Console.WriteLine(lazyPerson2.isValueCreated());
var result2 = lazyPerson2.Value;
Console.WriteLine(result2.ToString());
Console.WriteLine(lazyPerson2.isValueCreated());


