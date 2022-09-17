namespace SimpleLazyTests

{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {
            Id = 1;
            Name = "test";
            Age = 32;
        }

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Person {Id}, {Name}, {Age}";
        }
    }

}
