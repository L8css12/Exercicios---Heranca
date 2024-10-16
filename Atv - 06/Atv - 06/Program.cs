using Atv._06;

Gato gato = new Gato
{
    Especie = "Siamês"
};
Console.WriteLine($"A espécie do gato é: {gato.Especie}");
gato.EmitirSom();

Porco porco = new Porco
{
    Especie = "Tayassu"
};
Console.WriteLine($"A espécie do porco é: {porco.Especie}");
porco.EmitirSom();

Capivara capivara = new Capivara
{
    Especie = "Capivara"
};
Console.WriteLine($"A espécie da capivara é: {capivara.Especie}");
capivara.EmitirSom();

Console.ReadKey();