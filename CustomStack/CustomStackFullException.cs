using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_07_05
{
    // Saját kivétel minimalista implementálása
    class CustomStackFullException : Exception
    {
        public CustomStackFullException(string msg):base(msg)
        { 
        }

    }
}
