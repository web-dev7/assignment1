using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class TestClass1
    {
         public int findLength(string str)
        {
            try {
                int length = str.Length;
                return length;
            }
            catch(ArgumentNullException e)
            {
                throw e;
            }
           
        }
    }
}
