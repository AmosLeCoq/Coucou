using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class A
    {
        #region private
        
        #endregion private

        #region public
        public override string ToString()
        {
            return "A : Les portes ouvertes du CPNV sont le : ";
        }

        public string test()
        {
            return "\n----------";
        }

        public DateTime OpenDay(DateTime day)
        {
            return DateTime.Now;
        }
        #endregion public
    }
}
