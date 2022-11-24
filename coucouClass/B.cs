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
        private string _phraseB;
        #endregion private

        #region public
        public override string ToString()
        {
            return base.ToString() + " et B";
        }
        #endregion public
    }
}
