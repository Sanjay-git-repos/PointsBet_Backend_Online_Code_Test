using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{
    public class StringFormatter
    {
        //Return comma separated string with each item from specified items array (parameter 1) wrapped in specified quote string (parameter 2) 
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            //Check for null or empty items array
            if (items == null || items.Length == 0)
                return string.Empty;
        
            var commaSeperatedStringBuilder = new StringBuilder();

            for (int i = 0; i < items.Length; i++)
            {
                if (i > 0) 
                    commaSeperatedStringBuilder.Append(", ");

                commaSeperatedStringBuilder.Append(quote).Append(items[i]).Append(quote);
            }
            return commaSeperatedStringBuilder.ToString();
        }
    }
}
