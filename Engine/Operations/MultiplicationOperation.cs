public class MultiplicationOperation : Operation
{
    public MultiplicationOperation() : base()
    {

    }

    public override float Compute(float num1, float num2)
    {
        return num1 * num2;
    }
}