using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_GOST_89
{
    class DeEncryptor:Convertation
    {
        byte[] DencrByteFile;
        uint[] uintKey;
        ulong[] longData;

        public DeEncryptor(byte[] data, byte[] key)
        {
            uintKey = GetUIntKeyArray(key);
            longData = GetULongDataArray(data);
            DencrByteFile = ConvertToByte(DeEncryptFile());
        }

        public byte[] GetDeEncryptFile
        {
            get { return DencrByteFile; }
        }

        private ulong[] DeEncryptFile()
        {
            Fastel_loop[] K = new Fastel_loop[8];
            ulong[] ulongDeEncrFile = new ulong[longData.Length];

            for (int k = 0; k < longData.Length; k++)
            {
                ulongDeEncrFile[k] = longData[k];

                for (int i = 0; i < K.Length; i++)
                {
                    K[i] = new Fastel_loop(ulongDeEncrFile[k], uintKey[i]);
                    ulongDeEncrFile[k] = K[i].IsContin(false);
                }

                for (int j = 0; j < 3; j++)
                {
                    for (int i = K.Length - 1; i >= 0; i--)
                    {
                        K[i] = new Fastel_loop(ulongDeEncrFile[k], uintKey[i]);

                        if ((j == 2) && (i == 0))
                            ulongDeEncrFile[k] = K[i].IsContin(true);
                        else
                            ulongDeEncrFile[k] = K[i].IsContin(false);
                    }
                }  
            }
            return ulongDeEncrFile;
        }
    }
}
