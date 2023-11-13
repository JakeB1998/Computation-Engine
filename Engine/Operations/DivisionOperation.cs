
namespace ComputationEngine
{
    public class DivisionOperation : Operation
    {
        public DivisionOperation() : base(DefaultValues.FLOAT, DefaultValues.FLOAT, OperationType.Division)
        {

        }

        public DivisionOperation(float num1, float num2) : base(num1, num2, OperationType.Division)
        {

        }

        public override float Compute(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}