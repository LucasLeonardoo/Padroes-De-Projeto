//  ResidenciaContext.cs
//
//  Author:
//       Alex Pinheiro das Graças <alex.gracas>
//
//  Copyright (c) 2019 
//
//  Este arquivo não pode ser modificado, cedido ou alterado sem a permissão explicita do autor.
using ExemplosPadroesProjeto.Models.Moveis.Barroco;
using ExemplosPadroesProjeto.Models.Moveis.Futurista;
using ExemplosPadroesProjeto.Models.Moveis.Rustico;
using Microsoft.EntityFrameworkCore;
namespace ExemplosPadrõesProjeto.Models
{
    public class ResidenciaContext : DbContext
    {
        public ResidenciaContext()
        {
        }
        public ResidenciaContext(DbContextOptions<ResidenciaContext> options)
            : base(options)
        { }

        public DbSet<Moveis.Movel> Moveis { get; set; }
        public DbSet<Moveis.Barroco.MesaBarroca> MesasBarrocas { get; set; }
        public DbSet<Moveis.MesaFuturista> MesasFuturistas { get; set; }
        public DbSet<MesaRustica> MesasRusticas { get; set; }



        public DbSet<Moveis.Barroco.CadeiraBarroca> CadeirasBarrocas { get; set; }
        public DbSet<Moveis.CadeiraFuturista> CadeirasFuturistas { get; set; }
        public DbSet<CadeiraRustica> CadeirasRusticas { get; set; }


        public DbSet<ArmarioBarroco> ArmariosBarrocos { get; set; }
        public DbSet<ArmarioFuturista> ArmariosFuturistas { get; set; }
        public DbSet<ArmarioRustico> ArmariosRusticos { get; set; }

        public DbSet<EscrivaninhaBarroca> EscrivaninhasBarrocas { get; set; }
        public DbSet<EscrivaninhaFuturista> EscrivaninhasFuturistas { get; set; }
        public DbSet<EscrivaninhaRustica> EscrivaninhasRusticas { get; set; }


        public DbSet<Casa> Casas { get; set; }
    }
}
