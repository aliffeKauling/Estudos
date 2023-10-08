using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteComTDD
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int val1, int val2)
        {
            int resul = val1 + val2;
            listaHistorico.Insert(0, "Res: " + resul);
            return resul;
        }
        
        public int subtrair(int val1, int val2)
        {
            int resul = val1 - val2;
            listaHistorico.Insert(0, "Res: " + resul);

            return resul;
        }

        public int multiplicar(int val1, int val2)
        {
            int resul = val1 * val2;
            listaHistorico.Insert(0, "Res: " + resul);

            return resul;
        }

        public int dividir(int val1, int val2)
        {
            int resul = val1 / val2;
            listaHistorico.Insert(0, "Res: " + resul);

            return resul;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
