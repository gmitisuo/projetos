using Criptografia;
Cripto cripto = new Cripto();
Console.WriteLine("Insira uma Senha:");
string senha = Console.ReadLine();
string resultado = " ";

char[] caracteres = senha.ToCharArray();
foreach (char c in caracteres)
{
    string a = c.ToString();
    string b = cripto.Crip(a);
    resultado = resultado.Insert(resultado.Length, b);
}
resultado = resultado.TrimStart(' ');
Console.WriteLine(resultado);