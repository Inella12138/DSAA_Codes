using Recursion_ReverseString;

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
    Console.WriteLine("'{0}' reversed is '{1}'",str, ReverseString.Reverse(str, impl));
}
