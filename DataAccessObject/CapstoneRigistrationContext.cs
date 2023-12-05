using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessObject;

public partial class CapstoneRigistrationContext : DbContext
{
    public CapstoneRigistrationContext()
    {
    }

    public CapstoneRigistrationContext(DbContextOptions<CapstoneRigistrationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Lecturer> Lecturers { get; set; }

    public virtual DbSet<LecturerInGroup> LecturerInGroups { get; set; }

    public virtual DbSet<Semester> Semesters { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentInGroup> StudentInGroups { get; set; }

    public virtual DbSet<StudentInSemester> StudentInSemesters { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<TopicOfLecturer> TopicOfLecturers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
    }

    private static string GetConnectionString()
    {
        IConfigurationRoot configuration = (new ConfigurationBuilder())
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        return configuration.GetConnectionString("DefaultConnection");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Group__3214EC070A15CFC3");

            entity.ToTable("Group");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.LeaderNavigation).WithMany(p => p.Groups)
                .HasForeignKey(d => d.Leader)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKGroup668588");

            entity.HasOne(d => d.Semester).WithMany(p => p.Groups)
                .HasForeignKey(d => d.SemesterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKGroup667084");

            entity.HasOne(d => d.Topic).WithMany(p => p.Groups)
                .HasForeignKey(d => d.TopicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKGroup466710");
        });

        modelBuilder.Entity<Lecturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Lecturer__3214EC0768611CC7");

            entity.ToTable("Lecturer");

            entity.HasIndex(e => e.Code, "UQ__Lecturer__A25C5AA7AB3E0A92").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Role).HasMaxLength(10);
        });

        modelBuilder.Entity<LecturerInGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Lecturer__3214EC07411EF11B");

            entity.ToTable("LecturerInGroup");

            entity.HasOne(d => d.Group).WithMany(p => p.LecturerInGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKLecturerIn304804");

            entity.HasOne(d => d.InMainLecturerNavigation).WithMany(p => p.LecturerInGroupInMainLecturerNavigations)
                .HasForeignKey(d => d.InMainLecturer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKLecturerIn121503");

            entity.HasOne(d => d.Lecturer).WithMany(p => p.LecturerInGroupLecturers)
                .HasForeignKey(d => d.LecturerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKLecturerIn674099");
        });

        modelBuilder.Entity<Semester>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Semester__3214EC0791954783");

            entity.ToTable("Semester");

            entity.HasIndex(e => e.Name, "UQ__Semester__737584F68203D374").IsUnique();

            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("date");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC07C09BD382");

            entity.ToTable("Student");

            entity.HasIndex(e => e.Code, "UQ__Student__A25C5AA7852C7F13").IsUnique();

            entity.Property(e => e.Avatar)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.FullName).HasMaxLength(50);
        });

        modelBuilder.Entity<StudentInGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StudentI__3214EC07E8947CA5");

            entity.ToTable("StudentInGroup");

            entity.HasOne(d => d.Group).WithMany(p => p.StudentInGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKStudentInG346740");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentInGroups)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKStudentInG305462");
        });

        modelBuilder.Entity<StudentInSemester>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StudentI__3214EC071AD742EA");

            entity.ToTable("StudentInSemester");

            entity.HasOne(d => d.Semester).WithMany(p => p.StudentInSemesters)
                .HasForeignKey(d => d.SemesterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKStudentInS617386");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentInSemesters)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKStudentInS871375");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Topic__3214EC072B1DA802");

            entity.ToTable("Topic");

            entity.Property(e => e.CreateDate).HasColumnType("date");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Semester).WithMany(p => p.Topics)
                .HasForeignKey(d => d.SemesterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKTopic750096");
        });

        modelBuilder.Entity<TopicOfLecturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TopicOfL__3214EC07EBC1F9B3");

            entity.ToTable("TopicOfLecturer");

            entity.HasOne(d => d.Lecturer).WithMany(p => p.TopicOfLecturers)
                .HasForeignKey(d => d.LecturerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKTopicOfLec966583");

            entity.HasOne(d => d.Topic).WithMany(p => p.TopicOfLecturers)
                .HasForeignKey(d => d.TopicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKTopicOfLec108276");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
