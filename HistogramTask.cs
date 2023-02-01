using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var xAxis = new string[31];
            for (var i = 0; i < xAxis.Length; i++)
            {
                xAxis[i] = (i + 1).ToString();
            }

            var numberBorn = new double[xAxis.Length];

            foreach (var item in names)
            {
                if (item.Name == name && item.BirthDate.Day != 1)
                {
                    numberBorn[item.BirthDate.Day - 1]++;
                }
            }
            
            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name), 
                xAxis, numberBorn);
        }
    }
}