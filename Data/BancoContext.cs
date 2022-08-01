using Microsoft.EntityFrameworkCore;
using Projeto.Models;
using System;
using System.Collections.Generic;

namespace Projeto.Data
{
    public class EspacoCarContext : DbContext
    {
    public DbSet<AuthModel> Auth { get; set; }

    public string DbCaminho { get; }
    public EspacoCarContext()
        {
            var pasta = Environment.SpecialFolder.LocalApplicationData;
            var caminho = Environment.GetFolderPath(pasta);
            DbCaminho = System.IO.Path.Join(caminho, "EspacoCar.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer($"Data Source={DbCaminho}");

        public class AuthModel
        {
            public string UsuarioAuth { get; set; }
            public string SenhaAuth { get; set; }
        }
    }
}
