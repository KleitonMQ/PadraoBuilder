using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    interface IComputadorBuilder
    {
        void EscolherModelo(string modelo);
        void EscolherProcessador(string processador);
        void EscolherMemoriaRam(int memoriaRam);
        void EscolherArmazenamento(int armazenamento);
        void EscolherPlacaDeVideo(bool placaDeVideo);
        Computador ObterComputador();
    }
}
