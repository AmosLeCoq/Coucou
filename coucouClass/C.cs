﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class C : B
    {
        #region private

        #endregion private

        #region public
        public override string ToString()
        {
            string phrase = base.ToString().Split("le")[0]+"... bof. Je n'y vais pas !";
            return phrase+base.test();
        }
        #endregion public
    }
}
