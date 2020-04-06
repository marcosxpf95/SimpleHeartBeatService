using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleHeartBeatService
{
    class Mensagem
    {
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public char Tipo { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Rodape { get; set; }

        public Mensagem(string Remetente, string Destinatario, char Tipo, string Titulo, string Rodape)
        {
            this.Remetente = Remetente;
            this.Destinatario = Destinatario;
            this.Tipo = Tipo;
            this.Titulo = Titulo;
            this.Rodape = Rodape;
        }

    }
}
