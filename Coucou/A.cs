﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coucou
{
    public class A
    {
        #region private
        private string _phraseA= "Coucou je suis A";
        #endregion private

        #region public
        public A(string phraseA)
        {
            _phraseA = phraseA;
        }

        public string PhraseA
        {
            get
            {
                return _phraseA;
            }
        }
        #endregion public
    }
}
