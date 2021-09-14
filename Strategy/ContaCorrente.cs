namespace Strategy
{
    public class ContaCorrente : IConta
    {
        public double calcularTaxa(double valor) => valor * 0.5;
    }
}