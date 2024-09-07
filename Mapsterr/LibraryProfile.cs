using Mapster;
using Mapsterr.Models;
using Mapsterr.Models.VMs;


namespace Mapsterr
{
    public class LibraryProfile
    {
        public LibraryProfile(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            TypeAdapterConfig<Library, LibraryVM>.NewConfig().Map(dest => dest.Books, src => src.Books);

            TypeAdapterConfig<Book, BookVM>.NewConfig();
        }
    }
}
