namespace DefaultAPI.Conversion
{
    public class ConversionDimension
    {
        public static double Convert(double value, string fromUnit, string toUnit)
        {
            string key = fromUnit + "-" + toUnit;
            if (!conversionTable.ContainsKey(key))
            {
                throw new ArgumentException("Conversion not found");
            }
            return value * conversionTable[key];
        }

        private static readonly Dictionary<string, double> conversionTable = new Dictionary<string, double>()
        {
            { "km-m", 1000 },
            { "km-dm", 10000 },
            { "km-cm", 100000 },
            { "km-mm", 1000000 },
            { "km-µm", 1000000000 },
            { "km-nm", 1000000000000 },
            { "km-Å", 1000000000000000 },
            { "m-km", 0.001 },
            { "m-dm", 10 },
            { "m-cm", 100 },
            { "m-mm", 1000 },
            { "m-µm", 1000000 },
            { "m-nm", 1000000000 },
            { "m-Å", 1000000000000 },
            { "dm-km", 0.0001 },
            { "dm-m", 0.1 },
            { "dm-cm", 10 },
            { "dm-mm", 100 },
            { "dm-µm", 100000 },
            { "dm-nm", 100000000 },
            { "dm-Å", 1000000000000 },
            { "cm-km", 0.00001 },
            { "cm-m", 0.01 },
            { "cm-dm", 0.1 },
            { "cm-mm", 10 },
            { "cm-µm", 10000 },
            { "cm-nm", 10000000 },
            { "cm-Å", 10000000000 },
            { "mm-km", 0.000001 },
            { "mm-m", 0.001 },
            { "mm-dm", 0.01 },
            { "mm-cm", 0.1 },
            { "mm-µm", 1000 },
            { "mm-nm", 1000000 },
            { "mm-Å", 1000000000 },
            { "µm-km", 0.000000001 },
            { "µm-m", 0.000001 },
            { "µm-dm", 0.00001 },
            { "µm-cm", 0.0001 },
            { "µm-mm", 0.001 },
            { "µm-nm", 1000 },
            { "µm-Å", 1000000 },
            { "nm-km", 0.000000000001 },
            { "nm-m", 0.000000001 },
            { "nm-dm", 0.00000001 },
            { "nm-cm", 0.0000001 },
            { "nm-mm", 0.000001 },
            { "nm-µm", 0.001 },
            { "nm-Å", 1000 },
            { "Å-km", 0.000000000000001 },
            { "Å-m", 0.000000000001 },
            { "Å-dm", 0.000000001 },
            { "Å-cm", 0.00000001 },
            { "Å-mm", 0.0000001 },
            { "Å-µm", 0.0001 },
            { "Å-nm", 0.001 }
        };
    }
}
