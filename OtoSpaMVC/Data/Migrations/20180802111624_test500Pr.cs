using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoSpaMVC.Data.Migrations
{
    public partial class test500Pr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 222);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f970278-b751-4a1e-b562-35c36c216871", "AQAAAAEAACcQAAAAEFbYySXKmhPgVUIile6qIjgoesKTO2b9rWVG3IyYvDo2+4BIfkD4UStmHyC9WvVEIQ==" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1340, "Prod_340", 863226756.0 },
                    { 1339, "Prod_339", 652450332.0 },
                    { 1338, "Prod_338", 1765066960.0 },
                    { 1337, "Prod_337", 826614878.0 },
                    { 1336, "Prod_336", 1356800861.0 },
                    { 1335, "Prod_335", 1130837534.0 },
                    { 1334, "Prod_334", 733894683.0 },
                    { 1333, "Prod_333", 33931295.0 },
                    { 1332, "Prod_332", 781592046.0 },
                    { 1331, "Prod_331", 838343355.0 },
                    { 1330, "Prod_330", 1847506925.0 },
                    { 1329, "Prod_329", 2047332186.0 },
                    { 1328, "Prod_328", 1356345772.0 },
                    { 1327, "Prod_327", 1500756250.0 },
                    { 1326, "Prod_326", 931119799.0 },
                    { 1325, "Prod_325", 1021247409.0 },
                    { 1324, "Prod_324", 480260045.0 },
                    { 1323, "Prod_323", 1150074090.0 },
                    { 1322, "Prod_322", 1997127888.0 },
                    { 1321, "Prod_321", 1800591915.0 },
                    { 1320, "Prod_320", 1721022253.0 },
                    { 1319, "Prod_319", 1374862386.0 },
                    { 1318, "Prod_318", 1701526722.0 },
                    { 1317, "Prod_317", 1311402167.0 },
                    { 1316, "Prod_316", 1846253790.0 },
                    { 1315, "Prod_315", 1028755033.0 },
                    { 1314, "Prod_314", 169386514.0 },
                    { 1341, "Prod_341", 1298528199.0 },
                    { 1313, "Prod_313", 1039682927.0 },
                    { 1342, "Prod_342", 1774197857.0 },
                    { 1344, "Prod_344", 581172907.0 },
                    { 1371, "Prod_371", 431750811.0 },
                    { 1370, "Prod_370", 1231549718.0 },
                    { 1369, "Prod_369", 598144526.0 },
                    { 1368, "Prod_368", 1865383790.0 },
                    { 1367, "Prod_367", 118906113.0 },
                    { 1366, "Prod_366", 1392231183.0 },
                    { 1365, "Prod_365", 403475843.0 },
                    { 1364, "Prod_364", 328448270.0 },
                    { 1363, "Prod_363", 1674382027.0 },
                    { 1362, "Prod_362", 1417850100.0 },
                    { 1361, "Prod_361", 1802585724.0 },
                    { 1360, "Prod_360", 1341667414.0 },
                    { 1359, "Prod_359", 459503009.0 },
                    { 1358, "Prod_358", 491948524.0 },
                    { 1357, "Prod_357", 1685738813.0 },
                    { 1356, "Prod_356", 2007995854.0 },
                    { 1355, "Prod_355", 1008018738.0 },
                    { 1354, "Prod_354", 1221232876.0 },
                    { 1353, "Prod_353", 653031346.0 },
                    { 1352, "Prod_352", 1649875870.0 },
                    { 1351, "Prod_351", 1151337682.0 },
                    { 1350, "Prod_350", 114746617.0 },
                    { 1349, "Prod_349", 1307530980.0 },
                    { 1348, "Prod_348", 1619209469.0 },
                    { 1347, "Prod_347", 1579372525.0 },
                    { 1346, "Prod_346", 1806171181.0 },
                    { 1345, "Prod_345", 458886554.0 },
                    { 1343, "Prod_343", 2066620030.0 },
                    { 1312, "Prod_312", 740725509.0 },
                    { 1311, "Prod_311", 614227683.0 },
                    { 1310, "Prod_310", 1829707299.0 },
                    { 1277, "Prod_277", 1837778333.0 },
                    { 1276, "Prod_276", 1070554855.0 },
                    { 1275, "Prod_275", 1191055682.0 },
                    { 1274, "Prod_274", 889141501.0 },
                    { 1273, "Prod_273", 573440693.0 },
                    { 1272, "Prod_272", 170161141.0 },
                    { 1271, "Prod_271", 430984159.0 },
                    { 1270, "Prod_270", 448953007.0 },
                    { 1269, "Prod_269", 581666837.0 },
                    { 1268, "Prod_268", 441763204.0 },
                    { 1267, "Prod_267", 1560916475.0 },
                    { 1266, "Prod_266", 470233700.0 },
                    { 1265, "Prod_265", 1114959686.0 },
                    { 1264, "Prod_264", 862644478.0 },
                    { 1263, "Prod_263", 2095461276.0 },
                    { 1262, "Prod_262", 2025916554.0 },
                    { 1261, "Prod_261", 1113774246.0 },
                    { 1260, "Prod_260", 542582159.0 },
                    { 1259, "Prod_259", 626561152.0 },
                    { 1258, "Prod_258", 2050885272.0 },
                    { 1257, "Prod_257", 1185608942.0 },
                    { 1256, "Prod_256", 892410470.0 },
                    { 1255, "Prod_255", 1340666608.0 },
                    { 1254, "Prod_254", 247819785.0 },
                    { 1253, "Prod_253", 1491664622.0 },
                    { 1252, "Prod_252", 228445473.0 },
                    { 1251, "Prod_251", 354312023.0 },
                    { 1278, "Prod_278", 2004478979.0 },
                    { 1279, "Prod_279", 423314244.0 },
                    { 1280, "Prod_280", 2016770184.0 },
                    { 1281, "Prod_281", 1073422672.0 },
                    { 1309, "Prod_309", 616359649.0 },
                    { 1308, "Prod_308", 14635020.0 },
                    { 1307, "Prod_307", 1214600326.0 },
                    { 1306, "Prod_306", 1743746428.0 },
                    { 1305, "Prod_305", 713191667.0 },
                    { 1304, "Prod_304", 2068638519.0 },
                    { 1303, "Prod_303", 1560096670.0 },
                    { 1302, "Prod_302", 1276217357.0 },
                    { 1301, "Prod_301", 298044549.0 },
                    { 1300, "Prod_300", 1249015107.0 },
                    { 1299, "Prod_299", 1382659583.0 },
                    { 1298, "Prod_298", 468298186.0 },
                    { 1297, "Prod_297", 1791807046.0 },
                    { 1372, "Prod_372", 1105930753.0 },
                    { 1296, "Prod_296", 903144303.0 },
                    { 1294, "Prod_294", 776690467.0 },
                    { 1293, "Prod_293", 229000437.0 },
                    { 1292, "Prod_292", 1059459906.0 },
                    { 1291, "Prod_291", 987301144.0 },
                    { 1290, "Prod_290", 1661002338.0 },
                    { 1289, "Prod_289", 851284660.0 },
                    { 1288, "Prod_288", 1123384133.0 },
                    { 1287, "Prod_287", 229237331.0 },
                    { 1286, "Prod_286", 953532979.0 },
                    { 1285, "Prod_285", 1047377638.0 },
                    { 1284, "Prod_284", 1953530100.0 },
                    { 1283, "Prod_283", 126626286.0 },
                    { 1282, "Prod_282", 827116002.0 },
                    { 1295, "Prod_295", 401404861.0 },
                    { 1373, "Prod_373", 461188289.0 },
                    { 1374, "Prod_374", 2071231176.0 },
                    { 1375, "Prod_375", 1982089600.0 },
                    { 1465, "Prod_465", 1055046452.0 },
                    { 1464, "Prod_464", 256922867.0 },
                    { 1463, "Prod_463", 837884765.0 },
                    { 1462, "Prod_462", 1009989655.0 },
                    { 1461, "Prod_461", 1216747572.0 },
                    { 1460, "Prod_460", 557618794.0 },
                    { 1459, "Prod_459", 1634684684.0 },
                    { 1458, "Prod_458", 517469542.0 },
                    { 1457, "Prod_457", 693671982.0 },
                    { 1456, "Prod_456", 1352764819.0 },
                    { 1455, "Prod_455", 922175980.0 },
                    { 1454, "Prod_454", 2081879798.0 },
                    { 1453, "Prod_453", 930116531.0 },
                    { 1452, "Prod_452", 1329726817.0 },
                    { 1451, "Prod_451", 1630833883.0 },
                    { 1450, "Prod_450", 258793181.0 },
                    { 1449, "Prod_449", 440053870.0 },
                    { 1448, "Prod_448", 1032844615.0 },
                    { 1447, "Prod_447", 835798766.0 },
                    { 1446, "Prod_446", 1673415510.0 },
                    { 1445, "Prod_445", 164544776.0 },
                    { 1444, "Prod_444", 1863442357.0 },
                    { 1443, "Prod_443", 1133150689.0 },
                    { 1442, "Prod_442", 958872429.0 },
                    { 1441, "Prod_441", 1706859097.0 },
                    { 1440, "Prod_440", 62874213.0 },
                    { 1439, "Prod_439", 1661701662.0 },
                    { 1466, "Prod_466", 1737668251.0 },
                    { 1467, "Prod_467", 725633511.0 },
                    { 1468, "Prod_468", 1663340560.0 },
                    { 1469, "Prod_469", 1569131974.0 },
                    { 1497, "Prod_497", 1680583210.0 },
                    { 1496, "Prod_496", 108981341.0 },
                    { 1495, "Prod_495", 405722187.0 },
                    { 1494, "Prod_494", 516194767.0 },
                    { 1493, "Prod_493", 1457339938.0 },
                    { 1492, "Prod_492", 1462203388.0 },
                    { 1491, "Prod_491", 2063277649.0 },
                    { 1490, "Prod_490", 1441721080.0 },
                    { 1489, "Prod_489", 1004249585.0 },
                    { 1488, "Prod_488", 1428515413.0 },
                    { 1487, "Prod_487", 381410659.0 },
                    { 1486, "Prod_486", 1716042503.0 },
                    { 1485, "Prod_485", 2030173164.0 },
                    { 1438, "Prod_438", 1532429076.0 },
                    { 1484, "Prod_484", 16425215.0 },
                    { 1482, "Prod_482", 327117733.0 },
                    { 1481, "Prod_481", 820881237.0 },
                    { 1480, "Prod_480", 1446667706.0 },
                    { 1479, "Prod_479", 722869969.0 },
                    { 1478, "Prod_478", 1835661034.0 },
                    { 1477, "Prod_477", 1732652551.0 },
                    { 1476, "Prod_476", 1864393600.0 },
                    { 1475, "Prod_475", 1067744807.0 },
                    { 1474, "Prod_474", 1129000360.0 },
                    { 1473, "Prod_473", 1787173989.0 },
                    { 1472, "Prod_472", 1396201778.0 },
                    { 1471, "Prod_471", 913073458.0 },
                    { 1470, "Prod_470", 204677954.0 },
                    { 1483, "Prod_483", 122463400.0 },
                    { 1250, "Prod_250", 1732063927.0 },
                    { 1437, "Prod_437", 420077384.0 },
                    { 1435, "Prod_435", 1234890353.0 },
                    { 1402, "Prod_402", 1273584281.0 },
                    { 1401, "Prod_401", 1099376967.0 },
                    { 1400, "Prod_400", 626250917.0 },
                    { 1399, "Prod_399", 1737292610.0 },
                    { 1398, "Prod_398", 1150283659.0 },
                    { 1397, "Prod_397", 1659411376.0 },
                    { 1396, "Prod_396", 1440273645.0 },
                    { 1395, "Prod_395", 620236578.0 },
                    { 1394, "Prod_394", 870378464.0 },
                    { 1393, "Prod_393", 717675850.0 },
                    { 1392, "Prod_392", 1894261900.0 },
                    { 1391, "Prod_391", 1230657594.0 },
                    { 1390, "Prod_390", 682437226.0 },
                    { 1389, "Prod_389", 1285471491.0 },
                    { 1388, "Prod_388", 372293965.0 },
                    { 1387, "Prod_387", 1688156246.0 },
                    { 1386, "Prod_386", 748063031.0 },
                    { 1385, "Prod_385", 108281142.0 },
                    { 1384, "Prod_384", 1344697468.0 },
                    { 1383, "Prod_383", 1608410338.0 },
                    { 1382, "Prod_382", 1441142327.0 },
                    { 1381, "Prod_381", 911342820.0 },
                    { 1380, "Prod_380", 774671774.0 },
                    { 1379, "Prod_379", 1580969037.0 },
                    { 1378, "Prod_378", 2128496729.0 },
                    { 1377, "Prod_377", 1490103404.0 },
                    { 1376, "Prod_376", 1585989604.0 },
                    { 1403, "Prod_403", 433176842.0 },
                    { 1404, "Prod_404", 1635576808.0 },
                    { 1405, "Prod_405", 1242591352.0 },
                    { 1406, "Prod_406", 1605002475.0 },
                    { 1434, "Prod_434", 366830019.0 },
                    { 1433, "Prod_433", 1950799665.0 },
                    { 1432, "Prod_432", 1899415291.0 },
                    { 1431, "Prod_431", 1486173774.0 },
                    { 1430, "Prod_430", 2101411501.0 },
                    { 1429, "Prod_429", 863106497.0 },
                    { 1428, "Prod_428", 1150405371.0 },
                    { 1427, "Prod_427", 1947850449.0 },
                    { 1426, "Prod_426", 97084457.0 },
                    { 1425, "Prod_425", 1560487670.0 },
                    { 1424, "Prod_424", 1475302846.0 },
                    { 1423, "Prod_423", 2139507845.0 },
                    { 1422, "Prod_422", 1306207694.0 },
                    { 1436, "Prod_436", 1197354085.0 },
                    { 1421, "Prod_421", 1263670483.0 },
                    { 1419, "Prod_419", 1779762674.0 },
                    { 1418, "Prod_418", 1889280105.0 },
                    { 1417, "Prod_417", 1369035308.0 },
                    { 1416, "Prod_416", 1921038943.0 },
                    { 1415, "Prod_415", 1989920140.0 },
                    { 1414, "Prod_414", 1244426781.0 },
                    { 1413, "Prod_413", 470575033.0 },
                    { 1412, "Prod_412", 1116837630.0 },
                    { 1411, "Prod_411", 2077487996.0 },
                    { 1410, "Prod_410", 981624680.0 },
                    { 1409, "Prod_409", 798738822.0 },
                    { 1408, "Prod_408", 141395716.0 },
                    { 1407, "Prod_407", 600799480.0 },
                    { 1420, "Prod_420", 1215008358.0 },
                    { 1498, "Prod_498", 288339721.0 },
                    { 1249, "Prod_249", 957995980.0 },
                    { 1247, "Prod_247", 158385015.0 },
                    { 1089, "Prod_89", 2067721103.0 },
                    { 1088, "Prod_88", 624595271.0 },
                    { 1087, "Prod_87", 1731471553.0 },
                    { 1086, "Prod_86", 1914691809.0 },
                    { 1085, "Prod_85", 869471157.0 },
                    { 1084, "Prod_84", 1597959167.0 },
                    { 1083, "Prod_83", 1306779164.0 },
                    { 1082, "Prod_82", 73712824.0 },
                    { 1081, "Prod_81", 1491410099.0 },
                    { 1080, "Prod_80", 1015326040.0 },
                    { 1079, "Prod_79", 528780157.0 },
                    { 1078, "Prod_78", 1091501662.0 },
                    { 1077, "Prod_77", 282494820.0 },
                    { 1076, "Prod_76", 2142847154.0 },
                    { 1075, "Prod_75", 1904689992.0 },
                    { 1074, "Prod_74", 899256017.0 },
                    { 1073, "Prod_73", 55649514.0 },
                    { 1072, "Prod_72", 388305482.0 },
                    { 1071, "Prod_71", 1603578681.0 },
                    { 1070, "Prod_70", 637985118.0 },
                    { 1069, "Prod_69", 1244919814.0 },
                    { 1068, "Prod_68", 704244998.0 },
                    { 1067, "Prod_67", 1392207662.0 },
                    { 1066, "Prod_66", 1249292728.0 },
                    { 1065, "Prod_65", 7581457.0 },
                    { 1064, "Prod_64", 609626470.0 },
                    { 1063, "Prod_63", 1429882809.0 },
                    { 1090, "Prod_90", 2050045649.0 },
                    { 1062, "Prod_62", 1005285120.0 },
                    { 1091, "Prod_91", 533613169.0 },
                    { 1093, "Prod_93", 173417740.0 },
                    { 1120, "Prod_120", 1799968841.0 },
                    { 1119, "Prod_119", 1299750859.0 },
                    { 1118, "Prod_118", 1391519188.0 },
                    { 1117, "Prod_117", 1258101502.0 },
                    { 1116, "Prod_116", 604860593.0 },
                    { 1115, "Prod_115", 115066446.0 },
                    { 1114, "Prod_114", 52233870.0 },
                    { 1113, "Prod_113", 1972167507.0 },
                    { 1112, "Prod_112", 1981179513.0 },
                    { 1111, "Prod_111", 1988039261.0 },
                    { 1110, "Prod_110", 1960247821.0 },
                    { 1109, "Prod_109", 411264081.0 },
                    { 1108, "Prod_108", 454181640.0 },
                    { 1107, "Prod_107", 1540920593.0 },
                    { 1106, "Prod_106", 730729859.0 },
                    { 1105, "Prod_105", 1367910882.0 },
                    { 1104, "Prod_104", 1672198795.0 },
                    { 1103, "Prod_103", 2137232616.0 },
                    { 1102, "Prod_102", 1273471103.0 },
                    { 1101, "Prod_101", 393838153.0 },
                    { 1100, "Prod_100", 1231066777.0 },
                    { 1099, "Prod_99", 1399602068.0 },
                    { 1098, "Prod_98", 2003433539.0 },
                    { 1097, "Prod_97", 1572630374.0 },
                    { 1096, "Prod_96", 1313782307.0 },
                    { 1095, "Prod_95", 956732287.0 },
                    { 1094, "Prod_94", 1011475820.0 },
                    { 1092, "Prod_92", 388867447.0 },
                    { 1061, "Prod_61", 1266461518.0 },
                    { 1060, "Prod_60", 46880999.0 },
                    { 1059, "Prod_59", 1655448011.0 },
                    { 1026, "Prod_26", 349935108.0 },
                    { 1025, "Prod_25", 1829664410.0 },
                    { 1024, "Prod_24", 2037432217.0 },
                    { 1023, "Prod_23", 1526977742.0 },
                    { 1022, "Prod_22", 1923847384.0 },
                    { 1021, "Prod_21", 2026169245.0 },
                    { 1020, "Prod_20", 1104566327.0 },
                    { 1019, "Prod_19", 3258730.0 },
                    { 1018, "Prod_18", 142298888.0 },
                    { 1017, "Prod_17", 1245463788.0 },
                    { 1016, "Prod_16", 1962090801.0 },
                    { 1015, "Prod_15", 1712976471.0 },
                    { 1014, "Prod_14", 886712906.0 },
                    { 1013, "Prod_13", 48790791.0 },
                    { 1012, "Prod_12", 1801454015.0 },
                    { 1011, "Prod_11", 1802898947.0 },
                    { 1010, "Prod_10", 987540382.0 },
                    { 1009, "Prod_9", 66829977.0 },
                    { 1008, "Prod_8", 1320544901.0 },
                    { 1007, "Prod_7", 2090945206.0 },
                    { 1006, "Prod_6", 43540134.0 },
                    { 1005, "Prod_5", 984704208.0 },
                    { 1004, "Prod_4", 1925516875.0 },
                    { 1003, "Prod_3", 1419188789.0 },
                    { 1002, "Prod_2", 1480467825.0 },
                    { 1001, "Prod_1", 1075190373.0 },
                    { 1000, "Prod_0", 862589481.0 },
                    { 1027, "Prod_27", 336674162.0 },
                    { 1028, "Prod_28", 497771985.0 },
                    { 1029, "Prod_29", 1450257638.0 },
                    { 1030, "Prod_30", 1016799053.0 },
                    { 1058, "Prod_58", 941352118.0 },
                    { 1057, "Prod_57", 1513085629.0 },
                    { 1056, "Prod_56", 710938535.0 },
                    { 1055, "Prod_55", 396015782.0 },
                    { 1054, "Prod_54", 756358527.0 },
                    { 1053, "Prod_53", 1941325758.0 },
                    { 1052, "Prod_52", 36974561.0 },
                    { 1051, "Prod_51", 1706923442.0 },
                    { 1050, "Prod_50", 1411894017.0 },
                    { 1049, "Prod_49", 750588367.0 },
                    { 1048, "Prod_48", 1822556884.0 },
                    { 1047, "Prod_47", 418120555.0 },
                    { 1046, "Prod_46", 226450269.0 },
                    { 1121, "Prod_121", 1077416721.0 },
                    { 1045, "Prod_45", 920763959.0 },
                    { 1043, "Prod_43", 1053464463.0 },
                    { 1042, "Prod_42", 1442917637.0 },
                    { 1041, "Prod_41", 759471881.0 },
                    { 1040, "Prod_40", 663598259.0 },
                    { 1039, "Prod_39", 1646244920.0 },
                    { 1038, "Prod_38", 269270205.0 },
                    { 1037, "Prod_37", 1918107666.0 },
                    { 1036, "Prod_36", 487103252.0 },
                    { 1035, "Prod_35", 1201388638.0 },
                    { 1034, "Prod_34", 904141339.0 },
                    { 1033, "Prod_33", 1968841899.0 },
                    { 1032, "Prod_32", 2113201765.0 },
                    { 1031, "Prod_31", 392070824.0 },
                    { 1044, "Prod_44", 1995071626.0 },
                    { 1122, "Prod_122", 179724290.0 },
                    { 1123, "Prod_123", 196119441.0 },
                    { 1124, "Prod_124", 754469711.0 },
                    { 1214, "Prod_214", 15888553.0 },
                    { 1213, "Prod_213", 1662007027.0 },
                    { 1212, "Prod_212", 1960412948.0 },
                    { 1211, "Prod_211", 1219428208.0 },
                    { 1210, "Prod_210", 1325230693.0 },
                    { 1209, "Prod_209", 1292626694.0 },
                    { 1208, "Prod_208", 514380564.0 },
                    { 1207, "Prod_207", 2138831375.0 },
                    { 1206, "Prod_206", 1551350764.0 },
                    { 1205, "Prod_205", 802682401.0 },
                    { 1204, "Prod_204", 1970989369.0 },
                    { 1203, "Prod_203", 1662145332.0 },
                    { 1202, "Prod_202", 1008920552.0 },
                    { 1201, "Prod_201", 1529828476.0 },
                    { 1200, "Prod_200", 1619703147.0 },
                    { 1199, "Prod_199", 1836633333.0 },
                    { 1198, "Prod_198", 1364682239.0 },
                    { 1197, "Prod_197", 1737339448.0 },
                    { 1196, "Prod_196", 996215409.0 },
                    { 1195, "Prod_195", 594606626.0 },
                    { 1194, "Prod_194", 1048556082.0 },
                    { 1193, "Prod_193", 1185944615.0 },
                    { 1192, "Prod_192", 260796496.0 },
                    { 1191, "Prod_191", 700182880.0 },
                    { 1190, "Prod_190", 1966969570.0 },
                    { 1189, "Prod_189", 703658870.0 },
                    { 1188, "Prod_188", 1651861913.0 },
                    { 1215, "Prod_215", 1650155648.0 },
                    { 1216, "Prod_216", 422138245.0 },
                    { 1217, "Prod_217", 54015285.0 },
                    { 1218, "Prod_218", 921005874.0 },
                    { 1246, "Prod_246", 299365478.0 },
                    { 1245, "Prod_245", 159653261.0 },
                    { 1244, "Prod_244", 938023723.0 },
                    { 1243, "Prod_243", 1918830765.0 },
                    { 1242, "Prod_242", 180189129.0 },
                    { 1241, "Prod_241", 1369465311.0 },
                    { 1240, "Prod_240", 2103067208.0 },
                    { 1239, "Prod_239", 1907160727.0 },
                    { 1238, "Prod_238", 1443449690.0 },
                    { 1237, "Prod_237", 1550749632.0 },
                    { 1236, "Prod_236", 613314540.0 },
                    { 1235, "Prod_235", 993817262.0 },
                    { 1234, "Prod_234", 632355722.0 },
                    { 1187, "Prod_187", 1282457794.0 },
                    { 1233, "Prod_233", 1959092019.0 },
                    { 1231, "Prod_231", 1769866553.0 },
                    { 1230, "Prod_230", 1989577762.0 },
                    { 1229, "Prod_229", 2125998481.0 },
                    { 1228, "Prod_228", 1672510367.0 },
                    { 1227, "Prod_227", 1997172064.0 },
                    { 1226, "Prod_226", 1819695788.0 },
                    { 1225, "Prod_225", 756540116.0 },
                    { 1224, "Prod_224", 1170855606.0 },
                    { 1223, "Prod_223", 1382907156.0 },
                    { 1222, "Prod_222", 49529905.0 },
                    { 1221, "Prod_221", 1838632085.0 },
                    { 1220, "Prod_220", 1000925447.0 },
                    { 1219, "Prod_219", 1432613163.0 },
                    { 1232, "Prod_232", 161306407.0 },
                    { 1248, "Prod_248", 582167961.0 },
                    { 1186, "Prod_186", 1948701140.0 },
                    { 1184, "Prod_184", 1150247582.0 },
                    { 1151, "Prod_151", 1615276351.0 },
                    { 1150, "Prod_150", 1911467240.0 },
                    { 1149, "Prod_149", 308521273.0 },
                    { 1148, "Prod_148", 1680779416.0 },
                    { 1147, "Prod_147", 2123779133.0 },
                    { 1146, "Prod_146", 112029202.0 },
                    { 1145, "Prod_145", 1621601934.0 },
                    { 1144, "Prod_144", 1667068828.0 },
                    { 1143, "Prod_143", 1772926736.0 },
                    { 1142, "Prod_142", 689401812.0 },
                    { 1141, "Prod_141", 1933366762.0 },
                    { 1140, "Prod_140", 1698336844.0 },
                    { 1139, "Prod_139", 1789643831.0 },
                    { 1138, "Prod_138", 1194175915.0 },
                    { 1137, "Prod_137", 1643559401.0 },
                    { 1136, "Prod_136", 1777534542.0 },
                    { 1135, "Prod_135", 33599786.0 },
                    { 1134, "Prod_134", 857308926.0 },
                    { 1133, "Prod_133", 1251495140.0 },
                    { 1132, "Prod_132", 1986140474.0 },
                    { 1131, "Prod_131", 2129812326.0 },
                    { 1130, "Prod_130", 3019584.0 },
                    { 1129, "Prod_129", 1502119276.0 },
                    { 1128, "Prod_128", 603769240.0 },
                    { 1127, "Prod_127", 1774483288.0 },
                    { 1126, "Prod_126", 626823133.0 },
                    { 1125, "Prod_125", 1663967495.0 },
                    { 1152, "Prod_152", 1740706732.0 },
                    { 1153, "Prod_153", 115794579.0 },
                    { 1154, "Prod_154", 1159228773.0 },
                    { 1155, "Prod_155", 1713245602.0 },
                    { 1183, "Prod_183", 1854843513.0 },
                    { 1182, "Prod_182", 1653299418.0 },
                    { 1181, "Prod_181", 62639546.0 },
                    { 1180, "Prod_180", 964050192.0 },
                    { 1179, "Prod_179", 692463323.0 },
                    { 1178, "Prod_178", 88646159.0 },
                    { 1177, "Prod_177", 2113876747.0 },
                    { 1176, "Prod_176", 1947610455.0 },
                    { 1175, "Prod_175", 1426197625.0 },
                    { 1174, "Prod_174", 1161009561.0 },
                    { 1173, "Prod_173", 1161470903.0 },
                    { 1172, "Prod_172", 1623521133.0 },
                    { 1171, "Prod_171", 520896738.0 },
                    { 1185, "Prod_185", 2094822426.0 },
                    { 1170, "Prod_170", 2044611097.0 },
                    { 1168, "Prod_168", 526970480.0 },
                    { 1167, "Prod_167", 141796272.0 },
                    { 1166, "Prod_166", 1561494333.0 },
                    { 1165, "Prod_165", 1390031041.0 },
                    { 1164, "Prod_164", 1967840043.0 },
                    { 1163, "Prod_163", 511657910.0 },
                    { 1162, "Prod_162", 349263252.0 },
                    { 1161, "Prod_161", 515842117.0 },
                    { 1160, "Prod_160", 153199648.0 },
                    { 1159, "Prod_159", 1567826846.0 },
                    { 1158, "Prod_158", 794874804.0 },
                    { 1157, "Prod_157", 489463561.0 },
                    { 1156, "Prod_156", 1773709409.0 },
                    { 1169, "Prod_169", 1578229630.0 },
                    { 1499, "Prod_499", 220507804.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1499);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eaf6b985-76bd-46cb-85b2-8541c99328fa", null });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "ProductName", "ProductPrice" },
                values: new object[] { 111, "Car Tree", 99.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "ProductName", "ProductPrice" },
                values: new object[] { 222, "Clean Service", 10.0 });
        }
    }
}
