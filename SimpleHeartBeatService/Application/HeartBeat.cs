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

        public HeartBeat()
        {
            _timer = new Timer(100) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            cont++;
            Email email = new Email();
            email.enviarEmail(cont);
            Console.WriteLine("Qtd email" + cont);
            //string[] lines = new string[] { DateTime.Now.ToString() };
            //File.AppendAllLines(@"C:\Temp\Demos\HeartBeat.txt", lines);
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
