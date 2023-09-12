int n = Int32.Parse(Console.ReadLine());
Console.WriteLine(PossibleChoices(n));

static int PossibleChoices(int stairs)
{
    if (stairs == 0) { return 0; }
    if (stairs == 1) { return 1; }
    if (stairs == 2) { return 2; }
    if (stairs == 3) { return 4; }
    return PossibleChoices(stairs - 1) + PossibleChoices(stairs - 2) + PossibleChoices(stairs - 3);
}