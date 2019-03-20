using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_GOST_89
{
    class Encryptor:Convertation
    {
        byte[] encrByteFile;
        uint[] uintKey;
        ulong[] longData;

        public Encryptor(byte[] data, byte[] key)
        {
            uintKey = GetUIntKeyArray(key);
            longData = GetULongDataArray(data);
            encrByteFile = ConvertToByte(EncryptFile());
        }

        public byte[] GetEncryptFile
        {
            get { return encrByteFile; }
        }

        private ulong[] EncryptFile()
        {
            Fastel_loop[] K = new Fastel_loop[8];
            ulong[] ulongEncrFile = new ulong[longData.Length];

            for (int k = 0; k < longData.Length; k++)
            {
                ulongEncrFile[k] = longData[k];

                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < K.Length; i++)
                    {
                        K[i] = new Fastel_loop(ulongEncrFile[k], uintKey[i]);
                        ulongEncrFile[k] = K[i].IsContin(false);
                    }
                }

                for (int i = K.Length - 1; i >= 0; i--)
                {
                    K[i] = new Fastel_loop(ulongEncrFile[k], uintKey[i]);

                    if (i != 0)
                        ulongEncrFile[k] = K[i].IsContin(false);
                    else
                        ulongEncrFile[k] = K[i].IsContin(true);
                }
            }

            return ulongEncrFile;
        }
    }
}
