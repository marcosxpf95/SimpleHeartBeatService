using System;
using Topshelf;

namespace SimpleHeartBeatService
{
    class Program
    {
        static void Main(string[] args)
        {            

            var exitCode = HostFactory.Run(x =>
            {
                x.Service<HeartBeat>(s =>
                {
                    s.ConstructUsing(heartBeat => new HeartBeat());
                    s.WhenStarted(heartBeat => heartBeat.Start());
                    s.WhenStopped(heartBeat => heartBeat.Stop());
                });

                x.RunAsLocalSystem();

                x.SetServiceName("HeartbeatService");
                x.SetDisplayName("Heartbeat Service");
                x.SetDescription("this is the sample heartbeat service used in a Demo");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
            
        }
    }
}
