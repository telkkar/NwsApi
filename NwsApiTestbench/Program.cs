using System;
using System.Net.Http;
using NwsApi;

namespace NwsApiTestbench
{
    class Program
    {
        static void Main(string[] args)
        {
            var nwsDataLoader = new NwsDataLoader(new HttpClient(), "NwsApiTestbench");

            var loader = new NwsLoader(nwsDataLoader);

            var data = loader.PointData(43.05, -89.52);

            Console.ReadLine();
        }
    }
}
