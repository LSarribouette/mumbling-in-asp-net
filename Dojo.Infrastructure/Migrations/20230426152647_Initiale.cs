using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dojo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initiale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtMartial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtMartial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Arme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Damage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Samourai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    ArmeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samourai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Samourai_Arme_ArmeId",
                        column: x => x.ArmeId,
                        principalTable: "Arme",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ArtMartialSamourai",
                columns: table => new
                {
                    ArtsMartiauxId = table.Column<int>(type: "int", nullable: false),
                    SamouraisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtMartialSamourai", x => new { x.ArtsMartiauxId, x.SamouraisId });
                    table.ForeignKey(
                        name: "FK_ArtMartialSamourai_ArtMartial_ArtsMartiauxId",
                        column: x => x.ArtsMartiauxId,
                        principalTable: "ArtMartial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtMartialSamourai_Samourai_SamouraisId",
                        column: x => x.SamouraisId,
                        principalTable: "Samourai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ArtMartial",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Krav Maga" },
                    { 2, "Keysi Fighting Method" },
                    { 3, "Jiu-Jitsu Brésilien" },
                    { 4, "Judo" },
                    { 5, "Muay Thai" },
                    { 6, "Taekwondo" },
                    { 7, "Jujutsu japonais" },
                    { 8, "Aïkido" },
                    { 9, "Boxe" },
                    { 10, "Karaté" }
                });

            migrationBuilder.InsertData(
                table: "Samourai",
                columns: new[] { "Id", "ArmeId", "Name", "Strength" },
                values: new object[,]
                {
                    { 1, null, "Abe Masakatsu", 1533 },
                    { 2, null, "Adachi Yasumori", 605 },
                    { 3, null, "Adachi Kagemori", 286 },
                    { 4, null, "Adams William", 355 },
                    { 5, null, "Aiou Mototsuna", 520 },
                    { 6, null, "Akai Terukage", 1451 },
                    { 7, null, "Akao Kiyotsuna", 1982 },
                    { 8, null, "Akechi Mitsuhide", 1280 },
                    { 9, null, "Akiyama Nobutomo", 1996 },
                    { 10, null, "Amago Haruhisa", 1111 },
                    { 11, null, "Amago Yoshihisa", 1005 },
                    { 12, null, "Andō Morinari", 1520 },
                    { 13, null, "Ankokuji Ekei", 1183 },
                    { 14, null, "Aochi Shigetsuna", 501 },
                    { 15, null, "Aokage Takaakira", 1529 },
                    { 16, null, "Aoki Kazushige", 1123 },
                    { 17, null, "Akahori Chohichi", 1341 },
                    { 18, null, "Arai Hakuseki", 434 },
                    { 19, null, "Araki Motokiyo", 436 },
                    { 20, null, "Araki Murashige", 321 },
                    { 21, null, "Araki Muratsugu", 848 },
                    { 22, null, "Arima Kihei", 1817 },
                    { 23, null, "Asakura Yoshikage", 482 },
                    { 24, null, "Ayame Kagekatsu", 660 },
                    { 25, null, "Azai Hisamasa", 305 },
                    { 26, null, "Azai Nagamasa", 1969 },
                    { 27, null, "Azai Sukemasa", 1084 },
                    { 28, null, "Baba Nobufusa", 1850 },
                    { 29, null, "Bessho Nagaharu", 820 },
                    { 30, null, "Chacha", 246 },
                    { 31, null, "Chiba Shusaku Narimasa", 364 },
                    { 32, null, "Chōsokabe Morichika", 806 },
                    { 33, null, "Chōsokabe Kunichika", 1143 },
                    { 34, null, "Chōsokabe Motochika", 439 },
                    { 35, null, "Chōsokabe Nobuchika", 1379 },
                    { 36, null, "Collache Eugène", 1666 },
                    { 37, null, "Date Masamune", 1335 },
                    { 38, null, "Date Shigezane", 890 },
                    { 39, null, "Doi Toshikatsu", 927 },
                    { 40, null, "Etō Shinpei", 1961 },
                    { 41, null, "Endō Naotsune", 1513 },
                    { 42, null, "Enjoji Nobutane", 268 },
                    { 43, null, "Enomoto Takeaki", 3 },
                    { 44, null, "Era Fusahide", 1416 },
                    { 45, null, "Fūma Kotarō", 728 },
                    { 46, null, "Fuwa Mitsuharu", 1119 },
                    { 47, null, "Fukushima Masanori", 1103 },
                    { 48, null, "Gamō Katahide", 277 },
                    { 49, null, "Gamō Ujisato", 577 },
                    { 50, null, "Harada Naomasa", 150 },
                    { 51, null, "Harada Nobutane", 1888 },
                    { 52, null, "Harada Sanosuke", 536 },
                    { 53, null, "Hasekura Tsunenaga", 1069 },
                    { 54, null, "Hattori Hanzō", 1251 },
                    { 55, null, "Hatano Hideharu", 1153 },
                    { 56, null, "Hasegawa Eishin", 1913 },
                    { 57, null, "Hayashizaki Jinsuke Shigenobu", 1293 },
                    { 58, null, "Hayashi Narinaga", 866 },
                    { 59, null, "Hijikata Toshizo", 920 },
                    { 60, null, "Hirate Masahide", 1974 },
                    { 61, null, "Hitotsubashi Keiki", 1795 },
                    { 62, null, "Hōjō Masako", 1934 },
                    { 63, null, "Hōjō Tokimune", 256 },
                    { 64, null, "Hōjō Ujiyasu", 539 },
                    { 65, null, "Hōjō Ujimasa", 447 },
                    { 66, null, "Honda Tadakatsu", 1611 },
                    { 67, null, "Honda Tadatomo", 836 },
                    { 68, null, "Honganji Kennyo", 398 },
                    { 69, null, "Horio Yoshiharu", 1726 },
                    { 70, null, "Hosokawa Fujitaka", 1108 },
                    { 71, null, "Hosokawa Gracia", 384 },
                    { 72, null, "Hosokawa Tadaoki", 1798 },
                    { 73, null, "Hotta Masatoshi", 1283 },
                    { 74, null, "Ii Naoaki", 600 },
                    { 75, null, "Ii Naomasa", 373 },
                    { 76, null, "Ii Naomori", 1640 },
                    { 77, null, "Ii Naonaka", 220 },
                    { 78, null, "Ii Naosuke", 1383 },
                    { 79, null, "Ii Naotaka", 1700 },
                    { 80, null, "Ii Naotora", 1624 },
                    { 81, null, "Ii Naoyuki", 1522 },
                    { 82, null, "Ii Naozumi", 957 },
                    { 83, null, "Iizasa Ienao", 1703 },
                    { 84, null, "Ijuin Tadaaki", 1490 },
                    { 85, null, "Ikeda Tsuneoki", 686 },
                    { 86, null, "Imagawa Ujizane", 833 },
                    { 87, null, "Imagawa Yoshimoto", 1257 },
                    { 88, null, "Imai Kanehira", 1145 },
                    { 89, null, "Inaba Yoshimichi", 32 },
                    { 90, null, "Inugami Nagayasu", 407 },
                    { 91, null, "Ishida Mitsunari", 1399 },
                    { 92, null, "Isshiki Fujinaga", 1485 },
                    { 93, null, "Itagaki Nobukata", 981 },
                    { 94, null, "Itō Hirobumi", 526 },
                    { 95, null, "Iwanari Tomomichi", 411 },
                    { 96, null, "Jinbo Nagamoto", 985 },
                    { 97, null, "Jonas Tönse", 1595 },
                    { 98, null, "Kannan Kumar(Salem)", 1857 },
                    { 99, null, "Kakeda Toshimune", 804 },
                    { 100, null, "Kaneko Ietada", 69 },
                    { 101, null, "Katagiri Katsumoto", 1951 },
                    { 102, null, "Katakura Kojūro", 1092 },
                    { 103, null, "Katakura Shigenaga", 636 },
                    { 104, null, "Kataoka Mitsumasa", 1470 },
                    { 105, null, "Katō Kiyomasa", 1119 },
                    { 106, null, "Kawakami Gensai", 1886 },
                    { 107, null, "Kido Takayoshi", 211 },
                    { 108, null, "Kikkawa Hiroie", 1517 },
                    { 109, null, "Kimotsuki Kanetsugu", 1357 },
                    { 110, null, "Kitamura Kansuke", 1595 },
                    { 111, null, "Kobayakawa Hideaki", 145 },
                    { 112, null, "Kobayakawa Hidekane", 458 },
                    { 113, null, "Kobayakawa Takakage", 105 },
                    { 114, null, "Konishi Yukinaga", 54 },
                    { 115, null, "Kojima Toyoharu", 459 },
                    { 116, null, "Kuroda Kanbei", 300 },
                    { 117, null, "Kuroda Kiyotaka", 1150 },
                    { 118, null, "Kusunoki Masashige", 1972 },
                    { 119, null, "Kuwana Tarozaemon", 12 },
                    { 120, null, "Kumagai Naozane", 861 },
                    { 121, null, "Maeda Keiji", 1079 },
                    { 122, null, "Maeda Matsu", 1795 },
                    { 123, null, "Maeda Nagatane", 8 },
                    { 124, null, "Maeda Toshiie", 1268 },
                    { 125, null, "Maeda Toshinaga", 1490 },
                    { 126, null, "Maeda Toshitsune", 658 },
                    { 127, null, "Magome Kageyu", 640 },
                    { 128, null, "Manabe Akifusa", 28 },
                    { 129, null, "Matsudaira Katamori", 755 },
                    { 130, null, "Matsudaira Nobutsuna", 1337 },
                    { 131, null, "Matsudaira Nobuyasu", 1392 },
                    { 132, null, "Matsudaira Higo no Kami Katamori", 1897 },
                    { 133, null, "Matsudaira Sadanobu", 38 },
                    { 134, null, "Matsudaira Tadayoshi", 1296 },
                    { 135, null, "Matsudaira Teru", 560 },
                    { 136, null, "Matsunaga Hisahide", 221 },
                    { 137, null, "Matsunaga Hisamichi", 42 },
                    { 138, null, "Matsuo Bashō", 869 },
                    { 139, null, "Matsudaira Motoyasu", 810 },
                    { 140, null, "Minamoto no Mitsunaka", 1790 },
                    { 141, null, "Minamoto no Yoshiie", 118 },
                    { 142, null, "Minamoto no Yoshimitsu", 1504 },
                    { 143, null, "Minamoto no Yoshinaka", 1233 },
                    { 144, null, "Minamoto no Yoshitomo", 1375 },
                    { 145, null, "Minamoto no Yoshitsune", 779 },
                    { 146, null, "Minamoto no Tameyoshi", 497 },
                    { 147, null, "Minamoto no Yorimasa", 666 },
                    { 148, null, "Minamoto no Yorimitsu", 274 },
                    { 149, null, "Minamoto no Yoritomo", 1182 },
                    { 150, null, "Minamoto no Noriyori", 1898 },
                    { 151, null, "Minoro Takashi", 2 },
                    { 152, null, "Miura Anjin", 1963 },
                    { 153, null, "Miura Yoshimoto", 517 },
                    { 154, null, "Miyamoto Musashi", 464 },
                    { 155, null, "Miyoshi Chōkei", 1618 },
                    { 156, null, "Miyoshi Kazuhide", 152 },
                    { 157, null, "Miyoshi Masaga", 316 },
                    { 158, null, "Miyoshi Masayasu", 316 },
                    { 159, null, "Miyoshi Moriyata", 1964 },
                    { 160, null, "Miyoshi Nagayuki", 1523 },
                    { 161, null, "Miyoshi Yoshitsugu", 480 },
                    { 162, null, "Mizuno Tadakuni", 342 },
                    { 163, null, "Moniwa Yoshinao", 905 },
                    { 164, null, "Mōri Motonari", 671 },
                    { 165, null, "Mōri Nagasada", 1252 },
                    { 166, null, "Mori Nagayoshi", 136 },
                    { 167, null, "Mōri Okimoto", 54 },
                    { 168, null, "Mori Ranmaru", 1193 },
                    { 169, null, "Mōri Takamoto", 534 },
                    { 170, null, "Mori Tadamasa", 1562 },
                    { 171, null, "Mōri Terumoto", 1933 },
                    { 172, null, "Mori Yoshinari", 1258 },
                    { 173, null, "Murai Sadakatsu", 1602 },
                    { 174, null, "Nagakura Shinpachi", 1391 },
                    { 175, null, "Nagao Harukage", 175 },
                    { 176, null, "Nagao Kagenobu", 869 },
                    { 177, null, "Nagao Masakage", 1277 },
                    { 178, null, "Nagao Tamekage", 148 },
                    { 179, null, "Nakagawa Kiyohide", 1627 },
                    { 180, null, "Nakaoka Shintarō", 1361 },
                    { 181, null, "Naoe Kagetsuna", 1759 },
                    { 182, null, "Naoe Kanetsugu", 1183 },
                    { 183, null, "Narita Kaihime", 1473 },
                    { 184, null, "Nene", 603 },
                    { 185, null, "Nihonmatsu Yoshitsugu", 1668 },
                    { 186, null, "Niimi Nishiki", 1125 },
                    { 187, null, "Niiro Tadamoto", 676 },
                    { 188, null, "Niwa Nagahide", 560 },
                    { 189, null, "Niwa Nagashige", 477 },
                    { 190, null, "Oda Hiroyoshi", 1610 },
                    { 191, null, "Oda Nobuhide", 809 },
                    { 192, null, "Oda Nobukata", 1674 },
                    { 193, null, "Oda Nobukiyo", 482 },
                    { 194, null, "Oda Nobunaga", 1194 },
                    { 195, null, "Oda Nobutada", 541 },
                    { 196, null, "Oda Nobutomo", 445 },
                    { 197, null, "Oda Nobukatsu", 1528 },
                    { 198, null, "Oda Nobuyasu", 1141 },
                    { 199, null, "Ogasawara Shōsai", 1581 },
                    { 200, null, "Ōishi Kuranosuke", 1521 },
                    { 201, null, "Okada Izō", 1381 },
                    { 202, null, "Judge Ooka", 843 },
                    { 203, null, "Ōta Dōkan", 918 },
                    { 204, null, "Ōtani Yoshitsugu", 1133 },
                    { 205, null, "Ōtani Yoshiharu", 1471 },
                    { 206, null, "Ōtomo Sōrin", 1736 },
                    { 207, null, "Okita Sōji", 1393 },
                    { 208, null, "Ōkubo Toshimichi", 715 },
                    { 209, null, "Okunomiya Masaie", 1079 },
                    { 210, null, "Ōuchi Yoshitaka", 966 },
                    { 211, null, "Omy Yoshika", 1674 },
                    { 212, null, "Pore Sufi", 1902 },
                    { 213, null, "Reizei Takatoyo", 913 },
                    { 214, null, "Rokkaku Sadayori", 844 },
                    { 215, null, "Rokkaku Yoshiharu", 130 },
                    { 216, null, "Rokkaku Yoshikata", 627 },
                    { 217, null, "Rusu Masakage", 1598 },
                    { 218, null, "Ryūzōji Takanobu", 226 },
                    { 219, null, "Saigo Kiyokazu", 627 },
                    { 220, null, "Saigō Masako", 436 },
                    { 221, null, "Sagara Taketō", 986 },
                    { 222, null, "Saigō Takamori", 1225 },
                    { 223, null, "Saigo Yoshikatsu", 1562 },
                    { 224, null, "Saitō Dōsan", 175 },
                    { 225, null, "Saitō Hajime", 548 },
                    { 226, null, "Saito Musashibō Benkei", 278 },
                    { 227, null, "Saitō Yoshitatsu", 1520 },
                    { 228, null, "Sakai Tadakiyo", 1208 },
                    { 229, null, "Sakai Tadashige", 1884 },
                    { 230, null, "Sakai Tadatsugu", 77 },
                    { 231, null, "Sakai Tadayo", 234 },
                    { 232, null, "Sakakibara Yasumasa", 821 },
                    { 233, null, "Sakamoto Ryōma", 1240 },
                    { 234, null, "Sakuma Morimasa", 810 },
                    { 235, null, "Sakuma Nobumori", 982 },
                    { 236, null, "Sanada Akihime", 1413 },
                    { 237, null, "Sanada Komatsuhime", 1050 },
                    { 238, null, "Sanada Masayuki", 1387 },
                    { 239, null, "Sanada Nobuyuki", 229 },
                    { 240, null, "Sanada Yukimura", 1420 },
                    { 241, null, "Sasaki Kojirō", 1005 },
                    { 242, null, "Sassa Narimasa", 560 },
                    { 243, null, "Sasuke Sarutobi", 159 },
                    { 244, null, "Serizawa Kamo", 1089 },
                    { 245, null, "Shibata Katsuie", 472 },
                    { 246, null, "Shima Sakon", 389 },
                    { 247, null, "Shimada Ichirō", 232 },
                    { 248, null, "Shimazu Katsuhisa", 159 },
                    { 249, null, "Shimazu Tadahisa", 1802 },
                    { 250, null, "Shimazu Tadatsune", 1185 },
                    { 251, null, "Shimazu Tadayoshi", 1308 },
                    { 252, null, "Shimazu Takahisa", 1269 },
                    { 253, null, "Shimazu Toyohisa", 1160 },
                    { 254, null, "Shimazu Yoshihiro", 1161 },
                    { 255, null, "Shimazu Yoshihisa", 271 },
                    { 256, null, "Shindou Hiroshii", 1231 },
                    { 257, null, "Sogo Nagayasu", 850 },
                    { 258, null, "Sue Yoshitaka", 1583 },
                    { 259, null, "Tachibana Muneshige", 1579 },
                    { 260, null, "Tachibana Dōsetsu", 399 },
                    { 261, null, "Tachibana Ginchiyo", 1785 },
                    { 262, null, "Taigen Sessai", 1522 },
                    { 263, null, "Taira no Kiyomori", 572 },
                    { 264, null, "Taira Masakado", 32 },
                    { 265, null, "Takahashi Shigetane", 50 },
                    { 266, null, "Takenaka Shigeharu", 226 },
                    { 267, null, "Takasugi Shinsaku", 663 },
                    { 268, null, "Takayama Justo", 1370 },
                    { 269, null, "Takayama Ukon", 928 },
                    { 270, null, "Takechi Hanpeita", 975 },
                    { 271, null, "Takeda Katsuyori", 413 },
                    { 272, null, "Takeda Nobukatsu", 1783 },
                    { 273, null, "Takeda Nobushige", 1629 },
                    { 274, null, "Takeda Shingen", 1580 },
                    { 275, null, "Takenaka Hanbei", 635 },
                    { 276, null, "Tani Tadasumi", 1742 },
                    { 277, null, "Tōdō Takatora", 172 },
                    { 278, null, "Toki Yorinari", 257 },
                    { 279, null, "Tochimitsu Gantyoki", 1160 },
                    { 280, null, "Tokugawa Ieyasu", 657 },
                    { 281, null, "Tokugawa Hidetada", 980 },
                    { 282, null, "Tokugawa Nariaki", 1928 },
                    { 283, null, "Tokugawa Yoshinobu", 444 },
                    { 284, null, "Torii Mototada", 1521 },
                    { 285, null, "Toyotomi Hidenaga", 517 },
                    { 286, null, "Toyotomi Hideyoshi", 662 },
                    { 287, null, "Toyotomi Hideyori", 805 },
                    { 288, null, "Tozuka Tadaharu", 1342 },
                    { 289, null, "Tsukahara Bokuden", 358 },
                    { 290, null, "Uesugi Kagekatsu", 456 },
                    { 291, null, "Uesugi Kagetora", 790 },
                    { 292, null, "Uesugi Kenshin", 864 },
                    { 293, null, "Ujiie Naotomo", 550 },
                    { 294, null, "Ukita Naoie", 1074 },
                    { 295, null, "Ukita Okiie", 1866 },
                    { 296, null, "Umezawa Michiharu", 307 },
                    { 297, null, "Usami Sadamitsu", 689 },
                    { 298, null, "Uyama Hisanobu", 1831 },
                    { 299, null, "Wada Shinsuke", 1515 },
                    { 300, null, "Watanabe Kazan", 1159 },
                    { 301, null, "Watanabe no Tsuna", 893 },
                    { 302, null, "Yasumero Kenshin", 1361 },
                    { 303, null, "Yagyū Jūbei Mitsuyoshi", 1238 },
                    { 304, null, "Yagyū Munenori", 36 },
                    { 305, null, "Yamauchi Kazutoyo", 1368 },
                    { 306, null, "Yamada Arinaga", 1441 },
                    { 307, null, "Yamada Arinobu", 441 },
                    { 308, null, "Yamada Nagamasa", 1727 },
                    { 309, null, "Yamagata Masakage", 1494 },
                    { 310, null, "Yamakawa Hiroshi", 1770 },
                    { 311, null, "Yamakawa Kenjirō", 1938 },
                    { 312, null, "Yamakawa Naoe", 789 },
                    { 313, null, "Yamanaka Yukimori", 202 },
                    { 314, null, "Yamanami Keisuke", 404 },
                    { 315, null, "Yamaoka Tesshū", 1785 },
                    { 316, null, "Yanagawa Kenzaburo", 1510 },
                    { 317, null, "Yanagisawa Yoshiyasu", 1592 },
                    { 318, null, "Yonekura Shigetsugu", 1734 },
                    { 319, null, "Yūki Hideyasu", 569 },
                    { 320, null, "Yasuke", 665 }
                });

            migrationBuilder.InsertData(
                table: "Arme",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[,]
                {
                    { 1, 116, "Katana" },
                    { 2, 54, "Yumi" },
                    { 3, 144, "Wakisashi" },
                    { 4, 62, "Naginata" },
                    { 5, 482, "Yari" },
                    { 6, 89, "Masakari" },
                    { 7, 328, "Nodachi" },
                    { 8, 282, "Tessen" },
                    { 9, 185, "Tachi" },
                    { 10, 155, "Shuriken" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtMartialSamourai_SamouraisId",
                table: "ArtMartialSamourai",
                column: "SamouraisId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Samourai_ArmeId",
                table: "Samourai",
                column: "ArmeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arme_Samourai_Id",
                table: "Arme",
                column: "Id",
                principalTable: "Samourai",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arme_Samourai_Id",
                table: "Arme");

            migrationBuilder.DropTable(
                name: "ArtMartialSamourai");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ArtMartial");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Samourai");

            migrationBuilder.DropTable(
                name: "Arme");
        }
    }
}
