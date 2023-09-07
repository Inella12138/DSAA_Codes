using ImplementListsWithArrays;

AList myList = new AList();
myList.Add("FOPCS");
myList.Write();
myList.Add("OOPCS");
myList.Write();
myList.Insert(2, "MVC.NET");
myList.Write();
if (myList.Contains("OOPCS"))
    myList.Insert(3, "Design");
myList.Write();
myList.Insert(1, "Data Structures");
myList.Write();
myList.Replace(3, "Java");
myList.Write();
myList.RemoveAt(4);
myList.Write();
myList.Replace(1, "Android");
myList.Write();
