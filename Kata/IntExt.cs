namespace Kata
{
    public static class IntExt
    {
        public static bool IsMultipleOf(this int i, int div)
        {
            return i % div == 0;
        }
    }
}