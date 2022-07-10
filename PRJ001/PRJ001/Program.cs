using Domain;
using Exceptions;

class Program {
    public static void Main(string[] args)
    {
        try
        {
            var numeroAgencia = 38;
            ContaCorrente conta = new ContaCorrente();
            conta.Conta = "1234";
            conta.Titular = "Rafael Alves da Costa Junior";
            conta.NumeroAgencia = numeroAgencia;
            conta.NomeAgencia = "Itibiraçá Arruda";
            conta.Saldo = 24568.90;

            conta.Cliente = new Cliente();
            conta.Cliente.Id = 1;
            conta.Cliente.Documento = "005.604.843-21";
            conta.Cliente.Nome = "Rafael Costa";
            conta.Cliente.Endereco = "Quadra 307 Norte Alameda 24, Lote 35";
            conta.Cliente.dataNascimento = DateTime.Now;
            
            //provacar a exception
            //var contador = 100;
            //var resultado = contador / 0;

            conta.printAll();
            conta.Cliente.printAll();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exceção: "+e.StackTrace);
            throw new RiscoSaudeException();
        }
            
    }   

}


