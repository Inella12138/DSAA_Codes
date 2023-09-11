using TreeImplement;

Tree tree = new Tree();
tree.Insert(27);
tree.Insert(14);
tree.Insert(35);
tree.Insert(19);
tree.Insert(10);
tree.Insert(42);
tree.Insert(31);
tree.Insert(5);
if (tree.Find(35))
{
    Console.WriteLine("true");
}
else {  Console.WriteLine("false"); }
if (tree.Find(55))
{
    Console.WriteLine("true");
}
else { Console.WriteLine("false"); }
tree.Print(tree);
tree.Remove(42);
tree.Print(tree);
tree.Insert(33);
tree.Insert(29);
tree.Remove(35);
tree.Print(tree);
tree.Remove(31);
tree.Print(tree);

