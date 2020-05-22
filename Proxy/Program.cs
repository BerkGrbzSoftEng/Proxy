using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();


            sw.Start();
            GercekResim gercekresim = new GercekResim("OrnkeResim.png");
            GercekResim gercekresim2 = new GercekResim("OrnkeResim2.png");
            gercekresim.Goster();
            gercekresim2.Goster();

            sw.Stop();
            long elapsed = sw.Elapsed.Milliseconds;
            Console.WriteLine("Gecen Süre: {0} ms \n", elapsed);

            sw.Start();
            IGorsel resim2 = new ResimProxy("OrnekProxyResim.png");
            resim2.Goster();
            resim2.Goster();
            sw.Stop();
            long elapsed2 = sw.Elapsed.Milliseconds;
            Console.WriteLine("Gecen Süre: {0} ms ", elapsed2);
            Console.ReadLine();
        }
    }

    interface IGorsel
    {
        void Goster();
    }

    class GercekResim : IGorsel
    {
        private string dosyaAdi;
        public GercekResim(string dosyaAdi)
        {
            this.dosyaAdi = dosyaAdi;
            DisktenYukle();
        }

        private void DisktenYukle()
        {
            Thread.Sleep(2500);
            Console.WriteLine(dosyaAdi + " diskten yukleniyor...");
            
        }
        public void Goster()
        {
            Console.WriteLine(dosyaAdi + " diskten gösteriliyor...");
        }
    }

    class ResimProxy : IGorsel
    {
        private GercekResim gercekResim;
        private string dosyaAdi;

        public ResimProxy(string dosyaAdi)
        {
            this.dosyaAdi = dosyaAdi;
        }
        public void Goster()
        {
            if (gercekResim == null)
            {
                gercekResim = new GercekResim(dosyaAdi);
            }
            gercekResim.Goster();
        }
    }
}
