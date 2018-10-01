using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameboyEmulator
{
    public class CPU
    {
        // Registers
        // Pairs for 16 bit operations are
        // AF
        // BC
        // DE
        // HL
        private byte A;
        private byte B;
        private byte C;
        private byte D;
        private byte E;
        private byte F;
        private byte H;
        private byte L;

        private UInt16 SP; // stack pointer
        private UInt16 PC; // program counter (not used for now, position used instead)

        int position = 0;

        public CPU()
        {
            
        }

        public void Go(byte[] bytes) {
            while (bytes.Length > position)
            {
                ExecuteOP(bytes);
            }
        }

        private void ExecuteOP(byte[] bytes) {
            // http://www.pastraiser.com/cpu/gameboy/gameboy_opcodes.html
            //Console.Write(String.Format("{0, 4}", bytes[position].ToString("x2")));
            int length = 1;
            switch (bytes[position])
            {
                case 0x00:
                    // NOP
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x01:
                    //  LD BC,d16
                    //  bytes[position + 2]
                    //  bytes[position + 1]
                    length = 3;
                    break;
                case 0x02:
                    // LD (BC),A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x03:
                    // INC BC
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x04:
                    // INC B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x05:
                    // DEC B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x06:
                    //  LD B,d8
                    //  bytes[position + 1]
                    length = 2;
                    break;
                case 0x07:
                    // RLCA
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x08:
                    //  LD (a16),SP
                    //  bytes[position + 2]
                    //  bytes[position + 1]
                    length = 3;
                    break;
                case 0x09:
                    // ADD HL,BC
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x0A:
                    // LD A,(BC)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x0B:
                    // DEC BC
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x0C:
                    // INC C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x0D:
                    // DEC C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x0E:
                    //  LD C,d8
                    //  bytes[position + 1]
                    length = 2;
                    break;
                case 0x0F:
                    // RRCA
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x10:
                    // STOP 0
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x11:
                    // LD DE,d16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x12:
                    // LD (DE),A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x13:
                    // INC DE
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x14:
                    // INC D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x15:
                    // DEC D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x16:
                    // LD D,d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x17:
                    // RLA
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x18:
                    // JR r8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x19:
                    // ADD HL,DE
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x1A:
                    // LD A,(DE)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x1B:
                    // DEC DE
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x1C:
                    // INC E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x1D:
                    // DEC E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x1E:
                    // LD E,d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x1F:
                    // RRA
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x20:
                    // JR NZ,r8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x21:
                    // LD HL,d16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x22:
                    // LD (HL+),A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x23:
                    // INC HL
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x24:
                    // INC H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x25:
                    // DEC H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x26:
                    // LD H, d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x27:
                    // DAA
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x28:
                    // JR Z,r8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x29:
                    // ADD HL, HL
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x2A:
                    // LD A, (HL+)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x2B:
                    // DEC HL
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x2C:
                    // INC L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x2D:
                    // DEC L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x2E:
                    // LD L, d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x2F:
                    // CPL
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x30:
                    // JR NC, r8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x31:
                    // LD SP, d16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x32:
                    // LD (HL-),A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x33:
                    // INC SP
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x34:
                    // INC (HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x35:
                    // DEC (HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x36:
                    // LD (HL),d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x37:
                    // SCF
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x38:
                    // JR C,r8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x39:
                    // ADD HL,SP
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x3A:
                    // LD A,(HL-)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x3B:
                    // DEC SP
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x3C:
                    // INC A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x3D:
                    // DEC A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x3E:
                    // LD A,d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x3F:
                    // CCF
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x40:
                    // LD B,B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x41:
                    // LD B,C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x42:
                    // LD B,D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x43:
                    // LD B,E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x44:
                    // LD B,H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x45:
                    // LD B,L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x46:
                    // LD B,(HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x47:
                    // LD B,A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x48:
                    // LD C,B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x49:
                    // LD C,C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x4A:
                    // LD C,D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x4B:
                    // LD C,E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x4C:
                    // LD C,H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x4D:
                    // LD C,L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x4E:
                    // LD C,(HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x4F:
                    // LD C,A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x50:
                    // LD D,B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x51:
                    // LD D,C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x52:
                    // LD D,D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x53:
                    // LD D,E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x54:
                    // LD D,H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x55:
                    // LD D,L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x56:
                    // LD D,(HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x57:
                    // LD D,A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x58:
                    // LD E,B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x59:
                    // LD E,C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x5A:
                    // LD E,D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x5B:
                    // LD E,E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x5C:
                    // LD E,H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x5D:
                    // LD E,L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x5E:
                    // LD E,(HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x5F:
                    // LD E,A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x60:
                    // LD H,B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x61:
                    // LD H,C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x62:
                    // LD H,D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x63:
                    // LD H,E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x64:
                    // LD H,H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x65:
                    // LD H,L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x66:
                    // LD H,(HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x67:
                    // LD H,A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x68:
                    // LD L,B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x69:
                    // LD L,C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x6A:
                    // LD L,D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x6B:
                    // LD L,E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x6C:
                    // LD L,H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x6D:
                    // LD L,L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x6E:
                    // LD L,(HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x6F:
                    // LD L,A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x70:
                    // LD (HL),B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x71:
                    // LD (HL),C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x72:
                    // LD (HL),D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x73:
                    // LD (HL),E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x74:
                    // LD (HL),H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x75:
                    // LD (HL),L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x76:
                    // HALT
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x77:
                    // LD (HL),A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x78:
                    // LD A,B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x79:
                    // LD A,C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x7A:
                    // LD A,D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x7B:
                    // LD A,E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x7C:
                    // LD A,H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x7D:
                    // LD A,L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x7E:
                    // LD A,(HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x7F:
                    // LD A,A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x80:
                    // ADD A,B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x81:
                    // ADD A,C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x82:
                    // ADD A,D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x83:
                    // ADD A,E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x84:
                    // ADD A,H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x85:
                    // ADD A,L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x86:
                    // ADD A,(HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x87:
                    // ADD A,A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x88:
                    // ADC A,B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x89:
                    // ADC A,C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x8A:
                    // ADC A,D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x8B:
                    // ADC A,E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x8C:
                    // ADC A,H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x8D:
                    // ADC A,L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x8E:
                    // ADC A,(HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x8F:
                    // ADC A,A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x90:
                    // SUB B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x91:
                    // SUB C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x92:
                    // SUB D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x93:
                    // SUB E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x94:
                    // SUB H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x95:
                    // SUB L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x96:
                    // SUB (HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x97:
                    // SUB A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x98:
                    // SBC A,B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x99:
                    // SBC A,C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x9A:
                    // SBC A,D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x9B:
                    // SBC A,E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x9C:
                    // SBC A,H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x9D:
                    // SBC A,L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x9E:
                    // SBC A,(HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0x9F:
                    // SBC A,A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xA0:
                    // AND B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xA1:
                    // AND C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xA2:
                    // AND D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xA3:
                    // AND E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xA4:
                    // AND H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xA5:
                    // AND L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xA6:
                    // AND (HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xA7:
                    // AND A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xA8:
                    // XOR B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xA9:
                    // XOR C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xAA:
                    // XOR D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xAB:
                    // XOR E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xAC:
                    // XOR H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xAD:
                    // XOR L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xAE:
                    // XOR (HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xAF:
                    // XOR A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xB0:
                    // OR B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xB1:
                    // OR C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xB2:
                    // OR D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xB3:
                    // OR E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xB4:
                    // OR H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xB5:
                    // OR L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xB6:
                    // OR (HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xB7:
                    // OR A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xB8:
                    // CP B
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xB9:
                    // CP C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xBA:
                    // CP D
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xBB:
                    // CP E
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xBC:
                    // CP H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xBD:
                    // CP L
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xBE:
                    // CP (HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xBF:
                    // CP A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xC0:
                    // RET NZ
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xC1:
                    // POP BC
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xC2:
                    // JP NZ,a16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xC3:
                    // JP a16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xC4:
                    // CALL NZ,a16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xC5:
                    // PUSH BC
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xC6:
                    // ADD A,d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xC7:
                    // RST 00H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xC8:
                    // RET Z
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xC9:
                    // RET
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xCA:
                    // JP Z,a16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xCB:
                    // PREFIX CB
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xCC:
                    // CALL Z,a16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xCD:
                    // CALL a16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xCE:
                    // ADC A,d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xCF:
                    // RST 08H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xD0:
                    // RET NC
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xD1:
                    // POP DE
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xD2:
                    // JP NC,a16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xD4:
                    // CALL NC,a16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xD5:
                    // PUSH DE
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xD6:
                    // SUB d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xD7:
                    // RST 10H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xD8:
                    // RET C
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xD9:
                    // RETI
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xDA:
                    // JP C,a16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xDC:
                    // CALL C,a16
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xDE:
                    // SBC A,d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xDF:
                    // RST 18H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xE0:
                    // LDH (a8),A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xE1:
                    // POP HL
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xE2:
                    // LD (C),A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xE5:
                    // PUSH HL
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xE6:
                    // AND d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xE7:
                    // RST 20H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xE8:
                    // ADD SP,r8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xE9:
                    // JP (HL)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xEA:
                    // LD (a16),A
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xEE:
                    // XOR d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xEF:
                    // RST 28H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xF0:
                    // LDH A,(a8)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xF1:
                    // POP AF
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xF2:
                    // LD A,(C)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xF3:
                    // DI
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xF5:
                    // PUSH AF
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xF6:
                    // OR d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xF7:
                    // RST 30H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xF8:
                    // LD HL,SP+r8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xF9:
                    // LD SP,HL
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xFA:
                    // LD A,(a16)
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xFB:
                    // EI
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xFE:
                    // CP d8
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                case 0xFF:
                    // RST 38H
                    throw new OPCodeUnimplementedException(1, "Not Implemented"); 
                    break;
                default:
                    // Forgot this one
                    throw new OPCodeUnimplementedException(1, "Forgot one, oops"); 
                    break;
            }
            position += length;
        }

        // might be helpful later (16 bit to 8 bit) 
        // byte lowByte = (byte)(value & 0xff);
        // byte highByte = (byte)((value >> 8) & 0xff);

        public class OPCodeUnimplementedException : Exception
        {
            public OPCodeUnimplementedException(int severity, string message) : base(message)
            {
                // do whatever you want with severity
            }
        }
    }


}
