using DelimetersChecker;

string input1 = "a {b [c(d + e)/2 - f] +1}";
string input2 = "a {b [c (d + e)/2 - f  ] + 1";
string input3 = "{a [b + (c + 2)/d ] + e) + f }";
Console.WriteLine(Checker.CheckDelimeter(input1));
Console.WriteLine(Checker.CheckDelimeter(input2));
Console.WriteLine(Checker.CheckDelimeter(input3));
Console.WriteLine(Checker.RecursionChecker(input1));
Console.WriteLine(Checker.RecursionChecker(input2));
Console.WriteLine(Checker.RecursionChecker(input3));