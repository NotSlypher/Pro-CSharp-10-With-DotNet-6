using System.Collections;

WorkWithArrayList();

static void SimpleBoxUnboxOperation()
{
    int myInt = 25;
    object boxedInt = myInt; // Box myInt into a reference type
    int unboxedInt = (int)boxedInt; // Unbox boxedInt back into a value type
}

static void WorkWithArrayList()
{
    // Value types are automatically boxed when
    // passed to a member requesting an object.
    ArrayList myInts = new ArrayList();
    myInts.Add(10);
    myInts.Add(20);
    myInts.Add(35);
    // Unboxing occurs when we cast the object back
    // to a value type.
    int i = (int)myInts[0];
}