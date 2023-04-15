internal class Program
{
    private static void Main(string[] args)
    {
        string queryIP= "123.123.123.0";
        string queryIP2 = "2001:0db8:85a3:0000:0000:8a2e:0370:7704";
        Console.WriteLine(CheckIPv4(queryIP));
        Console.WriteLine(CheckIPv6(queryIP2));

    }
    public static bool CheckIPv4(string queryIP)
    {
        if(queryIP.Length>15&&queryIP.Length<7)return false;
        string[] strings = queryIP.Split('.');
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length>3)return false;
            for (int j = 0; j < strings[i].Length; j++)
            {
                if (!char.IsDigit(strings[i][j]))return false;
            }
        }
        return true;
    }
    public static bool CheckIPv6(string queryIP)
    {
       if(queryIP.Length>39&&queryIP.Length<15)return false;
        string[] strings = queryIP.Split(':');
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length != 4) return false;
            for (int j = 0; j < strings[i].Length; j++)
            {
                if (!Uri.IsHexDigit(strings[i][j])) return false;
            }
        }
        return true;
    }
}