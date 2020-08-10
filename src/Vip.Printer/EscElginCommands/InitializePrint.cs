using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscElginCommands
{
    internal class InitializePrint : IInitializePrint
    {
        public byte[] Initialize()
        {
            return new byte[] {27, '@'.ToByte()}
               .AddBytes(SetLineSpace3());
      }

        private static byte[] SetLineSpace3(byte range = 30)
        {
           return new byte[] { 27, '3'.ToByte(), range };
      }
   }
}