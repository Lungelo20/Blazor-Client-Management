// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RTT.Server.Data;

#nullable disable

namespace RTT.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RTT.Shared.ClientAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LineOne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LineTwo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientDetailsId");

                    b.ToTable("clientAddresses");
                });

            modelBuilder.Entity("RTT.Shared.ClientContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientDetailsId");

                    b.ToTable("clientContacts");
                });

            modelBuilder.Entity("RTT.Shared.ClientDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("clientDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Gender = "M",
                            Name = "A Client",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            Gender = "F",
                            Name = "B Client",
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            Gender = "M",
                            Name = "C Client",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            Gender = "F",
                            Name = "D Client",
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            Gender = "M",
                            Name = "E Client",
                            Status = 1
                        },
                        new
                        {
                            Id = 6,
                            Gender = "F",
                            Name = "F Client",
                            Status = 0
                        },
                        new
                        {
                            Id = 7,
                            Gender = "M",
                            Name = "G Client",
                            Status = 1
                        },
                        new
                        {
                            Id = 8,
                            Gender = "F",
                            Name = "H Client",
                            Status = 0
                        });
                });

            modelBuilder.Entity("RTT.Shared.ClientAddress", b =>
                {
                    b.HasOne("RTT.Shared.ClientDetails", null)
                        .WithMany("Addresses")
                        .HasForeignKey("ClientDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RTT.Shared.ClientContact", b =>
                {
                    b.HasOne("RTT.Shared.ClientDetails", null)
                        .WithMany("Contacts")
                        .HasForeignKey("ClientDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RTT.Shared.ClientDetails", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
