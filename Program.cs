using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleAppPostgre
{
    

    class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);
    
            builder.Services.AddControllers();
            //builder.Services.AddSingleton<>();
            builder.Services.AddEndpointsApiExplorer();

            var app = builder.Build();
            app.MapControllers();
            app.Run();
        }
    }

   
}