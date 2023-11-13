namespace ComputationEngine
{
    public class SubtractionOperation : Operation
    {
        public SubtractionOperation() : base(DefaultValues.FLOAT, DefaultValues.FLOAT, OperationType.Subtraction)
        {

        }

        public SubtractionOperation(float num1, float num2) : base(num1, num2, OperationType.Subtraction)
        {

        }

        public override float Compute(float num1, float num2)
        {
            return num1 - num2;
        }
    }
}