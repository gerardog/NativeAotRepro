// See https://aka.ms/new-console-template for more information
using System.IO.Pipes;

Console.WriteLine("Hello, World!");

var ps = new PipeSecurity();

using (var dataPipe = NamedPipeServerStreamConstructors.New("test", PipeDirection.InOut, 10,
    PipeTransmissionMode.Message, PipeOptions.Asynchronous, 1024, 1024, ps))
{
    Console.WriteLine("Named pipe created");
} 