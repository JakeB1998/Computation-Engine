using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.Linq;

namespace ComputationEngine
{
    public static class Solver
    {
        

        public static float QuickSolve(string problem)
        {
            Dictionary<string, int> pemdasMap = new Dictionary<string, int>
            {
                {SymbolHelper.ToSymbolRepresentation(OperationType.Addition), 1},
                {SymbolHelper.ToSymbolRepresentation(OperationType.Subtraction), 1},
                {SymbolHelper.ToSymbolRepresentation(OperationType.Multiplication), 2},
                {SymbolHelper.ToSymbolRepresentation(OperationType.Division), 2},
                {SymbolHelper.ToSymbolRepresentation(OperationType.Exponent), 3}
            };
            if (problem == null || problem.Length < 1)
                return DefaultValues.FLOAT;

            Stack<string> numbers = new Stack<string>(0);
            Stack<string> opperands = new Stack<string>(0);

            char[] chars = problem.ToCharArray();
            string digit = "";
            for (int i = 0; i < chars.Length; i++)
            {
                char token = chars[i];
                
                if (char.IsDigit(token))
                {
                    // UnityEngine.Debug.Log($"[{i}]Digit: {token}");
                    digit += token;
                }
                else if (SymbolHelper.IsOpperand(token.ToString()) || token == '.')
                {
                    // UnityEngine.Debug.Log($"[{i}]Symbol: {token}");
                    if (token == '.')
                    {
                        digit += token;
                        continue;
                    }

                    if (digit.Length > 0)
                    {
                        // UnityEngine.Debug.Log($"Number: {digit}");
                        numbers.Push(digit);
                    }

                    while (opperands.Count > 0 && pemdasMap.GetValueOrDefault(opperands.Peek()) >= pemdasMap.GetValueOrDefault(token.ToString()))
                    {
                        string opperand = opperands.Pop();
                        float num2 = float.Parse(numbers.Pop());
                        float num1 = float.Parse(numbers.Pop());
                        // UnityEngine.Debug.Log($"Doing: {num1}{opperand}{num2}");
                        switch(opperand)
                        {
                            case "+":
                                numbers.Push((num1 + num2).ToString());
                                break;
                            case "-":
                                numbers.Push((num1 - num2).ToString());
                                break;
                            case "*":
                                numbers.Push((num1 * num2).ToString());
                                break;
                            case "/":
                                numbers.Push((num1 / num2).ToString());
                                break;
                            case "^":
                                numbers.Push((Math.Pow(num1, num2)).ToString());
                                break;
                            default:
                                break;
                        }

                    }

                    opperands.Push(token.ToString());
                    digit = "";

                }
                else
                {
                    if (digit.Length > 0)
                    {
                        // UnityEngine.Debug.Log($"Number: {digit}");
                        numbers.Push(digit);
                        digit = "";
                    }
                }
            }

            if (digit.Length > 0)
            {
                numbers.Push(digit);
                digit = "";
            }

            // UnityEngine.Debug.Log(string.Join(",", numbers.ToArray()));
            // UnityEngine.Debug.Log(string.Join(",", opperands.ToArray()));
            if (opperands.Count > 0)
            {
                while (opperands.Count > 0)
                {
                    string opperand = opperands.Pop();
                    float num2 = float.Parse(numbers.Pop());
                    float num1 = float.Parse(numbers.Pop());
                    // UnityEngine.Debug.Log($"Doing after: {num1}{opperand}{num2}");

                    switch(opperand)
                    {
                        case "+":
                            numbers.Push((num1 + num2).ToString());
                            break;
                        case "-":
                            numbers.Push((num1 - num2).ToString());
                            break;
                        case "*":
                            numbers.Push((num1 * num2).ToString());
                            break;
                        case "/":
                            numbers.Push((num1 / num2).ToString());
                            break;
                        case "^":
                            numbers.Push((Math.Pow(num1, num2)).ToString());
                            break;
                        default:
                            break;
                    }
                }

                return float.Parse(numbers.Pop());
            }


            return DefaultValues.FLOAT;
        }
    }
}