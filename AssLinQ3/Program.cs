using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static AssLinQ3.ListGenerator;

namespace AssLinQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {


          

            /******************************************Task**************************/

            #region LINQ - Set Operators


            #region Find the unique Category names from Product List

            //var Result = ProductsList.Union(ProductsList, new CustomCompareByCategory())
            //             .Select(p => p.Category);






            #endregion


            #region  Produce a Sequence containing the unique first letter from both product and customer names.

            //var Result1 = ProductsList.Select(p => p.ProductName[0])
            //               .Union(CustomersList.Select(c => c.CustomerName[0]));












            #endregion




            #region . Create one sequence that contains the common first letter from both product and customer names.


            //var Result = ProductsList.Select(p => p.ProductName[0])
            //              .Intersect(CustomersList.Select(c => c.CustomerName[0]));

            #endregion


            #region . Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var Result = ProductsList.Select(P => P.ProductName[0])
            //              .Except(CustomersList.Select(C => C.CustomerName[0]));



            #endregion


            #region Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var Result = ProductsList.SelectMany(p => p.ProductName.ToArray().TakeLast(3))
            //                .Concat(CustomersList.SelectMany(c => c.CustomerName.ToArray().TakeLast(3)));








            #endregion

            #endregion


            #region LINQ - Partitioning Operators


            #region Get the first 3 orders from customers in Washington

            //var Result = CustomersList.Where(c => c.Country == "Washington").Take(3);




            #endregion




            #region Get all but the first 2 orders from customers in Washington.

            //var Result = CustomersList.Where(c=>c.City== "Washington").SelectMany(o => o.Orders).Skip(2);


            #endregion


            #region . Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((num,index)=>num>index);






            #endregion


            #region .Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers2.SkipWhile(x => x % 3 != 0);



            #endregion



            #region Get the elements of the array starting from the first element less than its position.
            //int[] numbers3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers3.SkipWhile((num,Index)=> num>Index);

            #endregion



            #region MyRegion

            #endregion






            #endregion

            #region LINQ - Quantifiers

            #region . Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.


            //var word = File.ReadAllLines("dictionary_english.txt");

            //var Result = word.Any(w=>w.Contains("ei"));







            #endregion

            #region Return a grouped a list of products only for categories that have at least one product that is out of stock.


            //var Result = from p in ProductsList


            //             group p by p.Category
            //             into val

            //             where val.Any(v => v.UnitsInStock == 0)

            //             select new {Category=val.Key,product=val.ToList() };







            //foreach (var item in Result)
            //{

            //    Console.WriteLine(item.Category);

            //    foreach (var item1 in item.product)
            //    {
            //        Console.WriteLine( item1);
            //    }
            //}






            #endregion


            #region Return a grouped a list of products only for categories that have all of their products in stock.

            //var Result = from P in ProductsList
            //             group P by P.Category
            //           into val
            //             where val.All(v => v.UnitsInStock > 0)
            //             select new { Category = val.Key, Product = val.ToList() };



            //foreach (var item in Result)
            //{

            //    Console.WriteLine(item.Category);

            //    foreach (var item1 in item.Product)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}





            #endregion


            #endregion



            #region LINQ – Grouping Operators

            #region 1.	Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbersss = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result = from N in numbersss
            //             group N by N % 5
            //             into val
            //             select new { Reminder = val.Key, num = val.ToList() };


            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Number with Reminder of {item.Reminder} divided by 5 is ");

            //    foreach (var item1 in item.num)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}







            #endregion

            #region 2.	Uses group by to partition a list of words by their first letter.

            //var word = File.ReadAllLines("dictionary_english.txt");

            //var Result = from w in word
            //             group w by w[0]
            //             into val
            //             select new { key = val.Key };


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


          

            #endregion


        }
    }
}
