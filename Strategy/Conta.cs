namespace Strategy
{
    public class Conta : IConta
    {
        private IConta _conta;
        
        public Conta(IConta conta)
        {
            _conta = conta;
        }
 
        public double calcularTaxa(double valor) => _conta.calcularTaxa(valor);
    }
}