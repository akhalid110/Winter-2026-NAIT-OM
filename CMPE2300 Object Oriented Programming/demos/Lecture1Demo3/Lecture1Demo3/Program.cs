// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * cmpe2300 - Object Oriented Programming 
 * Lecture1 - Demo3 - Workig with arrays and list
 */

// The array s the refetence type. We use "new" to create the actual array object
//in the case our array variable is sA. The variable holds a reference (an address)
//of the actual array object - we are also explicitly listing the values
using System.Threading;

string[] sA = new string[] { "one", "two", "three" };


//When we explicitly list the values, the "new" is the optional as for sB below
string[] sB = { "one", "two", "three" };

//Alternatively, we can specify both the size and the expluicit values
string[] sC = new string[4] { "one", "two", "three", "four" };

//Empty array
string[] sD = new string[2]; //string type gives null
int[] sE = new int[2];       // int type gives 0's      {Both are depend on the size of the array} 

//Accessing the elements of sA using foreach
Console.WriteLine("Display sA using foreach: ");
Console.Write($"sA: ");
foreach (string s in sA)
{
    Console.Write($"{s}, ");
}
Console.WriteLine();

//using string.Join for displaying the other arrays
Console.WriteLine($"sB: {string.Join(",", sB)}");
Console.WriteLine($"sC: {string.Join(",", sC)}");
Console.WriteLine($"sD: {string.Join(",", sD)}");
Console.WriteLine($"sE: {string.Join(",", sE)}");

Console.WriteLine();
Console.WriteLine();



//Using 2D Jagged array with 3 rows
int[][] jaggedArray = new int[3][];

//initialix=ze each row with different colums sizes
jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };

Console.WriteLine("jagged Array:");
for ( int i = 0; i < jaggedArray.Length; i++ )
{
    Console.Write($"Row[{i}]: ");
    for(int j=0; j < jaggedArray[i].Length; j++)
    {
        Console.Write($"{jaggedArray[i][j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();

//LIST

//Created the list using "new" method
List<int> iList = new List<int>();

//We add elements to the List using "add" method
iList.Add(5);
//iList[0] = 5; system.ArgumentOutOfRangeException  // Dont do this directly. It is ok if we do it after adding ONE element 
//iList[1] = 25; system.ArgumentOutOfRangeException  // Dont do this directly. It is ok if we do it after adding TWO element 
;
//creating List with 4 starting elements
List<int> mList = new List<int>() { 1, 2, 3, 4 };

//Noteh the code below creates the new reference variable that also points to the same object as mList
List<int> dupList = mList;

Console.WriteLine($"Initial Lists: {string.Join(",", iList)}");
Console.WriteLine($"mList: {string.Join(",", mList)}");
Console.WriteLine($"dupList: {string.Join(",", dupList)}");
Console.WriteLine();

dupList[2] = 50;
Console.WriteLine($"After changing the 2nd element of the dupList");
Console.WriteLine($"mList: {string.Join(",", mList)}");
Console.WriteLine($"dupList: {string.Join(",", dupList)}");
Console.WriteLine();

//The code below creates a new List object pointed to by copyList 
//initialized to the values of mList
List<int> copyList = new List<int>(mList);
Console.WriteLine($"Initial mList and copyList");
Console.WriteLine($"mList: {string.Join(",", mList)}");
Console.WriteLine($"copyList: {string.Join(",", copyList)}");
Console.WriteLine();


//modifying copyList[3] to 100. We note that this doesn't affect mList
copyList[3] = 100;
Console.WriteLine($"After changing the 3rd element of the dupList");
Console.WriteLine($"mList: {string.Join(",", mList)}");
Console.WriteLine($"copyList: {string.Join(",", copyList)}");
Console.WriteLine();
