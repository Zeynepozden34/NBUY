using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OzelDers.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branchs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UniverstyGraduatedFrom = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    HourlyPrice = table.Column<int>(type: "INTEGER", nullable: false),
                    IsFacetoFace = table.Column<bool>(type: "INTEGER", nullable: false),
                    CertifiedTrainer = table.Column<bool>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    BranchId = table.Column<int>(type: "INTEGER", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Branchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAndTeachers",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAndTeachers", x => new { x.StudentId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_StudentAndTeachers_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAndTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branchs",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Matematik", "matematik" },
                    { 2, "Fizik", "fizik" },
                    { 3, "Kimya", "kimya" },
                    { 4, "Tarih", "tarih" },
                    { 5, "İngilizce", "ingilizce" },
                    { 6, "Edebiyat", "edebiyat" },
                    { 7, "Biyoloji", "biyoloji" },
                    { 8, "Almanca", "almanca" },
                    { 9, "C#", "c#" },
                    { 10, "Felsefe", "felsefe" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "DateAdded", "Description", "FirstName", "Gender", "ImageUrl", "IsDeleted", "LastName", "Location", "Url" },
                values: new object[,]
                {
                    { 1, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lise Öğrencisi", "Selim", "erkek", "1.png", false, "Durmuş", "Üsküdar/İstanbul", "selimdurmus" },
                    { 2, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Üniversite Hazırlık Öğrencisi", "Defne", "kız", "2.png", false, "Görmüş", "Çankaya/Ankara", "defnegormus" },
                    { 3, 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Üniversite Öğrencisi", "Hazal", "kız", "3.png", false, "Kara", "Çukurova/Adana", "selimdurmus" },
                    { 4, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Üniversite Öğrencisi", "Gözde", "kız", "4.png", false, "Kama", "Bahçelievler/İstanbul", "selimdurmus" },
                    { 5, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lise Öğrencisi", "Hüseyin", "erkek", "5.png", false, "Kazanmış", "Küçükçekmece/İstanbul", "selimdurmus" },
                    { 6, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lise Öğrencisi", "Bilal", "erkek", "6.png", false, "Telli", "Bornova/İzmir", "selimdurmus" },
                    { 7, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lise Öğrencisi", "Yunus", "erkek", "7.png", false, "Deniz", "İzmit/Kocaeli", "denizyunus" },
                    { 8, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Üniversite Hazırlık Öğrencisi", "Cemre", "erkek", "8.png", false, "Kıran", "Üsküdar/İstanbul", "cemrekıran" },
                    { 9, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Üniversite Öğrencisi", "Yusuf", "erkek", "9.png", false, "Güzel", "Yüreğir/Adana", "selimdurmus" },
                    { 10, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Üniversite Öğrencisi", "Harun", "erkek", "10.png", false, "Bulut", "İskenderun/Hatay", "selimdurmus" },
                    { 11, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Üniversite Öğrencisi", "Yıldız", "kız", "11.png", false, "Mutlu", "Pendik/İstanbul", "selimdurmus" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Age", "BranchId", "CertifiedTrainer", "Description", "Email", "FirstName", "Gender", "HourlyPrice", "ImageUrl", "IsDeleted", "IsFacetoFace", "LastName", "Location", "UniverstyGraduatedFrom", "Url" },
                values: new object[,]
                {
                    { 1, 27, 5, true, "Engish lessons are given.", "jackbrand@ozelders.com", "Jack", "erkek", 800, "20.png", false, false, "Brand", "Toronto/Canada", "Cambridge University", "jackbrand" },
                    { 2, 27, 2, true, "Fizik dersi verilir.", "sevgiozer@ozelders.com", "Sevgi", "kadın", 400, "21.png", false, true, "Özer", "Avcılar/İstanbul", "İstanbul Üniversitesi", "sevgiozer" },
                    { 3, 35, 1, true, "Matematik dersi verilir.", "denizkuru@ozelders.com", "Deniz", "kadın", 600, "22.png", false, true, "Kuru", "Avcılar/İstanbul", "Haccettepe Üniversitesi", "denizkuru" },
                    { 4, 30, 3, true, "Kimya dersi verilir.", "selimgoren@ozelders.com", "Selim", "erkek", 650, "23.png", false, true, "Gören", "Çankaya/Ankara", "Marmara Üniversitesi", "selimgören" },
                    { 5, 40, 9, false, "C# dersi verilir.", "kemaleren@ozelders.com", "Kemal", "erkek", 400, "24.png", false, true, "Eren", "Bornova/İzmir", "Fırat Üniversitesi", "kemaleren" },
                    { 6, 25, 6, true, "Edebiyat dersi verilir.", "melissusan@ozelders.com", "Melis", "kadın", 600, "25.png", false, true, "Susan", "Sefaköy/İstanbul", "İstanbul Üniversitesi", "melissusan" },
                    { 7, 34, 8, true, "Almanca dersi verilir.", "defnebilen@ozelders.com", "Defne", "kadın", 500, "26.png", false, false, "Bilen", "Buca/İzmir", "Dokuz Eylül Üniversitesi", "defnebilen" }
                });

            migrationBuilder.InsertData(
                table: "StudentAndTeachers",
                columns: new[] { "StudentId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 4 },
                    { 6, 5 },
                    { 7, 6 },
                    { 8, 1 },
                    { 9, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentAndTeachers_TeacherId",
                table: "StudentAndTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_BranchId",
                table: "Teachers",
                column: "BranchId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentAndTeachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Branchs");
        }
    }
}
