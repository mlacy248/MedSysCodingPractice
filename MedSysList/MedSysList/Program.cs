namespace Code
{
    public class mainClass
    {
        static void Main()
        {
            //aboveBelow test setup- simple input

            Console.WriteLine("Above Below Tests...");

            int[] testList1 = new int[]
            {
                1,5,4,9,11,3,6,12,20,2
            };

            int testNumber1 = 8;

            Dictionary<string, int> aboveBelowDictionary1 = RtsCodeTest.aboveBelow(testList1, testNumber1);

            Console.WriteLine("Standard Input Test:");
            Console.WriteLine("above:  " + aboveBelowDictionary1["above"]);
            Console.WriteLine("below:  " + aboveBelowDictionary1["below"]);

            //aboveBelow test setup- null list, should return 0 for both above and below
            int[] testList2 = null;

            Dictionary<string, int> aboveBelowDictionary2 = RtsCodeTest.aboveBelow(testList2, testNumber1);

            Console.WriteLine("Null List Test:");
            Console.WriteLine("above:  " + aboveBelowDictionary2["above"]);
            Console.WriteLine("below:  " + aboveBelowDictionary2["below"]);

            //aboveBelow test setup- integer equal to one value in list, should return a total one less than length

            int testNumber2 = 9;

            Dictionary<string, int> aboveBelowDictionary3 = RtsCodeTest.aboveBelow(testList1, testNumber2);

            Console.WriteLine("List Contains Equal Value Test:");
            Console.WriteLine("above:  " + aboveBelowDictionary3["above"]);
            Console.WriteLine("below:  " + aboveBelowDictionary3["below"]);
            Console.WriteLine("List Length:  " + testList1.Length +
                " not equal to total aboveBelow count: " + (aboveBelowDictionary3["above"]
                + aboveBelowDictionary3["below"]));

            //stringRotation test setup, standard input

            Console.WriteLine("String Rotation Tests...");

            string testString1 = "Supercalifragilisticexpialidocious";
            int testRotationAmount1 = 8;

            Console.WriteLine("Standard Input Test");
            Console.WriteLine(RtsCodeTest.stringRotation(testString1, testRotationAmount1));

            string testString2 = null;

            Console.WriteLine("Null String Input Test");
            Console.WriteLine(RtsCodeTest.stringRotation(testString2, testRotationAmount1));

            int testRotationAmount2 = 108;

            Console.WriteLine("Rotation Amount Greater Than Length Input Test");
            Console.WriteLine("string length: " + testString1.Length + ", rotation amount: "
                + testRotationAmount2);
            Console.WriteLine(RtsCodeTest.stringRotation(testString1, testRotationAmount2));

        }
    }
}
