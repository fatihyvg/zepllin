using System.Text.RegularExpressions;
namespace zepllin.Extra
{
    public static class UrlSeo
    {
        public static string ConvertToSeoUrl(string data)
        {
            GetDataSeoStr(data);

            GetEncondSeoStr = Regex.Replace(GetEncondSeoStr, @"\&+", "and");

            GetEncondSeoStr = GetEncondSeoStr.Replace("'", "");

            GetEncondSeoStr = Regex.Replace(GetEncondSeoStr, @"[^a-z0-9]", "-");

            GetEncondSeoStr = Regex.Replace(GetEncondSeoStr, @"-+", "-");

            GetEncondSeoStr = GetEncondSeoStr.Trim('-');

            return GetEncondSeoStr;
        }
        private static void GetDataSeoStr(string data)
        {
            data = data.Replace("ş", "s");

            data = data.Replace("Ş", "s");

            data = data.Replace("İ", "i");

            data = data.Replace("I", "i");

            data = data.Replace("ı", "i");

            data = data.Replace("ö", "o");

            data = data.Replace("Ö", "o");

            data = data.Replace("ü", "u");

            data = data.Replace("Ü", "u");

            data = data.Replace("Ç", "c");

            data = data.Replace("ç", "c");

            data = data.Replace("ğ", "g");

            data = data.Replace("Ğ", "g");

            data = data.Replace(" ", "-");

            data = data.Replace("---", "-");

            data = data.Replace("?", "");

            data = data.Replace("/", "");

            data = data.Replace(".", "");

            data = data.Replace("'", "");

            data = data.Replace("#", "");

            data = data.Replace("%", "");

            data = data.Replace("&", "");

            data = data.Replace("*", "");

            data = data.Replace("!", "");

            data = data.Replace("@", "");

            data = data.Replace("+", "");

            data = data.Replace("'", "-");

            data = data.ToLower();

            data = data.Trim();

            GetEncondSeoStr = (data ?? "").ToLower();
        }
        private static string GetEncondSeoStr
        {
            get;
            set;
        }
    }
}
