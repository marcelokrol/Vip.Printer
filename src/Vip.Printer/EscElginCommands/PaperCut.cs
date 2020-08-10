using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscElginCommands
{
   internal class PaperCut : IPaperCut
   {
      public byte[] Full()
      {
         return new byte[] { 29, 'm'.ToByte() };
      }

      public byte[] Partial()
      {
         return new byte[] { 29, 'm'.ToByte() };
      }
   }
}