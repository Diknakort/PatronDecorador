using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    public interface IOrdenador
    {
        public int precio { get; set; }
        public int ram { get; set; }
        public int almacenamiento { get; set; }
    }
    public class OrdenadorBasico : IOrdenador
    {
        public int precio { get; set; } = 100;
        public int ram { get; set; } = 10;
        public int almacenamiento { get; set; } = 100;

        public override string? ToString()
        {
            return ($"El ordenador se compone de un precio {precio}, RAM de {ram} y con almacenamiento {almacenamiento}");
        }
    }
    public class DecoradorRAMMaxima : IOrdenador
    {
        IOrdenador ObjetoADecorar;
        public DecoradorRAMMaxima(IOrdenador ordenador)
        {
            this.ObjetoADecorar = ordenador;
        }

        public int precio { get { return this.ObjetoADecorar.precio + 200; } set { this.ObjetoADecorar.precio = value; } }
        public int ram { get; set; } = 100;
        public int almacenamiento { get { return this.ObjetoADecorar.almacenamiento; } set { } }
        public override string? ToString()
        {
            return ($"El ordenador se compone de un precio {precio}, RAM de {ram} y con almacenamiento {almacenamiento}");
        }
    }
    public class DecoradorDiscoSolido : IOrdenador
    {
        IOrdenador ObjetoADecorar;
        public DecoradorDiscoSolido(IOrdenador ordenador)
        {
            this.ObjetoADecorar = ordenador;
        }

        public int precio { get { return this.ObjetoADecorar.precio + 100; } set { } }
        public int ram { get { return this.ObjetoADecorar.ram; } set { } }
        public int almacenamiento { get { return this.ObjetoADecorar.almacenamiento *2; } set { } }
        public override string? ToString()
        {
            return ($"El ordenador se compone de un precio {precio}, RAM de {ram} y con almacenamiento {almacenamiento}");
        }
    }
    public class DecoradorAVerSiCuela : IOrdenador
    {
        IOrdenador ObjetoADecorar;
        public DecoradorAVerSiCuela(IOrdenador ordenador)
        {
            this.ObjetoADecorar = ordenador;
        }

        public int precio { get { return this.ObjetoADecorar.precio * 2; } set { } }
        public int ram { get { return this.ObjetoADecorar.ram; } set { } }
        public int almacenamiento { get { return this.ObjetoADecorar.almacenamiento; } set { } }
        public override string? ToString()
        {
            return ($"El ordenador se compone de un precio {precio}, RAM de {ram} y con almacenamiento {almacenamiento}");
        }
    }
}
