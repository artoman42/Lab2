using LibraryBLL;
using LibraryDAL;
using LibraryUIL;
using Microsoft.Extensions.DependencyInjection;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IServiceCollection serviceDescriptors = new ServiceCollection();
            serviceDescriptors.AddServices();
            IServiceProvider serviceProvider = serviceDescriptors.BuildServiceProvider();
            serviceProvider.GetService<IRunner>().Run();
        }
    }
}