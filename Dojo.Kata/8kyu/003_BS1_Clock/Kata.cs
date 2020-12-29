namespace Dojo.Kata._8kyu._003_BS1_Clock
{
    public static class Kata
    {
        public static int Past(int h, int m, int s) => ((((h * 60) + m) * 60) + s) * 1000;
    }
}
