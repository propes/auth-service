using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AuthService.WebApi
{
   class Program
   {
      static void Main(string[] args)
      {
         var host = CreateHostBuilder(args).Build();

         host.Run();
      }

      static IHostBuilder CreateHostBuilder(string[] args)
      {
         return Host
                  .CreateDefaultBuilder(args)
                  .ConfigureWebHostDefaults(wb => wb.UseStartup<Startup>());
      }
   }
}
