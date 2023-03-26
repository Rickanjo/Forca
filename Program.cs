Console.WriteLine("----Forca----\n");

String PalavraSecreta;
String Letra;
Console.Write("Qual a palavra Secreta?");
PalavraSecreta = Console.ReadLine()!;

Console.Write("Qual é a letra?" );
Letra = Console.ReadLine()!
.Trim()
.Substring(0,1)
.ToLower();

bool LetraExistente = PalavraSecreta
.ToLower()
.Contains (Letra);

Console.WriteLine($"\nA letra \"{Letra}\" existe na palavra secreta => {LetraExistente}");