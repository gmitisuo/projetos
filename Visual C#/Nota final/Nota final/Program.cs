using Nota_final;
string targetPath = @"C:\Users\gabri\OneDrive\Área de Trabalho\Area teste\Nota\NotaFinal.txt";
string sourcePath = @"C:\Users\gabri\OneDrive\Área de Trabalho\Area teste\Nota\Nota.txt";
Dictionary<string, string> AlunoNotas = new Dictionary<string, string>();
Calculo calculo = new Calculo();
try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        string[] separar = line.Split('|');
        AlunoNotas.Add(separar[0], separar[1]);
    }

}
catch (IOException e)
{
    Console.WriteLine("An error occured");
    Console.WriteLine(e.Message);
}
foreach (KeyValuePair<string,string> item in AlunoNotas)
{
    Console.WriteLine(item.Key + " : " + item.Value);
    string resultado = calculo.NotaFinal(item.Key,item.Value);
    try
    {
        using (StreamWriter sw = File.AppendText(targetPath))
        {
            sw.WriteLine(resultado);
        }
    }
    catch (IOException e)
    {
        Console.WriteLine("An error occured");
        Console.WriteLine(e.Message);
    }
}