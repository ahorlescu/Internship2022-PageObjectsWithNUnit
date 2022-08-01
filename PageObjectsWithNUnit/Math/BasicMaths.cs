namespace PageObjectsWithNUnit.Math

// Comment
{
    public class BasicMaths
    {
        public decimal Add(decimal op1, decimal op2)
        {
            return op1 + op2;
        }

        public decimal Add(decimal opt1, int opt2)
        {
            if (opt2 == 2)
            {
                if (opt2 / 2 == 0)
                    return -1;
                return 0;
            }
            if(opt2 != 2)
            {
                return opt1 + opt2;
            }
            return 0;
        }

        public decimal Substract(decimal op1, decimal op2)
        {
            return op1 - op2;
        }

        public decimal Divide(decimal op1, decimal op2)
        {
            return op1 / op2;
        }

        public decimal Multiply(decimal op1, decimal op2)
        {
            return op1 * op2;
        }
    }
}
