using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace proba2.Models;

public partial class StudentContext : DbContext
{
    public StudentContext()
    {
    }

    public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AssignedSubjects> AssignedSubjects { get; set; }

    public virtual DbSet<Enrollments> Enrollments { get; set; }

    public virtual DbSet<Students> Students { get; set; }

    public virtual DbSet<Subjects> Subjects { get; set; }

    public virtual DbSet<Teachers> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Petya\\source\\repos\\proba2\\proba2\\Database1.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AssignedSubjects>(entity =>
        {
            entity.HasKey(e => e.AssignId).HasName("PK__Assigned__32E5EDE647549CB7");

            entity.ToTable("Assigned_subjects");

            entity.Property(e => e.AssignId)
                .ValueGeneratedNever()
                .HasColumnName("assign_id");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

            entity.HasOne(d => d.Subject).WithMany(p => p.AssignedSubjects)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Assigned___subje__412EB0B6");

            entity.HasOne(d => d.Teacher).WithMany(p => p.AssignedSubjects)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Assigned___teach__4222D4EF");
        });

        modelBuilder.Entity<Enrollments>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId).HasName("PK__Enrollme__6D24AA7A72A0CD81");

            entity.Property(e => e.EnrollmentId)
                .ValueGeneratedNever()
                .HasColumnName("enrollment_id");
            entity.Property(e => e.EnrollmentDate)
                .HasColumnType("date")
                .HasColumnName("enrollment_date");
            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Enrollmen__stude__4316F928");

            entity.HasOne(d => d.Subject).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Enrollmen__subje__440B1D61");
        });

        modelBuilder.Entity<Students>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Students__2A33069AB28D8F0D");

            entity.HasIndex(e => e.Email, "UQ__Students__AB6E616455AF51E8").IsUnique();

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("student_id");
            entity.Property(e => e.Email)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Semester)
                .HasDefaultValueSql("((1))")
                .HasColumnName("semester");
        });

        modelBuilder.Entity<Subjects>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__Subjects__5004F660B976AC9C");

            entity.Property(e => e.SubjectId)
                .ValueGeneratedNever()
                .HasColumnName("subject_id");
            entity.Property(e => e.Semester).HasColumnName("semester");
            entity.Property(e => e.SubjectCode)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("subject_code");
            entity.Property(e => e.SubjectDescription)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("subject_description");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("subject_name");
        });

        modelBuilder.Entity<Teachers>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("PK__Teachers__03AE777E76A7EC2D");

            entity.HasIndex(e => e.Email, "UQ__Teachers__AB6E61649ED89B4C").IsUnique();

            entity.Property(e => e.TeacherId)
                .ValueGeneratedNever()
                .HasColumnName("teacher_id");
            entity.Property(e => e.Email)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("last_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
