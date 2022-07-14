using System;

namespace YFSharp
{

    class MainClass
    {
        static void Main(string[] args)
        {
            //YAHOOFinanceShortTest finServ = new YAHOOFinanceShortTest();
            YAHOOFinanceFullTest finServ = new YAHOOFinanceFullTest();
            finServ.Teste();
        }
    }

}
