using Nera.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nera.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTipoRescateAsync();
            await CheckVehiculoAsync();
            await CheckRescatistaAsync();
            await CheckRegistroRescateAsync();
            await CheckRescatistaAsync();


        }

        private async Task CheckRegistroRescateAsync()
        {
            throw new NotImplementedException();
        }

        private async Task CheckRescatistaAsync()
        {
            if(!_context.Rescatistas.Any())
            {
                AddRescatista("19481365-7", "Ramiro", "Fernandez", "Calleja", "222 00 222", "988 888 300", "Castro 900" );
                AddRescatista("1329898-7", "Alan", "Gonzalez", "Romero", "222 00 222", "988 888 300", "Los Angeles 900");
                await _context.SaveChangesAsync();
            }
        }

        private void AddRescatista(string rut, string nombres, string apellidoPat, string apellidoMat, string telefono, string celular, string direccion)
        {
            _context.Rescatistas.Add(new Rescatista
            {
                Rut = rut,
                Nombres = nombres,
                ApellidoPaterno = apellidoPat,
                ApellidoMaterno = apellidoMat,
                Telefono = telefono,
                Celular = celular,
                Direccion = direccion
            });
        }

        private async Task CheckVehiculoAsync()
        {
            throw new NotImplementedException();
        }

        private async Task CheckTipoRescateAsync()
        {
            if(!_context.TipoRescates.Any())
            {
                _context.TipoRescates.Add(new TipoRescate { Nombre = "Asistencia" });
                _context.TipoRescates.Add(new TipoRescate { Nombre = "Siniestro" });
                _context.TipoRescates.Add(new TipoRescate { Nombre = "Emergencia" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
