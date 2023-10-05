﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenFlowCRMModels.Models;

#nullable disable

namespace OpenFlowCRMModels.Migrations
{
    [DbContext(typeof(SQL_TESTContext))]
    [Migration("20231005122641_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OpenFlowCRMModels.Models.CatalogoModelli", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int?>("Altezza")
                        .HasColumnType("int");

                    b.Property<string>("Descrizione")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Larghezza")
                        .HasColumnType("int");

                    b.Property<int?>("Lunghezza")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CatalogoModelli");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.Clienti", b =>
                {
                    b.Property<long>("Idcliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("IDCliente");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Idcliente"));

                    b.Property<string>("Indirizzo")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Idcliente");

                    b.ToTable("Clienti");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.ComponenteMerceCatalogoModelli", b =>
                {
                    b.Property<long>("ComponenteMerceId")
                        .HasColumnType("bigint");

                    b.Property<long>("CatalogoModelliId")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("ComponenteMerceId", "CatalogoModelliId");

                    b.HasIndex("CatalogoModelliId");

                    b.ToTable("ComponenteMerceCatalogoModelli");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.ComponentiMerce", b =>
                {
                    b.Property<long>("IdcomponenteMerce")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("IDComponenteMerce");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdcomponenteMerce"));

                    b.Property<int?>("Altezza")
                        .HasColumnType("int");

                    b.Property<int?>("Larghezza")
                        .HasColumnType("int");

                    b.Property<int?>("Lunghezza")
                        .HasColumnType("int");

                    b.Property<string>("MaterialeComponente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .HasMaxLength(140)
                        .HasColumnType("nvarchar(140)");

                    b.Property<string>("TipoComponente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdcomponenteMerce");

                    b.ToTable("ComponentiMerce");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.Lotti", b =>
                {
                    b.Property<long>("LottoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("LottoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("LottoId"));

                    b.Property<int>("Altezza")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFineEffettiva")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataFinePrevista")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataInizioEffettiva")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataInizioPrevista")
                        .HasColumnType("datetime");

                    b.Property<int>("Larghezza")
                        .HasColumnType("int");

                    b.Property<int>("Lunghezza")
                        .HasColumnType("int");

                    b.Property<long?>("MacchinaAssegnata")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantita")
                        .HasColumnType("int");

                    b.Property<int>("Stato")
                        .HasColumnType("int");

                    b.Property<string>("TipoMateriale")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LottoId");

                    b.ToTable("Lotti");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.Macchine", b =>
                {
                    b.Property<long>("MacchineId")
                        .HasColumnType("bigint")
                        .HasColumnName("MacchineID");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Ip")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IP");

                    b.Property<long>("LottoCorrente")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("RisorseUmane")
                        .HasColumnType("bigint");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("MacchineId");

                    b.ToTable("Macchine");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.Ordini", b =>
                {
                    b.Property<long>("OrdiniId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("OrdiniID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("OrdiniId"));

                    b.Property<long>("Cliente")
                        .HasColumnType("bigint");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrdiniId");

                    b.HasIndex("Cliente");

                    b.ToTable("Ordini");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.Partite", b =>
                {
                    b.Property<long>("PartiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("PartiteID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PartiteId"));

                    b.Property<DateTime>("DataConsegna")
                        .HasColumnType("datetime");

                    b.Property<string>("Descrizione")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("Modello")
                        .HasColumnType("bigint");

                    b.Property<int>("Ncarichi")
                        .HasColumnType("int")
                        .HasColumnName("NCarichi");

                    b.Property<long?>("Ordine")
                        .HasColumnType("bigint");

                    b.Property<int>("PezziAlCarico")
                        .HasColumnType("int");

                    b.Property<int>("Stato")
                        .HasColumnType("int");

                    b.HasKey("PartiteId");

                    b.HasIndex("Modello");

                    b.HasIndex("Ordine");

                    b.ToTable("Partite");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.Utenti", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Utenti");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.VwPianoRiordino", b =>
                {
                    b.Property<int?>("Altezza")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataConsegnaPartita")
                        .HasColumnType("datetime");

                    b.Property<int?>("Larghezza")
                        .HasColumnType("int");

                    b.Property<int?>("Lunghezza")
                        .HasColumnType("int");

                    b.Property<string>("MaterialeComponente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("MetriCubi")
                        .HasColumnType("float");

                    b.Property<string>("TipoComponente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TotalePezziRichiesti")
                        .HasColumnType("int");

                    b.ToTable((string)null);

                    b.ToView("vw_PianoRiordino", (string)null);
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.ComponenteMerceCatalogoModelli", b =>
                {
                    b.HasOne("OpenFlowCRMModels.Models.CatalogoModelli", "CatalogoModelli")
                        .WithMany("ComponenteMerceCatalogoModelli")
                        .HasForeignKey("CatalogoModelliId")
                        .IsRequired()
                        .HasConstraintName("FK_ComponenteMerceCatalogoModelli_CatalogoModelli");

                    b.HasOne("OpenFlowCRMModels.Models.ComponentiMerce", "ComponenteMerce")
                        .WithMany("ComponenteMerceCatalogoModelli")
                        .HasForeignKey("ComponenteMerceId")
                        .IsRequired()
                        .HasConstraintName("FK_ComponenteMerceCatalogoModelli_ComponentiMerce");

                    b.Navigation("CatalogoModelli");

                    b.Navigation("ComponenteMerce");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.Ordini", b =>
                {
                    b.HasOne("OpenFlowCRMModels.Models.Clienti", "ClienteNavigation")
                        .WithMany("Ordini")
                        .HasForeignKey("Cliente")
                        .IsRequired()
                        .HasConstraintName("FK_Ordini_Clienti");

                    b.Navigation("ClienteNavigation");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.Partite", b =>
                {
                    b.HasOne("OpenFlowCRMModels.Models.CatalogoModelli", "ModelloNavigation")
                        .WithMany("Partite")
                        .HasForeignKey("Modello")
                        .IsRequired()
                        .HasConstraintName("FK_Partite_Modelli");

                    b.HasOne("OpenFlowCRMModels.Models.Ordini", "OrdineNavigation")
                        .WithMany("Partite")
                        .HasForeignKey("Ordine")
                        .HasConstraintName("FK_Ordini_Partite");

                    b.Navigation("ModelloNavigation");

                    b.Navigation("OrdineNavigation");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.CatalogoModelli", b =>
                {
                    b.Navigation("ComponenteMerceCatalogoModelli");

                    b.Navigation("Partite");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.Clienti", b =>
                {
                    b.Navigation("Ordini");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.ComponentiMerce", b =>
                {
                    b.Navigation("ComponenteMerceCatalogoModelli");
                });

            modelBuilder.Entity("OpenFlowCRMModels.Models.Ordini", b =>
                {
                    b.Navigation("Partite");
                });
#pragma warning restore 612, 618
        }
    }
}