using System;
namespace HanoriMvvm
{
    public class Startup
    {
        [STAThread]
        public static void Main(string[] args)
        {
            _ = new App().Run();
        }
    }
}
