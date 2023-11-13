
namespace MathFlashCardLib
{
    public class DivisionOperation : Operation
    {
        public DivisionOperation() : base()
        {

        }

        public DivisionOperation(float num1, float num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public override float Compute(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}