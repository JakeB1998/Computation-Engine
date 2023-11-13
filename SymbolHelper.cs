namespace ComputationEngine
{
    public static class SymbolHelper
    {
        public static string ToSymbolRepresentation(OperationType type)
        {
            switch(type)
            {
                case OperationType.Addition:
                    return "+";
                case OperationType.Subtraction:
                    return "-";
                case OperationType.Multiplication:
                    return "*";
                case OperationType.Division:
                    return "/";
                default:
                    break;
            }
            return null;
        }

    }
}