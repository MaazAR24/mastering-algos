namespace PracticeProject.Problems
{
    internal class TimeConversion
    {
        public static string ConvertToMilitaryFormat(string time)
        { 
            var split = time.Split(':');
            var lastElement = split[split.Length - 1];
            var hour = Convert.ToInt32(split[0]);

            if (lastElement.Contains("AM")) 
            {
                if (hour == 12)
                    split[0] = "00";
                split[split.Length - 1] = lastElement.Replace("AM", "");
            }
            else
            {
                if (hour < 12)
                    split[0] = (hour + 12).ToString();
                split[split.Length - 1] = lastElement.Replace("PM", "");
            }

            return string.Join(":", split);
        }
    }
}
