using _3_2_1_ExtensionMethods;

int myInt = 2342;
myInt.DisplayDefiningAssembly();

System.Data.DataSet d = new System.Data.DataSet();
d.DisplayDefiningAssembly();

Console.WriteLine("value of myInt: {0}", myInt);
Console.WriteLine("reversed digits of myInt: {0}", myInt.ReverseDigits());