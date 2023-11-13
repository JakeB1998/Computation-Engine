
public class SubtractionOperation : Operation
{
    public SubtractionOperation() : base()
    {

    }

    public SubtractionOperation(float num1, float num2)
    {
        Num1 = num1;
        Num2 = num2;
    }

    public override float Compute(float num1, float num2)
    {
        return num1 - num2;
    }
}