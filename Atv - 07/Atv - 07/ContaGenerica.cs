namespace Atv._07
{
    public abstract class ContaGenerica
    {
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Saldo { get; set; }

        public abstract void Depositar();
        public abstract void Sacar();
    }

    public class ContaCorrente : ContaGenerica
    {
        public int limite { get; set; }
        public override void Depositar()
        {
            Console.WriteLine("Você depositou R$15.786,99");
        }

        public override void Sacar()
        {
            Console.WriteLine("Você sacou R$5.786,99");
        }
    }
}