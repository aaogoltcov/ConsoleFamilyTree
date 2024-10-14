using ConsoleFamilyTree;

var John = new FamilyMember( 21, Gender.Male, "John", "Smith" );
var Jessica = new FamilyMember( 48, Gender.Female, "Jessica", "Smith" );
var Bob = new FamilyMember( 51, Gender.Female, "Bob", "Smith" );
var Claudia = new FamilyMember( 48, Gender.Female, "Claudia", "Smith" );
var Mike = new FamilyMember( 51, Gender.Female, "Mike", "Smith" );
var Sara = new FamilyMember( 48, Gender.Female, "Sara", "Fisher" );
var Bill = new FamilyMember( 51, Gender.Female, "Bill", "Fisher" );

John.Mother = Jessica;
John.Father = Bob;

Jessica.Mother = Sara;
Jessica.Father = Bill;

Jessica.AddSpouse(Bob, Spouse.Husband);
Sara.AddSpouse(Bill, Spouse.Husband);
Bill.AddSpouse(Sara, Spouse.Wife);
Jessica.Children = [John];
Sara.Children = [Jessica];
Bill.Children = [Jessica];

Bob.Mother = Claudia;
Bob.Father = Mike;

Bob.AddSpouse(Jessica, Spouse.Wife);
Claudia.AddSpouse(Mike, Spouse.Husband);
Mike.AddSpouse(Claudia, Spouse.Husband);
Bob.Children = [John];
Claudia.Children = [Bob];
Mike.Children = [Bob];



foreach (var grandFather in John.GetGrandFathers())
{
    grandFather?.Print();
}

foreach (var grandMother in John.GetGrandMothers())
{
    grandMother?.Print();
}

foreach (var child in Claudia.GetChildren())
{
    child?.Print();
}

Jessica.GetSpouse()?.Print();
Console.WriteLine(Jessica.GetSpouseType());