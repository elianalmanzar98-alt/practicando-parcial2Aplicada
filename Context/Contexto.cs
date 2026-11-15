
using ExamenBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenBlazor.Context;

public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
{
    public DbSet<Autores> Autores { get; set; }
}