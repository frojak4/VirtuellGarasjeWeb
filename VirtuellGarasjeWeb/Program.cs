
using System.Xml.Linq;

namespace VirtuellGarasje_JS_C_
{
    public class Program
    {




        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            var app = builder.Build();

            var garage = new Garage();

            app.UseHttpsRedirection();

            app.MapGet("/garasje", () =>
            {
                return garage.GetVehicles();
            });


            app.UseStaticFiles();
            app.Run();
        }
    }
}
