using Recursive_CountString;

string impl = "iterative";
Reverse("hello world");
Reverse("hello world", impl);
Reverse("apple");
Reverse("apple", impl);
Reverse("toy");
Reverse("toy", impl);
Reverse("");
Reverse("", impl);
static void Reverse(string str, string impl = "recursive")
{
    Console.WriteLine("'{0}' has a length of '{1}'", str, CountStrLen.Count(str, impl));
}
