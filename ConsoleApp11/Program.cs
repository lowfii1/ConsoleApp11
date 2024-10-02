int n = 10;
Console.WriteLine(n.ToString());
string frase = "socorram me subi no onibus em marrocos";
Console.WriteLine(frase);
Console.WriteLine($" 1 -> {frase.Length}");// 1 número de caracteres da frase:
var palavras = frase.Split(' ');
for (int i = palavras.Length - 1; i > -1; i--) // 2 separe a frase em uma matriz de palavras e exiba na ordem inversa
{
    Console.WriteLine($" {palavras[i]} ");
}
Console.WriteLine();

Console.WriteLine(frase.Replace(' ', '-'));

Console.WriteLine(frase.Substring(frase.LastIndexOf('m')));

for (int i = 0; i < frase.Length; i++)
{
    //Console.WriteLine(frase[i]);
    Console.WriteLine(frase.Substring(i,1));
}

var on = frase.Split('');

Console.ReadKey();




// número de caracteres:

// separe a frase em uma matriz de palavras e exiba na ordem inversa

// substitua os espaços da frase por traços (-)

// exiba apenas a palavra marrocos 

// mostre a frase em forma de coluna
