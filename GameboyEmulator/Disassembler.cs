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
            // http://www.pastraiser.com/cpu/gameboy/gameboy_opcodes.html
            //Console.Write(String.Format("{0, 4}", bytes[position].ToString("x2")));
            int length = 1;
            switch (bytes[position])
            {
                case 0x00:
                    Console.WriteLine("NOP");
                    break;
                case 0x01:
                    // LD BC,d16
                    Console.WriteLine("LD BC,{0}{1}", ByteToString(bytes[position + 2]), ByteToString(bytes[position + 1]));
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
                    Console.WriteLine("LD {0}{1}, SP", ByteToString(bytes[position + 2]), ByteToString(bytes[position + 1]));
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
                case 0x10:
                    Console.WriteLine("STOP 0");
                    break;
                case 0x11:
                    Console.WriteLine("LD DE,d16");
                    break;
                case 0x12:
                    Console.WriteLine("LD (DE),A");
                    break;
                case 0x13:
                    Console.WriteLine("INC DE");
                    break;
                case 0x14:
                    Console.WriteLine("INC D");
                    break;
                case 0x15:
                    Console.WriteLine("DEC D");
                    break;
                case 0x16:
                    Console.WriteLine("LD D,d8");
                    break;
                case 0x17:
                    Console.WriteLine("RLA");
                    break;
                case 0x18:
                    Console.WriteLine("JR r8");
                    break;
                case 0x19:
                    Console.WriteLine("ADD HL,DE");
                    break;
                case 0x1A:
                    Console.WriteLine("LD A,(DE)");
                    break;
                case 0x1B:
                    Console.WriteLine("DEC DE");
                    break;
                case 0x1C:
                    Console.WriteLine("INC E");
                    break;
                case 0x1D:
                    Console.WriteLine("DEC E");
                    break;
                case 0x1E:
                    Console.WriteLine("LD E,d8");
                    break;
                case 0x1F:
                    Console.WriteLine("RRA");
                    break;
                case 0x20:
                    Console.WriteLine("JR NZ,r8");
                    break;
                case 0x21:
                    Console.WriteLine("LD HL,d16");
                    break;
                case 0x22:
                    Console.WriteLine("LD (HL+),A");
                    break;
                case 0x23:
                    Console.WriteLine("INC HL");
                    break;
                case 0x24:
                    Console.WriteLine("INC H");
                    break;
                case 0x25:
                    Console.WriteLine("DEC H");
                    break;
                case 0x26:
                    Console.WriteLine("LD H, d8");
                    break;
                case 0x27:
                    Console.WriteLine("DAA");
                    break;
                case 0x28:
                    Console.WriteLine("JR Z,r8");
                    break;
                case 0x29:
                    Console.WriteLine("ADD HL, HL");
                    break;
                case 0x2A:
                    Console.WriteLine("LD A, (HL+)");
                    break;
                case 0x2B:
                    Console.WriteLine("DEC HL");
                    break;
                case 0x2C:
                    Console.WriteLine("INC L");
                    break;
                case 0x2D:
                    Console.WriteLine("DEC L");
                    break;
                case 0x2E:
                    Console.WriteLine("LD L, d8");
                    break;
                case 0x2F:
                    Console.WriteLine("CPL");
                    break;
                case 0x30:
                    Console.WriteLine("JR NC, r8");
                    break;
                case 0x31:
                    Console.WriteLine("LD SP, d16");
                    break;
                case 0x32:
                    Console.WriteLine("LD (HL-),A");
                    break;
                case 0x33:
                    Console.WriteLine("INC SP");
                    break;
                case 0x34:
                    Console.WriteLine("INC (HL)");
                    break;
                case 0x35:
                    Console.WriteLine("DEC (HL)");
                    break;
                case 0x36:
                    Console.WriteLine("LD (HL),d8");
                    break;
                case 0x37:
                    Console.WriteLine("SCF");
                    break;
                case 0x38:
                    Console.WriteLine("JR C,r8");
                    break;
                case 0x39:
                    Console.WriteLine("ADD HL,SP");
                    break;
                case 0x3A:
                    Console.WriteLine("LD A,(HL-)");
                    break;
                case 0x3B:
                    Console.WriteLine("DEC SP");
                    break;
                case 0x3C:
                    Console.WriteLine("INC A");
                    break;
                case 0x3D:
                    Console.WriteLine("DEC A");
                    break;
                case 0x3E:
                    Console.WriteLine("LD A,d8");
                    break;
                case 0x3F:
                    Console.WriteLine("CCF");
                    break;
                case 0x40:
                    Console.WriteLine("LD B,B");
                    break;
                case 0x41:
                    Console.WriteLine("LD B,C");
                    break;
                case 0x42:
                    Console.WriteLine("LD B,D");
                    break;
                case 0x43:
                    Console.WriteLine("LD B,E");
                    break;
                case 0x44:
                    Console.WriteLine("LD B,H");
                    break;
                case 0x45:
                    Console.WriteLine("LD B,L");
                    break;
                case 0x46:
                    Console.WriteLine("LD B,(HL)");
                    break;
                case 0x47:
                    Console.WriteLine("LD B,A");
                    break;
                case 0x48:
                    Console.WriteLine("LD C,B");
                    break;
                case 0x49:
                    Console.WriteLine("LD C,C");
                    break;
                case 0x4A:
                    Console.WriteLine("LD C,D");
                    break;
                case 0x4B:
                    Console.WriteLine("LD C,E");
                    break;
                case 0x4C:
                    Console.WriteLine("LD C,H");
                    break;
                case 0x4D:
                    Console.WriteLine("LD C,L");
                    break;
                case 0x4E:
                    Console.WriteLine("LD C,(HL)");
                    break;
                case 0x4F:
                    Console.WriteLine("LD C,A");
                    break;
                case 0x50:
                    Console.WriteLine("LD D,B");
                    break;
                case 0x51:
                    Console.WriteLine("LD D,C");
                    break;
                case 0x52:
                    Console.WriteLine("LD D,D");
                    break;
                case 0x53:
                    Console.WriteLine("LD D,E");
                    break;
                case 0x54:
                    Console.WriteLine("LD D,H");
                    break;
                case 0x55:
                    Console.WriteLine("LD D,L");
                    break;
                case 0x56:
                    Console.WriteLine("LD D,(HL)");
                    break;
                case 0x57:
                    Console.WriteLine("LD D,A");
                    break;
                case 0x58:
                    Console.WriteLine("LD E,B");
                    break;
                case 0x59:
                    Console.WriteLine("LD E,C");
                    break;
                case 0x5A:
                    Console.WriteLine("LD E,D");
                    break;
                case 0x5B:
                    Console.WriteLine("LD E,E");
                    break;
                case 0x5C:
                    Console.WriteLine("LD E,H");
                    break;
                case 0x5D:
                    Console.WriteLine("LD E,L");
                    break;
                case 0x5E:
                    Console.WriteLine("LD E,(HL)");
                    break;
                case 0x5F:
                    Console.WriteLine("LD E,A");
                    break;
                case 0x60:
                    Console.WriteLine("LD H,B");
                    break;
                case 0x61:
                    Console.WriteLine("LD H,C");
                    break;
                case 0x62:
                    Console.WriteLine("LD H,D");
                    break;
                case 0x63:
                    Console.WriteLine("LD H,E");
                    break;
                case 0x64:
                    Console.WriteLine("LD H,H");
                    break;
                case 0x65:
                    Console.WriteLine("LD H,L");
                    break;
                case 0x66:
                    Console.WriteLine("LD H,(HL)");
                    break;
                case 0x67:
                    Console.WriteLine("LD H,A");
                    break;
                case 0x68:
                    Console.WriteLine("LD L,B");
                    break;
                case 0x69:
                    Console.WriteLine("LD L,C");
                    break;
                case 0x6A:
                    Console.WriteLine("LD L,D");
                    break;
                case 0x6B:
                    Console.WriteLine("LD L,E");
                    break;
                case 0x6C:
                    Console.WriteLine("LD L,H");
                    break;
                case 0x6D:
                    Console.WriteLine("LD L,L");
                    break;
                case 0x6E:
                    Console.WriteLine("LD L,(HL)");
                    break;
                case 0x6F:
                    Console.WriteLine("LD L,A");
                    break;
                case 0x70:
                    Console.WriteLine("LD (HL),B");
                    break;
                case 0x71:
                    Console.WriteLine("LD (HL),C");
                    break;
                case 0x72:
                    Console.WriteLine("LD (HL),D");
                    break;
                case 0x73:
                    Console.WriteLine("LD (HL),E");
                    break;
                case 0x74:
                    Console.WriteLine("LD (HL),H");
                    break;
                case 0x75:
                    Console.WriteLine("LD (HL),L");
                    break;
                case 0x76:
                    Console.WriteLine("HALT");
                    break;
                case 0x77:
                    Console.WriteLine("LD (HL),A");
                    break;
                case 0x78:
                    Console.WriteLine("LD A,B");
                    break;
                case 0x79:
                    Console.WriteLine("LD A,C");
                    break;
                case 0x7A:
                    Console.WriteLine("LD A,D");
                    break;
                case 0x7B:
                    Console.WriteLine("LD A,E");
                    break;
                case 0x7C:
                    Console.WriteLine("LD A,H");
                    break;
                case 0x7D:
                    Console.WriteLine("LD A,L");
                    break;
                case 0x7E:
                    Console.WriteLine("LD A,(HL)");
                    break;
                case 0x7F:
                    Console.WriteLine("LD A,A");
                    break;
                case 0x80:
                    Console.WriteLine("ADD A,B");
                    break;
                case 0x81:
                    Console.WriteLine("ADD A,C");
                    break;
                case 0x82:
                    Console.WriteLine("ADD A,D");
                    break;
                case 0x83:
                    Console.WriteLine("ADD A,E");
                    break;
                case 0x84:
                    Console.WriteLine("ADD A,H");
                    break;
                case 0x85:
                    Console.WriteLine("ADD A,L");
                    break;
                case 0x86:
                    Console.WriteLine("ADD A,(HL)");
                    break;
                case 0x87:
                    Console.WriteLine("ADD A,A");
                    break;
                case 0x88:
                    Console.WriteLine("ADC A,B");
                    break;
                case 0x89:
                    Console.WriteLine("ADC A,C");
                    break;
                case 0x8A:
                    Console.WriteLine("ADC A,D");
                    break;
                case 0x8B:
                    Console.WriteLine("ADC A,E");
                    break;
                case 0x8C:
                    Console.WriteLine("ADC A,H");
                    break;
                case 0x8D:
                    Console.WriteLine("ADC A,L");
                    break;
                case 0x8E:
                    Console.WriteLine("ADC A,(HL)");
                    break;
                case 0x8F:
                    Console.WriteLine("ADC A,A");
                    break;
                case 0x90:
                    Console.WriteLine("SUB B");
                    break;
                case 0x91:
                    Console.WriteLine("SUB C");
                    break;
                case 0x92:
                    Console.WriteLine("SUB D");
                    break;
                case 0x93:
                    Console.WriteLine("SUB E");
                    break;
                case 0x94:
                    Console.WriteLine("SUB H");
                    break;
                case 0x95:
                    Console.WriteLine("SUB L");
                    break;
                case 0x96:
                    Console.WriteLine("SUB (HL)");
                    break;
                case 0x97:
                    Console.WriteLine("SUB A");
                    break;
                case 0x98:
                    Console.WriteLine("SBC A,B");
                    break;
                case 0x99:
                    Console.WriteLine("SBC A,C");
                    break;
                case 0x9A:
                    Console.WriteLine("SBC A,D");
                    break;
                case 0x9B:
                    Console.WriteLine("SBC A,E");
                    break;
                case 0x9C:
                    Console.WriteLine("SBC A,H");
                    break;
                case 0x9D:
                    Console.WriteLine("SBC A,L");
                    break;
                case 0x9E:
                    Console.WriteLine("SBC A,(HL)");
                    break;
                case 0x9F:
                    Console.WriteLine("SBC A,A");
                    break;
                case 0xA0:
                    Console.WriteLine("AND B");
                    break;
                case 0xA1:
                    Console.WriteLine("AND C");
                    break;
                case 0xA2:
                    Console.WriteLine("AND D");
                    break;
                case 0xA3:
                    Console.WriteLine("AND E");
                    break;
                case 0xA4:
                    Console.WriteLine("AND H");
                    break;
                case 0xA5:
                    Console.WriteLine("AND L");
                    break;
                case 0xA6:
                    Console.WriteLine("AND (HL)");
                    break;
                case 0xA7:
                    Console.WriteLine("AND A");
                    break;
                case 0xA8:
                    Console.WriteLine("XOR B");
                    break;
                case 0xA9:
                    Console.WriteLine("XOR C");
                    break;
                case 0xAA:
                    Console.WriteLine("XOR D");
                    break;
                case 0xAB:
                    Console.WriteLine("XOR E");
                    break;
                case 0xAC:
                    Console.WriteLine("XOR H");
                    break;
                case 0xAD:
                    Console.WriteLine("XOR L");
                    break;
                case 0xAE:
                    Console.WriteLine("XOR (HL)");
                    break;
                case 0xAF:
                    Console.WriteLine("XOR A");
                    break;
                case 0xB0:
                    Console.WriteLine("OR B");
                    break;
                case 0xB1:
                    Console.WriteLine("OR C");
                    break;
                case 0xB2:
                    Console.WriteLine("OR D");
                    break;
                case 0xB3:
                    Console.WriteLine("OR E");
                    break;
                case 0xB4:
                    Console.WriteLine("OR H");
                    break;
                case 0xB5:
                    Console.WriteLine("OR L");
                    break;
                case 0xB6:
                    Console.WriteLine("OR (HL)");
                    break;
                case 0xB7:
                    Console.WriteLine("OR A");
                    break;
                case 0xB8:
                    Console.WriteLine("CP B");
                    break;
                case 0xB9:
                    Console.WriteLine("CP C");
                    break;
                case 0xBA:
                    Console.WriteLine("CP D");
                    break;
                case 0xBB:
                    Console.WriteLine("CP E");
                    break;
                case 0xBC:
                    Console.WriteLine("CP H");
                    break;
                case 0xBD:
                    Console.WriteLine("CP L");
                    break;
                case 0xBE:
                    Console.WriteLine("CP (HL)");
                    break;
                case 0xBF:
                    Console.WriteLine("CP A");
                    break;
                case 0xC0:
                    Console.WriteLine("RET NZ");
                    break;
                case 0xC1:
                    Console.WriteLine("POP BC");
                    break;
                case 0xC2:
                    Console.WriteLine("JP NZ,a16");
                    break;
                case 0xC3:
                    Console.WriteLine("JP a16");
                    break;
                case 0xC4:
                    Console.WriteLine("CALL NZ,a16");
                    break;
                case 0xC5:
                    Console.WriteLine("PUSH BC");
                    break;
                case 0xC6:
                    Console.WriteLine("ADD A,d8");
                    break;
                case 0xC7:
                    Console.WriteLine("RST 00H");
                    break;
                case 0xC8:
                    Console.WriteLine("RET Z");
                    break;
                case 0xC9:
                    Console.WriteLine("RET");
                    break;
                case 0xCA:
                    Console.WriteLine("JP Z,a16");
                    break;
                case 0xCB:
                    Console.WriteLine("PREFIX CB");
                    break;
                case 0xCC:
                    Console.WriteLine("CALL Z,a16");
                    break;
                case 0xCD:
                    Console.WriteLine("CALL a16");
                    break;
                case 0xCE:
                    Console.WriteLine("ADC A,d8");
                    break;
                case 0xCF:
                    Console.WriteLine("RST 08H");
                    break;
                case 0xD0:
                    Console.WriteLine("RET NC");
                    break;
                case 0xD1:
                    Console.WriteLine("POP DE");
                    break;
                case 0xD2:
                    Console.WriteLine("JP NC,a16");
                    break;
                case 0xD4:
                    Console.WriteLine("CALL NC,a16");
                    break;
                case 0xD5:
                    Console.WriteLine("PUSH DE");
                    break;
                case 0xD6:
                    Console.WriteLine("SUB d8");
                    break;
                case 0xD7:
                    Console.WriteLine("RST 10H");
                    break;
                case 0xD8:
                    Console.WriteLine("RET C");
                    break;
                case 0xD9:
                    Console.WriteLine("RETI");
                    break;
                case 0xDA:
                    Console.WriteLine("JP C,a16");
                    break;
                case 0xDC:
                    Console.WriteLine("CALL C,a16");
                    break;
                case 0xDE:
                    Console.WriteLine("SBC A,d8");
                    break;
                case 0xDF:
                    Console.WriteLine("RST 18H");
                    break;
                case 0xE0:
                    Console.WriteLine("LDH (a8),A");
                    break;
                case 0xE1:
                    Console.WriteLine("POP HL");
                    break;
                case 0xE2:
                    Console.WriteLine("LD (C),A");
                    break;
                case 0xE5:
                    Console.WriteLine("PUSH HL");
                    break;
                case 0xE6:
                    Console.WriteLine("AND d8");
                    break;
                case 0xE7:
                    Console.WriteLine("RST 20H");
                    break;
                case 0xE8:
                    Console.WriteLine("ADD SP,r8");
                    break;
                case 0xE9:
                    Console.WriteLine("JP (HL)");
                    break;
                case 0xEA:
                    Console.WriteLine("LD (a16),A");
                    break;
                case 0xEE:
                    Console.WriteLine("XOR d8");
                    break;
                case 0xEF:
                    Console.WriteLine("RST 28H");
                    break;
                case 0xF0:
                    Console.WriteLine("LDH A,(a8)");
                    break;
                case 0xF1:
                    Console.WriteLine("POP AF");
                    break;
                case 0xF2:
                    Console.WriteLine("LD A,(C)");
                    break;
                case 0xF3:
                    Console.WriteLine("DI");
                    break;
                case 0xF5:
                    Console.WriteLine("PUSH AF");
                    break;
                case 0xF6:
                    Console.WriteLine("OR d8");
                    break;
                case 0xF7:
                    Console.WriteLine("RST 30H");
                    break;
                case 0xF8:
                    Console.WriteLine("LD HL,SP+r8");
                    break;
                case 0xF9:
                    Console.WriteLine("LD SP,HL");
                    break;
                case 0xFA:
                    Console.WriteLine("LD A,(a16)");
                    break;
                case 0xFB:
                    Console.WriteLine("EI");
                    break;
                case 0xFE:
                    Console.WriteLine("CP d8");
                    break;
                case 0xFF:
                    Console.WriteLine("RST 38H");
                    break;
                default:
                    Console.WriteLine("Not implemented");
                    break;
            }
            position += length;

        }

        private string ByteToString(byte b)
        {
            return String.Format("{0}", b.ToString("x2")).ToUpper();
        }
    }
}
