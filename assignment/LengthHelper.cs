using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class LengthHelper
    {
         public int findLength(string str)
        {
            if (str == null) throw new ArgumentNullException();
            int length = str.Length;
            return length;

        }
    }
}
