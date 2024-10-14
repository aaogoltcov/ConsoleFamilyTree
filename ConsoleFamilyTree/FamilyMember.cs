namespace ConsoleFamilyTree;

public class FamilyMember
{
    public int Age { get; init; }
    public Gender Gender { get; init; }
    private string Name { get; init; }
    private string Surname { get; init; }
    public FamilyMember Mother { get; set; }
    public FamilyMember Father { get; set; }
    public FamilyMember[] Children { get; set; }
    private FamilyMember Spouse { get; set; }
    private Spouse SpouseType { get; set; }

    public FamilyMember(int age, Gender gender, string name, string surname)
    {
        Age = age;
        Gender = gender;
        Name = name;
        Surname = surname;
    }

    public FamilyMember[] GetGrandMothers()
    {
        var grandMothers = new FamilyMember[2];

        if (Mother?.Mother != null)
        {
            grandMothers[0] = Mother.Mother;
        }
        
        if (Father?.Mother != null)
        {
            grandMothers[1] = Father.Mother;
        }

        return grandMothers;
    }
    
    public FamilyMember[] GetGrandFathers()
    {
        var grandMothers = new FamilyMember[2];

        if (Mother?.Mother != null)
        {
            grandMothers[0] = Mother.Father;
        }
        
        if (Father?.Mother != null)
        {
            grandMothers[1] = Father.Father;
        }

        return grandMothers;
    }

    public void AddSpouse(FamilyMember spouse, Spouse spouseType)
    {
        if (Spouse != null)
        {
            Console.WriteLine("You already have a spouse!");
        }
        
        Spouse = spouse;
        SpouseType = spouseType;
    }

    public FamilyMember[] GetChildren()
    {
        return Children;
    }

    public FamilyMember GetSpouse()
    {
        return Spouse;
    }
    
    public Spouse GetSpouseType()
    {
        return SpouseType;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name} {Surname}");
    }
}