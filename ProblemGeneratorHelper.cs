using System;
using UnityEngine;

public static class ProblemGeneratorHelper
{
    public static string GenerateRandProblem(string[] symbols, int difficulty, int numberDifficulty, int symbolDifficulty, out float answer)
    {
        int modifier1 = (int) Math.Pow(10, numberDifficulty);
        int modifier2 = (int) Math.Pow(10, numberDifficulty);
        int num1 = ProblemGeneratorHelper.GenerateRandNumber(1 * modifier1, 10 * modifier1);
        int num2 = ProblemGeneratorHelper.GenerateRandNumber(1 * modifier2, 10 * modifier2);
        string symbol = ProblemGeneratorHelper.GenerateRandSymbol(symbols, symbolDifficulty);
        answer = GetAnswer(num1, num2, symbol);
        return string.Format("{0} {1} {2}", num1, symbol, num2, symbol == "/" ? answer.ToString("F") : answer.ToString("F0"));
    }

    public static int GenerateRandNumber(int lowBound, int highBound)
    {
        // Debug.Log($"{lowBound}, {highBound}, {modifier}");
        return  UnityEngine.Random.Range(lowBound, highBound);
    }

    public static int GetNormalizedDifficulty(int difficulty, int escalationFactor)
    {
        int normalizedNum = (difficulty - (difficulty % escalationFactor));
        return normalizedNum == 0 ? 0 : normalizedNum / escalationFactor;
    }

    public static string GenerateRandSymbol(string[] symbols, int symbolDifficulty)
    {
        if (symbolDifficulty > symbols.Length) symbolDifficulty = symbols.Length;

        return symbols[UnityEngine.Random.Range(0, symbolDifficulty)];

        // return symbols[UnityEngine.Random.Range(0, normalizedDifficulty < 2 ? 1 : (normalizedDifficulty < 4 ? 2 : symbols.Length))];
    }

    private static float GetAnswer(int num1, int num2, string symbol)
    {
        switch (symbol)
        {
            case "+":
                return num1 + num2;
            case "-":
                return num1 - num2;
            case "*":
                return num1 * num2;
            case "/":
                return num1 / num2;
            default:
                break;
        }

        throw new Exception("Unsupported symbol: " + symbol);
    }
}
