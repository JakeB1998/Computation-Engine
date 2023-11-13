namespace ComputationEngine
{
    public class MultiplicationOperation : Operation
    {
        public MultiplicationOperation() : base(DefaultValues.FLOAT, DefaultValues.FLOAT, OperationType.Multiplication)
        {

        }

        public MultiplicationOperation(float num1, float num2) : base(num1, num2, OperationType.Multiplication)
        {

        }

        public override float Compute(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}