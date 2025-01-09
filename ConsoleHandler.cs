using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Sql_Interactor
{
    internal class ConsoleHandler
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleScreenBufferSize(IntPtr hConsoleOutput, Coord dwSize);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleWindowInfo(IntPtr hConsoleOutput, bool bAbsolute, ref SmallRect lpConsoleWindow);

        private const int STD_OUTPUT_HANDLE = -11;

        [StructLayout(LayoutKind.Sequential)]
        private struct Coord
        {
            public short X;
            public short Y;

            public Coord(short x, short y)
            {
                X = x;
                Y = y;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SmallRect
        {
            public short Left;
            public short Top;
            public short Right;
            public short Bottom;
        }

        public static void SetConsoleSize(int width, int height)
        {
            IntPtr handle = GetStdHandle(STD_OUTPUT_HANDLE);

            Coord bufferSize = new Coord((short)width, (short)height);
            SetConsoleScreenBufferSize(handle, bufferSize);

            SmallRect windowSize = new SmallRect
            {
                Left = 0,
                Top = 0,
                Right = (short)(width - 1),
                Bottom = (short)(height - 1)
            };
            SetConsoleWindowInfo(handle, true, ref windowSize);
        }
    }
}
