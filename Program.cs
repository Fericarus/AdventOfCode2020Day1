using System;

namespace AdventOfCode_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* --- ADVENT OF CODE 2020 ---
             * 
             * --- Día 1: Informe de reparación ---
             * 
             * Después de salvar la Navidad cinco años seguidos , ha decidido tomarse unas vacaciones en un bonito
             * resort en una isla tropical. Seguro que la Navidad seguirá sin ti.
             * 
             * La isla tropical tiene su propia moneda y solo se paga en efectivo. Las monedas de oro que se utilizan
             * allí tienen una pequeña imagen de una estrella de mar; los lugareños simplemente los llaman estrellas .
             * Ninguno de los intercambios de divisas parece haber oído hablar de ellos, pero de alguna manera,
             * deberá encontrar cincuenta de estas monedas para cuando llegue para poder pagar el depósito en su 
             * habitación.
             * 
             * Para guardar sus vacaciones, debe obtener las cincuenta estrellas antes del 25 de diciembre.
             * Recoge estrellas resolviendo acertijos. Dos rompecabezas estarán disponibles cada día en el calendario
             * de Adviento; el segundo rompecabezas se desbloquea cuando completas el primero. Cada rompecabezas 
             * otorga una estrella . ¡Buena suerte!
             * 
             * Antes de que te vayas, los Elfos en contabilidad solo necesitan que arregles tu informe de gastos 
             * (tu entrada de rompecabezas); aparentemente, algo no cuadra del todo.
             * 
             * Específicamente, necesitan que encuentre las dos entradas que suman 2020 y luego multiplique esos
             * dos números.
             * 
             * Por ejemplo, suponga que su informe de gastos contiene lo siguiente:
             * 
             * 1721
             * 979
             * 366
             * 299
             * 675
             * 1456
             * 
             * En esta lista, las dos entradas que suman 2020son 1721y 299. Multiplicarlos juntos produce
             * 1721 * 299 = 514579, por lo que la respuesta correcta es 514579.
             * 
             * Por supuesto, su informe de gastos es mucho más grande. Encuentre las dos entradas que 
             * sumen 2020; ¿Qué obtienes si los multiplicas?
             * 
             * Tu respuesta al acertijo fue 1016131 que es ¡CORRECTA!
             * 
             * --- La segunda parte ---
             * 
             * Los Elfos en contabilidad están agradecidos por su ayuda; uno de ellos incluso te ofrece una 
             * moneda de estrella de mar que les sobró de unas vacaciones pasadas. Le ofrecen un segundo si
             * puede encontrar tres números en su informe de gastos que cumplan con los mismos criterios.
             * 
             * Utilizando el ejemplo anterior de nuevo, las tres entradas que suma a 2020 son 979, 366, y 675.
             * Multiplicando juntos produce la respuesta, 241861950. En su informe de gastos, 
             * ¿cuál es el producto de las tres entradas que suman 2020?
             * 
             * Tu respuesta al acertijo fue 276432018 ¡QUE TAMBIÉN ES CORRECTA!
             * 
             * ¡Ambas partes de este rompecabezas están completas! Proporcionan dos estrellas doradas: **
             * 
             */


            // --- SOLUCIÓN ---

            int[] miArray2 = new int[]
            {
                1895, 1504, 1660, 1775, 1743, 1607, 1267, 1133, 292, 1646, 1285, 1808, 1512, 1839, 1869, 1578,
                1318, 1385, 1829, 1800, 1491, 1600, 1290, 1856, 1781, 1881, 1953, 2008, 1681, 1472, 1846, 2010,
                1619, 1584, 1849, 1876, 1744, 1980, 1421, 911, 1308, 1762, 1398, 1470, 1974, 1902, 1985, 2001,
                1926, 1374, 1678, 1523, 1894, 1597, 1778, 1940, 1362, 1613, 1629, 1473, 1633, 1867, 1838, 1931,
                1850, 1776, 1689, 1311, 1947, 1988, 1779, 1381, 1683, 1677, 1675, 1587, 767, 1401, 1412, 1544,
                1484, 618, 1755, 1073, 1970, 1735, 1770, 1623, 1665, 1783, 1400, 1892, 1921, 1506, 1978, 1731,
                1739, 1515, 1354, 1264, 1394, 1763, 1569, 1453, 1539, 2006, 1586, 1855, 1609, 1729, 1624, 506,
                1668, 1803, 1486, 1767, 1720, 1753, 1994, 1718, 1922, 1314, 1250, 1516, 1546, 1625, 1708, 1286,
                1993, 1785, 491, 1705, 1924, 1752, 1888, 1651, 1604, 1750, 1547, 1481, 1704, 1851, 904, 1920,
                1939, 1277, 1870, 1934, 1617, 1833, 1797, 1817, 1967, 1935, 1914, 1621, 1468, 1859, 1552, 1640,
                1709, 1121, 1973, 1343, 1266, 1806, 1360, 1299, 1990, 1356, 1631, 1555, 1811, 1323, 1794, 1550,
                1448, 1848, 1826, 1723, 1891, 1302, 1655, 947, 1580, 1908, 1641, 1816, 1701, 1871, 1588, 1843,
                1643, 1893, 1866, 1628, 1417, 1795, 1995,1937
            }; 

            int[] miArray = new int[200] 
            {
                1895, 1504, 1660, 1775, 1743, 1607, 1267, 1133, 292, 1646, 1285, 1808, 1512, 1839, 1869, 1578, 
                1800, 1491, 1600, 1290, 1856, 1781, 1881, 1953, 2008, 1681, 1472, 1846, 2010, 1619, 1584, 1849,
                1876, 1744, 1980, 1421, 911, 1308, 1762, 1398, 1470, 1974, 1902, 1985, 2001, 1926, 1374, 1678,
                1523, 1894, 1597, 1778, 1940, 1362, 1613, 1629, 1473, 1633, 1867, 1838, 1931, 1850, 1776, 1689,
                1311, 1947, 1988, 1779, 1381, 1683, 1677,1675, 1587, 767, 1401, 1412, 1544, 1484, 618, 1755,
                1073, 1970, 1735, 1770, 1623, 1665, 1783, 1400, 1892, 1921, 1506, 1978, 1731, 1739, 1515, 1354,
                1264, 1394, 1763, 1569, 1453, 1539, 2006, 1586, 1855, 1609, 1729, 1624, 506, 1668, 1803, 1486,
                1767, 1720, 1753, 1994, 1718, 1922, 1314, 1250, 1516, 1546, 1625, 1708, 1286, 1993, 1785, 491,
                1705, 1924, 1752, 1888, 1651, 1604, 1750, 1547, 1481, 1704, 1851, 904, 1920, 1939, 1277, 1870,
                1934, 1617, 1833, 1797, 1817, 1967, 1935, 1914, 1621, 1468, 1859, 1552, 1640, 1709, 1121, 1973,
                1343, 1266, 1806, 1360, 1299, 1990, 1356, 1631, 1555, 1811, 1323, 1794, 1550, 1448, 1848, 1826,
                1723, 1891, 1302, 1655, 947, 1580, 1908, 1641, 1816, 1701, 1871, 1588, 1843, 1643, 1893, 1866,
                1628, 1417, 1795, 1995, 1937, 1318, 1385, 1829
            };

            int[] arrayDemo = new int[6]
            {
                1721,
                979,
                366,
                299,
                675,
                1456
            };

            calcular(miArray2);

        }

        public static void calcular(int[] miArray) 
        {
            Console.WriteLine("El arreglo tiene " + miArray.Length + " elementos\n");

            for (int i = 0; i < miArray.Length; i++)
            {
                for (int j = 0; j < miArray.Length; j++)
                {
                    for (int k = 0; k < miArray.Length; k++) 
                    {
                        int suma = miArray[i] + miArray[j] + miArray[k];

                        if (suma == 2020)
                        {
                            Console.WriteLine("  Suma encontrada!");
                            Console.Write("  Los valores son: ");
                            Console.Write("  " + miArray[i]);
                            Console.Write("  " + miArray[j]);
                            Console.Write("  " + miArray[k]);
                            Console.WriteLine("  El resultado de multiplicar ambos valores es " + (miArray[i] * miArray[j] * miArray[k]) + "\n");
                        }
                    }
                    
                }
            }
        }
    }
}
