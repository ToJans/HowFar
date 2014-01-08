
namespace HowFar
{
    public class Location
    {
        public readonly double Latitude;
        public readonly double Longitude;

        public Location(double Latitude, double Longitude)
        {
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }

        public override int GetHashCode()
        {
            return Latitude.GetHashCode() ^ Longitude.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var l = obj as Location;
            if (l == null) return false;
            return Latitude == l.Latitude && Longitude == l.Longitude;
        }
    }
}
