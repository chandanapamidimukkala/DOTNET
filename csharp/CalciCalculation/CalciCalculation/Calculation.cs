using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalciCalculation
{
    public class Calculation
    {
        public int No1 { get; set; }
        public int No2 { get; set; }
        public string Add()
        {
            return string.Format("Sum = {0}", No1 + No2);
        }
        public string Diff()
        {
            return string.Format("Diff = {0}", No1 - No2);
        }
        public string Mul()
        {
            return string.Format("Mul = {0}", No1 * No2);
        }
        public string Div()
        {
            return string.Format("Div = {0}", No1 / No2);
        }
    }
}
