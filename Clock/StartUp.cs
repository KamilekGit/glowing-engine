using Clock.Data.interfaces;
using Clock.Data.Mocks;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Clock
{
    public class StartUp
    {
        public void Configureservices(IServiceCollection services)
        {
            services.AddMvc(option =>option.EnableEndpointRouting = false);
            services.AddTransient<IAllCars, mockcars>();
            services.AddTransient<ICarsCategory, MockCategory>();

        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages(); 
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
