using System;
 
namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        { 
            var days = new string[30];
            var months = new string[12];
            
            for (var i = 2; i <= 31; i++) 
                days[i-2] = i.ToString();

            for (var i = 1; i <= 12; i++) 
                months[i-1] = i.ToString();

            var heat = new double[30,12]; 
            
            for (var i = 0; i < 30; i++)
            {
                var monthArr = new double[12];
                foreach (var name in names)
                {
                    if (name.BirthDate.Day == i + 2) 
                        monthArr[name.BirthDate.Month - 1] += 1;
                }

                for (var j = 0; j < 12; j++) 
                    heat[i, j] = monthArr[j];
            }          
            return new HeatmapData("Пример карты интенсивностей",
                heat, days, months);
        }
    }
}