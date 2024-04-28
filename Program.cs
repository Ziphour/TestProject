Random coinFlip = new();
int flipRandom = coinFlip.Next(2);
string flipResult = flipRandom == 1 ? "Heads" : "Tails";
Console.WriteLine($"{flipResult}");
Console.WriteLine($"{(flipRandom == 1 ? "Heads" : "Tails")}");