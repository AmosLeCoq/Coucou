using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coucou
{
    public class rep
    {
        #region private
        private string _a;
        #endregion private

        #region public
        public rep(string a)
        {
            _a = a;
        }

        public string A
        {
            get
            {
                return _a;
            }
        }
        #endregion public
    }
}
