﻿using Microsoft.EntityFrameworkCore.Migrations;

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
                name: "Arme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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

            migrationBuilder.InsertData(
                table: "Arme",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[,]
                {
                    { 1, 461, "Katana" },
                    { 2, 484, "Yumi" },
                    { 3, 363, "Wakisashi" },
                    { 4, 482, "Naginata" },
                    { 5, 57, "Yari" },
                    { 6, 300, "Masakari" },
                    { 7, 102, "Nodachi" },
                    { 8, 211, "Tessen" },
                    { 9, 150, "Tachi" },
                    { 10, 455, "Shuriken" }
                });

            migrationBuilder.InsertData(
                table: "Samourai",
                columns: new[] { "Id", "ArmeId", "Name", "Strength" },
                values: new object[,]
                {
                    { 1, null, "Abe Masakatsu", 134 },
                    { 2, null, "Adachi Yasumori", 263 },
                    { 3, null, "Adachi Kagemori", 541 },
                    { 4, null, "Adams William", 1515 },
                    { 5, null, "Aiou Mototsuna", 638 },
                    { 6, null, "Akai Terukage", 672 },
                    { 7, null, "Akao Kiyotsuna", 711 },
                    { 8, null, "Akechi Mitsuhide", 1090 },
                    { 9, null, "Akiyama Nobutomo", 1371 },
                    { 10, null, "Amago Haruhisa", 1099 },
                    { 11, null, "Amago Yoshihisa", 1580 },
                    { 12, null, "Andō Morinari", 249 },
                    { 13, null, "Ankokuji Ekei", 621 },
                    { 14, null, "Aochi Shigetsuna", 357 },
                    { 15, null, "Aokage Takaakira", 1976 },
                    { 16, null, "Aoki Kazushige", 650 },
                    { 17, null, "Akahori Chohichi", 1058 },
                    { 18, null, "Arai Hakuseki", 1948 },
                    { 19, null, "Araki Motokiyo", 975 },
                    { 20, null, "Araki Murashige", 1137 },
                    { 21, null, "Araki Muratsugu", 1937 },
                    { 22, null, "Arima Kihei", 1150 },
                    { 23, null, "Asakura Yoshikage", 1950 },
                    { 24, null, "Ayame Kagekatsu", 628 },
                    { 25, null, "Azai Hisamasa", 1911 },
                    { 26, null, "Azai Nagamasa", 581 },
                    { 27, null, "Azai Sukemasa", 706 },
                    { 28, null, "Baba Nobufusa", 1069 },
                    { 29, null, "Bessho Nagaharu", 907 },
                    { 30, null, "Chacha", 520 },
                    { 31, null, "Chiba Shusaku Narimasa", 1869 },
                    { 32, null, "Chōsokabe Morichika", 1893 },
                    { 33, null, "Chōsokabe Kunichika", 1306 },
                    { 34, null, "Chōsokabe Motochika", 1490 },
                    { 35, null, "Chōsokabe Nobuchika", 480 },
                    { 36, null, "Collache Eugène", 1154 },
                    { 37, null, "Date Masamune", 696 },
                    { 38, null, "Date Shigezane", 951 },
                    { 39, null, "Doi Toshikatsu", 1931 },
                    { 40, null, "Etō Shinpei", 1105 },
                    { 41, null, "Endō Naotsune", 867 },
                    { 42, null, "Enjoji Nobutane", 1190 },
                    { 43, null, "Enomoto Takeaki", 1601 },
                    { 44, null, "Era Fusahide", 1144 },
                    { 45, null, "Fūma Kotarō", 1921 },
                    { 46, null, "Fuwa Mitsuharu", 1584 },
                    { 47, null, "Fukushima Masanori", 1388 },
                    { 48, null, "Gamō Katahide", 45 },
                    { 49, null, "Gamō Ujisato", 703 },
                    { 50, null, "Harada Naomasa", 198 },
                    { 51, null, "Harada Nobutane", 674 },
                    { 52, null, "Harada Sanosuke", 438 },
                    { 53, null, "Hasekura Tsunenaga", 1492 },
                    { 54, null, "Hattori Hanzō", 897 },
                    { 55, null, "Hatano Hideharu", 556 },
                    { 56, null, "Hasegawa Eishin", 1708 },
                    { 57, null, "Hayashizaki Jinsuke Shigenobu", 944 },
                    { 58, null, "Hayashi Narinaga", 633 },
                    { 59, null, "Hijikata Toshizo", 1387 },
                    { 60, null, "Hirate Masahide", 1456 },
                    { 61, null, "Hitotsubashi Keiki", 1245 },
                    { 62, null, "Hōjō Masako", 1344 },
                    { 63, null, "Hōjō Tokimune", 1838 },
                    { 64, null, "Hōjō Ujiyasu", 402 },
                    { 65, null, "Hōjō Ujimasa", 1463 },
                    { 66, null, "Honda Tadakatsu", 689 },
                    { 67, null, "Honda Tadatomo", 361 },
                    { 68, null, "Honganji Kennyo", 603 },
                    { 69, null, "Horio Yoshiharu", 1465 },
                    { 70, null, "Hosokawa Fujitaka", 1499 },
                    { 71, null, "Hosokawa Gracia", 410 },
                    { 72, null, "Hosokawa Tadaoki", 1162 },
                    { 73, null, "Hotta Masatoshi", 1330 },
                    { 74, null, "Ii Naoaki", 1864 },
                    { 75, null, "Ii Naomasa", 73 },
                    { 76, null, "Ii Naomori", 1939 },
                    { 77, null, "Ii Naonaka", 1298 },
                    { 78, null, "Ii Naosuke", 1436 },
                    { 79, null, "Ii Naotaka", 1441 },
                    { 80, null, "Ii Naotora", 1760 },
                    { 81, null, "Ii Naoyuki", 446 },
                    { 82, null, "Ii Naozumi", 1549 },
                    { 83, null, "Iizasa Ienao", 557 },
                    { 84, null, "Ijuin Tadaaki", 1674 },
                    { 85, null, "Ikeda Tsuneoki", 143 },
                    { 86, null, "Imagawa Ujizane", 745 },
                    { 87, null, "Imagawa Yoshimoto", 1841 },
                    { 88, null, "Imai Kanehira", 1839 },
                    { 89, null, "Inaba Yoshimichi", 711 },
                    { 90, null, "Inugami Nagayasu", 978 },
                    { 91, null, "Ishida Mitsunari", 220 },
                    { 92, null, "Isshiki Fujinaga", 562 },
                    { 93, null, "Itagaki Nobukata", 233 },
                    { 94, null, "Itō Hirobumi", 1231 },
                    { 95, null, "Iwanari Tomomichi", 776 },
                    { 96, null, "Jinbo Nagamoto", 596 },
                    { 97, null, "Jonas Tönse", 967 },
                    { 98, null, "Kannan Kumar(Salem)", 1082 },
                    { 99, null, "Kakeda Toshimune", 874 },
                    { 100, null, "Kaneko Ietada", 630 },
                    { 101, null, "Katagiri Katsumoto", 1343 },
                    { 102, null, "Katakura Kojūro", 66 },
                    { 103, null, "Katakura Shigenaga", 788 },
                    { 104, null, "Kataoka Mitsumasa", 520 },
                    { 105, null, "Katō Kiyomasa", 73 },
                    { 106, null, "Kawakami Gensai", 809 },
                    { 107, null, "Kido Takayoshi", 1458 },
                    { 108, null, "Kikkawa Hiroie", 293 },
                    { 109, null, "Kimotsuki Kanetsugu", 1430 },
                    { 110, null, "Kitamura Kansuke", 1235 },
                    { 111, null, "Kobayakawa Hideaki", 1608 },
                    { 112, null, "Kobayakawa Hidekane", 1501 },
                    { 113, null, "Kobayakawa Takakage", 526 },
                    { 114, null, "Konishi Yukinaga", 222 },
                    { 115, null, "Kojima Toyoharu", 1049 },
                    { 116, null, "Kuroda Kanbei", 1968 },
                    { 117, null, "Kuroda Kiyotaka", 1773 },
                    { 118, null, "Kusunoki Masashige", 1152 },
                    { 119, null, "Kuwana Tarozaemon", 1511 },
                    { 120, null, "Kumagai Naozane", 453 },
                    { 121, null, "Maeda Keiji", 1828 },
                    { 122, null, "Maeda Matsu", 1220 },
                    { 123, null, "Maeda Nagatane", 1327 },
                    { 124, null, "Maeda Toshiie", 797 },
                    { 125, null, "Maeda Toshinaga", 485 },
                    { 126, null, "Maeda Toshitsune", 1509 },
                    { 127, null, "Magome Kageyu", 874 },
                    { 128, null, "Manabe Akifusa", 1023 },
                    { 129, null, "Matsudaira Katamori", 1477 },
                    { 130, null, "Matsudaira Nobutsuna", 1937 },
                    { 131, null, "Matsudaira Nobuyasu", 1493 },
                    { 132, null, "Matsudaira Higo no Kami Katamori", 608 },
                    { 133, null, "Matsudaira Sadanobu", 782 },
                    { 134, null, "Matsudaira Tadayoshi", 1667 },
                    { 135, null, "Matsudaira Teru", 1584 },
                    { 136, null, "Matsunaga Hisahide", 795 },
                    { 137, null, "Matsunaga Hisamichi", 1287 },
                    { 138, null, "Matsuo Bashō", 1532 },
                    { 139, null, "Matsudaira Motoyasu", 816 },
                    { 140, null, "Minamoto no Mitsunaka", 98 },
                    { 141, null, "Minamoto no Yoshiie", 672 },
                    { 142, null, "Minamoto no Yoshimitsu", 560 },
                    { 143, null, "Minamoto no Yoshinaka", 1650 },
                    { 144, null, "Minamoto no Yoshitomo", 934 },
                    { 145, null, "Minamoto no Yoshitsune", 266 },
                    { 146, null, "Minamoto no Tameyoshi", 1029 },
                    { 147, null, "Minamoto no Yorimasa", 1564 },
                    { 148, null, "Minamoto no Yorimitsu", 1747 },
                    { 149, null, "Minamoto no Yoritomo", 1975 },
                    { 150, null, "Minamoto no Noriyori", 1339 },
                    { 151, null, "Minoro Takashi", 237 },
                    { 152, null, "Miura Anjin", 1420 },
                    { 153, null, "Miura Yoshimoto", 1566 },
                    { 154, null, "Miyamoto Musashi", 85 },
                    { 155, null, "Miyoshi Chōkei", 1971 },
                    { 156, null, "Miyoshi Kazuhide", 963 },
                    { 157, null, "Miyoshi Masaga", 1031 },
                    { 158, null, "Miyoshi Masayasu", 1285 },
                    { 159, null, "Miyoshi Moriyata", 1858 },
                    { 160, null, "Miyoshi Nagayuki", 1344 },
                    { 161, null, "Miyoshi Yoshitsugu", 1046 },
                    { 162, null, "Mizuno Tadakuni", 1756 },
                    { 163, null, "Moniwa Yoshinao", 202 },
                    { 164, null, "Mōri Motonari", 1986 },
                    { 165, null, "Mōri Nagasada", 150 },
                    { 166, null, "Mori Nagayoshi", 1838 },
                    { 167, null, "Mōri Okimoto", 1032 },
                    { 168, null, "Mori Ranmaru", 948 },
                    { 169, null, "Mōri Takamoto", 1908 },
                    { 170, null, "Mori Tadamasa", 1707 },
                    { 171, null, "Mōri Terumoto", 1291 },
                    { 172, null, "Mori Yoshinari", 1946 },
                    { 173, null, "Murai Sadakatsu", 1975 },
                    { 174, null, "Nagakura Shinpachi", 1599 },
                    { 175, null, "Nagao Harukage", 619 },
                    { 176, null, "Nagao Kagenobu", 1894 },
                    { 177, null, "Nagao Masakage", 1877 },
                    { 178, null, "Nagao Tamekage", 1806 },
                    { 179, null, "Nakagawa Kiyohide", 999 },
                    { 180, null, "Nakaoka Shintarō", 47 },
                    { 181, null, "Naoe Kagetsuna", 870 },
                    { 182, null, "Naoe Kanetsugu", 1976 },
                    { 183, null, "Narita Kaihime", 1756 },
                    { 184, null, "Nene", 1444 },
                    { 185, null, "Nihonmatsu Yoshitsugu", 395 },
                    { 186, null, "Niimi Nishiki", 755 },
                    { 187, null, "Niiro Tadamoto", 1257 },
                    { 188, null, "Niwa Nagahide", 1792 },
                    { 189, null, "Niwa Nagashige", 726 },
                    { 190, null, "Oda Hiroyoshi", 133 },
                    { 191, null, "Oda Nobuhide", 1970 },
                    { 192, null, "Oda Nobukata", 1637 },
                    { 193, null, "Oda Nobukiyo", 1543 },
                    { 194, null, "Oda Nobunaga", 1281 },
                    { 195, null, "Oda Nobutada", 1131 },
                    { 196, null, "Oda Nobutomo", 971 },
                    { 197, null, "Oda Nobukatsu", 1481 },
                    { 198, null, "Oda Nobuyasu", 1075 },
                    { 199, null, "Ogasawara Shōsai", 597 },
                    { 200, null, "Ōishi Kuranosuke", 641 },
                    { 201, null, "Okada Izō", 741 },
                    { 202, null, "Judge Ooka", 1434 },
                    { 203, null, "Ōta Dōkan", 915 },
                    { 204, null, "Ōtani Yoshitsugu", 1264 },
                    { 205, null, "Ōtani Yoshiharu", 8 },
                    { 206, null, "Ōtomo Sōrin", 1796 },
                    { 207, null, "Okita Sōji", 1903 },
                    { 208, null, "Ōkubo Toshimichi", 1889 },
                    { 209, null, "Okunomiya Masaie", 854 },
                    { 210, null, "Ōuchi Yoshitaka", 1898 },
                    { 211, null, "Omy Yoshika", 954 },
                    { 212, null, "Pore Sufi", 1500 },
                    { 213, null, "Reizei Takatoyo", 1332 },
                    { 214, null, "Rokkaku Sadayori", 615 },
                    { 215, null, "Rokkaku Yoshiharu", 1956 },
                    { 216, null, "Rokkaku Yoshikata", 51 },
                    { 217, null, "Rusu Masakage", 604 },
                    { 218, null, "Ryūzōji Takanobu", 1737 },
                    { 219, null, "Saigo Kiyokazu", 1621 },
                    { 220, null, "Saigō Masako", 701 },
                    { 221, null, "Sagara Taketō", 1785 },
                    { 222, null, "Saigō Takamori", 1964 },
                    { 223, null, "Saigo Yoshikatsu", 883 },
                    { 224, null, "Saitō Dōsan", 53 },
                    { 225, null, "Saitō Hajime", 545 },
                    { 226, null, "Saito Musashibō Benkei", 227 },
                    { 227, null, "Saitō Yoshitatsu", 239 },
                    { 228, null, "Sakai Tadakiyo", 1941 },
                    { 229, null, "Sakai Tadashige", 383 },
                    { 230, null, "Sakai Tadatsugu", 1431 },
                    { 231, null, "Sakai Tadayo", 716 },
                    { 232, null, "Sakakibara Yasumasa", 996 },
                    { 233, null, "Sakamoto Ryōma", 665 },
                    { 234, null, "Sakuma Morimasa", 610 },
                    { 235, null, "Sakuma Nobumori", 288 },
                    { 236, null, "Sanada Akihime", 1516 },
                    { 237, null, "Sanada Komatsuhime", 1063 },
                    { 238, null, "Sanada Masayuki", 48 },
                    { 239, null, "Sanada Nobuyuki", 434 },
                    { 240, null, "Sanada Yukimura", 1063 },
                    { 241, null, "Sasaki Kojirō", 1985 },
                    { 242, null, "Sassa Narimasa", 494 },
                    { 243, null, "Sasuke Sarutobi", 1981 },
                    { 244, null, "Serizawa Kamo", 1636 },
                    { 245, null, "Shibata Katsuie", 1445 },
                    { 246, null, "Shima Sakon", 1390 },
                    { 247, null, "Shimada Ichirō", 947 },
                    { 248, null, "Shimazu Katsuhisa", 1526 },
                    { 249, null, "Shimazu Tadahisa", 1245 },
                    { 250, null, "Shimazu Tadatsune", 1664 },
                    { 251, null, "Shimazu Tadayoshi", 583 },
                    { 252, null, "Shimazu Takahisa", 1196 },
                    { 253, null, "Shimazu Toyohisa", 305 },
                    { 254, null, "Shimazu Yoshihiro", 359 },
                    { 255, null, "Shimazu Yoshihisa", 520 },
                    { 256, null, "Shindou Hiroshii", 211 },
                    { 257, null, "Sogo Nagayasu", 6 },
                    { 258, null, "Sue Yoshitaka", 1439 },
                    { 259, null, "Tachibana Muneshige", 654 },
                    { 260, null, "Tachibana Dōsetsu", 296 },
                    { 261, null, "Tachibana Ginchiyo", 341 },
                    { 262, null, "Taigen Sessai", 765 },
                    { 263, null, "Taira no Kiyomori", 1459 },
                    { 264, null, "Taira Masakado", 566 },
                    { 265, null, "Takahashi Shigetane", 1228 },
                    { 266, null, "Takenaka Shigeharu", 1141 },
                    { 267, null, "Takasugi Shinsaku", 1629 },
                    { 268, null, "Takayama Justo", 1632 },
                    { 269, null, "Takayama Ukon", 899 },
                    { 270, null, "Takechi Hanpeita", 1290 },
                    { 271, null, "Takeda Katsuyori", 573 },
                    { 272, null, "Takeda Nobukatsu", 293 },
                    { 273, null, "Takeda Nobushige", 245 },
                    { 274, null, "Takeda Shingen", 1305 },
                    { 275, null, "Takenaka Hanbei", 311 },
                    { 276, null, "Tani Tadasumi", 655 },
                    { 277, null, "Tōdō Takatora", 303 },
                    { 278, null, "Toki Yorinari", 1938 },
                    { 279, null, "Tochimitsu Gantyoki", 316 },
                    { 280, null, "Tokugawa Ieyasu", 1085 },
                    { 281, null, "Tokugawa Hidetada", 946 },
                    { 282, null, "Tokugawa Nariaki", 1925 },
                    { 283, null, "Tokugawa Yoshinobu", 263 },
                    { 284, null, "Torii Mototada", 586 },
                    { 285, null, "Toyotomi Hidenaga", 577 },
                    { 286, null, "Toyotomi Hideyoshi", 389 },
                    { 287, null, "Toyotomi Hideyori", 1221 },
                    { 288, null, "Tozuka Tadaharu", 473 },
                    { 289, null, "Tsukahara Bokuden", 1025 },
                    { 290, null, "Uesugi Kagekatsu", 517 },
                    { 291, null, "Uesugi Kagetora", 1078 },
                    { 292, null, "Uesugi Kenshin", 350 },
                    { 293, null, "Ujiie Naotomo", 707 },
                    { 294, null, "Ukita Naoie", 523 },
                    { 295, null, "Ukita Okiie", 1499 },
                    { 296, null, "Umezawa Michiharu", 1143 },
                    { 297, null, "Usami Sadamitsu", 1231 },
                    { 298, null, "Uyama Hisanobu", 843 },
                    { 299, null, "Wada Shinsuke", 171 },
                    { 300, null, "Watanabe Kazan", 1041 },
                    { 301, null, "Watanabe no Tsuna", 1422 },
                    { 302, null, "Yasumero Kenshin", 381 },
                    { 303, null, "Yagyū Jūbei Mitsuyoshi", 1696 },
                    { 304, null, "Yagyū Munenori", 1147 },
                    { 305, null, "Yamauchi Kazutoyo", 817 },
                    { 306, null, "Yamada Arinaga", 1230 },
                    { 307, null, "Yamada Arinobu", 1020 },
                    { 308, null, "Yamada Nagamasa", 1317 },
                    { 309, null, "Yamagata Masakage", 464 },
                    { 310, null, "Yamakawa Hiroshi", 498 },
                    { 311, null, "Yamakawa Kenjirō", 17 },
                    { 312, null, "Yamakawa Naoe", 1697 },
                    { 313, null, "Yamanaka Yukimori", 1505 },
                    { 314, null, "Yamanami Keisuke", 961 },
                    { 315, null, "Yamaoka Tesshū", 1160 },
                    { 316, null, "Yanagawa Kenzaburo", 146 },
                    { 317, null, "Yanagisawa Yoshiyasu", 635 },
                    { 318, null, "Yonekura Shigetsugu", 976 },
                    { 319, null, "Yūki Hideyasu", 1815 },
                    { 320, null, "Yasuke", 1484 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samourai_ArmeId",
                table: "Samourai",
                column: "ArmeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Samourai");

            migrationBuilder.DropTable(
                name: "Arme");
        }
    }
}
