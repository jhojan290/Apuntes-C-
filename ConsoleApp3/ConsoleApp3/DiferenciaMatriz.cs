using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class DiferenciaMatriz
    {
        public int Diferencia(List<List<int>> matriz)
        {
            int sumaDiagonal = 0;
            for (int i = 0; i < 3; i++)
            {
                sumaDiagonal += matriz[i][i];
            }
            return sumaDiagonal;
        }    
    }
}
