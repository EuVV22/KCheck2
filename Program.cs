using KnowledgeCheck2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Child>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var myClass = new Child();

    Console.WriteLine("Enter the value for Name");
    myClass.Name = Console.ReadLine();
    Console.WriteLine($"Please enter the amount of {myClass.Name}");
    myClass.Quantity = int.Parse(Console.ReadLine());


    recordList.Add(myClass);
}

// Print out the list of records using Console.WriteLine()
foreach (var record in recordList)
{
    Console.WriteLine("Here is a list of the record that were added.");
    Console.WriteLine($"Record {record.Name} has a quantity of {record.Quantity}");
    Console.WriteLine(record.ToString());
}