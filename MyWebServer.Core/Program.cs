using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Configuration;

namespace MyWebServer.Core
{
    class Program
    {
        //锁对象必须静态私有
        static object lockHelper = new object();
        //UI程序进程，只允许一个
        static Process process;
        //获取UI进程路径
        static string clientLocation = ConfigurationManager.AppSettings["ClientLocation"];

        static void Main(string[] args)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.2.67"), 12000);
            TcpListener tcpListener = new TcpListener(ip);
            tcpListener.Start(10);

            while (true)
            {
                if (tcpListener.Pending())
                {
                    Socket socket = tcpListener.AcceptSocket();

                    if (process == null)
                    {
                        lock (lockHelper)
                        {
                            if (process == null)
                            {
                                process = Process.Start(clientLocation);
                            }
                        }
                    }

                    
                }
            }

            //关闭MyWebServer.UI.exe后，需要销毁实例，否则只能第一次启动时打开进程了，暂不实现。
        }
    }
}
