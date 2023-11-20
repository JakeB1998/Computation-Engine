using System;
using System.Collections.Generic;
using System.Linq;


namespace ComputationEngine
{
    public static class SymbolHelper
    {
        private static readonly Dictionary<OperationType, string> OPPERAND_MAP = new Dictionary<OperationType, string>
        {
            {OperationType.Addition, "+"},
            {OperationType.Subtraction,  "-"},
            {OperationType.Multiplication, "*"},
            {OperationType.Division, "/"},
            {OperationType.Exponent, "^"}

        };

        public static bool IsOpperand(string opperand)
        {
            return OPPERAND_MAP.Values.Contains(opperand);
        }
   
        public static string ToSymbolRepresentation(OperationType type)
        {
            return OPPERAND_MAP.GetValueOrDefault(type, null);
        }
        
    }
}