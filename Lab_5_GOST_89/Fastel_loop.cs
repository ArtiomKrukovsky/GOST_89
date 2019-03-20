using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_GOST_89
{
    class Fastel_loop
    {
        uint N1, N2, X_key;
        /// <summary>
        /// Получение значений ключа, разделение блока N(N1,N2)
        /// </summary>
        /// <param name="date"></param>
        /// <param name="key"></param>
        public Fastel_loop(ulong date, uint key)
        {
            N1 = (uint)(date >> 32);
            N2 = (uint)((date << 32) >> 32);
            X_key = key;
        }

        /// <summary>
        /// Младшая половина преобразуемого блока складывается(2^32) с ключом
        /// </summary>
        /// <returns></returns>
        private uint FirstStep()
        {
            return (uint)((X_key + N1) % Convert.ToUInt64(Math.Pow(2, 32)));
        }
        /// <summary>
        /// Получение 4-битовых Si с помощью сдвига и замена по таблице замен
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        private uint SecondStep(uint S)
        {
            uint S_rez, S0, S1, S2, S3, S4, S5, S6, S7;

            S0 = S >> 28;
            S1 = (S << 4) >> 28;
            S2 = (S << 8) >> 28;
            S3 = (S << 12) >> 28;
            S4 = (S << 16) >> 28;
            S5 = (S << 20) >> 28;
            S6 = (S << 24) >> 28;
            S7 = (S << 28) >> 28;

            S0 = Replace_table.Table0[S0];
            S1 = Replace_table.Table0[0x10 + S1];
            S2 = Replace_table.Table0[0x20 + S2];
            S3 = Replace_table.Table0[0x30 + S3];
            S4 = Replace_table.Table0[0x40 + S4];
            S5 = Replace_table.Table0[0x50 + S5];
            S6 = Replace_table.Table0[0x60 + S6];
            S7 = Replace_table.Table0[0x70 + S7];

            S_rez = S7 + (S6 << 4) + (S5 << 8) + (S4 << 12) + (S3 << 16) +
                    (S2 << 20) + (S1 << 24) + (S0 << 28);

            return S_rez;
        }
        /// <summary>
        /// Сдвиг на 11 битов
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        private uint ThirdStep(uint S)
        {
            return (S << 11) | (S >> 21);
        }

        private ulong FourthAndFifthStep(bool IsLastStep, uint S)
        {
            ulong N;

            S = (S ^ N2);

            if (!IsLastStep)
            {
                N2 = N1;
                N1 = S;
            }
            else
                N2 = S;

            N = ((ulong)N2) | (((ulong)N1) << 32);

            return N;
        }
        public ulong IsContin(bool IsLastStep)
        {
            return FourthAndFifthStep(IsLastStep, ThirdStep(SecondStep(FirstStep())));
        }
    }
}
