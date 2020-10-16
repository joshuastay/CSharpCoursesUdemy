namespace CsharpBasicsControlFlow
{
    public class DivisibleBy3
    {
        public int count = 0;

        public void CheckDiv3(int number)
        {
            if (number % 3 == 0)
            {
                count++;
            }
        }
    }
}
