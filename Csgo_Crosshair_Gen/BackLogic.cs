using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csgo_Crosshair_Gen
{
    class BackLogic
    {
        
        public void Randomizer()
        {
            UserControl userPlayers = new UserControl();
            Random randomPlayers = new Random();

            List<string> players = new List<string>
            {
                //<--Astralis-->
                "Dupreeh from Astralis",
                "Magisk from Astralis",
                "Xyp9x from Astralis",
                "Gla1ve from Astralis",
                "Device from Astralis",
                //<!--Astralis-->

                //<--NaVi-->
                "Edward from NaVi",
                "Zeus from NaVi",
                "Flamie from NaVi",
                "S1mple from NaVi",
                "Electronic from NaVi",
                //<!-NaVi-->

                //<--Liquid-->
                "Nitr0 from Liquid",
                "NAF from Liquid",
                "EliGE from Liquid",
                "TACO from Mibr",
                "Twistzz from Liquid",
                //<!-Liquid-->

                //<--Mibr-->
                "FalleN from Mibr",
                "Tarik from Mibr",
                "Fer from Mibr",
                "Stewie2K from Liquid",
                "Coldzera from Mibr",
                //<!-Mibr-->

                //<--Mousesports-->
                "Oskar from Mousesports",
                "ChrisJ from Mousesports",
                "SuNny from Mousesports",
                "STYKO from Mousesports",
                "Ropz from Mousesports",
                //<!-Mousesports-->

                //<--FaZe-->
                "Olof from FaZe",
                "Guardian from FaZe",
                "NiKo from FaZe",
                "Rain from FaZe",
                "Karrigan from FaZe",
                //<!-FaZe-->

                //<--NIP-->
                "F0rest from NIP",
                "GeT_RiGhT from NIP",
                "Dennis from NIP",
                "Lekr0 from NIP",
                "REZ from NIP",
                //<!-NIP-->

                //<--G2-->
                "JaCkz from G2",
                "Shox from G2",
                "KennyS from G2",
                "Bodyy from G2",
                "Lucky from G2",
                //<!-G2-->

                //<--Cloud9-->
                "Flusha from Cloud9",
                "KioShiMa from Cloud9",
                "RUSH from Cloud9",
                "Autimatic from Cloud9",
                "Golden from Cloud9",
                //<!-Cloud9-->

                //<--Extatus-->
                "wEAMO from Extatus",
                "Luko from Extatus",
                "Blogg1s from Extatus",
                "Desty from Extatus",
                "Rko from Extatus",
                //<!-Extatus-->

                //<--Fnatic-->
                "Xizt from Fnatic",
                "JW from Fnatic",
                "Twist from Fnatic",
                "KRIMZ from Fnatic",
                "Brollan from Fnatic",
                //<!-Fnatic-->

                //<--Heroic-->
                "MODDII from Heroic",
                "Friberg from Heroic",
                "AcilioN from Heroic",
                "Es3tag from Heroic",
                "Mertz from Heroic",
                //<!-Heroic-->

                //<--North-->
                "CadiaN from North",
                "Aizy from North",
                "Kjaerbye from North",
                "Gade from North",
                "Valde from North",
                //<!-North-->

                //<--BIG-->
                "Gob b from BIG",
                "TabseN from BIG",
                "TiziaN from BIG",
                "Nex from BIG",
                "Smooooooooooooooooooooya! from BIG",
                //<!-BIG-->

                //<--Kinguin-->
                "TaZ from Kinguin",
                "MINISE from Kinguin",
                "Rallen from Kinguin",
                "Reatz from Kinguin",
                "Mouz from Kinguin",
                //<!-Kinguin-->

                //<--Renegades-->
                "Daps from Renegades",
                "Fugly from Renegades",
                "Brehze from Renegades",
                "NahtE from Renegades",
                "CeRq from Renegades",
                //<!-Renegades-->

                //<--HellRaisers-->
                "Jks from HellRaisers",
                "AZR from HellRaisers",
                "Jkaem from HellRaisers",
                "Gratisfaction from HellRaisers",
                "Liazz from HellRaisers",
                //<!-HellRaisers-->

                //<--exSpaceSoldiers-->
                "MAJ3R from exSpaceSoldiers",
                "XANTARES from exSpaceSoldiers",
                "Calyx from exSpaceSoldiers",
                "Paz from exSpaceSoldiers",
                "NgiN from exSpaceSoldiers",
                //<!-exSpaceSoldiers-->

                //<--Sprout-->
                "PERCY from Sprout",
                "Spiidi from Sprout",
                "Denis from Sprout",
                "NaToSaphiX from Sprout",
                "FaveN from Sprout",
                //<!-Sprout-->

                //<--AGO-->
                "SZPERO from AGO",
                "Furlan from AGO",
                "Gruby from AGO",
                "Phr from AGO",
                "Kap3r from AGO",
                //<!-AGO-->

                //<--OpTic-->
                "Snappi from OpTic",
                "Cajunb from OpTic",
                "JUGi from OpTic",
                "K0nfig from OpTic",
                "Niko from OpTic",
                //<!-OpTic-->

                //<--Winstrike-->
                "WorldEdit from Winstrike",
                "WayLander from Winstrike",
                "Kvik from Winstrike",
                "Boombl4 from Winstrike",
                "N0rb3r7 from Winstrike",
                //<!-Winstrike-->

                //<--Luminosity-->
                "Steel from Luminosity",
                "HEN1 from Luminosity",
                "LUCAS1 from Luminosity",
                "Boltz from Luminosity",
                "NEKIZ from Luminosity"
                //<!-Luminosity-->
            };

            int playerPicked1 = randomPlayers.Next(players.Count);
            int playerPicked2 = randomPlayers.Next(players.Count);
            int playerPicked3 = randomPlayers.Next(players.Count);

            userPlayers.DisplayPlayers((string)players[playerPicked1], (string)players[playerPicked2], (string)players[playerPicked3]);
       
        }

        
    }
}
