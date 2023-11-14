using System;
using System.Linq;


namespace ComputationEngine
{
    public static class SymbolHelper
    {
        private static readonly string[] OPPERANDS = new string[]
        {
            "+", "-", "*", "/", "^"
        };

        public static bool IsOpperand(string opperand)
        {
            return OPPERANDS.Contains(opperand);
        }
   
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
                case OperationType.Exponent:
                    return "^";
                default:
                    break;
            }
            return null;
        }
        
    }
}