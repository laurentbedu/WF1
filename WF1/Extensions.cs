namespace WF1
{
    internal static class Extensions
    {
        public static string getRefUnit(this Dictionary<string, double> dictionary)
        {
            return dictionary.First(x => x.Value == 1).Key;
        }
    }
}
