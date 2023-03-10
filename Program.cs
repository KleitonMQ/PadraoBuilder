using PadraoBuilder;

var builder = new ComputadorBuilder();
var montador = new MontadorDeComputador(builder);

montador.MontarComputadorGamer();
var computadorGamer = builder.ObterComputador();

montador.MontarComputadorEscritorio();
var computadorEscritorio = builder.ObterComputador();

// Exibindo as informações dos computadores montados
Console.WriteLine("Computador Gamer:");
Console.WriteLine($"Modelo: {computadorGamer.Modelo}");
Console.WriteLine($"Processador: {computadorGamer.Processador}");
Console.WriteLine($"Memória RAM: {computadorGamer.MemoriaRam}");
Console.WriteLine($"Armazenamento: {computadorGamer.Armazenamento}");
Console.WriteLine($"Placa de vídeo: {computadorGamer.PlacaDeVideo}");

Console.WriteLine();

Console.WriteLine("Computador de Escritório:");
Console.WriteLine($"Modelo: {computadorEscritorio.Modelo}");
Console.WriteLine($"Processador: {computadorEscritorio.Processador}");
Console.WriteLine($"Memória RAM: {computadorEscritorio.MemoriaRam}");
Console.WriteLine($"Armazenamento: {computadorEscritorio.Armazenamento}");
Console.WriteLine($"Placa de vídeo: {computadorEscritorio.PlacaDeVideo}");