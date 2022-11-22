using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle
{
    public class ConsolePoint
    {
        private int left;
        private int top;
        public int Left
        {
            get
            {
                return this.left;
            }
            set
            {
                this.left = value;
            }
        }

        public int Top
        {
            get
            {
                return this.top;
            }
            set
            {
                this.top = value;
            }
        }
    }
}