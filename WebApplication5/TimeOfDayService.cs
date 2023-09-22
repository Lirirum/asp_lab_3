using Microsoft.AspNetCore.Mvc;

namespace WebApplication5
{
    public class TimeOfDayService
    {
   
        public string GetTimeOfDay()
        {
            var now = DateTime.Now;
            string text = $". Час на даний момент:  {now.TimeOfDay}";
            if (now.Hour >= 6 && now.Hour < 12)
            {
                return "Зараз ранок"+ text;
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                return "Зараз день" + text;
            }
            else if (now.Hour >= 18 && now.Hour < 24)
            {
                return "Зараз вечір" + text;
            }
            else
            {
                return "Зараз ніч" + text;
            }
        }

    }
}
