int[] fraudlentIDs = [1, 2, 3];

// fraudlentIDs[0] = "A123";
// fraudlentIDs[1] = "b123";

// fraudlentIDs = ["1","2","3"];
Console.WriteLine(fraudlentIDs[1]);
// fraudlentIDs[2] = 4;
Console.WriteLine($"Reassign Third: {fraudlentIDs[2]} {fraudlentIDs.Length} ");

int totalIDs = 0;
int bin = 0;
foreach (int id in fraudlentIDs)
{
    bin++;
    // Console.WriteLine($"Value of :{id}\nNumber:{bin}");
    totalIDs += id;

}
Console.WriteLine("ID " + totalIDs + " bin " + bin);
