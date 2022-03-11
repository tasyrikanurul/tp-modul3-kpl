namespace tpmodul3_1302201131
{
    internal class KodePos
    {
        int kodepos;
        string kelurahan;

        static void GetKodePos(string kelurahan, int kodepos)
        {
            Console.WriteLine(kelurahan + " " + kodepos);
        }

        static void Main(string[] args)
        {
            GetKodePos("Batununggal", 40266);
            GetKodePos("Kujangsari", 40287);
            GetKodePos("Mengger", 40267);
            GetKodePos("Wates", 40256);
            GetKodePos("Cijaura", 40287);
            GetKodePos("Jatisari", 40286);
            GetKodePos("Margasari", 40286);
            GetKodePos("Sekejati", 40286);
            GetKodePos("Kebonwaru", 40272);
            GetKodePos("Maleer", 40274);
            GetKodePos("Samoja", 40273);
        }
    }
}
    
    


            