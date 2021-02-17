using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp6
{
    internal abstract class AbstractOperation : IComparable<AbstractOperation>
    {
        private int arg1;
        private int arg2;
        public AbstractOperation() { }
        public AbstractOperation(int arg1, int arg2) {
            this.arg1 = arg1;
            this.arg2 = arg2;
        }
        public int Arg1 { get => arg1; set => arg1 = value; }
        public int Arg2 { get => arg2; set => arg2 = value; }

        public int CompareTo([AllowNull] AbstractOperation other)
        {
            if (this.GetResult() > other.GetResult())
            {
                return -1;
            }
            if (this.GetResult() < other.GetResult())
            {
                return 1;
            }
            else
                return 0;
        }

        public abstract int GetResult();
        public override string ToString()
        {
            return arg1 + ";" + arg2 + ";";
        }
    }
}
