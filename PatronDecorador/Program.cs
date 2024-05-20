// See https://aka.ms/new-console-template for more information

using PatronDecorador;

IOrdenador MiOrdenadorBasico = new OrdenadorBasico();
IOrdenador ordenadorAna = new DecoradorRAMMaxima( MiOrdenadorBasico);
IOrdenador ordenadorLuisa = new DecoradorDiscoSolido(new DecoradorRAMMaxima( MiOrdenadorBasico));
IOrdenador ordenadorGeronimo = new DecoradorAVerSiCuela(new DecoradorDiscoSolido(MiOrdenadorBasico));
Console.WriteLine($"El ordenador de Manolo es:{MiOrdenadorBasico.ToString()}");
Console.WriteLine($"El ordenador de Ana es:{ordenadorAna.ToString()}");
Console.WriteLine($"El ordenador de Luisa es:{ordenadorLuisa.ToString()}");
Console.WriteLine($"El ordenador de Geronimo es:{ordenadorGeronimo.ToString()}");