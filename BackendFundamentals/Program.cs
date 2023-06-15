

using BackendFundamentals.Protocols;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IUdp, Udp>()
            .BuildServiceProvider();

        var Udp = serviceProvider.GetRequiredService<IUdp>();

        Udp.CreateUdpServer();
    }
}
