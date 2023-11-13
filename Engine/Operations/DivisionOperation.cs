
namespace MathFlashCardLib
{
    public class DivisionOperation : Operation
    {
        public DivisionOperation() : base()
        {

        }

        public override float Compute(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}