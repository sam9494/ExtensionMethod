using System;

namespace ExtensionMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 在任一類別中, 新增自定義的方法
            // 不需要儲存狀態以及資料的情境
            //不需要建立新的衍生類型、重新編譯，或是修改原始類型
            // 補充一些.NET 內建的extension method, ex: linq的order by
            // 準備一個讓他們可以練習的例子, ex: string reverse

            //int[] arrayInts = { 1, 2, 3, 4, 5, 6 };
            //var enumerable = arrayInts.Select(x => x = 0);
            //var orderedEnumerable = arrayInts.OrderBy(g => g);
            //Console.WriteLine("Hello World!");

            var document = new Document(DateTime.Now);
            Console.WriteLine(document.Content);

            //var email = new Email(new DateTime(2019, 5, 20));
            //Console.WriteLine(email.Content);

            //string testString = "abc";
            //var reverseChars = testString.Reverse();
            //string reverseString = "";
            //foreach (var reverseChar in reverseChars)
            //{
            //    reverseString += reverseChar;
            //}
            //Console.WriteLine(reverseString);

            Console.ReadKey();

        }
    }
}