using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    internal class ComputadorBuilder : IComputadorBuilder
    {
        private Computador _computador;

        public ComputadorBuilder()
        {
            _computador = new Computador();
        }
        public void EscolherArmazenamento(int armazenamento)
        {
            _computador.Armazenamento = armazenamento;
        }

        public void EscolherMemoriaRam(int memoriaRam)
        {
            _computador.MemoriaRam = memoriaRam;
        }

        public void EscolherModelo(string modelo)
        {
            _computador.Modelo = modelo;
        }

        public void EscolherPlacaDeVideo(bool placaDeVideo)
        {
            _computador.PlacaDeVideo = placaDeVideo;
        }

        public void EscolherProcessador(string processador)
        {
            _computador.Processador = processador;
        }

        public Computador ObterComputador()
        {
            return _computador;
        }
    }
}
