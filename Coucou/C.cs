using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coucou
{
    public class C
    {
        #region private
        private string _phraseC;
        #endregion private

        #region public
        public C(string phraseC)
        {
            _phraseC = phraseC;
        }

        public string PhraseC
        {
            get
            {
                return _phraseC;
            }
        }
        #endregion public
    }
}
