
using System.Collections.Generic;

namespace ComputationEngine
{
    public class OperationChain
    {
        private List<Operation> _chain;

        public List<Operation> Chain
        {
            get => _chain;
            set => _chain = value;
        }

        public OperationChain()
        {
            _chain = new List<Operation>(0);
        }

        public OperationChain(List<Operation> chain)
        {
            _chain = chain;
        }

        public float ComputeChain()
        {
            for(int i = 0; i < _chain.Count; i++)
            {
                Operation item = _chain[i];
                float result = item.Compute();

                if (i + 1 >= _chain.Count)
                    return result;


                Chain[i + 1].Num1 = result;
                
            }
            return float.MinValue;
        }


        public override string ToString()
        {
            if (_chain != null && _chain.Count > 0)
            {
                string o = "[";
                foreach(Operation operation in _chain)
                {
                    o += "" + operation?.ToString() +", ";
                }
                o  = o.Substring(0, o.Length - 2);
                o += "]";
                return o;
            }
            return "[]";
        }

    }
}