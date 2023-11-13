namespace ComputationEngine
{
    public class AdditionOperation : Operation
    {
        public AdditionOperation() : base(DefaultValues.FLOAT, DefaultValues.FLOAT, OperationType.Addition)
        {

        }

        public AdditionOperation(float num1, float num2) : base(num1, num2, OperationType.Addition)
        {

        }

        public override float Compute(float num1, float num2)
        {
            return num1 + num2;
        }
    }
}