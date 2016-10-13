namespace AzureDataLake.ODataQuery
{
    public class ExprCompareDateTime : ExprCompare
    {
        public ComparisonDateTime Operator;

        public ExprCompareDateTime(Expr left, Expr right, ComparisonDateTime op) :
            base(left,right)
        {
            this.Operator = op;
        }

        public override void ToExprString(ExBuilder sb)
        {
            var op = ExprCompareDateTime.OpToString(this.Operator);
            sb.Append(this.LeftValue);
            sb.Append(" ");
            sb.Append(op);
            sb.Append(" ");
            sb.Append(this.RightValue);
        }

        public static string OpToString(ComparisonDateTime operation)
        {
            if (operation == ComparisonDateTime.GreaterThan)
            {
                return "gt";
            }
            else if (operation == ComparisonDateTime.GreaterThanOrEquals)
            {
                return "ge";
            }
            else if (operation == ComparisonDateTime.LesserThan)
            {
                return "lt";
            }
            else if (operation == ComparisonDateTime.LesserThanOrEquals)
            {
                return "le";
            }
            else if (operation == ComparisonDateTime.Equals)
            {
                return "eq";
            }
            else if (operation == ComparisonDateTime.NotEquals)
            {
                return "ne";
            }
            else
            {
                throw new System.ArgumentOutOfRangeException();
            }
        }
    }
}