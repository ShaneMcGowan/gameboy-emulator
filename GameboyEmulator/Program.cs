using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameboyEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int headerOffset = int.Parse("0x0134".Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine(headerOffset);

            Console.WriteLine("--------------------------");
            Console.WriteLine("---------EMULATOR---------");
            Console.WriteLine("--------------------------");

            byte[] rom = File.ReadAllBytes("game.gb");
            Console.WriteLine("Number of bytes: " + rom.Length);

            Console.WriteLine("\n hex");

            // Disassembler disassembler = new Disassembler();
            // disassembler.DisassembleROM(rom);
            CPU cpu = new CPU();
            cpu.Go(rom);
            
            Console.ReadKey();

        }
    }
}
