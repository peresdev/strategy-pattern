namespace Strategy
{
    public class ContaPoupanca : IConta
    {
        public double calcularTaxa(double valor) => valor * 0.8;
    }
}