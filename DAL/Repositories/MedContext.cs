using Core.Abstractions;
using Core.Configurations;
using Core.Models;
using Core.Validation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class MedContext : DbContext, IMedContext
    {
        public DbSet<ClientCart> Clients;
        public DbSet<Visit> Visits;
        public DbSet<TypeVisit> typeVisits;
        public DbSet<Gender> Genders;



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=.;Database=MedDB;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientCartConfiguration());
            modelBuilder.ApplyConfiguration(new VisitConfiguration());
            modelBuilder.ApplyConfiguration(new TypeVisitConfiguration());
            modelBuilder.ApplyConfiguration(new GenderConfiguration());
            modelBuilder.Entity<Visit>().Property(v => v.DateOfVisit).HasDefaultValue(DateTime.Now);


        }

        #region ClientMethod

        public IEnumerable<ClientCart> GetAllClients()
        {
            return Clients;
        }
        public void AddClient(ClientCart client)
        {
            Clients.Add(client);
        }

        public async Task<ClientCart> FindClient(Guid guid)
        {
            return await Clients.FindAsync(guid);
        }

        public void UpdateClient(ClientCart client)
        {
            Clients.Update(client);
        }

        public void RemoveClient(ClientCart client)
        {
            Clients.Remove(client);
        }
        #endregion

        #region VisitMethod

        public IEnumerable<Visit> GetAllVisits()
        {
            return Visits;
        }
        public void AddVisit(Visit visit)
        {
            Visits.Add(visit);
        }

        public async Task<Visit> FindVisit(Guid guid)
        {
            return await Visits.FindAsync(guid);
        }

        public void UpdateVisit(Visit visit)
        {
            Visits.Update(visit);
        }

        public void RemoveVisit(Visit visit)
        {
            Visits.Remove(visit);
        }


        #endregion
    }
}
