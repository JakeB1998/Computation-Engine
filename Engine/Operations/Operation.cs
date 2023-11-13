

using System;
using System.Runtime.CompilerServices;

namespace ComputationEngine
{
    public abstract class Operation : IComputable
    {
        private float _num1;
        private float _num2;

        private OperationType _operationType;

        public float Num1
        {
            get => _num1;
            set => _num1 = value;
        }

        public float Num2
        {
            get => _num2;
            set => _num2 = value;
        }

        public OperationType OperationType
        {
            get => _operationType;
        }


        protected Operation()
        {
            _operationType = OperationType.NonSet;
        }

        protected Operation(float num1, float num2) : this()
        {
            _num1 = num1;
            _num2 = num2;
        }

        protected Operation(float num1, float num2, OperationType operationType) : this(num1, num2)
        {
            _operationType = operationType;
        }



        public abstract float Compute(float num1, float num2);

        public virtual float Compute()
        {
            return this.Compute(_num1, _num2);
        }

        public string ToSymbolRepr()
        {
            return SymbolHelper.ToSymbolRepresentation(_operationType);
        }

        public override string ToString()
        {
            return $"{_num1} {SymbolHelper.ToSymbolRepresentation(_operationType)} {_num2} => {this.Compute().ToString()}";
        }


    }
}