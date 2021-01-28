#define LINQ_4


/************ ONLY FOR COMPE 561 ************/

//Kristine Tabidze / 823377042

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static delegatesAndLINQ.delegate_1;

namespace delegatesAndLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
#if delegate_1
            #region delegate_1
            // Problem: 
            // PART I) open delegate_1.cs file and declare the
            // type SayHello as a delegate that takes a single
            // string parameter and returns nothing.

            // PART II) next, declare a delegate of type SayHello with name HelloSayer
            // and assign to it an anonymous function (you can use lambda) which
            // does something useful with the string passed to it. For example, it prints it.


            // type the code for PART II here
            SayHello HelloSayer = (string text) => Console.WriteLine(text);

            // do not remove the next line.
            HelloSayer("Hello there");

            #endregion

#elif LINQ_1
            #region LINQ_1
            // Problem:
            // Write a program in C# Sharp to shows how the three parts of a query operation execute.
            // the program should print even integers from the data source of integers. (The numbers which produce the remainder 0 after divided by 2)
            // step 1) Create a data source of integers from 0 to 9
            // step 2) Create a LINQ query
            // step 3) Execute the query (just print it on the console)


            // type the code here

            Enumerable.Range(1, 10).Where(n => n % 2 == 0).ToList().ForEach(Console.WriteLine);

            #endregion

#elif LINQ_2
            #region LINQ_2
            // Do the previous problem only with LINQ extension methods
            // NOTE: you still need the data source 

            // type the code here


             Enumerable.Range(1, 10).Where(n => n % 2 == 0).ToList().ForEach(Console.WriteLine);

            #endregion

#elif LINQ_3
            #region LINQ_3
            // Problem: Write a program in C# Sharp to arrange the distinct elements in the list in ascending order.
            // Expected output:
            /*
             Expected Output :
                Biscuit
                Brade
                Butter
                Honey
             */
            // Data source is given. Take a look at Item_Mast.cs class


            // type the code here

            Item_Mast.GetItemMast().OrderBy(x => x.ItemDes);




            #endregion

#elif LINQ_4
            #region LINQ_4
            // Write a program in C# Sharp to Remove Items from List by passing filters.
            // Test Data:
            // Here is the list of items:
            // Char: m
            // Char: n
            // Char: o
            // Char: p
            // Char: q
            // you habe to create a storage for these items (List)
            // and apply the filters so that the output is the following:
            // Here is the list after removing item 'q' from the list :
            // Char: m
            // Char: n
            // Char: o
            // Char: p


            // type the code here

            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");

            listOfString.RemoveAll(en => en == "q");





            #endregion
#endif
        }
    }
}
