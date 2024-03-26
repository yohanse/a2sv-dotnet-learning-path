using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PostgresDb.Models;



namespace PostgresDb.Data;


public class ApiDbContext : DbContext {
    public virtual DbSet<Comment> comments {get; set;}
    public virtual DbSet<Post> posts {get; set;}
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Comment> (entity => {
            entity.HasOne(t => t.post)
            .WithMany(d => d.Comments)
            .HasForeignKey(x => x.PostId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Comment_Post");
        });
    }
}