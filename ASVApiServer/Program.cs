using ASVPack.Models;

namespace ASVApiServer
{
    public class Program
    {
        static ContentContainer gamePack = null;

        public static void Main(string[] args)
        {
            //load ark save game data
            string saveFilename = string.Empty;
            string localProfileFilename = string.Empty;
            string clusterFolder = string.Empty;

            saveFilename = @"C:\temp\vertyco\Fjordur\FjordurSavedArks\fjordur.ark";

            gamePack = new ContentContainer();
            gamePack.LoadSaveGame(saveFilename, localProfileFilename, clusterFolder);
    

            var builder = WebApplication.CreateBuilder(args);

            //add dependencies
            builder.Services.AddSingleton<IContentContainer>(gamePack);


            // Add services to the container.
            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();





            app.Run();
        }
    }
}