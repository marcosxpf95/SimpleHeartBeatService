using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Timers;

namespace SimpleHeartBeatService
{
    public class HeartBeat
    {
        private readonly Timer _timer;        
        int cont = 0;
        DateTime dataInicio = DateTime.Now;

        public HeartBeat()
        {
            _timer = new Timer(600) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }     

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {       
            
            Mensagem mensagem = new Mensagem("cobrancascreditoitau@gmail.com", "", "kaique.biazioli@gmail.com", "Importante: Itaú cobranças");
            Email email = new Email(mensagem);
            
            try
            {
                email.enviarEmail();
                cont++;
                string quantidadeEmailParaArquivo = "Qtd email " + cont;
                string[] lines = new string[] { quantidadeEmailParaArquivo };
                File.AppendAllLines(@"C:\Temp\Demos\HeartBeat.txt", lines);

                string proximoEmail = $"O próximo e-mail será enviado para o {mensagem.EmailDestinatario} as {dataInicio.AddHours(1)}";
                lines = new string[] { proximoEmail };
                File.AppendAllLines(@"C:\Temp\Demos\HeartBeat.txt", lines);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Email não enviado. Erro "+ ex);
            }                        
        }

        public void Start()
        {
            _timer.Start();
            string proximoEmail = $"O primeiro e-mail será enviado {dataInicio.AddHours(1)}";
            string[] lines = new string[] { proximoEmail };
            File.AppendAllLines(@"C:\Temp\Demos\HeartBeat.txt", lines);

        }

        public void Stop()
        {
            _timer.Stop();
        }
        
    }
}
