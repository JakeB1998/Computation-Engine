public class AdditionOperation : Operation
{
    public AdditionOperation() : base()
    {

    }

    public override float Compute(float num1, float num2)
    {
        return num1 + num2;
    }
}