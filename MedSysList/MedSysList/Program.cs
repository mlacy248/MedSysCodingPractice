using MedSysList;

namespace Code
{
    public class mainClass
    {
        static void Main()
        {


            var myList = new MyList<int>
            (
                new List<int>()
                {
                    1, 2, 3, 4, 5, 6
                }
            );

            myList.Add ( 7 );

            myList.Delete ( 3 );

            var val = myList.ReadValueAtIndex ( 0 );

            var readList = myList.ReadList();

            foreach ( var item in readList ) 
            { 
                Console.WriteLine ( item );
            }


        }
    }
}
