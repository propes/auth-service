using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AuthService.WebApi
{
   class Program
   {
      static void Main(string[] args)
      {
         var host = Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(wb => wb.UseStartup<Startup>())
            .Build();

         host.Run();
      }
   }
}
