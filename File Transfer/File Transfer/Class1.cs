using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace File_Transfer
{

        class Class1
        {
            static byte[,] sBox = new byte[16, 16]
            {
             {0x63, 0x7C, 0x77, 0x7B, 0xF2, 0x6B, 0x6F, 0xC5, 0x30, 0x01, 0x67, 0x2B, 0xFE, 0xD7, 0xAB, 0x76},
        {0xCA, 0x82, 0xC9, 0x7D, 0xFA, 0x59, 0x47, 0xF0, 0xAD, 0xD4, 0xA2, 0xAF, 0x9C, 0xA4, 0x72, 0xC0},
        {0xB7, 0xFD, 0x93, 0x26, 0x36, 0x3F, 0xF7, 0xCC, 0x34, 0xA5, 0xE5, 0xF1, 0x71, 0xD8, 0x31, 0x15},
        {0x04, 0xC7, 0x23, 0xC3, 0x18, 0x96, 0x05, 0x9A, 0x07, 0x12, 0x80, 0xE2, 0xEB, 0x27, 0xB2, 0x75},
        {0x09, 0x83, 0x2C, 0x1A, 0x1B, 0x6E, 0x5A, 0xA0, 0x52, 0x3B, 0xD6, 0xB3, 0x29, 0xE3, 0x2F, 0x84},
        {0x53, 0xD1, 0x00, 0xED, 0x20, 0xFC, 0xB1, 0x5B, 0x6A, 0xCB, 0xBE, 0x39, 0x4A, 0x4C, 0x58, 0xCF},
        {0xD0, 0xEF, 0xAA, 0xFB, 0x43, 0x4D, 0x33, 0x85, 0x45, 0xF9, 0x02, 0x7F, 0x50, 0x3C, 0x9F, 0xA8},
        {0x51, 0xA3, 0x40, 0x8F, 0x92, 0x9D, 0x38, 0xF5, 0xBC, 0xB6, 0xDA, 0x21, 0x10, 0xFF, 0xF3, 0xD2},
        {0xCD, 0x0C, 0x13, 0xEC, 0x5F, 0x97, 0x44, 0x17, 0xC4, 0xA7, 0x7E, 0x3D, 0x64, 0x5D, 0x19, 0x73},
        {0x60, 0x81, 0x4F, 0xDC, 0x22, 0x2A, 0x90, 0x88, 0x46, 0xEE, 0xB8, 0x14, 0xDE, 0x5E, 0x0B, 0xDB},
        {0xE0, 0x32, 0x3A, 0x0A, 0x49, 0x06, 0x24, 0x5C, 0xC2, 0xD3, 0xAC, 0x62, 0x91, 0x95, 0xE4, 0x79},
        {0xE7, 0xC8, 0x37, 0x6D, 0x8D, 0xD5, 0x4E, 0xA9, 0x6C, 0x56, 0xF4, 0xEA, 0x65, 0x7A, 0xAE, 0x08},
        {0xBA, 0x78, 0x25, 0x2E, 0x1C, 0xA6, 0xB4, 0xC6, 0xE8, 0xDD, 0x74, 0x1F, 0x4B, 0xBD, 0x8B, 0x8A},
        {0x70, 0x3E, 0xB5, 0x66, 0x48, 0x03, 0xF6, 0x0E, 0x61, 0x35, 0x57, 0xB9, 0x86, 0xC1, 0x1D, 0x9E},
        {0xE1, 0xF8, 0x98, 0x11, 0x69, 0xD9, 0x8E, 0x94, 0x9B, 0x1E, 0x87, 0xE9, 0xCE, 0x55, 0x28, 0xDF},
        {0x8C, 0xA1, 0x89, 0x0D, 0xBF, 0xE6, 0x42, 0x68, 0x41, 0x99, 0x2D, 0x0F, 0xB0, 0x54, 0xBB, 0x16}
            };

            static byte[,] invSBox = new byte[16, 16]
            {
            // Inverse S-box
             {0x52, 0x09, 0x6A, 0xD5, 0x30, 0x36, 0xA5, 0x38, 0xBF, 0x40, 0xA3, 0x9E, 0x81, 0xF3, 0xD7, 0xFB},
        {0x7C, 0xE3, 0x39, 0x82, 0x9B, 0x2F, 0xFF, 0x87, 0x34, 0x8E, 0x43, 0x44, 0xC4, 0xDE, 0xE9, 0xCB},
        {0x54, 0x7B, 0x94, 0x32, 0xA6, 0xC2, 0x23, 0x3D, 0xEE, 0x4C, 0x95, 0x0B, 0x42, 0xFA, 0xC3, 0x4E},
        {0x08, 0x2E, 0xA1, 0x66, 0x28, 0xD9, 0x24, 0xB2, 0x76, 0x5B, 0xA2, 0x49, 0x6D, 0x8B, 0xD1, 0x25},
        {0x72, 0xF8, 0xF6, 0x64, 0x86, 0x68, 0x98, 0x16, 0xD4, 0xA4, 0x5C, 0xCC, 0x5D, 0x65, 0xB6, 0x92},
        {0x6C, 0x70, 0x48, 0x50, 0xFD, 0xED, 0xB9, 0xDA, 0x5E, 0x15, 0x46, 0x57, 0xA7, 0x8D, 0x9D, 0x84},
        {0x90, 0xD8, 0xAB, 0x00, 0x8C, 0xBC, 0xD3, 0x0A, 0xF7, 0xE4, 0x58, 0x05, 0xB8, 0xB3, 0x45, 0x06},
        {0xD0, 0x2C, 0x1E, 0x8F, 0xCA, 0x3F, 0x0F, 0x02, 0xC1, 0xAF, 0xBD, 0x03, 0x01, 0x13, 0x8A, 0x6B},
        {0x3A, 0x91, 0x11, 0x41, 0x4F, 0x67, 0xDC, 0xEA, 0x97, 0xF2, 0xCF, 0xCE, 0xF0, 0xB4, 0xE6, 0x73},
        {0x96, 0xAC, 0x74, 0x22, 0xE7, 0xAD, 0x35, 0x85, 0xE2, 0xF9, 0x37, 0xE8, 0x1C, 0x75, 0xDF, 0x6E},
        {0x47, 0xF1, 0x1A, 0x71, 0x1D, 0x29, 0xC5, 0x89, 0x6F, 0xB7, 0x62, 0x0E, 0xAA, 0x18, 0xBE, 0x1B},
        {0xFC, 0x56, 0x3E, 0x4B, 0xC6, 0xD2, 0x79, 0x20, 0x9A, 0xDB, 0xC0, 0xFE, 0x78, 0xCD, 0x5A, 0xF4},
        {0x1F, 0xDD, 0xA8, 0x33, 0x88, 0x07, 0xC7, 0x31, 0xB1, 0x12, 0x10, 0x59, 0x27, 0x80, 0xEC, 0x5F},
        {0x60, 0x51, 0x7F, 0xA9, 0x19, 0xB5, 0x4A, 0x0D, 0x2D, 0xE5, 0x7A, 0x9F, 0x93, 0xC9, 0x9C, 0xEF},
        {0xA0, 0xE0, 0x3B, 0x4D, 0xAE, 0x2A, 0xF5, 0xB0, 0xC8, 0xEB, 0xBB, 0x3C, 0x83, 0x53, 0x99, 0x61},
        {0x17, 0x2B, 0x04, 0x7E, 0xBA, 0x77, 0xD6, 0x26, 0xE1, 0x69, 0x14, 0x63, 0x55, 0x21, 0x0C, 0x7D}
            };

          public  static int Nr; // Number of rounds
          public  static int Nk; // Number of 32-bit words comprising the key
          public  static int Nb = 4; // Number of columns (32-bit words) comprising the State

            static byte[] keySchedule; // Expanded key schedule

            static byte[,] state = new byte[4, 4]; // AES state matrix
          
            static void SubBytes()
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        state[i, j] = sBox[state[i, j] >> 4, state[i, j] & 0x0F];
                    }
                }
            }

            static void ShiftRows()
            {
                byte[,] temp = new byte[4, 4];

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        temp[i, j] = state[i, (j + i) % 4];
                    }
                }

                state = temp;
            }

            static void MixColumns()
            {
                byte[,] temp = new byte[4, 4]
                {
                    { 0x02, 0x03, 0x01, 0x01 },
                    { 0x01, 0x02, 0x03, 0x01 },
                    { 0x01, 0x01, 0x02, 0x03 },
                    { 0x03, 0x01, 0x01, 0x02 }
                };

                byte[,] result = new byte[4, 4];

                for (int col = 0; col < 4; col++)
                {
                    for (int row = 0; row < 4; row++)
                    {
                        byte val = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            val ^= Multiply(temp[row, k], state[k, col]);
                        }
                        result[row, col] = val;
                    }
                }

                state = result;
            }

            static byte Multiply(byte a, byte b)
            {
                byte p = 0;
                byte counter;
                byte hi_bit_set;
                for (counter = 0; counter < 8; counter++)
                {
                    if ((b & 1) != 0)
                    {
                        p ^= a;
                    }
                    hi_bit_set = (byte)(a & 0x80);
                    a <<= 1;
                    if (hi_bit_set != 0)
                    {
                        a ^= 0x1B; /* x^8 + x^4 + x^3 + x + 1 */
                    }
                    b >>= 1;
                }
                return p;
            }

            static void InvSubBytes()
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        state[i, j] = invSBox[state[i, j] >> 4, state[i, j] & 0x0F];
                    }
                }
            }

            static void InvShiftRows()
            {
                byte[,] temp = new byte[4, 4];

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        temp[i, j] = state[i, (j - i + 4) % 4];
                    }
                }

                state = temp;
            }

            static void InvMixColumns()
            {
                byte[,] temp = new byte[4, 4]
                {
                    { 0x0E, 0x0B, 0x0D, 0x09 },
                    { 0x09, 0x0E, 0x0B, 0x0D },
                    { 0x0D, 0x09, 0x0E, 0x0B },
                    { 0x0B, 0x0D, 0x09, 0x0E }
                };

                byte[,] result = new byte[4, 4];

                for (int col = 0; col < 4; col++)
                {
                    for (int row = 0; row < 4; row++)
                    {
                        byte val = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            val ^= Multiply(temp[row, k], state[k, col]);
                        }
                        result[row, col] = val;
                    }
                }

                state = result;
            }


           public static void EncryptFile(string inputFile, string outputFile, string key)
            {
                byte[] iv = GenerateIV();

                using (FileStream inputStream = new FileStream(inputFile, FileMode.Open))
                using (FileStream outputStream = new FileStream(outputFile, FileMode.Create))
                {
                    outputStream.Write(iv, 0, iv.Length);

                    byte[] buffer = new byte[16];
                    int bytesRead;

                    while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        if (bytesRead < 16) // Padding
                        {
                            for (int i = bytesRead; i < 16; i++)
                            {
                                buffer[i] = 0x00;
                            }
                        }

                        for (int i = 0; i < 16; i++)
                        {
                            state[i % 4, i / 4] = buffer[i];
                        }

                        AddRoundKey(0);

                        for (int round = 1; round < Nr; round++)
                        {
                            SubBytes();
                            ShiftRows();
                            MixColumns();
                            AddRoundKey(round);
                        }

                        SubBytes();
                        ShiftRows();
                        AddRoundKey(Nr);

                        // Write encrypted block to output stream
                        for (int i = 0; i < 16; i++)
                        {
                            buffer[i] = state[i % 4, i / 4];
                        }

                        outputStream.Write(buffer, 0, buffer.Length);
                    }
                }
            }

           public static void DecryptFile(string inputFile, string outputFile, string key)
            {
                using (FileStream inputStream = new FileStream(inputFile, FileMode.Open))
                using (FileStream outputStream = new FileStream(outputFile, FileMode.Create))
                {
                    byte[] iv = new byte[16];
                    inputStream.Read(iv, 0, iv.Length);

                    byte[] buffer = new byte[16];
                    int bytesRead;

                    while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        for (int i = 0; i < 16; i++)
                        {
                            state[i % 4, i / 4] = buffer[i];
                        }

                        AddRoundKey(Nr);

                        for (int round = Nr - 1; round > 0; round--)
                        {
                            InvShiftRows();
                            InvSubBytes();
                            AddRoundKey(round);
                            InvMixColumns();
                        }

                        InvShiftRows();
                        InvSubBytes();
                        AddRoundKey(0);

                        //// Write decrypted block to output stream
                        //for (int i = 0; i < 16; i++)
                        //{
                        //    buffer[i] = state[i % 4, i / 4];
                        //}

                        //outputStream.Write(buffer, 0, buffer.Length);
                        //// Remove padding
                        for (int i = 0; i < 16; i++)
                        {
                            if (state[i % 4, i / 4] != 0x00)
                            {
                                buffer[i] = state[i % 4, i / 4];
                                outputStream.WriteByte(buffer[i]);
                            }
                            else
                            {
                                break; // Stop writing if encounter padding
                            }
                        }

                    }
                }
            }

            public static void KeyExpansion(string key)
            {
                keySchedule = new byte[Nb * (Nr + 1) * 4];

                // Initial copy of key into key schedule
                for (int i = 0; i < Nk * 4; i++)
                {
                    keySchedule[i] = (byte)key[i];
                }

                int bytesGenerated = Nk * 4;
                int rconIteration = 1;
                byte[] temp = new byte[4];

                while (bytesGenerated < Nb * (Nr + 1) * 4)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        temp[i] = keySchedule[bytesGenerated - 4 + i];
                    }

                    if (bytesGenerated % (Nk * 4) == 0)
                    {
                        temp = SubWord(RotWord(temp));
                        temp[0] ^= (byte)(Rcon(rconIteration) & 0xFF);
                        rconIteration++;
                    }
                    else if (Nk > 6 && bytesGenerated % (Nk * 4) == Nb * 4)
                    {
                        temp = SubWord(temp);
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        keySchedule[bytesGenerated] = (byte)(keySchedule[bytesGenerated - Nk * 4] ^ temp[i]);
                        bytesGenerated++;
                    }
                }
            }

            static byte[] SubWord(byte[] word)
            {
                for (int i = 0; i < 4; i++)
                {
                    word[i] = sBox[word[i] >> 4, word[i] & 0x0F];
                }
                return word;
            }

            static byte[] RotWord(byte[] word)
            {
                byte temp = word[0];
                for (int i = 0; i < 3; i++)
                {
                    word[i] = word[i + 1];
                }
                word[3] = temp;
                return word;
            }

            static int Rcon(int i)
            {
                int c = 1;
                if (i == 0) return 0;
                while (i != 1)
                {
                    c = Mul(c, 2);
                    i--;
                }
                return c << 24;
            }

            static int Mul(int a, int b)
            {
                int p = 0;
                while (b != 0)
                {
                    if ((b & 1) != 0)
                    {
                        p ^= a;
                    }
                    if ((a & 0x80) != 0)
                    {
                        a = (a << 1) ^ 0x11b;
                    }
                    else
                    {
                        a <<= 1;
                    }
                    b >>= 1;
                }
                return p;
            }

            static void AddRoundKey(int round)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        state[j, i] ^= keySchedule[round * Nb * 4 + i * 4 + j];
                    }
                }
            }

            // Implement SubBytes, ShiftRows, MixColumns, InvSubBytes, InvShiftRows, InvMixColumns
            //...

            static byte[] GenerateIV()
            {
                // Generate initialization vector
                byte[] iv = new byte[16];
                Random rnd = new Random();
                rnd.NextBytes(iv);
                return iv;
            }


        }
    }


