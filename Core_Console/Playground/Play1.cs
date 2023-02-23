namespace Core_Console.Playground;

public class Play1
{
    private readonly Dictionary<AnimalType, Animal> _animals = new();
    public Animal currentAnimal;

    public Play1()
    {
        _animals.Add(AnimalType.cat, new Animal("cat"));
        _animals.Add(AnimalType.dog, new Animal("dog"));

        if (_animals.ContainsKey(AnimalType.beaver))
        {
            var newBeaver = new Animal("beaver");
            //_animals.Add(AnimalType.beaver, newBeaver);
            currentAnimal = _animals[AnimalType.beaver];

            currentAnimal.Name = newBeaver.Name;
        }
    }

    //public string GetName() {
    //}
}

public enum AnimalType
{
    cat,
    dog,
    beaver
}

public class Animal
{
    public Animal(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}