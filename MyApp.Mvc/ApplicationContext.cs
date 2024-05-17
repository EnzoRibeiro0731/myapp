using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext {
  public DbSet<Todo> Todos { get; set; }

  public ApplicationContext(DbContextOptions options) : base(options) { }
}