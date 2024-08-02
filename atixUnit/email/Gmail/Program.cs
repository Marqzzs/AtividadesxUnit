using Gmail;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um email para validação: ");
        string email = Console.ReadLine();

        bool isValid = Email.ValidarEmail(email);

        if (isValid)
        {
            Console.WriteLine("O email é válido.");
        }
        else
        {
            Console.WriteLine("O email é inválido.");
        }
    }
}