using System;
using System.IO;
using System.Collections.Generic;

namespace File_Transfer
{
    class Class1
    {
        static byte[,] sBox = new byte[16, 16] {
        // S-Box
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

        static byte[,] invSBox = new byte[16, 16] {
        // Inverse S-Box
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

        static byte[] Rcon = new byte[] {
        // Round constant
        0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x80, 0x1B, 0x36
    };

        static byte[][] KeyExpansion(byte[] key)
        {
            byte[][] expandedKeys = new byte[11][];
            for (int i = 0; i < 11; i++)
            {
                expandedKeys[i] = new byte[16];
            }

            // Copy the original key to the first entry of the expandedKeys array
            Array.Copy(key, 0, expandedKeys[0], 0, 16);

            for (int i = 1; i < 11; i++)
            {
                byte[] temp = new byte[4];
                Array.Copy(expandedKeys[i - 1], 12, temp, 0, 4);

                // Rotate the bytes
                byte tempByte = temp[0];
                temp[0] = temp[1];
                temp[1] = temp[2];
                temp[2] = temp[3];
                temp[3] = tempByte;

                // Substitute each byte
                for (int j = 0; j < 4; j++)
                {
                    temp[j] = sBox[temp[j] >> 4, temp[j] & 0x0F];
                }

                temp[0] ^= Rcon[i - 1];

                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        expandedKeys[i][4 * j + k] = (byte)(expandedKeys[i - 1][4 * j + k] ^ temp[j]);
                    }
                }
            }

            return expandedKeys;
        }

        static byte[][] InvKeyExpansion(byte[] key)
        {
            byte[][] expandedKeys = new byte[11][];
            for (int i = 0; i < 11; i++)
            {
                expandedKeys[i] = new byte[16];
            }

            // Copy the original key to the last entry of the expandedKeys array
            Array.Copy(key, 0, expandedKeys[10], 0, 16);

            for (int i = 9; i >= 0; i--)
            {
                byte[] temp = new byte[4];
                Array.Copy(expandedKeys[i + 1], 12, temp, 0, 4);

                // Rotate the bytes
                byte tempByte = temp[3];
                temp[3] = temp[2];
                temp[2] = temp[1];
                temp[1] = temp[0];
                temp[0] = tempByte;

                // Substitute each byte
                for (int j = 0; j < 4; j++)
                {
                    temp[j] = invSBox[temp[j] >> 4, temp[j] & 0x0F];
                }

                temp[0] ^= Rcon[i];

                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        expandedKeys[i][4 * j + k] = (byte)(expandedKeys[i + 1][4 * j + k] ^ temp[j]);
                    }
                }
            }

            return expandedKeys;
        }

        static byte[] Encrypt(byte[] input, byte[] key)
        {
            byte[][] state = new byte[4][];
            for (int i = 0; i < 4; i++)
            {
                state[i] = new byte[4];
            }

            byte[][] roundKeys = KeyExpansion(key);

            int roundCount = roundKeys.Length / 16;

            int inputOffset = 0;
            for (int round = 0; round < roundCount - 1; round++)
            {
                // AddRoundKey
                AddRoundKey(state, roundKeys, input, inputOffset);
                inputOffset += 16;

                // SubBytes
                SubBytes(state);

                // ShiftRows
                ShiftRows(state);

                // MixColumns
                MixColumns(state);
            }

            // Final round
            AddRoundKey(state, roundKeys, input, inputOffset);

            byte[] output = new byte[16];
            for (int i = 0; i < 4; i++)
            {
                Array.Copy(state[i], 0, output, i * 4, 4);
            }

            return output;
        }

        static byte[] Decrypt(byte[] cipherText, byte[] key)
        {
            byte[][] state = new byte[4][];
            for (int i = 0; i < 4; i++)
            {
                state[i] = new byte[4];
            }

            byte[][] roundKeys = InvKeyExpansion(key);
            Array.Reverse(roundKeys);

            int roundCount = roundKeys.Length / 16;

            int inputOffset = 0;
            for (int round = 0; round < roundCount - 1; round++)
            {
                // AddRoundKey
                AddRoundKey(state, roundKeys, cipherText, inputOffset);
                inputOffset += 16;

                // InvShiftRows
                InvShiftRows(state);

                // InvSubBytes
                InvSubBytes(state);

                // InvMixColumns
                if (round < roundCount - 2)
                {
                    InvMixColumns(state);
                }
            }

            // Final round
            AddRoundKey(state, roundKeys, cipherText, inputOffset);

            byte[] output = new byte[16];
            for (int i = 0; i < 4; i++)
            {
                Array.Copy(state[i], 0, output, i * 4, 4);
            }

            return output;
        }

        static void AddRoundKey(byte[][] state, byte[][] roundKeys, byte[] input, int inputOffset)
        {
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    state[j][i] ^= input[inputOffset + index];
                    index++;
                }
            }
        }

        static void SubBytes(byte[][] state)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    state[i][j] = sBox[state[i][j] >> 4, state[i][j] & 0x0F];
                }
            }
        }

        static void InvSubBytes(byte[][] state)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    state[i][j] = invSBox[state[i][j] >> 4, state[i][j] & 0x0F];
                }
            }
        }

        static void ShiftRows(byte[][] state)
        {
            for (int i = 1; i < 4; i++)
            {
                byte[] temp = new byte[i];
                Array.Copy(state[i], 0, temp, 0, i);
                Array.Copy(state[i], i, state[i], 0, 4 - i);
                Array.Copy(temp, 0, state[i], 4 - i, i);
            }
        }

        static void InvShiftRows(byte[][] state)
        {
            for (int i = 1; i < 4; i++)
            {
                byte[] temp = new byte[4 - i];
                Array.Copy(state[i], 0, temp, 0, 4 - i);
                Array.Copy(state[i], 4 - i, state[i], 0, i);
                Array.Copy(temp, 0, state[i], i, 4 - i);
            }
        }

        static void MixColumns(byte[][] state)
        {
            for (int i = 0; i < 4; i++)
            {
                byte[] column = new byte[4];
                for (int j = 0; j < 4; j++)
                {
                    column[j] = state[j][i];
                }
                state[0][i] = (byte)(GFMultiply(column[0], 2) ^ GFMultiply(column[1], 3) ^ column[2] ^ column[3]);
                state[1][i] = (byte)(column[0] ^ GFMultiply(column[1], 2) ^ GFMultiply(column[2], 3) ^ column[3]);
                state[2][i] = (byte)(column[0] ^ column[1] ^ GFMultiply(column[2], 2) ^ GFMultiply(column[3], 3));
                state[3][i] = (byte)(GFMultiply(column[0], 3) ^ column[1] ^ column[2] ^ GFMultiply(column[3], 2));
            }
        }

        static void InvMixColumns(byte[][] state)
        {
            for (int i = 0; i < 4; i++)
            {
                byte[] column = new byte[4];
                for (int j = 0; j < 4; j++)
                {
                    column[j] = state[j][i];
                }
                state[0][i] = (byte)(GFMultiply(column[0], 14) ^ GFMultiply(column[1], 11) ^ GFMultiply(column[2], 13) ^ GFMultiply(column[3], 9));
                state[1][i] = (byte)(GFMultiply(column[0], 9) ^ GFMultiply(column[1], 14) ^ GFMultiply(column[2], 11) ^ GFMultiply(column[3], 13));
                state[2][i] = (byte)(GFMultiply(column[0], 13) ^ GFMultiply(column[1], 9) ^ GFMultiply(column[2], 14) ^ GFMultiply(column[3], 11));
                state[3][i] = (byte)(GFMultiply(column[0], 11) ^ GFMultiply(column[1], 13) ^ GFMultiply(column[2], 9) ^ GFMultiply(column[3], 14));
            }
        }

        static byte GMultiply(byte a, byte b)
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

        static byte GFMultiply(byte a, byte factor)
        {
            byte ret = 0;
            byte i;
            for (i = 0; i < 8; i++)
            {
                if ((factor & 1) != 0)
                {
                    ret ^= a;
                }
                bool hi_bit_set = (a & 0x80) != 0;
                a <<= 1;
                if (hi_bit_set)
                {
                    a ^= 0x1B;
                }
                factor >>= 1;
            }
            return ret;
        }

        static byte[] AddPadding(byte[] input)
        {
            int paddingLength = 16 - (input.Length % 16);
            byte[] paddedInput = new byte[input.Length + paddingLength];
            Array.Copy(input, paddedInput, input.Length);
            for (int i = input.Length; i < paddedInput.Length; i++)
            {
                paddedInput[i] = (byte)paddingLength;
            }
            return paddedInput;
        }

        static byte[] RemovePadding(byte[] input)
        {
            int paddingLength = input[input.Length - 1];
            byte[] unpaddedInput = new byte[input.Length - paddingLength];
            Array.Copy(input, unpaddedInput, unpaddedInput.Length);
            return unpaddedInput;
        }

        public static void EncryptFile(string inputFile, string outputFile, byte[] key, byte[] iv)
        {
            byte[] inputBytes = File.ReadAllBytes(inputFile);
            inputBytes = AddPadding(inputBytes);

            List<byte[]> encryptedBlocks = new List<byte[]>();

            byte[] previousCipherBlock = iv;
            for (int i = 0; i < inputBytes.Length; i += 16)
            {
                byte[] blockToEncrypt = new byte[16];
                Array.Copy(inputBytes, i, blockToEncrypt, 0, 16);

                for (int j = 0; j < 16; j++)
                {
                    blockToEncrypt[j] ^= previousCipherBlock[j];
                }

                byte[] encryptedBlock = Encrypt(blockToEncrypt, key);

                encryptedBlocks.Add(encryptedBlock);

                previousCipherBlock = encryptedBlock;
            }

            using (FileStream fs = new FileStream(outputFile, FileMode.Create))
            {
                foreach (byte[] block in encryptedBlocks)
                {
                    fs.Write(block, 0, block.Length);
                }
            }
        }

        public static void DecryptFile(string inputFile, string outputFile, byte[] key, byte[] iv)
        {
            byte[] cipherText = File.ReadAllBytes(inputFile);

            List<byte[]> decryptedBlocks = new List<byte[]>();

            byte[] previousCipherBlock = iv;
            for (int i = 0; i < cipherText.Length; i += 16)
            {
                byte[] blockToDecrypt = new byte[16];
                Array.Copy(cipherText, i, blockToDecrypt, 0, 16);

                byte[] decryptedBlock = Decrypt(blockToDecrypt, key);

                for (int j = 0; j < 16; j++)
                {
                    decryptedBlock[j] ^= previousCipherBlock[j];
                }

                decryptedBlocks.Add(decryptedBlock);

                previousCipherBlock = blockToDecrypt;
            }

            byte[] decryptedData = new byte[decryptedBlocks.Count * 16];
            int offset = 0;
            foreach (byte[] block in decryptedBlocks)
            {
                Array.Copy(block, 0, decryptedData, offset, 16);
                offset += 16;
            }

            decryptedData = RemovePadding(decryptedData);

            File.WriteAllBytes(outputFile, decryptedData);
        }

      
        
    }
}