using System;
using System.Collections.Generic;

static class TransactionRiskCalculator
{
    private const int MaxDepth = 1000;

    public static int CalculateRiskScore(string transactionId)
    {
        // Validate the transaction identifier first.
        if (!TryParseTransactionId(transactionId, out string cleanId))
        {
            Console.WriteLine("Invalid transaction ID format.");
            return -1;
        }

        int depth = 0;
        var visited = new HashSet<string>();

        return CalculateRecursive(cleanId, ref depth, visited);
    }

    private static bool TryParseTransactionId(string id, out string cleanId)
    {
        // Require transaction ids to use the TX prefix.
        if (!string.IsNullOrEmpty(id) && id.StartsWith("TX"))
        {
            cleanId = id.Trim();
            return true;
        }

        cleanId = string.Empty;
        return false;
    }

    private static int CalculateRecursive(string transactionId, ref int depth, HashSet<string> visited)
    {
        // Stop once recursion reaches the safety limit.
        if (depth >= MaxDepth)
        {
            Console.WriteLine("Warning: Maximum recursion depth exceeded at " + transactionId);
            return -1;
        }

        if (visited.Contains(transactionId))
        {
            // Return when a cycle is detected.
            return 0;
        }

        visited.Add(transactionId);
        depth = depth + 1;

        // A real implementation would fetch the next transaction here.
        // Recursive traversal would continue from this point.
        return depth;
    }
}

