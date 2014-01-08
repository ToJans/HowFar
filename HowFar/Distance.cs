
namespace HowFar
{
    public class Distance
    {
        private double Amount;
        private string Unit;
        public Distance(double Amount, string Unit)
        {
            this.Amount = Amount;
            this.Unit = Unit;
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode() ^ Unit.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var l = obj as Distance;
            if (l == null) return false;
            return Amount == l.Amount && Unit == l.Unit;
        }
    }
}
