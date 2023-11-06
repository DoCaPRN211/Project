using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database=DoCaPRN;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bookmark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bookmark__3213E83F35F39AD4");

            entity.ToTable("Bookmark");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.Createtime)
                .HasPrecision(0)
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
                .HasConstraintName("FK__Bookmark__postid__3F466844");

            entity.HasOne(d => d.User).WithMany(p => p.Bookmarks)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bookmark__userid__403A8C7D");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3213E83F6A6AAC86");

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
            entity.HasKey(e => e.Id).HasName("PK__Comment__3213E83FB776C866");

            entity.ToTable("Comment");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.Content)
                .HasMaxLength(500)
                .HasColumnName("content");
            entity.Property(e => e.Createtime)
                .HasPrecision(0)
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
                .HasConstraintName("FK__Comment__postid__4316F928");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comment__userid__440B1D61");
        });

        modelBuilder.Entity<PetBreed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pet_Bree__3213E83F03581C7F");

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
                .HasConstraintName("FK__Pet_Breed__posti__5070F446");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Post__3213E83F90C0C0E5");

            entity.ToTable("Post");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Content)
                .HasMaxLength(500)
                .HasColumnName("content");
            entity.Property(e => e.Createtime)
                .HasPrecision(0)
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
                .HasConstraintName("FK__Post__categoryid__3C69FB99");

            entity.HasOne(d => d.User).WithMany(p => p.Posts)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Post__userid__3B75D760");
        });

        modelBuilder.Entity<React>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__React__3213E83FAE7DC619");

            entity.ToTable("React");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id");
            entity.Property(e => e.Commentid)
                .HasMaxLength(50)
                .HasColumnName("commentid");
            entity.Property(e => e.Createtime)
                .HasPrecision(0)
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
                .HasConstraintName("FK__React__commentid__48CFD27E");

            entity.HasOne(d => d.Post).WithMany(p => p.Reacts)
                .HasForeignKey(d => d.Postid)
                .HasConstraintName("FK__React__postid__46E78A0C");

            entity.HasOne(d => d.User).WithMany(p => p.Reacts)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__React__userid__47DBAE45");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Report__3213E83F9C8A24B7");

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
                .HasConstraintName("FK__Report__commenti__4D94879B");

            entity.HasOne(d => d.Post).WithMany(p => p.Reports)
                .HasForeignKey(d => d.Postid)
                .HasConstraintName("FK__Report__postid__4BAC3F29");

            entity.HasOne(d => d.User).WithMany(p => p.Reports)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Report__userid__4CA06362");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3213E83FC249E1AE");

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
