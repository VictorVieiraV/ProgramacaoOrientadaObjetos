using System.Globalization;

namespace POO.Models {
    class Aluno {
        public string Nome;
        public double NotaA;
        public double NotaB;
        public double NotaC;

        public double CalculaNotaFinal() {
            return (NotaA + NotaB + NotaC);
        }

        public string CalculaAprovacao() {
            if (CalculaNotaFinal() >= 60.0) {
                return "Aprovado";
            } else {
                return "Reprovado \n" + PontosFaltantes();
            }
        }
        public string PontosFaltantes() {
            return $"Faltaram {(60.0 - CalculaNotaFinal()).ToString("F2", CultureInfo.InvariantCulture)} pontos";
        }
    }
}
