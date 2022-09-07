

internal partial class Program
{
    private static void Main(string[] args)
    {
        var frase = "A noite está linda!";


        Console.WriteLine(frase.Substring(0, 5));

        Console.WriteLine(frase);

        Console.WriteLine(frase.Replace("linda", "bonita"));  // troca palavra escrita

        frase.Trim(); // removee espaços vazios
        frase.TrimEnd(); // remove só do final
        frase.TrimStart(); // remove só do inicio

        Console.WriteLine(frase.Trim('!'));

        string cpf = "5555555";

       //frase.PadLeft(); //acrecenta

        Console.WriteLine(cpf.PadLeft(11, '0')); // acrecentou

        // string frase2 = frase + "Ensolarado"; concatenar

        // string frase3 = $"{frase} ensolarado"; //interpolaçã, atribuiu ao final 

        Console.WriteLine();

    }
}