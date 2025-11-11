namespace App;

public static class Login
{
    private const string UserFile = "UserInlog.txt";

    public static bool TryLogin(string username, string password)
    {
        string[] Lines = File.ReadAllLines(UserFile);
        int i = 0;
        while (i < Lines.Length)
        {
            string Line = Lines[i];
            string[] p = Line.Split(',');

            string u = p[0];
            string pass = p[1];

            if (u == username && pass == password)
            {
                return true;
            }
            i++;

        }
        return false;
    }
    
}