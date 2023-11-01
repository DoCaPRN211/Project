using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObject.Models;

public partial class DoCaPrnContext : DbContext
{
    public DoCaPrnContext()
    {
    }

    public DoCaPrnContext(DbContextOptions<DoCaPrnContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bookmark> Bookmarks { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<PetBreed> PetBreeds { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<React> Reacts { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<User> Users { get; set; }

    private string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
                     .AddJsonFile("appsettings.json", true, true)
                     .Build();
        var strConn = config["ConnectionStrings:DefaultConnectionStringDB"];
        return strConn;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(GetConnectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bookmark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bookmark__3213E83FB12F5677");

            entity.ToTable("Bookmark");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createtime)
                .HasPrecision(6)
                .HasColumnName("createtime");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Postid)
                .HasMaxLength(50)
                .HasColumnName("postid");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");

            entity.HasOne(d => d.Post).WithMany(p => p.Bookmarks)
                .HasForeignKey(d => d.Postid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bookmark__postid__3E52440B");

            entity.HasOne(d => d.User).WithMany(p => p.Bookmarks)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bookmark__userid__3F466844");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3213E83F9FBD9414");

            entity.ToTable("Category");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comment__3213E83FB194B235");

            entity.ToTable("Comment");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.Content)
                .HasMaxLength(500)
                .HasColumnName("content");
            entity.Property(e => e.Createtime)
                .HasPrecision(6)
                .HasColumnName("createtime");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Postid)
                .HasMaxLength(50)
                .HasColumnName("postid");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");

            entity.HasOne(d => d.Post).WithMany(p => p.Comments)
                .HasForeignKey(d => d.Postid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comment__postid__4222D4EF");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comment__userid__4316F928");
        });

        modelBuilder.Entity<PetBreed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pet_Bree__3213E83F60CBA3B1");

            entity.ToTable("Pet_Breed");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.Breedname)
                .HasMaxLength(50)
                .HasColumnName("breedname");
            entity.Property(e => e.PetType)
                .HasMaxLength(50)
                .HasColumnName("pet_type");
            entity.Property(e => e.Postid)
                .HasMaxLength(50)
                .HasColumnName("postid");

            entity.HasOne(d => d.Post).WithMany(p => p.PetBreeds)
                .HasForeignKey(d => d.Postid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pet_Breed__posti__4F7CD00D");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Post__3213E83FE3500256");

            entity.ToTable("Post");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Content)
                .HasMaxLength(500)
                .HasColumnName("content");
            entity.Property(e => e.Createtime)
                .HasPrecision(6)
                .HasColumnName("createtime");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Title)
                .HasMaxLength(500)
                .HasColumnName("title");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");

            entity.HasOne(d => d.Category).WithMany(p => p.Posts)
                .HasForeignKey(d => d.Categoryid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Post__categoryid__3B75D760");

            entity.HasOne(d => d.User).WithMany(p => p.Posts)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Post__userid__3A81B327");
        });

        modelBuilder.Entity<React>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__React__3213E83FE59EE997");

            entity.ToTable("React");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Commentid)
                .HasMaxLength(50)
                .HasColumnName("commentid");
            entity.Property(e => e.Createtime)
                .HasPrecision(6)
                .HasColumnName("createtime");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Postid)
                .HasMaxLength(50)
                .HasColumnName("postid");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");

            entity.HasOne(d => d.Comment).WithMany(p => p.Reacts)
                .HasForeignKey(d => d.Commentid)
                .HasConstraintName("FK__React__commentid__47DBAE45");

            entity.HasOne(d => d.Post).WithMany(p => p.Reacts)
                .HasForeignKey(d => d.Postid)
                .HasConstraintName("FK__React__postid__45F365D3");

            entity.HasOne(d => d.User).WithMany(p => p.Reacts)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__React__userid__46E78A0C");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Report__3213E83FD92A7CC4");

            entity.ToTable("Report");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.Commentid)
                .HasMaxLength(50)
                .HasColumnName("commentid");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Message)
                .HasMaxLength(200)
                .HasColumnName("message");
            entity.Property(e => e.Postid)
                .HasMaxLength(50)
                .HasColumnName("postid");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");

            entity.HasOne(d => d.Comment).WithMany(p => p.Reports)
                .HasForeignKey(d => d.Commentid)
                .HasConstraintName("FK__Report__commenti__4CA06362");

            entity.HasOne(d => d.Post).WithMany(p => p.Reports)
                .HasForeignKey(d => d.Postid)
                .HasConstraintName("FK__Report__postid__4AB81AF0");

            entity.HasOne(d => d.User).WithMany(p => p.Reports)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Report__userid__4BAC3F29");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3213E83FD74D42A4");

            entity.ToTable("User");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("dob");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("fullname");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isban).HasColumnName("isban");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(10)
                .HasColumnName("role");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
