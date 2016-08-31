using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NotePadPilao.Hubs
{
    public class NotePadHub : Hub
    {
        public void Enviar(string content)
        {
            if (System.Runtime.Caching.MemoryCache.Default.Get("content") == null)
                System.Runtime.Caching.MemoryCache.Default.Add("content", content, DateTime.Now.AddYears(1));
            else
                System.Runtime.Caching.MemoryCache.Default.Set("content", content, DateTime.Now.AddYears(1));
            Clients.All.enviarTexto(content);
        }
    }
}