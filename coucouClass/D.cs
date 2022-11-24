using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class D : A
    {
        #region private
        #endregion private

        #region public
        public override string ToString()
        {
           
            return base.ToString()+base.OpenDay(DateTime.Now)+" et on attend 15'000 personnes"+base.test();
        }
        #endregion public
    }
}
