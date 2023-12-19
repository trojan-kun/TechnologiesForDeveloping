using System;
using System.Threading;
using System.Globalization;
namespace DZ
{
    public class Program
    {
        static private void Regional()
        {
            Console.WriteLine();
            Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
            Console.WriteLine("Currency Symbol: {0}", NumberFormatInfo.CurrentInfo.CurrencySymbol);
            int a = 100100;
            float price = 99.99F;
            float discount = 0.0333F;
            
            Console.WriteLine("Число с разделением в тысячи: "+ a.ToString("n1"));
            Console.WriteLine("Деньги: "+ price.ToString("c"));
            Console.WriteLine("Процент: "+ discount.ToString("p1"));
            
            Console.WriteLine("Число: "+ 64.ToString());
            Console.WriteLine("Число: "+ int.Parse("46"));

            Console.WriteLine("Число с запятой: "+ 5.6.ToString());          
            Console.WriteLine("Число с запятой: "+ float.Parse("6,50"));

            DateTime thisDay = DateTime.Today;
            Console.WriteLine("Дата: "+ thisDay.ToString());
            Console.WriteLine("Дата: "+ DateTime.Parse("2077 4 december"));
        }
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Regional();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("ja-JP");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP");
            Regional();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
            Regional();
        }
    }
}
