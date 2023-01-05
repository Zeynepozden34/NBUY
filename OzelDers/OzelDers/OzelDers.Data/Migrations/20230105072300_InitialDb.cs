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
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
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
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
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
                    BrunchId = table.Column<int>(type: "INTEGER", nullable: false),
                    BranchId = table.Column<int>(type: "INTEGER", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
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
                        principalColumn: "Id");
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
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Matematik" },
                    { 2, "Fizik" },
                    { 3, "Kimya" },
                    { 4, "Tarih" },
                    { 5, "İngilizce" },
                    { 6, "Edebiyat" },
                    { 7, "Biyoloji" },
                    { 8, "Almanca" },
                    { 9, "C#" },
                    { 10, "Felsefe" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Description", "FirstName", "Gender", "ImageUrl", "IsDeleted", "LastName", "Location" },
                values: new object[,]
                {
                    { 1, 17, "Lise Öğrencisi", "Selim", "erkek", "1.png", false, "Durmuş", "Üsküdar/İstanbul" },
                    { 2, 18, "Üniversite Hazırlık Öğrencisi", "Defne", "kız", "2.png", false, "Görmüş", "Çankaya/Ankara" },
                    { 3, 21, "Üniversite Öğrencisi", "Hazal", "kız", "3.png", false, "Kara", "Çukurova/Adana" },
                    { 4, 23, "Üniversite Öğrencisi", "Gözde", "kız", "4.png", false, "Kama", "Bahçelievler/İstanbul" },
                    { 5, 17, "Lise Öğrencisi", "Hüseyin", "erkek", "5.png", false, "Kazanmış", "Küçükçekmece/İstanbul" },
                    { 6, 16, "Lise Öğrencisi", "Bilal", "erkek", "6.png", false, "Telli", "Bornova/İzmir" },
                    { 7, 15, "Lise Öğrencisi", "Yunus", "erkek", "7.png", false, "Deniz", "İzmit/Kocaeli" },
                    { 8, 18, "Üniversite Hazırlık Öğrencisi", "Cemre", "erkek", "8.png", false, "Kıran", "Üsküdar/İstanbul" },
                    { 9, 19, "Üniversite Öğrencisi", "Yusuf", "erkek", "9.png", false, "Güzel", "Yüreğir/Adana" },
                    { 10, 19, "Üniversite Öğrencisi", "Harun", "erkek", "10.png", false, "Bulut", "İskenderun/Hatay" },
                    { 11, 20, "Üniversite Öğrencisi", "Yıldız", "kız", "11.png", false, "Mutlu", "Pendik/İstanbul" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Age", "BranchId", "BrunchId", "CertifiedTrainer", "Description", "Email", "FirstName", "Gender", "HourlyPrice", "ImageUrl", "IsDeleted", "IsFacetoFace", "LastName", "Location", "UniverstyGraduatedFrom" },
                values: new object[,]
                {
                    { 1, 27, null, 5, true, "Engish lessons are given.", "jackbrand@ozelders.com", "Jack", "erkek", 800, "20.png", false, false, "Brand", "Toronto/Canada", "Cambridge University" },
                    { 2, 27, null, 2, true, "Fizik dersi verilir.", "sevgiozer@ozelders.com", "Sevgi", "kadın", 400, "21.png", false, true, "Özer", "Avcılar/İstanbul", "İstanbul Üniversitesi" },
                    { 3, 35, null, 1, true, "Matematik dersi verilir.", "denizkuru@ozelders.com", "Deniz", "kadın", 600, "22.png", false, true, "Kuru", "Avcılar/İstanbul", "Haccettepe Üniversitesi" },
                    { 4, 30, null, 3, true, "Kimya dersi verilir.", "selimgoren@ozelders.com", "Selim", "erkek", 650, "23.png", false, true, "Gören", "Çankaya/Ankara", "Marmara Üniversitesi" },
                    { 5, 40, null, 9, false, "C# dersi verilir.", "kemaleren@ozelders.com", "Kemal", "erkek", 400, "24.png", false, true, "Eren", "Bornova/İzmir", "Fırat Üniversitesi" },
                    { 6, 25, null, 6, true, "Edebiyat dersi verilir.", "melissusan@ozelders.com", "Melis", "kadın", 600, "25.png", false, true, "Susan", "Sefaköy/İstanbul", "İstanbul Üniversitesi" },
                    { 7, 34, null, 8, true, "Almanca dersi verilir.", "defnebilen@ozelders.com", "Defne", "kadın", 500, "26.png", false, false, "Bilen", "Buca/İzmir", "Dokuz Eylül Üniversitesi" }
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
                column: "BranchId");
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
