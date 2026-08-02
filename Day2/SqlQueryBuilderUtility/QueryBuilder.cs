using System;
using System.Text;

class QueryBuilder
{
    private StringBuilder query = new StringBuilder();
    private bool hasClause = false;

    // Add a plain condition clause.
    public void AddWhereClause(string clause)
    {
        if (!hasClause)
        {
            query.Append("WHERE " + clause);
            hasClause = true;
        }
        else
        {
            query.Append("\nAND " + clause);
        }
    }

    // Add nested conditions through delegate callbacks.
    public void AddWhereClause(params Action<QueryBuilder>[] nestedConditions)
    {
        int indentLevel = 0;

        // Render nested conditions recursively.
        void ProcessNested(Action<QueryBuilder> condition, ref int indent)
        {
            var nestedBuilder = new QueryBuilder();
            condition(nestedBuilder);

            string indentation = new string(' ', indent * 2);

            query.Append("\n" + indentation + "AND (");
            query.Append("\n" + indentation + "  " + nestedBuilder.query.ToString().Replace("WHERE ", ""));
            query.Append("\n" + indentation + ")");
        }

        foreach (var cond in nestedConditions)
        {
            ProcessNested(cond, ref indentLevel);
        }
    }

    public override string ToString()
    {
        return query.ToString();
    }
}

