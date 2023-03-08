using System;
using System.Runtime.CompilerServices;

int somaVogais, somaConsoantes;
Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine();
Console.WriteLine("A quantidade de caracteres dessa palavra é: " + palavra.Length);

somaVogais = 0;
somaConsoantes = 0;
string nome = palavra.ToLower();

for (int i = 0; i < nome.Length; i++)
{
    if (char.IsLetter(nome[i]))
    {


        switch (nome[i])
        {
            case 'a':
                somaVogais++;
                break;
            case 'e':
                somaVogais++;
                break;
            case 'i':
                somaVogais++;
                break;
            case 'o':
                somaVogais++;
                break;
            case 'u':
                somaVogais++;
                break;
            default:
                somaConsoantes++;
                break;
        }

    }  

}
Console.WriteLine("A soma das vogais de "+(nome) + " é: " + somaVogais);
Console.WriteLine("A soma das consoantes de " + (nome) + " é: " + somaConsoantes);

char [] novoNome = new char[nome.Length];

for (int i = 0; i < nome.Length; i++)
{
    if (i % 2 == 0)
    {
        novoNome[i] = char.ToUpper(nome[i]);
        
    }
    else
    {
       novoNome[i] = char.ToLower(nome[i]);
    }
}

string nomeString = new string(novoNome);
Console.WriteLine("Intercalação maiúsculo e minúsculo entre os caracteres: " + nomeString);


char[] reverso = palavra.Reverse().ToArray();
string nomeContrario = new string(reverso);
Console.WriteLine($"A palavra {palavra} espelhada é: {nomeContrario}");