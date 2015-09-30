using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheATM
{
    public class ATMFunction
    {
        public static void ExitATM()
        {
            HttpContext.Current.Session.Clear();
        }
    }
}