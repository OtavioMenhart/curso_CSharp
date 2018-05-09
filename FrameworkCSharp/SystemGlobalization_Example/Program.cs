using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace SystemGlobalization_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calendar e datetime

            //TimeSpan ts1 = new TimeSpan();
            DateTime dt1 = DateTime.Now;

            Calendar cal;
            DateTime dt = new DateTime(2012, 1, 1, new GregorianCalendar());
            dt.AddHours(3);

            //TimeSpan ts2 = new TimeSpan();

            //ts1.Subtract(ts2);
            DateTime dt2 = DateTime.Now;
            dt2.Subtract(dt1);

            #endregion

            #region CultureInfo
            CultureInfo ci = new CultureInfo("en-US");

            #endregion

            #region CultureInfo - Threading
            CultureInfo cit = Thread.CurrentThread.CurrentCulture;
            CultureInfo ciUI = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            CultureInfo cinv = CultureInfo.InvariantCulture;

            Console.WriteLine(SystemGlobalization_Example.Main.DESCRICAO);
            Console.ReadKey();
            #endregion
        }
    }
}
