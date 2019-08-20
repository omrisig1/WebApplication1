using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class add_URIImage_to_Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URIImage",
                table: "Product",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18d9326b-3b1d-44bb-a560-eeb879d3191b", "AQAAAAEAACcQAAAAEAFlmw94zHVuAW63BHMaRwAy8pJdrtBSeS94ZgF7/E0e7voHTk5kKNmwTGBQD2Q2VQ==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 1549712596.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 684753773.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 1077629489.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 174400145.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 1024887937.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 221009177.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 931852061.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 1193126739.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 1846626418.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 572429913.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 1459220450.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 1655379182.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 113314333.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 190371762.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 1028685382.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 1393010486.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 710089779.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 1030310420.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 55670932.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 765619929.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 12216909.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 864334878.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 148533003.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 921628002.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 1273142019.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 810655538.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 1029484354.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 398435956.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 332392318.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 2109015192.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 1322008848.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 1949515100.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 117319515.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 2065418840.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 1188069897.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 2003209413.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 1934064870.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 1723904860.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 83550661.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 1602852314.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 147086149.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 170988769.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 629266360.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 2145063353.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 235172980.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 231638531.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 479969779.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 220254647.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 963665362.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 170158756.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1050,
                column: "ProductPrice",
                value: 88283330.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1051,
                column: "ProductPrice",
                value: 1447187585.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1052,
                column: "ProductPrice",
                value: 552494001.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1053,
                column: "ProductPrice",
                value: 359522347.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1054,
                column: "ProductPrice",
                value: 1838846029.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1055,
                column: "ProductPrice",
                value: 97489617.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1056,
                column: "ProductPrice",
                value: 2095816316.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1057,
                column: "ProductPrice",
                value: 1715597033.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1058,
                column: "ProductPrice",
                value: 460853672.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1059,
                column: "ProductPrice",
                value: 1773827945.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1060,
                column: "ProductPrice",
                value: 751120369.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1061,
                column: "ProductPrice",
                value: 2093011651.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1062,
                column: "ProductPrice",
                value: 272846320.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1063,
                column: "ProductPrice",
                value: 1297206772.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1064,
                column: "ProductPrice",
                value: 810016611.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1065,
                column: "ProductPrice",
                value: 1069300896.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1066,
                column: "ProductPrice",
                value: 950171566.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1067,
                column: "ProductPrice",
                value: 1754974686.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1068,
                column: "ProductPrice",
                value: 561897411.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1069,
                column: "ProductPrice",
                value: 585071515.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1070,
                column: "ProductPrice",
                value: 1018541162.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1071,
                column: "ProductPrice",
                value: 545780465.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1072,
                column: "ProductPrice",
                value: 358871658.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1073,
                column: "ProductPrice",
                value: 12414164.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1074,
                column: "ProductPrice",
                value: 30645679.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1075,
                column: "ProductPrice",
                value: 1400823686.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1076,
                column: "ProductPrice",
                value: 1794664064.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1077,
                column: "ProductPrice",
                value: 1710548843.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1078,
                column: "ProductPrice",
                value: 98566921.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1079,
                column: "ProductPrice",
                value: 453615387.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1080,
                column: "ProductPrice",
                value: 1890281305.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1081,
                column: "ProductPrice",
                value: 221341606.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1082,
                column: "ProductPrice",
                value: 994366140.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1083,
                column: "ProductPrice",
                value: 1721829108.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1084,
                column: "ProductPrice",
                value: 1432843761.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1085,
                column: "ProductPrice",
                value: 1434416809.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1086,
                column: "ProductPrice",
                value: 809132998.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1087,
                column: "ProductPrice",
                value: 1317392714.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1088,
                column: "ProductPrice",
                value: 1786168357.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1089,
                column: "ProductPrice",
                value: 502692179.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1090,
                column: "ProductPrice",
                value: 1466988643.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1091,
                column: "ProductPrice",
                value: 1778063383.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1092,
                column: "ProductPrice",
                value: 675163087.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1093,
                column: "ProductPrice",
                value: 2016801909.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1094,
                column: "ProductPrice",
                value: 263843844.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1095,
                column: "ProductPrice",
                value: 1761153691.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1096,
                column: "ProductPrice",
                value: 1457737995.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1097,
                column: "ProductPrice",
                value: 891655134.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1098,
                column: "ProductPrice",
                value: 747158641.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1099,
                column: "ProductPrice",
                value: 725467630.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1100,
                column: "ProductPrice",
                value: 841062511.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1101,
                column: "ProductPrice",
                value: 284590639.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1102,
                column: "ProductPrice",
                value: 1217952782.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1103,
                column: "ProductPrice",
                value: 1938189393.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1104,
                column: "ProductPrice",
                value: 711213140.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1105,
                column: "ProductPrice",
                value: 1102098411.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1106,
                column: "ProductPrice",
                value: 500427826.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1107,
                column: "ProductPrice",
                value: 2099675383.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1108,
                column: "ProductPrice",
                value: 1888472214.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1109,
                column: "ProductPrice",
                value: 1997617889.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1110,
                column: "ProductPrice",
                value: 2009904746.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1111,
                column: "ProductPrice",
                value: 1944863019.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1112,
                column: "ProductPrice",
                value: 1029142011.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1113,
                column: "ProductPrice",
                value: 1566833831.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1114,
                column: "ProductPrice",
                value: 1443142186.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1115,
                column: "ProductPrice",
                value: 2089374309.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1116,
                column: "ProductPrice",
                value: 510757410.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1117,
                column: "ProductPrice",
                value: 110612758.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1118,
                column: "ProductPrice",
                value: 1423958557.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1119,
                column: "ProductPrice",
                value: 935195348.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1120,
                column: "ProductPrice",
                value: 1819763444.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1121,
                column: "ProductPrice",
                value: 1192374398.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1122,
                column: "ProductPrice",
                value: 1528401875.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1123,
                column: "ProductPrice",
                value: 1618800778.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1124,
                column: "ProductPrice",
                value: 677678418.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1125,
                column: "ProductPrice",
                value: 800073325.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1126,
                column: "ProductPrice",
                value: 1430212924.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1127,
                column: "ProductPrice",
                value: 2049148942.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1128,
                column: "ProductPrice",
                value: 1308165866.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1129,
                column: "ProductPrice",
                value: 1976571181.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1130,
                column: "ProductPrice",
                value: 1502681237.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1131,
                column: "ProductPrice",
                value: 315120829.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1132,
                column: "ProductPrice",
                value: 375502101.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1133,
                column: "ProductPrice",
                value: 932694837.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1134,
                column: "ProductPrice",
                value: 1172148422.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1135,
                column: "ProductPrice",
                value: 1017802565.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1136,
                column: "ProductPrice",
                value: 562984370.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1137,
                column: "ProductPrice",
                value: 615772293.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1138,
                column: "ProductPrice",
                value: 422727867.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1139,
                column: "ProductPrice",
                value: 1890340896.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1140,
                column: "ProductPrice",
                value: 346100882.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1141,
                column: "ProductPrice",
                value: 269053161.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1142,
                column: "ProductPrice",
                value: 988516046.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1143,
                column: "ProductPrice",
                value: 1348146014.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1144,
                column: "ProductPrice",
                value: 52382979.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1145,
                column: "ProductPrice",
                value: 1081721170.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1146,
                column: "ProductPrice",
                value: 161033271.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1147,
                column: "ProductPrice",
                value: 667924802.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1148,
                column: "ProductPrice",
                value: 2133255269.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1149,
                column: "ProductPrice",
                value: 1881548728.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1150,
                column: "ProductPrice",
                value: 662508180.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1151,
                column: "ProductPrice",
                value: 759237136.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1152,
                column: "ProductPrice",
                value: 1027292123.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1153,
                column: "ProductPrice",
                value: 1371558839.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1154,
                column: "ProductPrice",
                value: 465299732.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1155,
                column: "ProductPrice",
                value: 1208283659.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1156,
                column: "ProductPrice",
                value: 315784310.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1157,
                column: "ProductPrice",
                value: 1158747550.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1158,
                column: "ProductPrice",
                value: 672622874.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1159,
                column: "ProductPrice",
                value: 1470735361.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1160,
                column: "ProductPrice",
                value: 1231481033.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1161,
                column: "ProductPrice",
                value: 10874430.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1162,
                column: "ProductPrice",
                value: 203621416.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1163,
                column: "ProductPrice",
                value: 1471496579.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1164,
                column: "ProductPrice",
                value: 2054532198.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1165,
                column: "ProductPrice",
                value: 1106895816.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1166,
                column: "ProductPrice",
                value: 981472817.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1167,
                column: "ProductPrice",
                value: 1656042720.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1168,
                column: "ProductPrice",
                value: 1954280955.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1169,
                column: "ProductPrice",
                value: 1984935167.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1170,
                column: "ProductPrice",
                value: 938501838.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1171,
                column: "ProductPrice",
                value: 1454580663.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1172,
                column: "ProductPrice",
                value: 1247480437.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1173,
                column: "ProductPrice",
                value: 1093213207.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1174,
                column: "ProductPrice",
                value: 1206365.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1175,
                column: "ProductPrice",
                value: 962822182.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1176,
                column: "ProductPrice",
                value: 1763453898.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1177,
                column: "ProductPrice",
                value: 1739851407.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1178,
                column: "ProductPrice",
                value: 978529698.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1179,
                column: "ProductPrice",
                value: 1155552794.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1180,
                column: "ProductPrice",
                value: 51151953.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1181,
                column: "ProductPrice",
                value: 174400021.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1182,
                column: "ProductPrice",
                value: 1475489219.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1183,
                column: "ProductPrice",
                value: 986212684.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1184,
                column: "ProductPrice",
                value: 726174900.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1185,
                column: "ProductPrice",
                value: 155556000.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1186,
                column: "ProductPrice",
                value: 847424252.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1187,
                column: "ProductPrice",
                value: 563538808.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1188,
                column: "ProductPrice",
                value: 2026990651.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1189,
                column: "ProductPrice",
                value: 1523460309.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1190,
                column: "ProductPrice",
                value: 114130154.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1191,
                column: "ProductPrice",
                value: 963832366.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1192,
                column: "ProductPrice",
                value: 1502744965.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1193,
                column: "ProductPrice",
                value: 511588052.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1194,
                column: "ProductPrice",
                value: 70971762.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1195,
                column: "ProductPrice",
                value: 1894821998.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1196,
                column: "ProductPrice",
                value: 1625027291.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1197,
                column: "ProductPrice",
                value: 1076615013.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1198,
                column: "ProductPrice",
                value: 853209362.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1199,
                column: "ProductPrice",
                value: 505082709.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1200,
                column: "ProductPrice",
                value: 1659843899.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1201,
                column: "ProductPrice",
                value: 64586097.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1202,
                column: "ProductPrice",
                value: 273239393.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1203,
                column: "ProductPrice",
                value: 1707915648.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1204,
                column: "ProductPrice",
                value: 355158789.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1205,
                column: "ProductPrice",
                value: 767523063.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1206,
                column: "ProductPrice",
                value: 1071352245.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1207,
                column: "ProductPrice",
                value: 1493674462.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1208,
                column: "ProductPrice",
                value: 782464373.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1209,
                column: "ProductPrice",
                value: 1062073096.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1210,
                column: "ProductPrice",
                value: 1004425307.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1211,
                column: "ProductPrice",
                value: 135528449.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1212,
                column: "ProductPrice",
                value: 1739813398.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1213,
                column: "ProductPrice",
                value: 1076665626.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1214,
                column: "ProductPrice",
                value: 831695307.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1215,
                column: "ProductPrice",
                value: 469192911.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1216,
                column: "ProductPrice",
                value: 94980757.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1217,
                column: "ProductPrice",
                value: 777004278.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1218,
                column: "ProductPrice",
                value: 157433578.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1219,
                column: "ProductPrice",
                value: 1311088097.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1220,
                column: "ProductPrice",
                value: 1819067110.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1221,
                column: "ProductPrice",
                value: 1977529555.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1222,
                column: "ProductPrice",
                value: 1188647615.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1223,
                column: "ProductPrice",
                value: 1990416192.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1224,
                column: "ProductPrice",
                value: 1282916912.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1225,
                column: "ProductPrice",
                value: 1534265018.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1226,
                column: "ProductPrice",
                value: 1511431244.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1227,
                column: "ProductPrice",
                value: 148004284.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1228,
                column: "ProductPrice",
                value: 434353344.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1229,
                column: "ProductPrice",
                value: 1813463560.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1230,
                column: "ProductPrice",
                value: 897390437.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1231,
                column: "ProductPrice",
                value: 98950784.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1232,
                column: "ProductPrice",
                value: 298753944.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1233,
                column: "ProductPrice",
                value: 2033042535.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1234,
                column: "ProductPrice",
                value: 1055304441.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1235,
                column: "ProductPrice",
                value: 1546161402.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1236,
                column: "ProductPrice",
                value: 1460756174.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1237,
                column: "ProductPrice",
                value: 1327169117.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1238,
                column: "ProductPrice",
                value: 43165794.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1239,
                column: "ProductPrice",
                value: 1518247383.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1240,
                column: "ProductPrice",
                value: 643799301.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1241,
                column: "ProductPrice",
                value: 913345336.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1242,
                column: "ProductPrice",
                value: 1340669981.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1243,
                column: "ProductPrice",
                value: 377029454.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1244,
                column: "ProductPrice",
                value: 2078630548.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1245,
                column: "ProductPrice",
                value: 1538197251.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1246,
                column: "ProductPrice",
                value: 783614514.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1247,
                column: "ProductPrice",
                value: 1985674885.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1248,
                column: "ProductPrice",
                value: 1239488291.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1249,
                column: "ProductPrice",
                value: 1161374397.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1250,
                column: "ProductPrice",
                value: 1211953140.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1251,
                column: "ProductPrice",
                value: 260134912.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1252,
                column: "ProductPrice",
                value: 331293334.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1253,
                column: "ProductPrice",
                value: 1101716811.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1254,
                column: "ProductPrice",
                value: 245611145.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1255,
                column: "ProductPrice",
                value: 1241909890.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1256,
                column: "ProductPrice",
                value: 435534028.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1257,
                column: "ProductPrice",
                value: 1989902394.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1258,
                column: "ProductPrice",
                value: 1984594282.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1259,
                column: "ProductPrice",
                value: 380489317.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1260,
                column: "ProductPrice",
                value: 815687365.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1261,
                column: "ProductPrice",
                value: 335459860.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1262,
                column: "ProductPrice",
                value: 471433017.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1263,
                column: "ProductPrice",
                value: 528596359.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1264,
                column: "ProductPrice",
                value: 1724278205.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1265,
                column: "ProductPrice",
                value: 317586422.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1266,
                column: "ProductPrice",
                value: 1396370051.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1267,
                column: "ProductPrice",
                value: 1266366409.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1268,
                column: "ProductPrice",
                value: 1580956731.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1269,
                column: "ProductPrice",
                value: 845129451.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1270,
                column: "ProductPrice",
                value: 568032283.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1271,
                column: "ProductPrice",
                value: 327407186.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1272,
                column: "ProductPrice",
                value: 145950383.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1273,
                column: "ProductPrice",
                value: 198781741.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1274,
                column: "ProductPrice",
                value: 79400695.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1275,
                column: "ProductPrice",
                value: 317833673.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1276,
                column: "ProductPrice",
                value: 48971473.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1277,
                column: "ProductPrice",
                value: 223730060.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1278,
                column: "ProductPrice",
                value: 1471381190.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1279,
                column: "ProductPrice",
                value: 1304315207.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1280,
                column: "ProductPrice",
                value: 162762403.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1281,
                column: "ProductPrice",
                value: 1085351905.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1282,
                column: "ProductPrice",
                value: 468111539.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1283,
                column: "ProductPrice",
                value: 832574493.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1284,
                column: "ProductPrice",
                value: 13622319.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1285,
                column: "ProductPrice",
                value: 49367424.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1286,
                column: "ProductPrice",
                value: 1327252996.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1287,
                column: "ProductPrice",
                value: 756632679.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1288,
                column: "ProductPrice",
                value: 1199543289.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1289,
                column: "ProductPrice",
                value: 1372990097.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1290,
                column: "ProductPrice",
                value: 522739273.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1291,
                column: "ProductPrice",
                value: 1030449326.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1292,
                column: "ProductPrice",
                value: 902170381.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1293,
                column: "ProductPrice",
                value: 1222272023.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1294,
                column: "ProductPrice",
                value: 114671917.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1295,
                column: "ProductPrice",
                value: 1867934987.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1296,
                column: "ProductPrice",
                value: 2001507865.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1297,
                column: "ProductPrice",
                value: 224185521.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1298,
                column: "ProductPrice",
                value: 212346795.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1299,
                column: "ProductPrice",
                value: 1173156025.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1300,
                column: "ProductPrice",
                value: 1701422746.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1301,
                column: "ProductPrice",
                value: 1076843651.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1302,
                column: "ProductPrice",
                value: 1964313700.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1303,
                column: "ProductPrice",
                value: 1953954386.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1304,
                column: "ProductPrice",
                value: 5454013.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1305,
                column: "ProductPrice",
                value: 296657853.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1306,
                column: "ProductPrice",
                value: 1673780075.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1307,
                column: "ProductPrice",
                value: 1692107139.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1308,
                column: "ProductPrice",
                value: 434428015.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1309,
                column: "ProductPrice",
                value: 1487373018.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1310,
                column: "ProductPrice",
                value: 605050316.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1311,
                column: "ProductPrice",
                value: 1771399514.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1312,
                column: "ProductPrice",
                value: 2078116750.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1313,
                column: "ProductPrice",
                value: 92390974.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1314,
                column: "ProductPrice",
                value: 1777322460.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1315,
                column: "ProductPrice",
                value: 1289931006.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1316,
                column: "ProductPrice",
                value: 1426943867.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1317,
                column: "ProductPrice",
                value: 1198454070.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1318,
                column: "ProductPrice",
                value: 2074569586.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1319,
                column: "ProductPrice",
                value: 1087022680.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1320,
                column: "ProductPrice",
                value: 549928972.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1321,
                column: "ProductPrice",
                value: 51849271.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1322,
                column: "ProductPrice",
                value: 1626418666.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1323,
                column: "ProductPrice",
                value: 1767562180.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1324,
                column: "ProductPrice",
                value: 1881985724.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1325,
                column: "ProductPrice",
                value: 1097178503.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1326,
                column: "ProductPrice",
                value: 984832351.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1327,
                column: "ProductPrice",
                value: 483273906.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1328,
                column: "ProductPrice",
                value: 1643705370.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1329,
                column: "ProductPrice",
                value: 1918544901.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1330,
                column: "ProductPrice",
                value: 2023405001.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1331,
                column: "ProductPrice",
                value: 1384381498.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1332,
                column: "ProductPrice",
                value: 1570978811.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1333,
                column: "ProductPrice",
                value: 1857820711.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1334,
                column: "ProductPrice",
                value: 1162488007.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1335,
                column: "ProductPrice",
                value: 645514298.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1336,
                column: "ProductPrice",
                value: 680633751.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1337,
                column: "ProductPrice",
                value: 73752699.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1338,
                column: "ProductPrice",
                value: 239232379.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1339,
                column: "ProductPrice",
                value: 1276560012.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1340,
                column: "ProductPrice",
                value: 2082666542.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1341,
                column: "ProductPrice",
                value: 1194741403.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1342,
                column: "ProductPrice",
                value: 1881800210.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1343,
                column: "ProductPrice",
                value: 1271765817.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1344,
                column: "ProductPrice",
                value: 180051680.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1345,
                column: "ProductPrice",
                value: 310935305.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1346,
                column: "ProductPrice",
                value: 511928122.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1347,
                column: "ProductPrice",
                value: 221891306.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1348,
                column: "ProductPrice",
                value: 1004545109.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1349,
                column: "ProductPrice",
                value: 384336457.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1350,
                column: "ProductPrice",
                value: 2000586666.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1351,
                column: "ProductPrice",
                value: 215165694.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1352,
                column: "ProductPrice",
                value: 1856695128.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1353,
                column: "ProductPrice",
                value: 684919661.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1354,
                column: "ProductPrice",
                value: 35338952.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1355,
                column: "ProductPrice",
                value: 1061685374.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1356,
                column: "ProductPrice",
                value: 1010020531.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1357,
                column: "ProductPrice",
                value: 1756347066.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1358,
                column: "ProductPrice",
                value: 1631564208.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1359,
                column: "ProductPrice",
                value: 467871056.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1360,
                column: "ProductPrice",
                value: 871421048.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1361,
                column: "ProductPrice",
                value: 602618068.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1362,
                column: "ProductPrice",
                value: 1607997315.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1363,
                column: "ProductPrice",
                value: 75478660.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1364,
                column: "ProductPrice",
                value: 1023563563.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1365,
                column: "ProductPrice",
                value: 780264364.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1366,
                column: "ProductPrice",
                value: 1760016249.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1367,
                column: "ProductPrice",
                value: 1779891585.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1368,
                column: "ProductPrice",
                value: 489498513.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1369,
                column: "ProductPrice",
                value: 543920061.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1370,
                column: "ProductPrice",
                value: 21409154.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1371,
                column: "ProductPrice",
                value: 765303067.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1372,
                column: "ProductPrice",
                value: 371333590.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1373,
                column: "ProductPrice",
                value: 210121473.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1374,
                column: "ProductPrice",
                value: 563951684.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1375,
                column: "ProductPrice",
                value: 914783115.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1376,
                column: "ProductPrice",
                value: 1877128254.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1377,
                column: "ProductPrice",
                value: 1914248395.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1378,
                column: "ProductPrice",
                value: 999622399.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1379,
                column: "ProductPrice",
                value: 983162318.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1380,
                column: "ProductPrice",
                value: 2144845927.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1381,
                column: "ProductPrice",
                value: 175052944.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1382,
                column: "ProductPrice",
                value: 1038324343.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1383,
                column: "ProductPrice",
                value: 671480812.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1384,
                column: "ProductPrice",
                value: 1477553781.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1385,
                column: "ProductPrice",
                value: 1220351206.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1386,
                column: "ProductPrice",
                value: 1087281916.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1387,
                column: "ProductPrice",
                value: 298171049.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1388,
                column: "ProductPrice",
                value: 1234593658.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1389,
                column: "ProductPrice",
                value: 1660398179.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1390,
                column: "ProductPrice",
                value: 1195089313.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1391,
                column: "ProductPrice",
                value: 483882231.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1392,
                column: "ProductPrice",
                value: 1784037.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1393,
                column: "ProductPrice",
                value: 1330956869.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1394,
                column: "ProductPrice",
                value: 1964734510.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1395,
                column: "ProductPrice",
                value: 892160373.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1396,
                column: "ProductPrice",
                value: 1146339634.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1397,
                column: "ProductPrice",
                value: 1218433449.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1398,
                column: "ProductPrice",
                value: 1807797800.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1399,
                column: "ProductPrice",
                value: 959382862.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1400,
                column: "ProductPrice",
                value: 110514602.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1401,
                column: "ProductPrice",
                value: 291632083.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1402,
                column: "ProductPrice",
                value: 1291988339.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1403,
                column: "ProductPrice",
                value: 2020220594.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1404,
                column: "ProductPrice",
                value: 1922522849.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1405,
                column: "ProductPrice",
                value: 647395498.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1406,
                column: "ProductPrice",
                value: 1403427650.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1407,
                column: "ProductPrice",
                value: 1058685554.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1408,
                column: "ProductPrice",
                value: 1680563523.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1409,
                column: "ProductPrice",
                value: 680151383.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1410,
                column: "ProductPrice",
                value: 744152666.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1411,
                column: "ProductPrice",
                value: 655367682.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1412,
                column: "ProductPrice",
                value: 168836566.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1413,
                column: "ProductPrice",
                value: 60513789.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1414,
                column: "ProductPrice",
                value: 2030104322.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1415,
                column: "ProductPrice",
                value: 108480003.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1416,
                column: "ProductPrice",
                value: 1123889271.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1417,
                column: "ProductPrice",
                value: 348628402.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1418,
                column: "ProductPrice",
                value: 157520425.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1419,
                column: "ProductPrice",
                value: 1362807903.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1420,
                column: "ProductPrice",
                value: 1252577994.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1421,
                column: "ProductPrice",
                value: 873957099.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1422,
                column: "ProductPrice",
                value: 2104893473.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1423,
                column: "ProductPrice",
                value: 388695880.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1424,
                column: "ProductPrice",
                value: 908426294.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1425,
                column: "ProductPrice",
                value: 1097122469.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1426,
                column: "ProductPrice",
                value: 175630929.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1427,
                column: "ProductPrice",
                value: 599972267.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1428,
                column: "ProductPrice",
                value: 1952466156.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1429,
                column: "ProductPrice",
                value: 1231386857.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1430,
                column: "ProductPrice",
                value: 1328039027.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1431,
                column: "ProductPrice",
                value: 70806704.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1432,
                column: "ProductPrice",
                value: 1666046141.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1433,
                column: "ProductPrice",
                value: 1599835083.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1434,
                column: "ProductPrice",
                value: 284759615.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1435,
                column: "ProductPrice",
                value: 1265325743.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1436,
                column: "ProductPrice",
                value: 442660151.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1437,
                column: "ProductPrice",
                value: 577699295.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1438,
                column: "ProductPrice",
                value: 308553509.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1439,
                column: "ProductPrice",
                value: 242270182.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1440,
                column: "ProductPrice",
                value: 1376519102.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1441,
                column: "ProductPrice",
                value: 1588191908.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1442,
                column: "ProductPrice",
                value: 177203072.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1443,
                column: "ProductPrice",
                value: 2114037821.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1444,
                column: "ProductPrice",
                value: 328357412.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1445,
                column: "ProductPrice",
                value: 2099317177.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1446,
                column: "ProductPrice",
                value: 1874641211.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1447,
                column: "ProductPrice",
                value: 1500865794.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1448,
                column: "ProductPrice",
                value: 860448093.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1449,
                column: "ProductPrice",
                value: 1268366406.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1450,
                column: "ProductPrice",
                value: 1327866648.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1451,
                column: "ProductPrice",
                value: 209823131.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1452,
                column: "ProductPrice",
                value: 473024923.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1453,
                column: "ProductPrice",
                value: 2004585443.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1454,
                column: "ProductPrice",
                value: 1266400414.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1455,
                column: "ProductPrice",
                value: 796153049.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1456,
                column: "ProductPrice",
                value: 1893817803.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1457,
                column: "ProductPrice",
                value: 315404358.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1458,
                column: "ProductPrice",
                value: 523906199.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1459,
                column: "ProductPrice",
                value: 237512279.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1460,
                column: "ProductPrice",
                value: 2031360115.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1461,
                column: "ProductPrice",
                value: 215567282.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1462,
                column: "ProductPrice",
                value: 665814944.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1463,
                column: "ProductPrice",
                value: 2008772212.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1464,
                column: "ProductPrice",
                value: 911707902.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1465,
                column: "ProductPrice",
                value: 85457861.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1466,
                column: "ProductPrice",
                value: 548917087.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1467,
                column: "ProductPrice",
                value: 128597029.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1468,
                column: "ProductPrice",
                value: 1335349720.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1469,
                column: "ProductPrice",
                value: 176890478.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1470,
                column: "ProductPrice",
                value: 1225415398.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1471,
                column: "ProductPrice",
                value: 2105785522.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1472,
                column: "ProductPrice",
                value: 1599670439.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1473,
                column: "ProductPrice",
                value: 1474845789.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1474,
                column: "ProductPrice",
                value: 1545884347.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1475,
                column: "ProductPrice",
                value: 1223981632.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1476,
                column: "ProductPrice",
                value: 108865926.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1477,
                column: "ProductPrice",
                value: 1550451198.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1478,
                column: "ProductPrice",
                value: 1619934014.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1479,
                column: "ProductPrice",
                value: 368704663.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1480,
                column: "ProductPrice",
                value: 782076804.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1481,
                column: "ProductPrice",
                value: 234360681.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1482,
                column: "ProductPrice",
                value: 1299119720.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1483,
                column: "ProductPrice",
                value: 96211649.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1484,
                column: "ProductPrice",
                value: 1463115755.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1485,
                column: "ProductPrice",
                value: 530327795.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1486,
                column: "ProductPrice",
                value: 1157377327.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1487,
                column: "ProductPrice",
                value: 1221056244.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1488,
                column: "ProductPrice",
                value: 1893030215.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1489,
                column: "ProductPrice",
                value: 1048202112.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1490,
                column: "ProductPrice",
                value: 931103486.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1491,
                column: "ProductPrice",
                value: 1686851339.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1492,
                column: "ProductPrice",
                value: 1613388642.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1493,
                column: "ProductPrice",
                value: 1630636776.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1494,
                column: "ProductPrice",
                value: 1917989260.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1495,
                column: "ProductPrice",
                value: 573063719.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1496,
                column: "ProductPrice",
                value: 334488863.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1497,
                column: "ProductPrice",
                value: 1875510053.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1498,
                column: "ProductPrice",
                value: 614441818.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1499,
                column: "ProductPrice",
                value: 1802495097.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URIImage",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f970278-b751-4a1e-b562-35c36c216871", "AQAAAAEAACcQAAAAEFbYySXKmhPgVUIile6qIjgoesKTO2b9rWVG3IyYvDo2+4BIfkD4UStmHyC9WvVEIQ==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000,
                column: "ProductPrice",
                value: 862589481.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001,
                column: "ProductPrice",
                value: 1075190373.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002,
                column: "ProductPrice",
                value: 1480467825.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003,
                column: "ProductPrice",
                value: 1419188789.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004,
                column: "ProductPrice",
                value: 1925516875.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005,
                column: "ProductPrice",
                value: 984704208.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006,
                column: "ProductPrice",
                value: 43540134.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007,
                column: "ProductPrice",
                value: 2090945206.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008,
                column: "ProductPrice",
                value: 1320544901.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009,
                column: "ProductPrice",
                value: 66829977.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010,
                column: "ProductPrice",
                value: 987540382.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011,
                column: "ProductPrice",
                value: 1802898947.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012,
                column: "ProductPrice",
                value: 1801454015.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013,
                column: "ProductPrice",
                value: 48790791.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014,
                column: "ProductPrice",
                value: 886712906.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015,
                column: "ProductPrice",
                value: 1712976471.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016,
                column: "ProductPrice",
                value: 1962090801.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017,
                column: "ProductPrice",
                value: 1245463788.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018,
                column: "ProductPrice",
                value: 142298888.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019,
                column: "ProductPrice",
                value: 3258730.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020,
                column: "ProductPrice",
                value: 1104566327.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021,
                column: "ProductPrice",
                value: 2026169245.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022,
                column: "ProductPrice",
                value: 1923847384.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023,
                column: "ProductPrice",
                value: 1526977742.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024,
                column: "ProductPrice",
                value: 2037432217.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025,
                column: "ProductPrice",
                value: 1829664410.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026,
                column: "ProductPrice",
                value: 349935108.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027,
                column: "ProductPrice",
                value: 336674162.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028,
                column: "ProductPrice",
                value: 497771985.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029,
                column: "ProductPrice",
                value: 1450257638.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030,
                column: "ProductPrice",
                value: 1016799053.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031,
                column: "ProductPrice",
                value: 392070824.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032,
                column: "ProductPrice",
                value: 2113201765.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033,
                column: "ProductPrice",
                value: 1968841899.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034,
                column: "ProductPrice",
                value: 904141339.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035,
                column: "ProductPrice",
                value: 1201388638.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036,
                column: "ProductPrice",
                value: 487103252.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037,
                column: "ProductPrice",
                value: 1918107666.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038,
                column: "ProductPrice",
                value: 269270205.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039,
                column: "ProductPrice",
                value: 1646244920.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040,
                column: "ProductPrice",
                value: 663598259.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041,
                column: "ProductPrice",
                value: 759471881.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042,
                column: "ProductPrice",
                value: 1442917637.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043,
                column: "ProductPrice",
                value: 1053464463.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044,
                column: "ProductPrice",
                value: 1995071626.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045,
                column: "ProductPrice",
                value: 920763959.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046,
                column: "ProductPrice",
                value: 226450269.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047,
                column: "ProductPrice",
                value: 418120555.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048,
                column: "ProductPrice",
                value: 1822556884.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049,
                column: "ProductPrice",
                value: 750588367.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1050,
                column: "ProductPrice",
                value: 1411894017.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1051,
                column: "ProductPrice",
                value: 1706923442.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1052,
                column: "ProductPrice",
                value: 36974561.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1053,
                column: "ProductPrice",
                value: 1941325758.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1054,
                column: "ProductPrice",
                value: 756358527.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1055,
                column: "ProductPrice",
                value: 396015782.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1056,
                column: "ProductPrice",
                value: 710938535.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1057,
                column: "ProductPrice",
                value: 1513085629.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1058,
                column: "ProductPrice",
                value: 941352118.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1059,
                column: "ProductPrice",
                value: 1655448011.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1060,
                column: "ProductPrice",
                value: 46880999.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1061,
                column: "ProductPrice",
                value: 1266461518.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1062,
                column: "ProductPrice",
                value: 1005285120.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1063,
                column: "ProductPrice",
                value: 1429882809.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1064,
                column: "ProductPrice",
                value: 609626470.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1065,
                column: "ProductPrice",
                value: 7581457.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1066,
                column: "ProductPrice",
                value: 1249292728.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1067,
                column: "ProductPrice",
                value: 1392207662.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1068,
                column: "ProductPrice",
                value: 704244998.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1069,
                column: "ProductPrice",
                value: 1244919814.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1070,
                column: "ProductPrice",
                value: 637985118.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1071,
                column: "ProductPrice",
                value: 1603578681.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1072,
                column: "ProductPrice",
                value: 388305482.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1073,
                column: "ProductPrice",
                value: 55649514.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1074,
                column: "ProductPrice",
                value: 899256017.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1075,
                column: "ProductPrice",
                value: 1904689992.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1076,
                column: "ProductPrice",
                value: 2142847154.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1077,
                column: "ProductPrice",
                value: 282494820.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1078,
                column: "ProductPrice",
                value: 1091501662.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1079,
                column: "ProductPrice",
                value: 528780157.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1080,
                column: "ProductPrice",
                value: 1015326040.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1081,
                column: "ProductPrice",
                value: 1491410099.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1082,
                column: "ProductPrice",
                value: 73712824.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1083,
                column: "ProductPrice",
                value: 1306779164.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1084,
                column: "ProductPrice",
                value: 1597959167.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1085,
                column: "ProductPrice",
                value: 869471157.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1086,
                column: "ProductPrice",
                value: 1914691809.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1087,
                column: "ProductPrice",
                value: 1731471553.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1088,
                column: "ProductPrice",
                value: 624595271.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1089,
                column: "ProductPrice",
                value: 2067721103.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1090,
                column: "ProductPrice",
                value: 2050045649.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1091,
                column: "ProductPrice",
                value: 533613169.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1092,
                column: "ProductPrice",
                value: 388867447.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1093,
                column: "ProductPrice",
                value: 173417740.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1094,
                column: "ProductPrice",
                value: 1011475820.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1095,
                column: "ProductPrice",
                value: 956732287.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1096,
                column: "ProductPrice",
                value: 1313782307.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1097,
                column: "ProductPrice",
                value: 1572630374.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1098,
                column: "ProductPrice",
                value: 2003433539.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1099,
                column: "ProductPrice",
                value: 1399602068.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1100,
                column: "ProductPrice",
                value: 1231066777.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1101,
                column: "ProductPrice",
                value: 393838153.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1102,
                column: "ProductPrice",
                value: 1273471103.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1103,
                column: "ProductPrice",
                value: 2137232616.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1104,
                column: "ProductPrice",
                value: 1672198795.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1105,
                column: "ProductPrice",
                value: 1367910882.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1106,
                column: "ProductPrice",
                value: 730729859.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1107,
                column: "ProductPrice",
                value: 1540920593.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1108,
                column: "ProductPrice",
                value: 454181640.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1109,
                column: "ProductPrice",
                value: 411264081.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1110,
                column: "ProductPrice",
                value: 1960247821.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1111,
                column: "ProductPrice",
                value: 1988039261.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1112,
                column: "ProductPrice",
                value: 1981179513.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1113,
                column: "ProductPrice",
                value: 1972167507.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1114,
                column: "ProductPrice",
                value: 52233870.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1115,
                column: "ProductPrice",
                value: 115066446.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1116,
                column: "ProductPrice",
                value: 604860593.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1117,
                column: "ProductPrice",
                value: 1258101502.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1118,
                column: "ProductPrice",
                value: 1391519188.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1119,
                column: "ProductPrice",
                value: 1299750859.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1120,
                column: "ProductPrice",
                value: 1799968841.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1121,
                column: "ProductPrice",
                value: 1077416721.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1122,
                column: "ProductPrice",
                value: 179724290.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1123,
                column: "ProductPrice",
                value: 196119441.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1124,
                column: "ProductPrice",
                value: 754469711.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1125,
                column: "ProductPrice",
                value: 1663967495.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1126,
                column: "ProductPrice",
                value: 626823133.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1127,
                column: "ProductPrice",
                value: 1774483288.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1128,
                column: "ProductPrice",
                value: 603769240.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1129,
                column: "ProductPrice",
                value: 1502119276.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1130,
                column: "ProductPrice",
                value: 3019584.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1131,
                column: "ProductPrice",
                value: 2129812326.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1132,
                column: "ProductPrice",
                value: 1986140474.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1133,
                column: "ProductPrice",
                value: 1251495140.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1134,
                column: "ProductPrice",
                value: 857308926.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1135,
                column: "ProductPrice",
                value: 33599786.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1136,
                column: "ProductPrice",
                value: 1777534542.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1137,
                column: "ProductPrice",
                value: 1643559401.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1138,
                column: "ProductPrice",
                value: 1194175915.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1139,
                column: "ProductPrice",
                value: 1789643831.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1140,
                column: "ProductPrice",
                value: 1698336844.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1141,
                column: "ProductPrice",
                value: 1933366762.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1142,
                column: "ProductPrice",
                value: 689401812.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1143,
                column: "ProductPrice",
                value: 1772926736.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1144,
                column: "ProductPrice",
                value: 1667068828.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1145,
                column: "ProductPrice",
                value: 1621601934.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1146,
                column: "ProductPrice",
                value: 112029202.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1147,
                column: "ProductPrice",
                value: 2123779133.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1148,
                column: "ProductPrice",
                value: 1680779416.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1149,
                column: "ProductPrice",
                value: 308521273.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1150,
                column: "ProductPrice",
                value: 1911467240.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1151,
                column: "ProductPrice",
                value: 1615276351.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1152,
                column: "ProductPrice",
                value: 1740706732.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1153,
                column: "ProductPrice",
                value: 115794579.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1154,
                column: "ProductPrice",
                value: 1159228773.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1155,
                column: "ProductPrice",
                value: 1713245602.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1156,
                column: "ProductPrice",
                value: 1773709409.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1157,
                column: "ProductPrice",
                value: 489463561.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1158,
                column: "ProductPrice",
                value: 794874804.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1159,
                column: "ProductPrice",
                value: 1567826846.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1160,
                column: "ProductPrice",
                value: 153199648.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1161,
                column: "ProductPrice",
                value: 515842117.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1162,
                column: "ProductPrice",
                value: 349263252.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1163,
                column: "ProductPrice",
                value: 511657910.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1164,
                column: "ProductPrice",
                value: 1967840043.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1165,
                column: "ProductPrice",
                value: 1390031041.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1166,
                column: "ProductPrice",
                value: 1561494333.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1167,
                column: "ProductPrice",
                value: 141796272.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1168,
                column: "ProductPrice",
                value: 526970480.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1169,
                column: "ProductPrice",
                value: 1578229630.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1170,
                column: "ProductPrice",
                value: 2044611097.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1171,
                column: "ProductPrice",
                value: 520896738.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1172,
                column: "ProductPrice",
                value: 1623521133.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1173,
                column: "ProductPrice",
                value: 1161470903.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1174,
                column: "ProductPrice",
                value: 1161009561.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1175,
                column: "ProductPrice",
                value: 1426197625.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1176,
                column: "ProductPrice",
                value: 1947610455.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1177,
                column: "ProductPrice",
                value: 2113876747.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1178,
                column: "ProductPrice",
                value: 88646159.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1179,
                column: "ProductPrice",
                value: 692463323.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1180,
                column: "ProductPrice",
                value: 964050192.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1181,
                column: "ProductPrice",
                value: 62639546.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1182,
                column: "ProductPrice",
                value: 1653299418.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1183,
                column: "ProductPrice",
                value: 1854843513.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1184,
                column: "ProductPrice",
                value: 1150247582.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1185,
                column: "ProductPrice",
                value: 2094822426.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1186,
                column: "ProductPrice",
                value: 1948701140.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1187,
                column: "ProductPrice",
                value: 1282457794.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1188,
                column: "ProductPrice",
                value: 1651861913.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1189,
                column: "ProductPrice",
                value: 703658870.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1190,
                column: "ProductPrice",
                value: 1966969570.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1191,
                column: "ProductPrice",
                value: 700182880.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1192,
                column: "ProductPrice",
                value: 260796496.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1193,
                column: "ProductPrice",
                value: 1185944615.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1194,
                column: "ProductPrice",
                value: 1048556082.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1195,
                column: "ProductPrice",
                value: 594606626.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1196,
                column: "ProductPrice",
                value: 996215409.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1197,
                column: "ProductPrice",
                value: 1737339448.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1198,
                column: "ProductPrice",
                value: 1364682239.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1199,
                column: "ProductPrice",
                value: 1836633333.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1200,
                column: "ProductPrice",
                value: 1619703147.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1201,
                column: "ProductPrice",
                value: 1529828476.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1202,
                column: "ProductPrice",
                value: 1008920552.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1203,
                column: "ProductPrice",
                value: 1662145332.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1204,
                column: "ProductPrice",
                value: 1970989369.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1205,
                column: "ProductPrice",
                value: 802682401.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1206,
                column: "ProductPrice",
                value: 1551350764.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1207,
                column: "ProductPrice",
                value: 2138831375.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1208,
                column: "ProductPrice",
                value: 514380564.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1209,
                column: "ProductPrice",
                value: 1292626694.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1210,
                column: "ProductPrice",
                value: 1325230693.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1211,
                column: "ProductPrice",
                value: 1219428208.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1212,
                column: "ProductPrice",
                value: 1960412948.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1213,
                column: "ProductPrice",
                value: 1662007027.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1214,
                column: "ProductPrice",
                value: 15888553.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1215,
                column: "ProductPrice",
                value: 1650155648.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1216,
                column: "ProductPrice",
                value: 422138245.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1217,
                column: "ProductPrice",
                value: 54015285.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1218,
                column: "ProductPrice",
                value: 921005874.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1219,
                column: "ProductPrice",
                value: 1432613163.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1220,
                column: "ProductPrice",
                value: 1000925447.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1221,
                column: "ProductPrice",
                value: 1838632085.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1222,
                column: "ProductPrice",
                value: 49529905.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1223,
                column: "ProductPrice",
                value: 1382907156.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1224,
                column: "ProductPrice",
                value: 1170855606.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1225,
                column: "ProductPrice",
                value: 756540116.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1226,
                column: "ProductPrice",
                value: 1819695788.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1227,
                column: "ProductPrice",
                value: 1997172064.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1228,
                column: "ProductPrice",
                value: 1672510367.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1229,
                column: "ProductPrice",
                value: 2125998481.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1230,
                column: "ProductPrice",
                value: 1989577762.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1231,
                column: "ProductPrice",
                value: 1769866553.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1232,
                column: "ProductPrice",
                value: 161306407.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1233,
                column: "ProductPrice",
                value: 1959092019.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1234,
                column: "ProductPrice",
                value: 632355722.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1235,
                column: "ProductPrice",
                value: 993817262.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1236,
                column: "ProductPrice",
                value: 613314540.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1237,
                column: "ProductPrice",
                value: 1550749632.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1238,
                column: "ProductPrice",
                value: 1443449690.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1239,
                column: "ProductPrice",
                value: 1907160727.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1240,
                column: "ProductPrice",
                value: 2103067208.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1241,
                column: "ProductPrice",
                value: 1369465311.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1242,
                column: "ProductPrice",
                value: 180189129.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1243,
                column: "ProductPrice",
                value: 1918830765.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1244,
                column: "ProductPrice",
                value: 938023723.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1245,
                column: "ProductPrice",
                value: 159653261.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1246,
                column: "ProductPrice",
                value: 299365478.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1247,
                column: "ProductPrice",
                value: 158385015.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1248,
                column: "ProductPrice",
                value: 582167961.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1249,
                column: "ProductPrice",
                value: 957995980.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1250,
                column: "ProductPrice",
                value: 1732063927.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1251,
                column: "ProductPrice",
                value: 354312023.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1252,
                column: "ProductPrice",
                value: 228445473.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1253,
                column: "ProductPrice",
                value: 1491664622.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1254,
                column: "ProductPrice",
                value: 247819785.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1255,
                column: "ProductPrice",
                value: 1340666608.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1256,
                column: "ProductPrice",
                value: 892410470.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1257,
                column: "ProductPrice",
                value: 1185608942.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1258,
                column: "ProductPrice",
                value: 2050885272.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1259,
                column: "ProductPrice",
                value: 626561152.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1260,
                column: "ProductPrice",
                value: 542582159.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1261,
                column: "ProductPrice",
                value: 1113774246.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1262,
                column: "ProductPrice",
                value: 2025916554.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1263,
                column: "ProductPrice",
                value: 2095461276.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1264,
                column: "ProductPrice",
                value: 862644478.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1265,
                column: "ProductPrice",
                value: 1114959686.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1266,
                column: "ProductPrice",
                value: 470233700.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1267,
                column: "ProductPrice",
                value: 1560916475.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1268,
                column: "ProductPrice",
                value: 441763204.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1269,
                column: "ProductPrice",
                value: 581666837.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1270,
                column: "ProductPrice",
                value: 448953007.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1271,
                column: "ProductPrice",
                value: 430984159.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1272,
                column: "ProductPrice",
                value: 170161141.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1273,
                column: "ProductPrice",
                value: 573440693.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1274,
                column: "ProductPrice",
                value: 889141501.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1275,
                column: "ProductPrice",
                value: 1191055682.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1276,
                column: "ProductPrice",
                value: 1070554855.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1277,
                column: "ProductPrice",
                value: 1837778333.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1278,
                column: "ProductPrice",
                value: 2004478979.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1279,
                column: "ProductPrice",
                value: 423314244.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1280,
                column: "ProductPrice",
                value: 2016770184.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1281,
                column: "ProductPrice",
                value: 1073422672.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1282,
                column: "ProductPrice",
                value: 827116002.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1283,
                column: "ProductPrice",
                value: 126626286.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1284,
                column: "ProductPrice",
                value: 1953530100.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1285,
                column: "ProductPrice",
                value: 1047377638.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1286,
                column: "ProductPrice",
                value: 953532979.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1287,
                column: "ProductPrice",
                value: 229237331.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1288,
                column: "ProductPrice",
                value: 1123384133.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1289,
                column: "ProductPrice",
                value: 851284660.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1290,
                column: "ProductPrice",
                value: 1661002338.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1291,
                column: "ProductPrice",
                value: 987301144.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1292,
                column: "ProductPrice",
                value: 1059459906.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1293,
                column: "ProductPrice",
                value: 229000437.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1294,
                column: "ProductPrice",
                value: 776690467.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1295,
                column: "ProductPrice",
                value: 401404861.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1296,
                column: "ProductPrice",
                value: 903144303.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1297,
                column: "ProductPrice",
                value: 1791807046.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1298,
                column: "ProductPrice",
                value: 468298186.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1299,
                column: "ProductPrice",
                value: 1382659583.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1300,
                column: "ProductPrice",
                value: 1249015107.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1301,
                column: "ProductPrice",
                value: 298044549.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1302,
                column: "ProductPrice",
                value: 1276217357.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1303,
                column: "ProductPrice",
                value: 1560096670.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1304,
                column: "ProductPrice",
                value: 2068638519.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1305,
                column: "ProductPrice",
                value: 713191667.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1306,
                column: "ProductPrice",
                value: 1743746428.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1307,
                column: "ProductPrice",
                value: 1214600326.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1308,
                column: "ProductPrice",
                value: 14635020.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1309,
                column: "ProductPrice",
                value: 616359649.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1310,
                column: "ProductPrice",
                value: 1829707299.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1311,
                column: "ProductPrice",
                value: 614227683.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1312,
                column: "ProductPrice",
                value: 740725509.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1313,
                column: "ProductPrice",
                value: 1039682927.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1314,
                column: "ProductPrice",
                value: 169386514.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1315,
                column: "ProductPrice",
                value: 1028755033.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1316,
                column: "ProductPrice",
                value: 1846253790.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1317,
                column: "ProductPrice",
                value: 1311402167.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1318,
                column: "ProductPrice",
                value: 1701526722.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1319,
                column: "ProductPrice",
                value: 1374862386.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1320,
                column: "ProductPrice",
                value: 1721022253.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1321,
                column: "ProductPrice",
                value: 1800591915.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1322,
                column: "ProductPrice",
                value: 1997127888.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1323,
                column: "ProductPrice",
                value: 1150074090.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1324,
                column: "ProductPrice",
                value: 480260045.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1325,
                column: "ProductPrice",
                value: 1021247409.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1326,
                column: "ProductPrice",
                value: 931119799.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1327,
                column: "ProductPrice",
                value: 1500756250.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1328,
                column: "ProductPrice",
                value: 1356345772.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1329,
                column: "ProductPrice",
                value: 2047332186.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1330,
                column: "ProductPrice",
                value: 1847506925.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1331,
                column: "ProductPrice",
                value: 838343355.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1332,
                column: "ProductPrice",
                value: 781592046.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1333,
                column: "ProductPrice",
                value: 33931295.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1334,
                column: "ProductPrice",
                value: 733894683.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1335,
                column: "ProductPrice",
                value: 1130837534.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1336,
                column: "ProductPrice",
                value: 1356800861.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1337,
                column: "ProductPrice",
                value: 826614878.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1338,
                column: "ProductPrice",
                value: 1765066960.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1339,
                column: "ProductPrice",
                value: 652450332.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1340,
                column: "ProductPrice",
                value: 863226756.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1341,
                column: "ProductPrice",
                value: 1298528199.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1342,
                column: "ProductPrice",
                value: 1774197857.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1343,
                column: "ProductPrice",
                value: 2066620030.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1344,
                column: "ProductPrice",
                value: 581172907.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1345,
                column: "ProductPrice",
                value: 458886554.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1346,
                column: "ProductPrice",
                value: 1806171181.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1347,
                column: "ProductPrice",
                value: 1579372525.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1348,
                column: "ProductPrice",
                value: 1619209469.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1349,
                column: "ProductPrice",
                value: 1307530980.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1350,
                column: "ProductPrice",
                value: 114746617.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1351,
                column: "ProductPrice",
                value: 1151337682.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1352,
                column: "ProductPrice",
                value: 1649875870.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1353,
                column: "ProductPrice",
                value: 653031346.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1354,
                column: "ProductPrice",
                value: 1221232876.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1355,
                column: "ProductPrice",
                value: 1008018738.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1356,
                column: "ProductPrice",
                value: 2007995854.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1357,
                column: "ProductPrice",
                value: 1685738813.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1358,
                column: "ProductPrice",
                value: 491948524.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1359,
                column: "ProductPrice",
                value: 459503009.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1360,
                column: "ProductPrice",
                value: 1341667414.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1361,
                column: "ProductPrice",
                value: 1802585724.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1362,
                column: "ProductPrice",
                value: 1417850100.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1363,
                column: "ProductPrice",
                value: 1674382027.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1364,
                column: "ProductPrice",
                value: 328448270.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1365,
                column: "ProductPrice",
                value: 403475843.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1366,
                column: "ProductPrice",
                value: 1392231183.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1367,
                column: "ProductPrice",
                value: 118906113.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1368,
                column: "ProductPrice",
                value: 1865383790.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1369,
                column: "ProductPrice",
                value: 598144526.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1370,
                column: "ProductPrice",
                value: 1231549718.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1371,
                column: "ProductPrice",
                value: 431750811.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1372,
                column: "ProductPrice",
                value: 1105930753.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1373,
                column: "ProductPrice",
                value: 461188289.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1374,
                column: "ProductPrice",
                value: 2071231176.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1375,
                column: "ProductPrice",
                value: 1982089600.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1376,
                column: "ProductPrice",
                value: 1585989604.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1377,
                column: "ProductPrice",
                value: 1490103404.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1378,
                column: "ProductPrice",
                value: 2128496729.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1379,
                column: "ProductPrice",
                value: 1580969037.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1380,
                column: "ProductPrice",
                value: 774671774.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1381,
                column: "ProductPrice",
                value: 911342820.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1382,
                column: "ProductPrice",
                value: 1441142327.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1383,
                column: "ProductPrice",
                value: 1608410338.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1384,
                column: "ProductPrice",
                value: 1344697468.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1385,
                column: "ProductPrice",
                value: 108281142.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1386,
                column: "ProductPrice",
                value: 748063031.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1387,
                column: "ProductPrice",
                value: 1688156246.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1388,
                column: "ProductPrice",
                value: 372293965.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1389,
                column: "ProductPrice",
                value: 1285471491.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1390,
                column: "ProductPrice",
                value: 682437226.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1391,
                column: "ProductPrice",
                value: 1230657594.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1392,
                column: "ProductPrice",
                value: 1894261900.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1393,
                column: "ProductPrice",
                value: 717675850.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1394,
                column: "ProductPrice",
                value: 870378464.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1395,
                column: "ProductPrice",
                value: 620236578.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1396,
                column: "ProductPrice",
                value: 1440273645.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1397,
                column: "ProductPrice",
                value: 1659411376.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1398,
                column: "ProductPrice",
                value: 1150283659.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1399,
                column: "ProductPrice",
                value: 1737292610.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1400,
                column: "ProductPrice",
                value: 626250917.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1401,
                column: "ProductPrice",
                value: 1099376967.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1402,
                column: "ProductPrice",
                value: 1273584281.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1403,
                column: "ProductPrice",
                value: 433176842.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1404,
                column: "ProductPrice",
                value: 1635576808.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1405,
                column: "ProductPrice",
                value: 1242591352.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1406,
                column: "ProductPrice",
                value: 1605002475.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1407,
                column: "ProductPrice",
                value: 600799480.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1408,
                column: "ProductPrice",
                value: 141395716.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1409,
                column: "ProductPrice",
                value: 798738822.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1410,
                column: "ProductPrice",
                value: 981624680.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1411,
                column: "ProductPrice",
                value: 2077487996.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1412,
                column: "ProductPrice",
                value: 1116837630.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1413,
                column: "ProductPrice",
                value: 470575033.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1414,
                column: "ProductPrice",
                value: 1244426781.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1415,
                column: "ProductPrice",
                value: 1989920140.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1416,
                column: "ProductPrice",
                value: 1921038943.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1417,
                column: "ProductPrice",
                value: 1369035308.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1418,
                column: "ProductPrice",
                value: 1889280105.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1419,
                column: "ProductPrice",
                value: 1779762674.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1420,
                column: "ProductPrice",
                value: 1215008358.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1421,
                column: "ProductPrice",
                value: 1263670483.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1422,
                column: "ProductPrice",
                value: 1306207694.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1423,
                column: "ProductPrice",
                value: 2139507845.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1424,
                column: "ProductPrice",
                value: 1475302846.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1425,
                column: "ProductPrice",
                value: 1560487670.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1426,
                column: "ProductPrice",
                value: 97084457.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1427,
                column: "ProductPrice",
                value: 1947850449.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1428,
                column: "ProductPrice",
                value: 1150405371.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1429,
                column: "ProductPrice",
                value: 863106497.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1430,
                column: "ProductPrice",
                value: 2101411501.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1431,
                column: "ProductPrice",
                value: 1486173774.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1432,
                column: "ProductPrice",
                value: 1899415291.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1433,
                column: "ProductPrice",
                value: 1950799665.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1434,
                column: "ProductPrice",
                value: 366830019.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1435,
                column: "ProductPrice",
                value: 1234890353.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1436,
                column: "ProductPrice",
                value: 1197354085.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1437,
                column: "ProductPrice",
                value: 420077384.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1438,
                column: "ProductPrice",
                value: 1532429076.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1439,
                column: "ProductPrice",
                value: 1661701662.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1440,
                column: "ProductPrice",
                value: 62874213.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1441,
                column: "ProductPrice",
                value: 1706859097.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1442,
                column: "ProductPrice",
                value: 958872429.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1443,
                column: "ProductPrice",
                value: 1133150689.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1444,
                column: "ProductPrice",
                value: 1863442357.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1445,
                column: "ProductPrice",
                value: 164544776.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1446,
                column: "ProductPrice",
                value: 1673415510.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1447,
                column: "ProductPrice",
                value: 835798766.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1448,
                column: "ProductPrice",
                value: 1032844615.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1449,
                column: "ProductPrice",
                value: 440053870.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1450,
                column: "ProductPrice",
                value: 258793181.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1451,
                column: "ProductPrice",
                value: 1630833883.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1452,
                column: "ProductPrice",
                value: 1329726817.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1453,
                column: "ProductPrice",
                value: 930116531.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1454,
                column: "ProductPrice",
                value: 2081879798.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1455,
                column: "ProductPrice",
                value: 922175980.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1456,
                column: "ProductPrice",
                value: 1352764819.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1457,
                column: "ProductPrice",
                value: 693671982.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1458,
                column: "ProductPrice",
                value: 517469542.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1459,
                column: "ProductPrice",
                value: 1634684684.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1460,
                column: "ProductPrice",
                value: 557618794.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1461,
                column: "ProductPrice",
                value: 1216747572.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1462,
                column: "ProductPrice",
                value: 1009989655.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1463,
                column: "ProductPrice",
                value: 837884765.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1464,
                column: "ProductPrice",
                value: 256922867.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1465,
                column: "ProductPrice",
                value: 1055046452.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1466,
                column: "ProductPrice",
                value: 1737668251.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1467,
                column: "ProductPrice",
                value: 725633511.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1468,
                column: "ProductPrice",
                value: 1663340560.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1469,
                column: "ProductPrice",
                value: 1569131974.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1470,
                column: "ProductPrice",
                value: 204677954.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1471,
                column: "ProductPrice",
                value: 913073458.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1472,
                column: "ProductPrice",
                value: 1396201778.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1473,
                column: "ProductPrice",
                value: 1787173989.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1474,
                column: "ProductPrice",
                value: 1129000360.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1475,
                column: "ProductPrice",
                value: 1067744807.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1476,
                column: "ProductPrice",
                value: 1864393600.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1477,
                column: "ProductPrice",
                value: 1732652551.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1478,
                column: "ProductPrice",
                value: 1835661034.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1479,
                column: "ProductPrice",
                value: 722869969.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1480,
                column: "ProductPrice",
                value: 1446667706.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1481,
                column: "ProductPrice",
                value: 820881237.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1482,
                column: "ProductPrice",
                value: 327117733.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1483,
                column: "ProductPrice",
                value: 122463400.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1484,
                column: "ProductPrice",
                value: 16425215.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1485,
                column: "ProductPrice",
                value: 2030173164.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1486,
                column: "ProductPrice",
                value: 1716042503.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1487,
                column: "ProductPrice",
                value: 381410659.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1488,
                column: "ProductPrice",
                value: 1428515413.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1489,
                column: "ProductPrice",
                value: 1004249585.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1490,
                column: "ProductPrice",
                value: 1441721080.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1491,
                column: "ProductPrice",
                value: 2063277649.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1492,
                column: "ProductPrice",
                value: 1462203388.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1493,
                column: "ProductPrice",
                value: 1457339938.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1494,
                column: "ProductPrice",
                value: 516194767.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1495,
                column: "ProductPrice",
                value: 405722187.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1496,
                column: "ProductPrice",
                value: 108981341.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1497,
                column: "ProductPrice",
                value: 1680583210.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1498,
                column: "ProductPrice",
                value: 288339721.0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1499,
                column: "ProductPrice",
                value: 220507804.0);
        }
    }
}
