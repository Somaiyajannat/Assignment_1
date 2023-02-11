class Program
{
    public static void Main(string[] args)
    {
        string a = "MatRix";
        int uc = 0;
        int lc = 0;

        for (int i = 0; i < a.Length; i++)
        {
            int value  = Convert.ToInt32(a[i]);
            if (value >=65  && value <= 90)
            {
                uc++;
            }
            if (value >= 97 && value <= 122)
            {
                lc++;
            }
            
        }
        if(uc == lc)
        {
            string word = a.ToLower();
            Console.Write(word);
        }
        if (uc > lc)
        {
            string word = a.ToUpper();
            Console.Write(word);
        }
        if (lc > uc)
        {
            string word = a.ToLower();
            Console.Write(word);
        }

    }
}