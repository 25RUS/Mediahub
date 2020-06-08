using System;

namespace mediahub
{
    class Program
    {
        static void Main(string[] args)
        {
            Shell shell = new Shell();
            shell.Hello();

            HttpRequest httpRq = new HttpRequest();
            httpRq.ClientInit();


        }
    }
}
