using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class B : A
    {
        #region private

        #endregion private

        #region public
        public override string ToString()
        {
            base.OpenDay(DateTime.Now).ToString();
            return base.ToString() + base.OpenDay(DateTime.Now).ToString() +" Heu non, dans 2 jours"+base.test();
        }
        #endregion public
    }
}
