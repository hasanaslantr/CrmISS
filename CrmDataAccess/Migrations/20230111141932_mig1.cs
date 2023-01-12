using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrmDataAccess.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cari",
                columns: table => new
                {
                    CariId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CariKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OzelKod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cari", x => x.CariId);
                });

            migrationBuilder.CreateTable(
                name: "CariYetkili",
                columns: table => new
                {
                    YetkiliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CariId = table.Column<int>(type: "int", nullable: false),
                    YetkiliAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CariYetkili", x => x.YetkiliId);
                });

            migrationBuilder.CreateTable(
                name: "Destek",
                columns: table => new
                {
                    DestekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: false),
                    YetkiliId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurumId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaslamaT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BaslamaS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KapanisT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KapanisS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlanlamaT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlanlamaS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IcerikDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HarcananSure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SorumluPersonelId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zaman = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destek", x => x.DestekId);
                });

            migrationBuilder.CreateTable(
                name: "DestekDetay",
                columns: table => new
                {
                    DetayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestekId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DetayIcerik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestekDetay", x => x.DetayId);
                });

            migrationBuilder.CreateTable(
                name: "DestekDetayHizmet",
                columns: table => new
                {
                    DetayHizmetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestekId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    HizmetAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miktar = table.Column<double>(type: "float", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tarih = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestekDetayHizmet", x => x.DetayHizmetId);
                });

            migrationBuilder.CreateTable(
                name: "DestekDokuman",
                columns: table => new
                {
                    DestekDokumanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestekId = table.Column<int>(type: "int", nullable: false),
                    DokumanYol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DokumanTur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestekDokuman", x => x.DestekDokumanId);
                });

            migrationBuilder.CreateTable(
                name: "Durum",
                columns: table => new
                {
                    DurumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DurumAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OzelKod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Durum", x => x.DurumId);
                });

            migrationBuilder.CreateTable(
                name: "HizmetAnlasmlari",
                columns: table => new
                {
                    HizmetAnlasmaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CariId = table.Column<int>(type: "int", nullable: false),
                    HizmetId = table.Column<int>(type: "int", nullable: false),
                    BaslamaT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OzelKod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizmetAnlasmlari", x => x.HizmetAnlasmaId);
                });

            migrationBuilder.CreateTable(
                name: "Hizmetler",
                columns: table => new
                {
                    HizmetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OzelKod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmetler", x => x.HizmetId);
                });

            migrationBuilder.CreateTable(
                name: "Ilce",
                columns: table => new
                {
                    IlceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirID = table.Column<int>(type: "int", nullable: false),
                    IlceAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilce", x => x.IlceId);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OzelKod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departman = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.PersonelId);
                });

            migrationBuilder.CreateTable(
                name: "Sehir",
                columns: table => new
                {
                    SehirId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehir", x => x.SehirId);
                });

            migrationBuilder.CreateTable(
                name: "SmtpMail",
                columns: table => new
                {
                    SmtpMailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmtpHost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpPort = table.Column<int>(type: "int", nullable: false),
                    SmtpSecuritiy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpParola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpHelpLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmtpMail", x => x.SmtpMailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cari");

            migrationBuilder.DropTable(
                name: "CariYetkili");

            migrationBuilder.DropTable(
                name: "Destek");

            migrationBuilder.DropTable(
                name: "DestekDetay");

            migrationBuilder.DropTable(
                name: "DestekDetayHizmet");

            migrationBuilder.DropTable(
                name: "DestekDokuman");

            migrationBuilder.DropTable(
                name: "Durum");

            migrationBuilder.DropTable(
                name: "HizmetAnlasmlari");

            migrationBuilder.DropTable(
                name: "Hizmetler");

            migrationBuilder.DropTable(
                name: "Ilce");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "Sehir");

            migrationBuilder.DropTable(
                name: "SmtpMail");
        }
    }
}
