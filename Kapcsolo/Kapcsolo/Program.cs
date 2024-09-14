#region Switch Feladatok

//1. Feladat:

Console.Write("Adj meg egy érdemjegyet (1-5): ");
int jegy = int.Parse(Console.ReadLine()!);

switch(jegy)
{
    case 1: Console.WriteLine("Gratulálok megfogsz bukni!"); break;
    case 2: Console.WriteLine("Hát browski vigyázzá!"); break;
    case 3: Console.WriteLine("Skibidi 3-mas..."); break;
    case 4: Console.WriteLine("Majdnem tökéletes 🤬"); break;
    case 5: Console.WriteLine("Jó, de kilették tagadva az oláh cigányokból!"); break;
    default: Console.WriteLine("Szerintem ez az eredmény nem létezik...-,-.,-.,-.,-.,-.");break;
}

//2. Feladat:

Console.Write("Adj meg egy hónapot: ");
string honap = Console.ReadLine()!;

switch(honap)
{
    case "December" or "Január" or "Február": Console.WriteLine("Jelenleg 1/4 van.");break;
    case "Március" or "Április" or "Május": Console.WriteLine("Jelenleg 2/4 van.");break;
    case "Június" or "Július" or "Augusztus": Console.WriteLine("Jelenleg 3/4 van.");break;
    case "Szeptember" or "Október" or "December": Console.WriteLine("Jelenleg 4/4 van.");break;
    default: Console.WriteLine("Szerintem valamit elrontottál, vagy csak nem lett jó a nagybetű.");break;
}

//3. Feladat:

Console.Write("Add meg valamelyik hónapnak a sorzsámát(1-12): ");
int hsz = int.Parse(Console.ReadLine()!);

switch(hsz)
{
    case 12 or 1 or 2: Console.WriteLine("Tél van, de gondolom hó az nincs.");break;
    case 3 or 4 or 5: Console.WriteLine("Tavasz van, ami azt jelenti, hogy 2024. március 31.-én jön a nyuszi!");break;
    case 6 or 7 or 8: Console.WriteLine("Itt a nyár pörög a minecárt!");break;
    case 9 or 10 or 11: Console.WriteLine("\r\nItt van az ősz, itt van ujra,\r\nS szép, mint mindig, énnekem.\r\nTudja isten, hogy mi okból\r\nSzeretem? de szeretem.\r\n \r\nKiülök a dombtetőre,\r\nInnen nézek szerteszét,\r\nS hallgatom a fák lehulló\r\nLevelének lágy neszét.");break;
    default: Console.WriteLine("Nincs ilyen számsorral rendelkező évszak! (vagy csak még nem találták ki.)");break;
}

//4. Feladat:

Console.Write("Hány órát alszol egy nap?: ");
int orak = int.Parse(Console.ReadLine()!);

switch(orak)
{
    case 1 or 2 or 3 or 4 or 5 or 6: Console.WriteLine("Egy kicsit kevés nem gondolod? Pörög a LoL ha nem tévedek...");break;
    case 7 or 8 or 9: Console.WriteLine("Átlagos.");break;
    case 
}

//5. Feladat:

//6. Feladat:

//7. Feladat:

//8. Feladat:

//9. Feladat:

#endregion

#region Többirányú elágazás gyakorló feladatok

//10. Feladat:

//11. Feladat:

#endregion

#region Asztali alkalmazások fejlesztése

//12. Feladat:

#endregion