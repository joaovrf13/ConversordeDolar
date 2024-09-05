
using System.Globalization; 

namespace Exercicio01 {
    internal class Dolar {

        public static double Reais;
        public static double ValorComprado;
       
       public static double ValoraserPago() {
            return Reais * ValorComprado;
        }
        
        public static double IOF() {
            return ValoraserPago() * 6.0/100.0;
        }

        public static double ValorFinal() {
            return ValoraserPago() + IOF();
        }
    }
}
