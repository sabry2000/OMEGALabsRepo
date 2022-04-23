using System;
using System.Collections.Generic;
using System.Linq;

namespace TB6600_Application
{

    public enum Unit
    {
        invalid,
        mm,
        cm,
        inch
    }

    public static class Units
    {
        private const double DOUBLE_INCHES_PER_CM = 0.3937;
        private const int INT_MM_PER_CM = 10;

        private const string STR_CM = "cm";
        private const string STR_MM = "mm";
        private const string STR_INCH = "inch";

        public static ICollection<string> GetAllUnits()
        {
            var enumlist = Enum.GetValues(typeof(Unit)).Cast<Unit>().ToList();
            enumlist.Remove(Unit.invalid);
            var unitsList = from x in enumlist
                            select x.ToString();
            return unitsList.ToArray();
        }

        public static Unit FromString(string unitString)
        {
            switch (unitString)
            {
                case STR_CM:
                    return Unit.cm;
                case STR_MM:
                    return Unit.mm;
                case STR_INCH:
                    return Unit.inch;
                default:
                    return Unit.invalid;
            }
        }

        public static double Convert(double value, Unit fromUnits, Unit toUnits)
        {
            if (fromUnits == toUnits)
                return value;
            else
            {
                switch (toUnits)
                {
                    case Unit.cm:
                        return ToCentimeters(value, fromUnits);
                    case Unit.mm:
                        return ToMillimeters(value, fromUnits);
                    case Unit.inch:
                        return ToInches(value, fromUnits);
                    default:
                        return value;
                }
            }
        }

        private static double ToInches(double value, Unit fromUnits)
        {
            if (fromUnits.Equals(Unit.cm))
                value *= DOUBLE_INCHES_PER_CM;
            else if (fromUnits.Equals(Unit.mm))
                value = value * DOUBLE_INCHES_PER_CM * INT_MM_PER_CM;

            return value;
        }

        private static double ToMillimeters(double value, Unit fromUnits)
        {
            if (fromUnits.Equals(Unit.cm))
                value *= INT_MM_PER_CM;
            else if (fromUnits.Equals(Unit.inch))
                value = value / DOUBLE_INCHES_PER_CM * INT_MM_PER_CM;

            return value;
        }

        private static double ToCentimeters(double value, Unit fromUnits)
        {
            if (fromUnits.Equals(Unit.mm))
                value /= INT_MM_PER_CM;
            else if (fromUnits.Equals(Unit.inch))
                value /= DOUBLE_INCHES_PER_CM;

            return value;
        }
    }
}
