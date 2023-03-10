using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    internal class MontadorDeComputador
    {
        private IComputadorBuilder _builder;

        public MontadorDeComputador(IComputadorBuilder builder)
        {
            _builder = builder;
        }

        public void MontarComputadorGamer()
        {
            _builder.EscolherModelo("Gamer");
            _builder.EscolherProcessador("Intel Core i7");
            _builder.EscolherMemoriaRam(16);
            _builder.EscolherArmazenamento(1000);
            _builder.EscolherPlacaDeVideo(true);
        }

        public void MontarComputadorEscritorio()
        {
            _builder.EscolherModelo("Escritório");
            _builder.EscolherProcessador("Intel Core i3");
            _builder.EscolherMemoriaRam(8);
            _builder.EscolherArmazenamento(500);
            _builder.EscolherPlacaDeVideo(false);
        }
    }
}
