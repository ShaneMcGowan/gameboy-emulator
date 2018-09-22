using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameboyEmulator
{
    public class Disassembler
    {
        int position = 0;
        // int length = 0;

        public Disassembler()
        {

        }

        public void DisassembleROM(byte[] bytes)
        {
            while (bytes.Length > position)
            {
                DisassembleOP(bytes);
            }

            /*
             if (position % 8 == 0)
               {
                   Console.WriteLine("");
               }
               */
        }

        public void DisassembleOP(byte[] bytes)
        {
            //Console.Write(String.Format("{0, 4}", bytes[position].ToString("x2")));
            int length = 1;
            switch (bytes[position])
            {
                case 0x00:
                    Console.WriteLine("NOP");
                    break;
                case 0x01:
                    // LD BC,d16
                    Console.WriteLine("LD BC,{0}{1}", ByteToString(bytes[position + 1]), ByteToString(bytes[position + 2]));
                    length = 3;
                    break;
                case 0x02:
                    Console.WriteLine("LD (BC),A");
                    break;
                case 0x03:
                    Console.WriteLine("INC BC");
                    break;
                case 0x04:
                    Console.WriteLine("INC B");
                    break;
                case 0x05:
                    Console.WriteLine("DEC B");
                    break;
                case 0x06:
                    // LD B,d8
                    Console.WriteLine("LD B,{0}", ByteToString(bytes[position + 1]));
                    length = 2;
                    break;
                case 0x07:
                    Console.WriteLine("RLCA");
                    break;
                case 0x08:
                    // LD (a16),SP
                    Console.WriteLine("LD {0}{1}, SP", ByteToString(bytes[position + 1]), ByteToString(bytes[position + 2]));
                    length = 3;
                    break;
                case 0x09:
                    Console.WriteLine("ADD HL,BC");
                    break;
                case 0x0A:
                    Console.WriteLine("LD A,(BC)");
                    break;
                case 0x0B:
                    Console.WriteLine("DEC BC");
                    break;
                case 0x0C:
                    Console.WriteLine("INC C");
                    break;
                case 0x0D:
                    Console.WriteLine("DEC C");
                    break;
                case 0x0E:
                    // LD C,d8
                    Console.WriteLine("LD C, {0}", ByteToString(bytes[position + 1]));
                    length = 2;
                    break;
                case 0x0F:
                    Console.WriteLine("RRCA");
                    break;
                default:
                    Console.WriteLine("Not implemented");
                    break;
            }
            position += length;
            // http://www.pastraiser.com/cpu/gameboy/gameboy_opcodes.html
        }

        private string ByteToString(byte b) {
            return String.Format("{0}", b.ToString("x2")).ToUpper();
        }
    }
}
