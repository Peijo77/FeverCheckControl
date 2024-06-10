
namespace FeverCheckControl.Models
{
    public static class TemperatureUtility
    {
        public static string CheckFever(float temperature)
        {
            if (temperature >=37.5) 
            {
                return "YOU HAVE FEVER";
            }
            else if (temperature <=35)
            {
                return "YOU MIGHT HAVE HYPOTHERMIA";
            }
            else 
            {
                return "YOUR TEMPERATURE IS NORMAL";
            }
        }
    }

}
