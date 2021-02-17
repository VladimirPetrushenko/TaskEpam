using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class SumOperation : AbstractOperation
    {
        public SumOperation() : base() { }
        public SumOperation(int arg1, int arg2) : base(arg1, arg2) { }
        public override int GetResult()
        {
            return Arg1 + Arg2;
        }
        public override string ToString()
        {
            return Arg1 + "+" + Arg2 + "=" + GetResult();
        }
    }

    class SubOperation : AbstractOperation
    {
        public SubOperation() : base() { }
        public SubOperation(int arg1, int arg2) : base(arg1, arg2) { }
        public override int GetResult()
        {
            return Arg1 - Arg2;
        }
        public override string ToString()
        {
            return Arg1 + "-" + Arg2 + "=" + GetResult();
        }
    }

    class MultiplyeOperation : AbstractOperation
    {
        public MultiplyeOperation() : base() { }
        public MultiplyeOperation(int arg1, int arg2) : base(arg1, arg2) { }
        public override int GetResult()
        {
            return Arg1 * Arg2;
        }
        public override string ToString()
        {
            return Arg1 + "*" + Arg2 + "=" + GetResult();
        }
    }

    class DevOperation : AbstractOperation
    {
        public DevOperation() : base() { }
        public DevOperation(int arg1, int arg2) : base(arg1, arg2) { }
        public override int GetResult()
        {
            return Arg1 / Arg2;
        }
        public override string ToString()
        {
            return Arg1 + "/" + Arg2 + "=" + GetResult();
        }
    }

    class StepOperation : AbstractOperation
    {
        public StepOperation() : base() { }
        public StepOperation(int arg1, int arg2) : base(arg1, arg2) { }
        public override int GetResult()
        {
            int result=1;
            for (int i = 0; i < Arg2; i++) {
                result *= Arg1;
            }
            return result;
        }
        public override string ToString()
        {
            return Arg1 + "^" + Arg2 + "=" + GetResult();
        }
    }
}
