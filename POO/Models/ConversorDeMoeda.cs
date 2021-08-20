namespace POO.Models {
    class ConversorDeMoeda {
        public static double Iof = 0.06;
        public static double ConversaoDolar(double cotacao, double quantidade) {

            double imposto = (cotacao * quantidade * Iof);
            return cotacao * quantidade + imposto;
        }
    }
}
