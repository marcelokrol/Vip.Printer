﻿using Vip.Printer.Enums;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscElginCommands
{
    internal class EscElgin : IPrintCommand
    {
        #region Properties

        public IFontMode FontMode { get; set; }
        public IFontWidth FontWidth { get; set; }
        public IAlignment Alignment { get; set; }
        public IPaperCut PaperCut { get; set; }
        public IDrawer Drawer { get; set; }
        public IQrCode QrCode { get; set; }
        public IImage Image { get; set; }
        public IBarCode BarCode { get; set; }
        public IInitializePrint InitializePrint { get; set; }
        public int ColsNormal => 48;
        public int ColsCondensed => 64;
        public int ColsExpanded => 24;

        #endregion

        #region Constructor

        public EscElgin()
        {
            FontMode = new FontMode();
            FontWidth = new FontWidth();
            Alignment = new Alignment();
            PaperCut = new PaperCut();
            Drawer = new Drawer();
            QrCode = new QrCode();
            Image = new Image();
            BarCode = new BarCode();
            InitializePrint = new InitializePrint();
        }

        #endregion

        #region Methods

        public byte[] Separator()
        {
            return FontMode.Condensed(PrinterModeState.On)
                .AddBytes(new string('-', ColsCondensed))
                .AddBytes(FontMode.Condensed(PrinterModeState.Off))
                .AddLF();
        }

        public byte[] AutoTest()
        {
            return new byte[] {29, 40, 65, 2, 0, 0, 2};
        }

        #endregion
    }
}