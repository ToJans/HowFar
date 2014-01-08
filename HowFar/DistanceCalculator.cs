using System;

namespace HowFar
{
    public static class DistanceCalculator
    {
        public static Maybe<Distance> Distance(Maybe<Location> a, Maybe<Location> b)
        {
            return Distance((dynamic)a, (dynamic)b);
        }

        static Maybe<Distance> Distance(Just<Location> l1, Just<Location> l2)
        {
            var R = 6371; // Radius of the earth in km
            var dLat = Deg2rad(l1.Value.Latitude - l2.Value.Latitude);  // deg2rad below
            var dLon = Deg2rad(l1.Value.Longitude - l2.Value.Longitude);
            var a =
              Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
              Math.Cos(Deg2rad(l2.Value.Latitude)) * Math.Cos(Deg2rad(l1.Value.Longitude)) *
              Math.Sin(dLon / 2) * Math.Sin(dLon / 2)
              ;
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c; // Distance in km
            return new Just<Distance>(new Distance(d, "km"));
        }

        static Maybe<Distance> Distance(Nothing<Location> a, Just<Location> b)
        {
            return new Nothing<Distance>();
        }

        static Maybe<Distance> Distance(Just<Location> a, Nothing<Location> b)
        {
            return new Nothing<Distance>();
        }

        static Maybe<Distance> Distance(Nothing<Location> a, Nothing<Location> b)
        {
            return new Nothing<Distance>();
        }

        static double Deg2rad(double deg) { return deg * (Math.PI / 180); }
    }
}
