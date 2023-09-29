int n = Int32.Parse(Console.ReadLine());
Console.WriteLine(PossibleChoices(n));

static int PossibleChoices(int stairs)
{
    if (stairs <= 1) { return 1; }
    if (stairs == 2) { return 2; }
    int[] paths = new int[stairs + 1];
    paths[0] = 1;
    paths[1] = 1;
    paths[2] = 2;
    for (int i = 3; i <= stairs; i++)
    {
        paths[i] = paths[i - 1] + paths[i - 2] + paths[i - 3];
    }
    return paths[stairs];
}