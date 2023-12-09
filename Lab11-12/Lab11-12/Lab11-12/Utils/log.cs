using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTPOLAST.Utils
{
    public class log
    {
        public string logstr;
        public void LogText()
        {
            File.WriteAllText("log.txt", logstr + " " + DateTime.Now);
        }
    }
}
