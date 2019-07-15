using System.Collections.Generic;

namespace Summoners_War_Statistics
{
    internal class Mapping
    {
        #region Singleton

        private static Mapping instance;

        public static Mapping Instance => instance ?? (instance = new Mapping());

        private Mapping()
        {
            #region Monster Attributes
            monsterAttributes.Add(1, "Water");
            monsterAttributes.Add(2, "Fire");
            monsterAttributes.Add(3, "Wind");
            monsterAttributes.Add(4, "Light");
            monsterAttributes.Add(5, "Dark");
            #endregion

            #region Monster Names
            monsterNames.Add(101, "Fairy");
            monsterNames.Add(10111, "Elucia");
            monsterNames.Add(10112, "Iselia");
            monsterNames.Add(10113, "Aeilene");
            monsterNames.Add(10114, "Neal");
            monsterNames.Add(10115, "Sorin");
            monsterNames.Add(10131, "Elucia");
            monsterNames.Add(10132, "Iselia");
            monsterNames.Add(10133, "Aeilene");
            monsterNames.Add(10134, "Neal");
            monsterNames.Add(10135, "Sorin");

            monsterNames.Add(102, "Imp");
            monsterNames.Add(10211, "Fynn");
            monsterNames.Add(10212, "Cogma");
            monsterNames.Add(10213, "Ralph");
            monsterNames.Add(10214, "Taru");
            monsterNames.Add(10215, "Garok");

            monsterNames.Add(103, "Pixie");
            monsterNames.Add(10311, "Kacey");
            monsterNames.Add(10312, "Tatu");
            monsterNames.Add(10313, "Shannon");
            monsterNames.Add(10314, "Cheryl");
            monsterNames.Add(10315, "Camaryn");
            monsterNames.Add(10331, "Kacey");
            monsterNames.Add(10332, "Tatu");
            monsterNames.Add(10333, "Shannon");
            monsterNames.Add(10334, "Cheryl");
            monsterNames.Add(10335, "Camaryn");

            monsterNames.Add(104, "Yeti");
            monsterNames.Add(10411, "Kunda");
            monsterNames.Add(10412, "Tantra");
            monsterNames.Add(10413, "Rakaja");
            monsterNames.Add(10414, "Arkajan");
            monsterNames.Add(10415, "Kumae");

            monsterNames.Add(105, "Harpy");
            monsterNames.Add(10511, "Ramira");
            monsterNames.Add(10512, "Lucasha");
            monsterNames.Add(10513, "Prilea");
            monsterNames.Add(10514, "Kabilla");
            monsterNames.Add(10515, "Hellea");

            monsterNames.Add(106, "Hellhound");
            monsterNames.Add(10611, "Tarq");
            monsterNames.Add(10612, "Sieq");
            monsterNames.Add(10613, "Gamir");
            monsterNames.Add(10614, "Shamar");
            monsterNames.Add(10615, "Shumar");

            monsterNames.Add(107, "Warbear");
            monsterNames.Add(10711, "Dagora");
            monsterNames.Add(10712, "Ursha");
            monsterNames.Add(10713, "Ramagos");
            monsterNames.Add(10714, "Lusha");
            monsterNames.Add(10715, "Gorgo");
            monsterNames.Add(10731, "Dagora");
            monsterNames.Add(10732, "Ursha");
            monsterNames.Add(10733, "Ramagos");
            monsterNames.Add(10734, "Lusha");
            monsterNames.Add(10735, "Gorgo");

            monsterNames.Add(108, "Elemental");
            monsterNames.Add(10811, "Daharenos");
            monsterNames.Add(10812, "Bremis");
            monsterNames.Add(10813, "Taharus");
            monsterNames.Add(10814, "Priz");
            monsterNames.Add(10815, "Camules");

            monsterNames.Add(109, "Garuda");
            monsterNames.Add(10911, "Konamiya");
            monsterNames.Add(10912, "Cahule");
            monsterNames.Add(10913, "Lindermen");
            monsterNames.Add(10914, "Teon");
            monsterNames.Add(10915, "Rizak");

            monsterNames.Add(110, "Inugami");
            monsterNames.Add(11011, "Icaru");
            monsterNames.Add(11012, "Raoq");
            monsterNames.Add(11013, "Ramahan");
            monsterNames.Add(11014, "Belladeon");
            monsterNames.Add(11015, "Kro");
            monsterNames.Add(11031, "Icaru");
            monsterNames.Add(11032, "Raoq");
            monsterNames.Add(11033, "Ramahan");
            monsterNames.Add(11034, "Belladeon");
            monsterNames.Add(11035, "Kro");

            monsterNames.Add(111, "Salamander");
            monsterNames.Add(11111, "Kaimann");
            monsterNames.Add(11112, "Krakdon");
            monsterNames.Add(11113, "Lukan");
            monsterNames.Add(11114, "Sharman");
            monsterNames.Add(11115, "Decamaron");

            monsterNames.Add(112, "Nine-tailed Fox");
            monsterNames.Add(11211, "Soha");
            monsterNames.Add(11212, "Shihwa");
            monsterNames.Add(11213, "Arang");
            monsterNames.Add(11214, "Chamie");
            monsterNames.Add(11215, "Kamiya");

            monsterNames.Add(113, "Serpent");
            monsterNames.Add(11311, "Shailoq");
            monsterNames.Add(11312, "Fao");
            monsterNames.Add(11313, "Ermeda");
            monsterNames.Add(11314, "Elpuria");
            monsterNames.Add(11315, "Mantura");

            monsterNames.Add(114, "Golem");
            monsterNames.Add(11411, "Kuhn");
            monsterNames.Add(11412, "Kugo");
            monsterNames.Add(11413, "Ragion");
            monsterNames.Add(11414, "Groggo");
            monsterNames.Add(11415, "Maggi");

            monsterNames.Add(115, "Griffon");
            monsterNames.Add(11511, "Kahn");
            monsterNames.Add(11512, "Spectra");
            monsterNames.Add(11513, "Bernard");
            monsterNames.Add(11514, "Shamann");
            monsterNames.Add(11515, "Varus");

            monsterNames.Add(116, "Undine");
            monsterNames.Add(11611, "Mikene");
            monsterNames.Add(11612, "Atenai");
            monsterNames.Add(11613, "Delphoi");
            monsterNames.Add(11614, "Icasha");
            monsterNames.Add(11615, "Tilasha");

            monsterNames.Add(117, "Inferno");
            monsterNames.Add(11711, "Purian");
            monsterNames.Add(11712, "Tagaros");
            monsterNames.Add(11713, "Anduril");
            monsterNames.Add(11714, "Eludain");
            monsterNames.Add(11715, "Drogan");

            monsterNames.Add(118, "Sylph");
            monsterNames.Add(11811, "Tyron");
            monsterNames.Add(11812, "Baretta");
            monsterNames.Add(11813, "Shimitae");
            monsterNames.Add(11814, "Eredas");
            monsterNames.Add(11815, "Aschubel");

            monsterNames.Add(119, "Sylphid");
            monsterNames.Add(11911, "Lumirecia");
            monsterNames.Add(11912, "Fria");
            monsterNames.Add(11913, "Acasis");
            monsterNames.Add(11914, "Mihael");
            monsterNames.Add(11915, "Icares");

            monsterNames.Add(120, "High Elemental");
            monsterNames.Add(12011, "Ellena");
            monsterNames.Add(12012, "Kahli");
            monsterNames.Add(12013, "Moria");
            monsterNames.Add(12014, "Shren");
            monsterNames.Add(12015, "Jumaline");

            monsterNames.Add(121, "Harpu");
            monsterNames.Add(12111, "Sisroo");
            monsterNames.Add(12112, "Colleen");
            monsterNames.Add(12113, "Seal");
            monsterNames.Add(12114, "Sia");
            monsterNames.Add(12115, "Seren");
           
            monsterNames.Add(122, "Slime");
            monsterNames.Add(12211, "");
            monsterNames.Add(12212, "");
            monsterNames.Add(12213, "");
            monsterNames.Add(12214, "");
            monsterNames.Add(12215, "");
           
            monsterNames.Add(123, "Forest Keeper");
            monsterNames.Add(12311, "");
            monsterNames.Add(12312, "");
            monsterNames.Add(12313, "");
            monsterNames.Add(12314, "");
            monsterNames.Add(12315, "");
           
            monsterNames.Add(124, "Mushroom");
            monsterNames.Add(12411, "");
            monsterNames.Add(12412, "");
            monsterNames.Add(12413, "");
            monsterNames.Add(12414, "");
            monsterNames.Add(12415, "");
           
            monsterNames.Add(125, "Maned Boar");
            monsterNames.Add(12511, "");
            monsterNames.Add(12512, "");
            monsterNames.Add(12513, "");
            monsterNames.Add(12514, "");
            monsterNames.Add(12515, "");
           
            monsterNames.Add(126, "Monster Flower");
            monsterNames.Add(12611, "");
            monsterNames.Add(12612, "");
            monsterNames.Add(12613, "");
            monsterNames.Add(12614, "");
            monsterNames.Add(12615, "");
           
            monsterNames.Add(127, "Ghost");
            monsterNames.Add(12711, "");
            monsterNames.Add(12712, "");
            monsterNames.Add(12713, "");
            monsterNames.Add(12714, "");
            monsterNames.Add(12715, "");
           
            monsterNames.Add(128, "Low Elemental");
            monsterNames.Add(12811, "Tigresse");
            monsterNames.Add(12812, "Lamor");
            monsterNames.Add(12813, "Samour");
            monsterNames.Add(12814, "Varis");
            monsterNames.Add(12815, "Havana");
           
            monsterNames.Add(129, "Mimick");
            monsterNames.Add(12911, "");
            monsterNames.Add(12912, "");
            monsterNames.Add(12913, "");
            monsterNames.Add(12914, "");
            monsterNames.Add(12915, "");
           
            monsterNames.Add(130, "Horned Frog");
            monsterNames.Add(13011, "");
            monsterNames.Add(13012, "");
            monsterNames.Add(13013, "");
            monsterNames.Add(13014, "");
            monsterNames.Add(13015, "");
           
            monsterNames.Add(131, "Sandman");
            monsterNames.Add(13111, "");
            monsterNames.Add(13112, "");
            monsterNames.Add(13113, "");
            monsterNames.Add(13114, "");
            monsterNames.Add(13115, "");
           
            monsterNames.Add(132, "Howl");
            monsterNames.Add(13211, "Lulu");
            monsterNames.Add(13212, "Lala");
            monsterNames.Add(13213, "Chichi");
            monsterNames.Add(13214, "Shushu");
            monsterNames.Add(13215, "Chacha");
           
            monsterNames.Add(133, "Succubus");
            monsterNames.Add(13311, "Izaria");
            monsterNames.Add(13312, "Akia");
            monsterNames.Add(13313, "Selena");
            monsterNames.Add(13314, "Aria");
            monsterNames.Add(13315, "Isael");
           
            monsterNames.Add(134, "Joker");
            monsterNames.Add(13411, "Sian");
            monsterNames.Add(13412, "Jojo");
            monsterNames.Add(13413, "Lushen");
            monsterNames.Add(13414, "Figaro");
            monsterNames.Add(13415, "Liebli");
           
            monsterNames.Add(135, "Ninja");
            monsterNames.Add(13511, "Susano");
            monsterNames.Add(13512, "Garo");
            monsterNames.Add(13513, "Orochi");
            monsterNames.Add(13514, "Gin");
            monsterNames.Add(13515, "Han");
           
            monsterNames.Add(136, "Surprise Box");
            monsterNames.Add(13611, "");
            monsterNames.Add(13612, "");
            monsterNames.Add(13613, "");
            monsterNames.Add(13614, "");
            monsterNames.Add(13615, "");
           
            monsterNames.Add(137, "Bearman");
            monsterNames.Add(13711, "Gruda");
            monsterNames.Add(13712, "Kungen");
            monsterNames.Add(13713, "Dagorr");
            monsterNames.Add(13714, "Ahman");
            monsterNames.Add(13715, "Haken");
           
            monsterNames.Add(138, "Valkyrja");
            monsterNames.Add(13811, "Camilla");
            monsterNames.Add(13812, "Vanessa");
            monsterNames.Add(13813, "Katarina");
            monsterNames.Add(13814, "Akroma");
            monsterNames.Add(13815, "Trinity");
           
            monsterNames.Add(139, "Pierret");
            monsterNames.Add(13911, "Julie");
            monsterNames.Add(13912, "Clara");
            monsterNames.Add(13913, "Sophia");
            monsterNames.Add(13914, "Eva");
            monsterNames.Add(13915, "Luna");
           
            monsterNames.Add(140, "Werewolf");
            monsterNames.Add(14011, "Vigor");
            monsterNames.Add(14012, "Garoche");
            monsterNames.Add(14013, "Shakan");
            monsterNames.Add(14014, "Eshir");
            monsterNames.Add(14015, "Jultan");
           
            monsterNames.Add(141, "Phantom Thief");
            monsterNames.Add(14111, "Luer");
            monsterNames.Add(14112, "Jean");
            monsterNames.Add(14113, "Julien");
            monsterNames.Add(14114, "Louis");
            monsterNames.Add(14115, "Guillaume");
           
            monsterNames.Add(142, "Angelmon");
            monsterNames.Add(14211, "Blue Angelmon");
            monsterNames.Add(14212, "Red Angelmon");
            monsterNames.Add(14213, "Gold Angelmon");
            monsterNames.Add(14214, "White Angelmon");
            monsterNames.Add(14215, "Dark Angelmon");
           
            monsterNames.Add(144, "Dragon");
            monsterNames.Add(14411, "Verad");
            monsterNames.Add(14412, "Zaiross");
            monsterNames.Add(14413, "Jamire");
            monsterNames.Add(14414, "Zerath");
            monsterNames.Add(14415, "Grogen");
           
            monsterNames.Add(145, "Phoenix");
            monsterNames.Add(14511, "Sigmarus");
            monsterNames.Add(14512, "Perna");
            monsterNames.Add(14513, "Teshar");
            monsterNames.Add(14514, "Eludia");
            monsterNames.Add(14515, "Jaara");
           
            monsterNames.Add(146, "Chimera");
            monsterNames.Add(14611, "Taor");
            monsterNames.Add(14612, "Rakan");
            monsterNames.Add(14613, "Lagmaron");
            monsterNames.Add(14614, "Shan");
            monsterNames.Add(14615, "Zeratu");
           
            monsterNames.Add(147, "Vampire");
            monsterNames.Add(14711, "Liesel");
            monsterNames.Add(14712, "Verdehile");
            monsterNames.Add(14713, "Argen");
            monsterNames.Add(14714, "Julianne");
            monsterNames.Add(14715, "Cadiz");
            monsterNames.Add(
                                     148, "Viking");
            monsterNames.Add(14811, "Huga");
            monsterNames.Add(14812, "Geoffrey");
            monsterNames.Add(14813, "Walter");
            monsterNames.Add(14814, "Jansson");
            monsterNames.Add(14815, "Janssen");
           
            monsterNames.Add(149, "Amazon");
            monsterNames.Add(14911, "Ellin");
            monsterNames.Add(14912, "Ceres");
            monsterNames.Add(14913, "Hina");
            monsterNames.Add(14914, "Lyn");
            monsterNames.Add(14915, "Mara");
           
            monsterNames.Add(150, "Martial Cat");
            monsterNames.Add(15011, "Mina");
            monsterNames.Add(15012, "Mei");
            monsterNames.Add(15013, "Naomi");
            monsterNames.Add(15014, "Xiao Ling");
            monsterNames.Add(15015, "Miho");
           
            monsterNames.Add(152, "Vagabond");
            monsterNames.Add(15211, "Allen");
            monsterNames.Add(15212, "Kai'en");
            monsterNames.Add(15213, "Roid");
            monsterNames.Add(15214, "Darion");
            monsterNames.Add(15215, "Jubelle");
     
            monsterNames.Add(153, "Epikion Priest");
            monsterNames.Add(15311, "Rina");
            monsterNames.Add(15312, "Chloe");
            monsterNames.Add(15313, "Michelle");
            monsterNames.Add(15314, "Iona");
            monsterNames.Add(15315, "Rasheed");
           
            monsterNames.Add(154, "Magical Archer");
            monsterNames.Add(15411, "Sharron");
            monsterNames.Add(15412, "Cassandra");
            monsterNames.Add(15413, "Ardella");
            monsterNames.Add(15414, "Chris");
            monsterNames.Add(15415, "Bethony");
           
            monsterNames.Add(155, "Rakshasa");
            monsterNames.Add(15511, "Su");
            monsterNames.Add(15512, "Hwa");
            monsterNames.Add(15513, "Yen");
            monsterNames.Add(15514, "Pang");
            monsterNames.Add(15515, "Ran");
           
            monsterNames.Add(156, "Bounty Hunter");
            monsterNames.Add(15611, "Wayne");
            monsterNames.Add(15612, "Randy");
            monsterNames.Add(15613, "Roger");
            monsterNames.Add(15614, "Walkers");
            monsterNames.Add(15615, "Jamie");
           
            monsterNames.Add(157, "Oracle");
            monsterNames.Add(15711, "Praha");
            monsterNames.Add(15712, "Juno");
            monsterNames.Add(15713, "Seara");
            monsterNames.Add(15714, "Laima");
            monsterNames.Add(15715, "Giana");
           
            monsterNames.Add(158, "Imp Champion");
            monsterNames.Add(15811, "Yaku");
            monsterNames.Add(15812, "Fairo");
            monsterNames.Add(15813, "Pigma");
            monsterNames.Add(15814, "Shaffron");
            monsterNames.Add(15815, "Loque");
           
            monsterNames.Add(159, "Mystic Witch");
            monsterNames.Add(15911, "Megan");
            monsterNames.Add(15912, "Rebecca");
            monsterNames.Add(15913, "Silia");
            monsterNames.Add(15914, "Linda");
            monsterNames.Add(15915, "Gina");
           
            monsterNames.Add(160, "Grim Reaper");
            monsterNames.Add(16011, "Hemos");
            monsterNames.Add(16012, "Sath");
            monsterNames.Add(16013, "Hiva");
            monsterNames.Add(16014, "Prom");
            monsterNames.Add(16015, "Thrain");
           
            monsterNames.Add(161, "Occult Girl");
            monsterNames.Add(16111, "Anavel");
            monsterNames.Add(16112, "Rica");
            monsterNames.Add(16113, "Charlotte");
            monsterNames.Add(16114, "Lora");
            monsterNames.Add(16115, "Nicki");
           
            monsterNames.Add(162, "Death Knight");
            monsterNames.Add(16211, "Fedora");
            monsterNames.Add(16212, "Arnold");
            monsterNames.Add(16213, "Briand");
            monsterNames.Add(16214, "Conrad");
            monsterNames.Add(16215, "Dias");
           
            monsterNames.Add(163, "Lich");
            monsterNames.Add(16311, "Rigel");
            monsterNames.Add(16312, "Antares");
            monsterNames.Add(16313, "Fuco");
            monsterNames.Add(16314, "Halphas");
            monsterNames.Add(16315, "Grego");
           
            monsterNames.Add(164, "Skull Soldier");
            monsterNames.Add(16411, "");
            monsterNames.Add(16412, "");
            monsterNames.Add(16413, "");
            monsterNames.Add(16414, "");
            monsterNames.Add(16415, "");
           
            monsterNames.Add(165, "Living Armor");
            monsterNames.Add(16511, "Nickel");
            monsterNames.Add(16512, "Iron");
            monsterNames.Add(16513, "Copper");
            monsterNames.Add(16514, "Silver");
            monsterNames.Add(16515, "Zinc");
           
            monsterNames.Add(166, "Dragon Knight");
            monsterNames.Add(16611, "Chow");
            monsterNames.Add(16612, "Laika");
            monsterNames.Add(16613, "Leo");
            monsterNames.Add(16614, "Jager");
            monsterNames.Add(16615, "Ragdoll");
           
            monsterNames.Add(167, "Magical Archer Promo");
            monsterNames.Add(16711, "");
            monsterNames.Add(16712, "");
            monsterNames.Add(16713, "");
            monsterNames.Add(16714, "Fami");
            monsterNames.Add(16715, "");
           
            monsterNames.Add(168, "Monkey King");
            monsterNames.Add(16811, "Shi Hou");
            monsterNames.Add(16812, "Mei Hou Wang");
            monsterNames.Add(16813, "Xing Zhe");
            monsterNames.Add(16814, "Qitian Dasheng");
            monsterNames.Add(16815, "Son Zhang Lao");
           
            monsterNames.Add(169, "Samurai");
            monsterNames.Add(16911, "Kaz");
            monsterNames.Add(16912, "Jun");
            monsterNames.Add(16913, "Kaito");
            monsterNames.Add(16914, "Tosi");
            monsterNames.Add(16915, "Sige");
           
            monsterNames.Add(170, "Archangel");
            monsterNames.Add(17011, "Ariel");
            monsterNames.Add(17012, "Velajuel");
            monsterNames.Add(17013, "Eladriel");
            monsterNames.Add(17014, "Artamiel");
            monsterNames.Add(17015, "Fermion");
           
            monsterNames.Add(172, "Drunken Master");
            monsterNames.Add(17211, "Mao");
            monsterNames.Add(17212, "Xiao Chun");
            monsterNames.Add(17213, "Huan");
            monsterNames.Add(17214, "Tien Qin");
            monsterNames.Add(17215, "Wei Shin");
           
            monsterNames.Add(173, "Kung Fu Girl");
            monsterNames.Add(17311, "Xiao Lin");
            monsterNames.Add(17312, "Hong Hua");
            monsterNames.Add(17313, "Ling Ling");
            monsterNames.Add(17314, "Liu Mei");
            monsterNames.Add(17315, "Fei");
           
            monsterNames.Add(174, "Beast Monk");
            monsterNames.Add(17411, "Chandra");
            monsterNames.Add(17412, "Kumar");
            monsterNames.Add(17413, "Ritesh");
            monsterNames.Add(17414, "Shazam");
            monsterNames.Add(17415, "Rahul");
           
            monsterNames.Add(175, "Mischievous Bat");
            monsterNames.Add(17511, "");
            monsterNames.Add(17512, "");
            monsterNames.Add(17513, "");
            monsterNames.Add(17514, "");
            monsterNames.Add(17515, "");
           
            monsterNames.Add(176, "Battle Scorpion");
            monsterNames.Add(17611, "");
            monsterNames.Add(17612, "");
            monsterNames.Add(17613, "");
            monsterNames.Add(17614, "");
            monsterNames.Add(17615, "");
           
            monsterNames.Add(177, "Minotauros");
            monsterNames.Add(17711, "Urtau");
            monsterNames.Add(17712, "Burentau");
            monsterNames.Add(17713, "Eintau");
            monsterNames.Add(17714, "Grotau");
            monsterNames.Add(17715, "Kamatau");
           
            monsterNames.Add(178, "Lizardman");
            monsterNames.Add(17811, "Kernodon");
            monsterNames.Add(17812, "Igmanodon");
            monsterNames.Add(17813, "Velfinodon");
            monsterNames.Add(17814, "Glinodon");
            monsterNames.Add(17815, "Devinodon");
           
            monsterNames.Add(179, "Hell Lady");
            monsterNames.Add(17911, "Beth");
            monsterNames.Add(17912, "Raki");
            monsterNames.Add(17913, "Ethna");
            monsterNames.Add(17914, "Asima");
            monsterNames.Add(17915, "Craka");
           
            monsterNames.Add(180, "Brownie Magician");
            monsterNames.Add(18011, "Orion");
            monsterNames.Add(18012, "Draco");
            monsterNames.Add(18013, "Aquila");
            monsterNames.Add(18014, "Gemini");
            monsterNames.Add(18015, "Korona");
           
            monsterNames.Add(181, "Kobold Bomber");
            monsterNames.Add(18111, "Malaka");
            monsterNames.Add(18112, "Zibrolta");
            monsterNames.Add(18113, "Taurus");
            monsterNames.Add(18114, "Dover");
            monsterNames.Add(18115, "Bering");
           
            monsterNames.Add(182, "King Angelmon");
            monsterNames.Add(18211, "Blue King Angelmon");
            monsterNames.Add(18212, "Red King Angelmon");
            monsterNames.Add(18213, "Gold King Angelmon");
            monsterNames.Add(18214, "White King Angelmon");
            monsterNames.Add(18215, "Dark King Angelmon");
           
            monsterNames.Add(183, "Sky Dancer");
            monsterNames.Add(18311, "Mihyang");
            monsterNames.Add(18312, "Hwahee");
            monsterNames.Add(18313, "Chasun");
            monsterNames.Add(18314, "Yeonhong");
            monsterNames.Add(18315, "Wolyung");
           
            monsterNames.Add(184, "Taoist");
            monsterNames.Add(18411, "Gildong");
            monsterNames.Add(18412, "Gunpyeong");
            monsterNames.Add(18413, "Woochi");
            monsterNames.Add(18414, "Hwadam");
            monsterNames.Add(18415, "Woonhak");
           
            monsterNames.Add(185, "Beast Hunter");
            monsterNames.Add(18511, "Gangchun");
            monsterNames.Add(18512, "Nangrim");
            monsterNames.Add(18513, "Suri");
            monsterNames.Add(18514, "Baekdu");
            monsterNames.Add(18515, "Hannam");
           
            monsterNames.Add(186, "Pioneer");
            monsterNames.Add(18611, "Woosa");
            monsterNames.Add(18612, "Chiwu");
            monsterNames.Add(18613, "Pungbaek");
            monsterNames.Add(18614, "Nigong");
            monsterNames.Add(18615, "Woonsa");
           
            monsterNames.Add(187, "Penguin Knight");
            monsterNames.Add(18711, "Toma");
            monsterNames.Add(18712, "Naki");
            monsterNames.Add(18713, "Mav");
            monsterNames.Add(18714, "Dona");
            monsterNames.Add(18715, "Kuna");
           
            monsterNames.Add(188, "Barbaric King");
            monsterNames.Add(18811, "Aegir");
            monsterNames.Add(18812, "Surtr");
            monsterNames.Add(18813, "Hraesvelg");
            monsterNames.Add(18814, "Mimirr");
            monsterNames.Add(18815, "Hrungnir");
           
            monsterNames.Add(189, "Polar Queen");
            monsterNames.Add(18911, "Alicia");
            monsterNames.Add(18912, "Brandia");
            monsterNames.Add(18913, "Tiana");
            monsterNames.Add(18914, "Elenoa");
            monsterNames.Add(18915, "Lydia");
           
            monsterNames.Add(190, "Battle Mammoth");
            monsterNames.Add(19011, "Talc");
            monsterNames.Add(19012, "Granite");
            monsterNames.Add(19013, "Olivine");
            monsterNames.Add(19014, "Marble");
            monsterNames.Add(19015, "Basalt");
           
            monsterNames.Add(191, "Fairy Queen");
            monsterNames.Add(19111, "");
            monsterNames.Add(19112, "");
            monsterNames.Add(19113, "");
            monsterNames.Add(19114, "Fran");
            monsterNames.Add(19115, "");
           
            monsterNames.Add(192, "Ifrit");
            monsterNames.Add(19211, "Theomars");
            monsterNames.Add(19212, "Tesarion");
            monsterNames.Add(19213, "Akhamamir");
            monsterNames.Add(19214, "Elsharion");
            monsterNames.Add(19215, "Veromos");
           
            monsterNames.Add(193, "Cow Girl");
            monsterNames.Add(19311, "Sera");
            monsterNames.Add(19312, "Anne");
            monsterNames.Add(19313, "Hannah");
            monsterNames.Add(19314, "Loren");
            monsterNames.Add(19315, "Cassie");
           
            monsterNames.Add(194, "Pirate Captain");
            monsterNames.Add(19411, "Galleon");
            monsterNames.Add(19412, "Carrack");
            monsterNames.Add(19413, "Barque");
            monsterNames.Add(19414, "Brig");
            monsterNames.Add(19415, "Frigate");
           
            monsterNames.Add(195, "Charger Shark");
            monsterNames.Add(19511, "Aqcus");
            monsterNames.Add(19512, "Ignicus");
            monsterNames.Add(19513, "Zephicus");
            monsterNames.Add(19514, "Rumicus");
            monsterNames.Add(19515, "Calicus");
           
            monsterNames.Add(196, "Mermaid");
            monsterNames.Add(19611, "Tetra");
            monsterNames.Add(19612, "Platy");
            monsterNames.Add(19613, "Cichlid");
            monsterNames.Add(19614, "Molly");
            monsterNames.Add(19615, "Betta");
           
            monsterNames.Add(197, "Sea Emperor");
            monsterNames.Add(19711, "Poseidon");
            monsterNames.Add(19712, "Okeanos");
            monsterNames.Add(19713, "Triton");
            monsterNames.Add(19714, "Pontos");
            monsterNames.Add(19715, "Manannan");
           
            monsterNames.Add(198, "Magic Knight");
            monsterNames.Add(19811, "Lapis");
            monsterNames.Add(19812, "Astar");
            monsterNames.Add(19813, "Lupinus");
            monsterNames.Add(19814, "Iris");
            monsterNames.Add(19815, "Lanett");
           
            monsterNames.Add(199, "Assassin");
            monsterNames.Add(19911, "Stella");
            monsterNames.Add(19912, "Lexy");
            monsterNames.Add(19913, "Tanya");
            monsterNames.Add(19914, "Natalie");
            monsterNames.Add(19915, "Isabelle");
           
            monsterNames.Add(200, "Neostone Fighter");
            monsterNames.Add(20011, "Ryan");
            monsterNames.Add(20012, "Trevor");
            monsterNames.Add(20013, "Logan");
            monsterNames.Add(20014, "Lucas");
            monsterNames.Add(20015, "Karl");
           
            monsterNames.Add(201, "Neostone Agent");
            monsterNames.Add(20111, "Emma");
            monsterNames.Add(20112, "Lisa");
            monsterNames.Add(20113, "Olivia");
            monsterNames.Add(20114, "Illiana");
            monsterNames.Add(20115, "Sylvia");
           
            monsterNames.Add(202, "Martial Artist");
            monsterNames.Add(20211, "Luan");
            monsterNames.Add(20212, "Sin");
            monsterNames.Add(20213, "Lo");
            monsterNames.Add(20214, "Hiro");
            monsterNames.Add(20215, "Jackie");
           
            monsterNames.Add(203, "Mummy");
            monsterNames.Add(20311, "Nubia");
            monsterNames.Add(20312, "Sonora");
            monsterNames.Add(20313, "Namib");
            monsterNames.Add(20314, "Sahara");
            monsterNames.Add(20315, "Karakum");
           
            monsterNames.Add(204, "Anubis");
            monsterNames.Add(20411, "Avaris");
            monsterNames.Add(20412, "Khmun");
            monsterNames.Add(20413, "Iunu");
            monsterNames.Add(20414, "Amarna");
            monsterNames.Add(20415, "Thebae");
           
            monsterNames.Add(205, "Desert Queen");
            monsterNames.Add(20511, "Bastet");
            monsterNames.Add(20512, "Sekhmet");
            monsterNames.Add(20513, "Hathor");
            monsterNames.Add(20514, "Isis");
            monsterNames.Add(20515, "Nephthys");
           
            monsterNames.Add(206, "Horus");
            monsterNames.Add(20611, "Qebehsenuef");
            monsterNames.Add(20612, "Duamutef");
            monsterNames.Add(20613, "Imesety");
            monsterNames.Add(20614, "Wedjat");
            monsterNames.Add(20615, "Amduat");
           
            monsterNames.Add(207, "Jack-o'-lantern");
            monsterNames.Add(20711, "Chilling");
            monsterNames.Add(20712, "Smokey");
            monsterNames.Add(20713, "Windy");
            monsterNames.Add(20714, "Misty");
            monsterNames.Add(20715, "Dusky");
           
            monsterNames.Add(208, "Frankenstein");
            monsterNames.Add(20811, "Tractor");
            monsterNames.Add(20812, "Bulldozer");
            monsterNames.Add(20813, "Crane");
            monsterNames.Add(20814, "Driller");
            monsterNames.Add(20815, "Crawler");
           
            monsterNames.Add(209, "Elven Ranger");
            monsterNames.Add(20911, "Eluin");
            monsterNames.Add(20912, "Adrian");
            monsterNames.Add(20913, "Erwin");
            monsterNames.Add(20914, "Lucien");
            monsterNames.Add(20915, "Isillen");
           
            monsterNames.Add(210, "Harg");
            monsterNames.Add(21011, "Remy");
            monsterNames.Add(21012, "Racuni");
            monsterNames.Add(21013, "Raviti");
            monsterNames.Add(21014, "Dova");
            monsterNames.Add(21015, "Kroa");
           
            monsterNames.Add(211, "Fairy King");
            monsterNames.Add(21111, "Psamathe");
            monsterNames.Add(21112, "Daphnis");
            monsterNames.Add(21113, "Ganymede");
            monsterNames.Add(21114, "Oberon");
            monsterNames.Add(21115, "Nyx");
           
            monsterNames.Add(212, "Panda Warrior");
            monsterNames.Add(21211, "Mo Long");
            monsterNames.Add(21212, "Xiong Fei");
            monsterNames.Add(21213, "Feng Yan");
            monsterNames.Add(21214, "Tian Lang");
            monsterNames.Add(21215, "Mi Ying");
           
            monsterNames.Add(213, "Dice Magician");
            monsterNames.Add(21311, "Reno");
            monsterNames.Add(21312, "Ludo");
            monsterNames.Add(21313, "Morris");
            monsterNames.Add(21314, "Tablo");
            monsterNames.Add(21315, "Monte");
           
            monsterNames.Add(214, "Harp Magician");
            monsterNames.Add(21411, "Sonnet");
            monsterNames.Add(21412, "Harmonia");
            monsterNames.Add(21413, "Triana");
            monsterNames.Add(21414, "Celia");
            monsterNames.Add(21415, "Vivachel");
           
            monsterNames.Add(215, "Unicorn");
            monsterNames.Add(21511, "Amelia");
            monsterNames.Add(21512, "Helena");
            monsterNames.Add(21513, "Diana");
            monsterNames.Add(21514, "Eleanor");
            monsterNames.Add(21515, "Alexandra");
            monsterNames.Add(21611, "Amelia");
            monsterNames.Add(21612, "Helena");
            monsterNames.Add(21613, "Diana");
            monsterNames.Add(21614, "Eleanor");
            monsterNames.Add(21615, "Alexandra");
           
            monsterNames.Add(218, "Paladin");
            monsterNames.Add(21811, "Josephine");
            monsterNames.Add(21812, "Ophilia");
            monsterNames.Add(21813, "Louise");
            monsterNames.Add(21814, "Jeanne");
            monsterNames.Add(21815, "Leona");
           
            monsterNames.Add(219, "Chakram Dancer");
            monsterNames.Add(21911, "Talia");
            monsterNames.Add(21912, "Shaina");
            monsterNames.Add(21913, "Melissa");
            monsterNames.Add(21914, "Deva");
            monsterNames.Add(21915, "Belita");
           
            monsterNames.Add(220, "Boomerang Warrior");
            monsterNames.Add(22011, "Sabrina");
            monsterNames.Add(22012, "Maruna");
            monsterNames.Add(22013, "Zenobia");
            monsterNames.Add(22014, "Bailey");
            monsterNames.Add(22015, "Martina");
           
            monsterNames.Add(221, "Dryad");
            monsterNames.Add(22111, "Herne");
            monsterNames.Add(22112, "Nisha");
            monsterNames.Add(22113, "Mellia");
            monsterNames.Add(22114, "Felleria");
            monsterNames.Add(22115, "Hyanes");
           
            monsterNames.Add(222, "Druid");
            monsterNames.Add(22211, "Abellio");
            monsterNames.Add(22212, "Bellenus");
            monsterNames.Add(22213, "Taranys");
            monsterNames.Add(22214, "Valantis");
            monsterNames.Add(22215, "Pater");
            monsterNames.Add(22311, "Abellio");
            monsterNames.Add(22312, "Bellenus");
            monsterNames.Add(22313, "Taranys");
            monsterNames.Add(22314, "Valantis");
            monsterNames.Add(22315, "Pater");
           
            monsterNames.Add(224, "Giant Warrior");
            monsterNames.Add(22411, "Bagir");
            monsterNames.Add(22412, "Vidurr");
            monsterNames.Add(22413, "Skogul");
            monsterNames.Add(22414, "Einheri");
            monsterNames.Add(22415, "Trasar");
            monsterNames.Add(22513, "Skogul");
            monsterNames.Add(22515, "Trasar");
           
            monsterNames.Add(226, "Lightning Emperor");
            monsterNames.Add(22611, "Bolverk");
            monsterNames.Add(22612, "Baleygr");
            monsterNames.Add(22613, "Odin");
            monsterNames.Add(22614, "Geldnir");
            monsterNames.Add(22615, "Herteit");
           
            monsterNames.Add(227, "Sniper Mk.I");
            monsterNames.Add(22711, "Covenant");
            monsterNames.Add(22712, "Carcano");
            monsterNames.Add(22713, "Carbine");
            monsterNames.Add(22714, "Magnum");
            monsterNames.Add(22715, "Dragunov");
            monsterNames.Add(228, "Sniper Mk.I");
            monsterNames.Add(22812, "Carcano");
            monsterNames.Add(22813, "Carbine");
            monsterNames.Add(22815, "Dragunov");
           
            monsterNames.Add(229, "Cannon Girl");
            monsterNames.Add(22911, "Abigail");
            monsterNames.Add(22912, "Scarlett");
            monsterNames.Add(22913, "Christina");
            monsterNames.Add(22914, "Emily");
            monsterNames.Add(22915, "Bella");
     
            monsterNames.Add(23005, "Vampire Lord");
            monsterNames.Add(23015, "Eirgar");

            monsterNames.Add(15105, "Devilmon");
            monsterNames.Add(14314, "Rainbowmon");

            monsterNames.Add(1000111, "Homunculus - Attack (Water)");
            monsterNames.Add(1000112, "Homunculus - Attack (Fire)");
            monsterNames.Add(1000113, "Homunculus - Attack (Wind)");
            monsterNames.Add(1000214, "Homunculus - Support (Light)");
            monsterNames.Add(1000215, "Homunculus - Support (Dark)");
            #endregion

            #region Rune Effect Types
            runeEffectTypes.Add(0, "");
            runeEffectTypes.Add(1, "HP flat");
            runeEffectTypes.Add(2, "HP%");
            runeEffectTypes.Add(3, "ATK flat");
            runeEffectTypes.Add(4, "ATK%");
            runeEffectTypes.Add(5, "DEF flat");
            runeEffectTypes.Add(6, "DEF%");
            runeEffectTypes.Add(8, "SPD");
            runeEffectTypes.Add(9, "CRate");
            runeEffectTypes.Add(10, "CDmg");
            runeEffectTypes.Add(11, "RES");
            runeEffectTypes.Add(12, "ACC");
            #endregion
        }
        #endregion

        #region Properties
        private Dictionary<int, string> monsterAttributes = new Dictionary<int, string>();
        private Dictionary<int, string> monsterNames = new Dictionary<int, string>();
        private Dictionary<int, string> runeEffectTypes = new Dictionary<int, string>(); 
        #endregion


        #region Methods
        public string GetMonsterAttribute(int id)
        {
            if (monsterAttributes.ContainsKey(id))
            {
                return monsterAttributes[id];
            }
            return "Unknown Monster's Attribute";
        }

        public string GetMonsterName(int id)
        {
            if (monsterNames.ContainsKey(id))
            {
                return monsterNames[id];
            }
            return "Unknown Monster";
        }

        public string GetRuneEffectType(int id)
        {
            if (runeEffectTypes.ContainsKey(id))
            {
                return runeEffectTypes[id];
            }
            return "Unknown Rune Effect Type";

        }
        #endregion
    }
}
