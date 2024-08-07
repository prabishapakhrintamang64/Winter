using System;
using System.Collections;

class Problem123
{
    public static void solution()
    {
        ArrayList myList = new ArrayList();

        myList.Add("Harry");
        myList.Add("Miller");

        Console.WriteLine("Original Second element: " + myList[1]);

        myList[1] = "Styles";
        Console.WriteLine("Updated second element: " + myList[1]);
    }
}