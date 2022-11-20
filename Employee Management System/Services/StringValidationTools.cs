namespace Employee_Management_System.Services
{
    public class StringValidationTools
    {
        public static bool ASCIIInterval(string text ,int valueOne , int valueTwo)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!(text[i] >= valueOne && text[i] <= valueTwo))
                {
                    return false;
                }
                
            }
            return true;
        }
        public static bool isHaveNumber(string text)
        {
            foreach (char c in text)
            {
                if (c >= 49 && c <= 57)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool isHaveUpperLetter(string text)
        {
            foreach (char c in text)
            {
                if (c >= 65 && c <= 90)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
