using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class C : B
    {
        #region private
        private string _phraseC;
        #endregion private

        #region public
        public override string ToString()
        {
            return base.ToString()+" c";
        }
        #endregion public
    }
}
