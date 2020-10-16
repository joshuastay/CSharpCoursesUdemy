namespace Exercises
{
    public class Between1and10
    {
        public static string Between(int newnumber)
        {
            if (newnumber >= 1 && newnumber <= 10)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }

        }
    }
}
