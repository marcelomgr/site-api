namespace DefaultAPI.Conversion
{
    public class Conversion
    {
        #region Kilometer
        public static double KilometerToMeter(double value)
        {
            return value * 1000;
        }

        public static double KilometerToDecimeter(double value)
        {
            return value * 10000;
        }

        public static double KilometerToCentimeter(double value)
        {
            return value * 100000;
        }

        public static double KilometerToMillimeter(double value)
        {
            return value * 1000000;
        }

        public static double KilometerToMicrometer(double value)
        {
            return value * 1000000000;
        }

        public static double KilometerToNanometer(double value)
        {
            return value * 1000000000000;
        }

        public static double KilometerToAngstrom(double value)
        {
            return value * 1000000000000000;
        }

        #endregion

        #region Meter

        public static double MeterToKilometer(double value)
        {
            return value / 1000;
        }

        public static double MeterToDecimeter(double value)
        {
            return value * 10;
        }

        public static double MeterToCentimeter(double value)
        {
            return value * 100;
        }

        public static double MeterToMillimeter(double value)
        {
            return value * 1000;
        }

        public static double MeterToMicrometer(double value)
        {
            return value * 1000000;
        }

        public static double MeterToNanometer(double value)
        {
            return value * 1000000000;
        }

        public static double MeterToAngstrom(double value)
        {
            return value * 1000000000000;
        }

        #endregion Meter

        #region Decimeter

        public static double DecimeterToKilometer(double value)
        {
            return value / 10000;
        }

        public static double DecimeterToMeter(double value)
        {
            return value / 10;
        }

        public static double DecimeterToCentimeter(double value)
        {
            return value * 10;
        }

        public static double DecimeterToMillimeter(double value)
        {
            return value * 100;
        }

        public static double DecimeterToMicrometer(double value)
        {
            return value * 100000;
        }

        public static double DecimeterToNanometer(double value)
        {
            return value * 100000000;
        }

        public static double DecimeterToAngstrom(double value)
        {
            return value * 1000000000000;
        }

        #endregion

        #region Centimeter

        public static double CentimeterToKilometer(double value)
        {
            return value / 100000;
        }

        public static double CentimeterToMeter(double value)
        {
            return value / 100;
        }

        public static double CentimeterToDecimeter(double value)
        {
            return value / 10;
        }

        public static double CentimeterToMillimeter(double value)
        {
            return value * 10;
        }

        public static double CentimeterToMicrometer(double value)
        {
            return value * 10000;
        }

        public static double CentimeterToNanometer(double value)
        {
            return value * 10000000;
        }

        public static double CentimeterToAngstrom(double value)
        {
            return value * 10000000000;
        }

        #endregion

        #region Milimeter

        public static double MillimeterToKilometer(double value)
        {
            return value / 1000000;
        }

        public static double MillimeterToMeter(double value)
        {
            return value / 1000;
        }

        public static double MillimeterToDecimeter(double value)
        {
            return value / 100;
        }

        public static double MillimeterToCentimeter(double value)
        {
            return value / 10;
        }

        public static double MillimeterToMicrometer(double value)
        {
            return value * 1000;
        }

        public static double MillimeterToNanometer(double value)
        {
            return value * 1000000;
        }

        public static double MillimeterToAngstrom(double value)
        {
            return value * 1000000000;
        }

        #endregion

        #region Micrometer

        public static double MicrometerToKilometer(double value)
        {
            return value / 1000000000;
        }

        public static double MicrometerToMeter(double value)
        {
            return value / 1000000;
        }

        public static double MicrometerToDecimeter(double value)
        {
            return value / 100000;
        }

        public static double MicrometerToCentimeter(double value)
        {
            return value / 10000;
        }

        public static double MicrometerToMillimeter(double value)
        {
            return value / 1000;
        }

        public static double MicrometerToNanometer(double value)
        {
            return value * 1000;
        }

        public static double NanometerToMicrometer(double value)
        {
            return value / 1000;
        }

        #endregion

        #region AngstromToKilometer

        public static double AngstromToKilometer(double value)
        {
            return value / 1000000000000000;
        }

        public static double AngstromToMeter(double value)
        {
            return value / 1000000000000;
        }

        public static double AngstromToDecimeter(double value)
        {
            return value / 1000000000000;
        }

        public static double AngstromToCentimeter(double value)
        {
            return value / 100000000;
        }

        public static double AngstromToMillimeter(double value)
        {
            return value / 1000000;
        }

        public static double AngstromToMicrometer(double value)
        {
            return value / 1000;
        }

        public static double AngstromToNanometer(double value)
        {
            return value / 1000;
        }

        #endregion

    }
}
