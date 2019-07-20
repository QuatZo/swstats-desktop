using System;
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

            monsterNames.Add(148, "Viking");
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

            // Think about doing fuseable and HoH monsters lists, it'll be easier to maintain in the future
            #region Monster Base Class
            monsterBaseClass.Add(10111, 3);
            monsterBaseClass.Add(10112, 3);
            monsterBaseClass.Add(10113, 2);
            monsterBaseClass.Add(10114, 3);
            monsterBaseClass.Add(10115, 2);
            monsterBaseClass.Add(10131, 3);
            monsterBaseClass.Add(10132, 3);
            monsterBaseClass.Add(10133, 2);
            monsterBaseClass.Add(10134, 3);
            monsterBaseClass.Add(10135, 2);

            monsterBaseClass.Add(10211, 2);
            monsterBaseClass.Add(10212, 2);
            monsterBaseClass.Add(10213, 2);
            monsterBaseClass.Add(10214, 2);
            monsterBaseClass.Add(10215, 2);

            monsterBaseClass.Add(10311, 2);
            monsterBaseClass.Add(10312, 2);
            monsterBaseClass.Add(10313, 2);
            monsterBaseClass.Add(10314, 2);
            monsterBaseClass.Add(10315, 2);
            monsterBaseClass.Add(10331, 2);
            monsterBaseClass.Add(10332, 2);
            monsterBaseClass.Add(10333, 2);
            monsterBaseClass.Add(10334, 2);
            monsterBaseClass.Add(10335, 2);

            monsterBaseClass.Add(10411, 2);
            monsterBaseClass.Add(10412, 2);
            monsterBaseClass.Add(10413, 2);
            monsterBaseClass.Add(10414, 2);
            monsterBaseClass.Add(10415, 3);

            monsterBaseClass.Add(10511, 3);
            monsterBaseClass.Add(10512, 3);
            monsterBaseClass.Add(10513, 3);
            monsterBaseClass.Add(10514, 3);
            monsterBaseClass.Add(10515, 3);

            monsterBaseClass.Add(10611, 2);
            monsterBaseClass.Add(10612, 2);
            monsterBaseClass.Add(10613, 2);
            monsterBaseClass.Add(10614, 2);
            monsterBaseClass.Add(10615, 3);

            monsterBaseClass.Add(10711, 3);
            monsterBaseClass.Add(10712, 2);
            monsterBaseClass.Add(10713, 2);
            monsterBaseClass.Add(10714, 2);
            monsterBaseClass.Add(10715, 2);
            monsterBaseClass.Add(10731, 3);
            monsterBaseClass.Add(10732, 2);
            monsterBaseClass.Add(10733, 2);
            monsterBaseClass.Add(10734, 2);
            monsterBaseClass.Add(10735, 2);

            monsterBaseClass.Add(10811, 2);
            monsterBaseClass.Add(10812, 2);
            monsterBaseClass.Add(10813, 2);
            monsterBaseClass.Add(10814, 3);
            monsterBaseClass.Add(10815, 3);

            monsterBaseClass.Add(10911, 2);
            monsterBaseClass.Add(10912, 2);
            monsterBaseClass.Add(10913, 2);
            monsterBaseClass.Add(10914, 3);
            monsterBaseClass.Add(10915, 2);

            monsterBaseClass.Add(11011, 3);
            monsterBaseClass.Add(11012, 3);
            monsterBaseClass.Add(11013, 3);
            monsterBaseClass.Add(11014, 3);
            monsterBaseClass.Add(11015, 3);
            monsterBaseClass.Add(11031, 3);
            monsterBaseClass.Add(11032, 3);
            monsterBaseClass.Add(11033, 3);
            monsterBaseClass.Add(11034, 3);
            monsterBaseClass.Add(11035, 3);

            monsterBaseClass.Add(11111, 2);
            monsterBaseClass.Add(11112, 3);
            monsterBaseClass.Add(11113, 2);
            monsterBaseClass.Add(11114, 2);
            monsterBaseClass.Add(11115, 2);

            monsterBaseClass.Add(11211, 4);
            monsterBaseClass.Add(11212, 4);
            monsterBaseClass.Add(11213, 4);
            monsterBaseClass.Add(11214, 4);
            monsterBaseClass.Add(11215, 14);

            monsterBaseClass.Add(11311, 3);
            monsterBaseClass.Add(11312, 3);
            monsterBaseClass.Add(11313, 3);
            monsterBaseClass.Add(11314, 3);
            monsterBaseClass.Add(11315, 3);

            monsterBaseClass.Add(11411, 3);
            monsterBaseClass.Add(11412, 3);
            monsterBaseClass.Add(11413, 3);
            monsterBaseClass.Add(11414, 3);
            monsterBaseClass.Add(11415, 3);

            monsterBaseClass.Add(11511, 3);
            monsterBaseClass.Add(11512, 3);
            monsterBaseClass.Add(11513, 3);
            monsterBaseClass.Add(11514, 3);
            monsterBaseClass.Add(11515, 3);

            monsterBaseClass.Add(11611, 4);
            monsterBaseClass.Add(11612, 4);
            monsterBaseClass.Add(11613, 4);
            monsterBaseClass.Add(11614, 14);
            monsterBaseClass.Add(11615, 14);

            monsterBaseClass.Add(11711, 3);
            monsterBaseClass.Add(11712, 3);
            monsterBaseClass.Add(11713, 3);
            monsterBaseClass.Add(11714, 3);
            monsterBaseClass.Add(11715, 3);

            monsterBaseClass.Add(11811, 4);
            monsterBaseClass.Add(11812, 4);
            monsterBaseClass.Add(11813, 4);
            monsterBaseClass.Add(11814, 14);
            monsterBaseClass.Add(11815, 4);

            monsterBaseClass.Add(11911, 4);
            monsterBaseClass.Add(11912, 4);
            monsterBaseClass.Add(11913, 4);
            monsterBaseClass.Add(11914, 4);
            monsterBaseClass.Add(11915, 4);

            monsterBaseClass.Add(12011, 3);
            monsterBaseClass.Add(12012, 3);
            monsterBaseClass.Add(12013, 3);
            monsterBaseClass.Add(12014, 3);
            monsterBaseClass.Add(12015, 3);

            monsterBaseClass.Add(12111, 2);
            monsterBaseClass.Add(12112, 2);
            monsterBaseClass.Add(12113, 2);
            monsterBaseClass.Add(12114, 3);
            monsterBaseClass.Add(12115, 3);

            monsterBaseClass.Add(128, 1);
            monsterBaseClass.Add(12811, 1);
            monsterBaseClass.Add(12812, 1);
            monsterBaseClass.Add(12813, 1);
            monsterBaseClass.Add(12814, 1);
            monsterBaseClass.Add(12815, 1);

            monsterBaseClass.Add(13211, 2);
            monsterBaseClass.Add(13212, 2);
            monsterBaseClass.Add(13213, 2);
            monsterBaseClass.Add(13214, 2);
            monsterBaseClass.Add(13215, 2);

            monsterBaseClass.Add(13311, 4);
            monsterBaseClass.Add(13312, 4);
            monsterBaseClass.Add(13313, 4);
            monsterBaseClass.Add(13314, 14);
            monsterBaseClass.Add(13315, 14);

            monsterBaseClass.Add(13411, 4);
            monsterBaseClass.Add(13412, 4);
            monsterBaseClass.Add(13413, 4);
            monsterBaseClass.Add(13414, 14);
            monsterBaseClass.Add(13415, 4);

            monsterBaseClass.Add(13511, 4);
            monsterBaseClass.Add(13512, 4);
            monsterBaseClass.Add(13513, 4);
            monsterBaseClass.Add(13514, 14);
            monsterBaseClass.Add(13515, 5);


            monsterBaseClass.Add(13711, 3);
            monsterBaseClass.Add(13712, 3);
            monsterBaseClass.Add(13713, 3);
            monsterBaseClass.Add(13714, 3);
            monsterBaseClass.Add(13715, 3);

            monsterBaseClass.Add(13811, 5);
            monsterBaseClass.Add(13812, 5);
            monsterBaseClass.Add(13813, 15);
            monsterBaseClass.Add(13814, 5);
            monsterBaseClass.Add(13815, 5);

            monsterBaseClass.Add(13911, 4);
            monsterBaseClass.Add(13912, 4);
            monsterBaseClass.Add(13913, 4);
            monsterBaseClass.Add(13914, 14);
            monsterBaseClass.Add(13915, 4);

            monsterBaseClass.Add(14011, 3);
            monsterBaseClass.Add(14012, 3);
            monsterBaseClass.Add(14013, 3);
            monsterBaseClass.Add(14014, 3);
            monsterBaseClass.Add(14015, 3);

            monsterBaseClass.Add(14111, 4);
            monsterBaseClass.Add(14112, 4);
            monsterBaseClass.Add(14113, 4);
            monsterBaseClass.Add(14114, 14);
            monsterBaseClass.Add(14115, 14);

            monsterBaseClass.Add(14411, 5);
            monsterBaseClass.Add(14412, 5);
            monsterBaseClass.Add(14413, 5);
            monsterBaseClass.Add(14414, 5);
            monsterBaseClass.Add(14415, 5);

            monsterBaseClass.Add(14511, 15);
            monsterBaseClass.Add(14512, 5);
            monsterBaseClass.Add(14513, 5);
            monsterBaseClass.Add(14514, 5);
            monsterBaseClass.Add(14515, 5);

            monsterBaseClass.Add(14611, 5);
            monsterBaseClass.Add(14612, 5);
            monsterBaseClass.Add(14613, 5);
            monsterBaseClass.Add(14614, 5);
            monsterBaseClass.Add(14615, 5);

            monsterBaseClass.Add(14711, 4);
            monsterBaseClass.Add(14712, 4);
            monsterBaseClass.Add(14713, 4);
            monsterBaseClass.Add(14714, 4);
            monsterBaseClass.Add(14715, 4);

            monsterBaseClass.Add(14811, 2);
            monsterBaseClass.Add(14812, 3);
            monsterBaseClass.Add(14813, 2);
            monsterBaseClass.Add(14814, 2);
            monsterBaseClass.Add(14815, 3);

            monsterBaseClass.Add(14911, 3);
            monsterBaseClass.Add(14912, 3);
            monsterBaseClass.Add(14913, 3);
            monsterBaseClass.Add(14914, 3);
            monsterBaseClass.Add(14915, 3);

            monsterBaseClass.Add(15011, 3);
            monsterBaseClass.Add(15012, 3);
            monsterBaseClass.Add(15013, 3);
            monsterBaseClass.Add(15014, 3);
            monsterBaseClass.Add(15015, 3);

            monsterBaseClass.Add(15211, 2);
            monsterBaseClass.Add(15212, 3);
            monsterBaseClass.Add(15213, 2);
            monsterBaseClass.Add(15214, 3);
            monsterBaseClass.Add(15215, 3);

            monsterBaseClass.Add(15311, 3);
            monsterBaseClass.Add(15312, 4);
            monsterBaseClass.Add(15313, 3);
            monsterBaseClass.Add(15314, 4);
            monsterBaseClass.Add(15315, 3);

            monsterBaseClass.Add(15411, 3);
            monsterBaseClass.Add(15412, 3);
            monsterBaseClass.Add(15413, 3);
            monsterBaseClass.Add(15414, 4);
            monsterBaseClass.Add(15415, 4);

            monsterBaseClass.Add(15511, 4);
            monsterBaseClass.Add(15512, 4);
            monsterBaseClass.Add(15513, 4);
            monsterBaseClass.Add(15514, 4);
            monsterBaseClass.Add(15515, 14);

            monsterBaseClass.Add(15611, 3);
            monsterBaseClass.Add(15612, 3);
            monsterBaseClass.Add(15613, 3);
            monsterBaseClass.Add(15614, 3);
            monsterBaseClass.Add(15615, 3);

            monsterBaseClass.Add(15711, 5);
            monsterBaseClass.Add(15712, 5);
            monsterBaseClass.Add(15713, 5);
            monsterBaseClass.Add(15714, 5);
            monsterBaseClass.Add(15715, 5);

            monsterBaseClass.Add(15811, 3);
            monsterBaseClass.Add(15812, 3);
            monsterBaseClass.Add(15813, 3);
            monsterBaseClass.Add(15814, 3);
            monsterBaseClass.Add(15815, 3);

            monsterBaseClass.Add(15911, 3);
            monsterBaseClass.Add(15912, 3);
            monsterBaseClass.Add(15913, 3);
            monsterBaseClass.Add(15914, 3);
            monsterBaseClass.Add(15915, 3);

            monsterBaseClass.Add(16011, 3);
            monsterBaseClass.Add(16012, 3);
            monsterBaseClass.Add(16013, 3);
            monsterBaseClass.Add(16014, 3);
            monsterBaseClass.Add(16015, 3);

            monsterBaseClass.Add(16111, 5);
            monsterBaseClass.Add(16112, 5);
            monsterBaseClass.Add(16113, 5);
            monsterBaseClass.Add(16114, 5);
            monsterBaseClass.Add(16115, 5);

            monsterBaseClass.Add(16211, 4);
            monsterBaseClass.Add(16212, 4);
            monsterBaseClass.Add(16213, 4);
            monsterBaseClass.Add(16214, 14);
            monsterBaseClass.Add(16215, 14);

            monsterBaseClass.Add(16311, 4);
            monsterBaseClass.Add(16312, 4);
            monsterBaseClass.Add(16313, 4);
            monsterBaseClass.Add(16314, 4);
            monsterBaseClass.Add(16315, 4);

            monsterBaseClass.Add(16511, 3);
            monsterBaseClass.Add(16512, 3);
            monsterBaseClass.Add(16513, 3);
            monsterBaseClass.Add(16514, 3);
            monsterBaseClass.Add(16515, 3);

            monsterBaseClass.Add(16611, 5);
            monsterBaseClass.Add(16612, 5);
            monsterBaseClass.Add(16613, 5);
            monsterBaseClass.Add(16614, 5);
            monsterBaseClass.Add(16615, 5);

            monsterBaseClass.Add(16711, 0);
            monsterBaseClass.Add(16712, 0);
            monsterBaseClass.Add(16713, 0);
            monsterBaseClass.Add(16714, 3);
            monsterBaseClass.Add(16715, 0);

            monsterBaseClass.Add(16811, 5);
            monsterBaseClass.Add(16812, 5);
            monsterBaseClass.Add(16813, 5);
            monsterBaseClass.Add(16814, 5);
            monsterBaseClass.Add(16815, 5);

            monsterBaseClass.Add(16911, 4);
            monsterBaseClass.Add(16912, 4);
            monsterBaseClass.Add(16913, 4);
            monsterBaseClass.Add(16914, 4);
            monsterBaseClass.Add(16915, 4);

            monsterBaseClass.Add(17011, 5);
            monsterBaseClass.Add(17012, 5);
            monsterBaseClass.Add(17013, 5);
            monsterBaseClass.Add(17014, 5);
            monsterBaseClass.Add(17015, 5);

            monsterBaseClass.Add(17211, 3);
            monsterBaseClass.Add(17212, 3);
            monsterBaseClass.Add(17213, 3);
            monsterBaseClass.Add(17214, 3);
            monsterBaseClass.Add(17215, 3);

            monsterBaseClass.Add(17311, 4);
            monsterBaseClass.Add(17312, 4);
            monsterBaseClass.Add(17313, 4);
            monsterBaseClass.Add(17314, 14);
            monsterBaseClass.Add(17315, 4);

            monsterBaseClass.Add(17411, 5);
            monsterBaseClass.Add(17412, 5);
            monsterBaseClass.Add(17413, 5);
            monsterBaseClass.Add(17414, 5);
            monsterBaseClass.Add(17415, 5);

            monsterBaseClass.Add(17611, 2);
            monsterBaseClass.Add(17612, 2);
            monsterBaseClass.Add(17613, 2);
            monsterBaseClass.Add(17614, 2);
            monsterBaseClass.Add(17615, 2);

            monsterBaseClass.Add(17711, 3);
            monsterBaseClass.Add(17712, 3);
            monsterBaseClass.Add(17713, 3);
            monsterBaseClass.Add(17714, 3);
            monsterBaseClass.Add(17715, 3);

            monsterBaseClass.Add(17811, 3);
            monsterBaseClass.Add(17812, 3);
            monsterBaseClass.Add(17813, 3);
            monsterBaseClass.Add(17814, 3);
            monsterBaseClass.Add(17815, 3);

            monsterBaseClass.Add(17911, 5);
            monsterBaseClass.Add(17912, 5);
            monsterBaseClass.Add(17913, 5);
            monsterBaseClass.Add(17914, 5);
            monsterBaseClass.Add(17915, 5);

            monsterBaseClass.Add(18011, 4);
            monsterBaseClass.Add(18012, 4);
            monsterBaseClass.Add(18013, 4);
            monsterBaseClass.Add(18014, 14);
            monsterBaseClass.Add(18015, 14);

            monsterBaseClass.Add(18111, 4);
            monsterBaseClass.Add(18112, 4);
            monsterBaseClass.Add(18113, 4);
            monsterBaseClass.Add(18114, 4);
            monsterBaseClass.Add(18115, 14);

            monsterBaseClass.Add(18211, 1);
            monsterBaseClass.Add(18212, 1);
            monsterBaseClass.Add(18213, 1);
            monsterBaseClass.Add(18214, 1);
            monsterBaseClass.Add(18215, 1);

            monsterBaseClass.Add(18311, 4);
            monsterBaseClass.Add(18312, 4);
            monsterBaseClass.Add(18313, 4);
            monsterBaseClass.Add(18314, 5);
            monsterBaseClass.Add(18315, 5);

            monsterBaseClass.Add(18411, 4);
            monsterBaseClass.Add(18412, 3);
            monsterBaseClass.Add(18413, 4);
            monsterBaseClass.Add(18414, 4);
            monsterBaseClass.Add(18415, 3);

            monsterBaseClass.Add(18511, 3);
            monsterBaseClass.Add(18512, 3);
            monsterBaseClass.Add(18513, 3);
            monsterBaseClass.Add(18514, 3);
            monsterBaseClass.Add(18515, 3);

            monsterBaseClass.Add(18611, 5);
            monsterBaseClass.Add(18612, 5);
            monsterBaseClass.Add(18613, 5);
            monsterBaseClass.Add(18614, 5);
            monsterBaseClass.Add(18615, 5);

            monsterBaseClass.Add(18711, 3);
            monsterBaseClass.Add(18712, 3);
            monsterBaseClass.Add(18713, 3);
            monsterBaseClass.Add(18714, 3);
            monsterBaseClass.Add(18715, 3);

            monsterBaseClass.Add(18811, 4);
            monsterBaseClass.Add(18812, 4);
            monsterBaseClass.Add(18813, 4);
            monsterBaseClass.Add(18814, 4);
            monsterBaseClass.Add(18815, 4);

            monsterBaseClass.Add(18911, 5);
            monsterBaseClass.Add(18912, 5);
            monsterBaseClass.Add(18913, 5);
            monsterBaseClass.Add(18914, 5);
            monsterBaseClass.Add(18915, 5);

            monsterBaseClass.Add(19011, 3);
            monsterBaseClass.Add(19012, 3);
            monsterBaseClass.Add(19013, 3);
            monsterBaseClass.Add(19014, 3);
            monsterBaseClass.Add(19015, 3);

            monsterBaseClass.Add(19111, 0);
            monsterBaseClass.Add(19112, 0);
            monsterBaseClass.Add(19113, 0);
            monsterBaseClass.Add(19114, 3);
            monsterBaseClass.Add(19115, 0);

            monsterBaseClass.Add(19211, 15);
            monsterBaseClass.Add(19212, 15);
            monsterBaseClass.Add(19213, 15);
            monsterBaseClass.Add(19214, 15);
            monsterBaseClass.Add(19215, 15);

            monsterBaseClass.Add(19311, 3);
            monsterBaseClass.Add(19312, 3);
            monsterBaseClass.Add(19313, 3);
            monsterBaseClass.Add(19314, 3);
            monsterBaseClass.Add(19315, 3);

            monsterBaseClass.Add(19411, 4);
            monsterBaseClass.Add(19412, 4);
            monsterBaseClass.Add(19413, 4);
            monsterBaseClass.Add(19414, 14);
            monsterBaseClass.Add(19415, 4);

            monsterBaseClass.Add(19511, 3);
            monsterBaseClass.Add(19512, 3);
            monsterBaseClass.Add(19513, 3);
            monsterBaseClass.Add(19514, 3);
            monsterBaseClass.Add(19515, 3);

            monsterBaseClass.Add(19611, 4);
            monsterBaseClass.Add(19612, 4);
            monsterBaseClass.Add(19613, 4);
            monsterBaseClass.Add(19614, 4);
            monsterBaseClass.Add(19615, 4);

            monsterBaseClass.Add(19711, 5);
            monsterBaseClass.Add(19712, 5);
            monsterBaseClass.Add(19713, 5);
            monsterBaseClass.Add(19714, 5);
            monsterBaseClass.Add(19715, 5);

            monsterBaseClass.Add(19811, 4);
            monsterBaseClass.Add(19812, 4);
            monsterBaseClass.Add(19813, 4);
            monsterBaseClass.Add(19814, 4);
            monsterBaseClass.Add(19815, 14);

            monsterBaseClass.Add(19911, 4);
            monsterBaseClass.Add(19912, 4);
            monsterBaseClass.Add(19913, 4);
            monsterBaseClass.Add(19914, 14);
            monsterBaseClass.Add(19915, 14);

            monsterBaseClass.Add(20011, 4);
            monsterBaseClass.Add(20012, 4);
            monsterBaseClass.Add(20013, 4);
            monsterBaseClass.Add(20014, 4);
            monsterBaseClass.Add(20015, 14);

            monsterBaseClass.Add(20111, 4);
            monsterBaseClass.Add(20112, 4);
            monsterBaseClass.Add(20113, 4);
            monsterBaseClass.Add(20114, 4);
            monsterBaseClass.Add(20115, 5);

            monsterBaseClass.Add(20211, 3);
            monsterBaseClass.Add(20212, 3);
            monsterBaseClass.Add(20213, 3);
            monsterBaseClass.Add(20214, 3);
            monsterBaseClass.Add(20215, 3);

            monsterBaseClass.Add(20311, 3);
            monsterBaseClass.Add(20312, 3);
            monsterBaseClass.Add(20313, 3);
            monsterBaseClass.Add(20314, 3);
            monsterBaseClass.Add(20315, 3);

            monsterBaseClass.Add(20411, 4);
            monsterBaseClass.Add(20412, 4);
            monsterBaseClass.Add(20413, 4);
            monsterBaseClass.Add(20414, 4);
            monsterBaseClass.Add(20415, 5);

            monsterBaseClass.Add(20511, 5);
            monsterBaseClass.Add(20512, 5);
            monsterBaseClass.Add(20513, 5);
            monsterBaseClass.Add(20514, 5);
            monsterBaseClass.Add(20515, 5);

            monsterBaseClass.Add(20611, 4);
            monsterBaseClass.Add(20612, 4);
            monsterBaseClass.Add(20613, 4);
            monsterBaseClass.Add(20614, 5);
            monsterBaseClass.Add(20615, 4);

            monsterBaseClass.Add(20711, 4);
            monsterBaseClass.Add(20712, 4);
            monsterBaseClass.Add(20713, 4);
            monsterBaseClass.Add(20714, 4);
            monsterBaseClass.Add(20715, 14);

            monsterBaseClass.Add(20811, 3);
            monsterBaseClass.Add(20812, 3);
            monsterBaseClass.Add(20813, 3);
            monsterBaseClass.Add(20814, 3);
            monsterBaseClass.Add(20815, 3);

            monsterBaseClass.Add(20911, 3);
            monsterBaseClass.Add(20912, 3);
            monsterBaseClass.Add(20913, 3);
            monsterBaseClass.Add(20914, 3);
            monsterBaseClass.Add(20915, 4);

            monsterBaseClass.Add(21011, 3);
            monsterBaseClass.Add(21012, 3);
            monsterBaseClass.Add(21013, 4);
            monsterBaseClass.Add(21014, 4);
            monsterBaseClass.Add(21015, 3);

            monsterBaseClass.Add(21111, 5);
            monsterBaseClass.Add(21112, 5);
            monsterBaseClass.Add(21113, 5);
            monsterBaseClass.Add(21114, 5);
            monsterBaseClass.Add(21115, 5);

            monsterBaseClass.Add(21211, 5);
            monsterBaseClass.Add(21212, 15);
            monsterBaseClass.Add(21213, 5);
            monsterBaseClass.Add(21214, 5);
            monsterBaseClass.Add(21215, 5);

            monsterBaseClass.Add(21311, 4);
            monsterBaseClass.Add(21312, 4);
            monsterBaseClass.Add(21313, 4);
            monsterBaseClass.Add(21314, 4);
            monsterBaseClass.Add(21315, 4);

            monsterBaseClass.Add(21411, 4);
            monsterBaseClass.Add(21412, 4);
            monsterBaseClass.Add(21413, 4);
            monsterBaseClass.Add(21414, 5);
            monsterBaseClass.Add(21415, 5);

            monsterBaseClass.Add(21511, 5);
            monsterBaseClass.Add(21512, 5);
            monsterBaseClass.Add(21513, 5);
            monsterBaseClass.Add(21514, 5);
            monsterBaseClass.Add(21515, 5);
            monsterBaseClass.Add(21611, 5);
            monsterBaseClass.Add(21612, 5);
            monsterBaseClass.Add(21613, 5);
            monsterBaseClass.Add(21614, 5);
            monsterBaseClass.Add(21615, 5);

            monsterBaseClass.Add(21811, 5);
            monsterBaseClass.Add(21812, 5);
            monsterBaseClass.Add(21813, 5);
            monsterBaseClass.Add(21814, 15);
            monsterBaseClass.Add(21815, 5);

            monsterBaseClass.Add(21911, 4);
            monsterBaseClass.Add(21912, 4);
            monsterBaseClass.Add(21913, 4);
            monsterBaseClass.Add(21914, 14);
            monsterBaseClass.Add(21915, 4);

            monsterBaseClass.Add(22011, 4);
            monsterBaseClass.Add(22012, 4);
            monsterBaseClass.Add(22013, 4);
            monsterBaseClass.Add(22014, 4);
            monsterBaseClass.Add(22015, 4);

            monsterBaseClass.Add(22111, 4);
            monsterBaseClass.Add(22112, 4);
            monsterBaseClass.Add(22113, 4);
            monsterBaseClass.Add(22114, 4);
            monsterBaseClass.Add(22115, 4);

            monsterBaseClass.Add(22211, 5);
            monsterBaseClass.Add(22212, 5);
            monsterBaseClass.Add(22213, 5);
            monsterBaseClass.Add(22214, 5);
            monsterBaseClass.Add(22215, 5);
            monsterBaseClass.Add(22311, 5);
            monsterBaseClass.Add(22312, 5);
            monsterBaseClass.Add(22313, 5);
            monsterBaseClass.Add(22314, 5);
            monsterBaseClass.Add(22315, 5);

            monsterBaseClass.Add(22411, 3);
            monsterBaseClass.Add(22412, 3);
            monsterBaseClass.Add(22413, 4);
            monsterBaseClass.Add(22414, 4);
            monsterBaseClass.Add(22415, 4);
            monsterBaseClass.Add(22513, 4);
            monsterBaseClass.Add(22515, 4);

            monsterBaseClass.Add(22611, 5);
            monsterBaseClass.Add(22612, 5);
            monsterBaseClass.Add(22613, 5);
            monsterBaseClass.Add(22614, 5);
            monsterBaseClass.Add(22615, 5);

            monsterBaseClass.Add(22711, 4);
            monsterBaseClass.Add(22712, 4);
            monsterBaseClass.Add(22713, 4);
            monsterBaseClass.Add(22714, 4);
            monsterBaseClass.Add(22715, 4);
            monsterBaseClass.Add(22812, 4);
            monsterBaseClass.Add(22813, 4);
            monsterBaseClass.Add(22815, 4);

            monsterBaseClass.Add(22911, 4);
            monsterBaseClass.Add(22912, 4);
            monsterBaseClass.Add(22913, 5);
            monsterBaseClass.Add(22914, 4);
            monsterBaseClass.Add(22915, 5);

            monsterBaseClass.Add(23015, 15);

            monsterBaseClass.Add(15105, 1);
            monsterBaseClass.Add(14314, 0);
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

            #region Rune Sets
            runeSets.Add(1, ("Energy", 2));
            runeSets.Add(2, ("Guard", 2));
            runeSets.Add(3, ("Swift", 4));
            runeSets.Add(4, ("Blade", 2));
            runeSets.Add(5, ("Rage", 4));
            runeSets.Add(6, ("Focus", 2));
            runeSets.Add(7, ("Endure", 2));
            runeSets.Add(8, ("Fatal", 4));
            runeSets.Add(10, ("Despair", 4));
            runeSets.Add(11, ("Vampire", 4));
            runeSets.Add(13, ("Violent", 4));
            runeSets.Add(14, ("Nemesis", 2));
            runeSets.Add(15, ("Will", 2));
            runeSets.Add(16, ("Shield", 2));
            runeSets.Add(17, ("Revenge", 2));
            runeSets.Add(18, ("Destroy", 2));
            runeSets.Add(19, ("Fight", 2));
            runeSets.Add(20, ("Determination", 2));
            runeSets.Add(21, ("Enhance", 2));
            runeSets.Add(22, ("Accuracy", 2));
            runeSets.Add(23, ("Tolerance", 2));
            runeSets.Add(99, ("Immemorial", 1));
            #endregion

            #region Rune Quality
            runeQuality.Add(1, "Common");
            runeQuality.Add(2, "Magic");
            runeQuality.Add(3, "Rare");
            runeQuality.Add(4, "Hero");
            runeQuality.Add(5, "Legend");
            // ancient rune qualities
            runeQuality.Add(11, "Ancient Common");
            runeQuality.Add(12, "Ancient Magic");
            runeQuality.Add(13, "Ancient Rare");
            runeQuality.Add(14, "Ancient Hero");
            runeQuality.Add(15, "Ancient Legend");
            #endregion

            #region Rune Mainstats
            runeMainstats.Add(1, new Dictionary<int, int>() { { 1, 804 }, { 2, 1092 }, { 3, 1380 }, { 4, 1704 }, { 5, 2088 }, { 6, 2448 } });
            runeMainstats.Add(2, new Dictionary<int, int>() { { 1, 18 }, { 2, 20 }, { 3, 38 }, { 4, 43 }, { 5, 51 }, { 6, 63 } });
            runeMainstats.Add(3, new Dictionary<int, int>() { { 1, 54 }, { 2, 74 }, { 3, 93 }, { 4, 113 }, { 5, 135 }, { 6, 160 } });
            runeMainstats.Add(4, new Dictionary<int, int>() { { 1, 18 }, { 2, 20 }, { 3, 38 }, { 4, 43 }, { 5, 51 }, { 6, 63 } });
            runeMainstats.Add(5, new Dictionary<int, int>() { { 1, 54 }, { 2, 74 }, { 3, 93 }, { 4, 113 }, { 5, 135 }, { 6, 160 } });
            runeMainstats.Add(6, new Dictionary<int, int>() { { 1, 18 }, { 2, 20 }, { 3, 38 }, { 4, 43 }, { 5, 51 }, { 6, 63 } });

            runeMainstats.Add(8, new Dictionary<int, int>() { { 1, 18 }, { 2, 19 }, { 3, 25 }, { 4, 30 }, { 5, 39 }, { 6, 42 } });
            runeMainstats.Add(9, new Dictionary<int, int>() { { 1, 18 }, { 2, 20 }, { 3, 37 }, { 4, 41 }, { 5, 47 }, { 6, 58 } });
            runeMainstats.Add(10, new Dictionary<int, int>() { { 1, 20 }, { 2, 37 }, { 3, 43 }, { 4, 58 }, { 5, 65 }, { 6, 80 } });
            runeMainstats.Add(11, new Dictionary<int, int>() { { 1, 18 }, { 2, 20 }, { 3, 38 }, { 4, 44 }, { 5, 51 }, { 6, 64 } });
            runeMainstats.Add(12, new Dictionary<int, int>() { { 1, 18 }, { 2, 20 }, { 3, 38 }, { 4, 44 }, { 5, 51 }, { 6, 64 } });
            #endregion

            #region Rune Substats
            runeSubstats.Add(1, new Dictionary<int, int>() { { 1, 300 }, { 2, 525 }, { 3, 825 }, { 4, 1125 }, { 5, 1500 }, { 6, 1875 } });
            runeSubstats.Add(2, new Dictionary<int, int>() { { 1, 10 }, { 2, 15 }, { 3, 25 }, { 4, 30 }, { 5, 35 }, { 6, 40 } });
            runeSubstats.Add(3, new Dictionary<int, int>() { { 1, 20 }, { 2, 25 }, { 3, 40 }, { 4, 50 }, { 5, 75 }, { 6, 100 } });
            runeSubstats.Add(4, new Dictionary<int, int>() { { 1, 10 }, { 2, 15 }, { 3, 25 }, { 4, 30 }, { 5, 35 }, { 6, 40 } });
            runeSubstats.Add(5, new Dictionary<int, int>() { { 1, 20 }, { 2, 25 }, { 3, 40 }, { 4, 50 }, { 5, 75 }, { 6, 100 } });
            runeSubstats.Add(6, new Dictionary<int, int>() { { 1, 10 }, { 2, 15 }, { 3, 25 }, { 4, 30 }, { 5, 35 }, { 6, 40 } });

            runeSubstats.Add(8, new Dictionary<int, int>() { { 1, 5 }, { 2, 10 }, { 3, 15 }, { 4, 20 }, { 5, 25 }, { 6, 30 } });
            runeSubstats.Add(9, new Dictionary<int, int>() { { 1, 5 }, { 2, 10 }, { 3, 15 }, { 4, 20 }, { 5, 25 }, { 6, 30 } });
            runeSubstats.Add(10, new Dictionary<int, int>() { { 1, 10 }, { 2, 15 }, { 3, 20 }, { 4, 25 }, { 5, 25 }, { 6, 35 } });
            runeSubstats.Add(11, new Dictionary<int, int>() { { 1, 10 }, { 2, 15 }, { 3, 20 }, { 4, 25 }, { 5, 35 }, { 6, 40 } });
            runeSubstats.Add(12, new Dictionary<int, int>() { { 1, 10 }, { 2, 15 }, { 3, 20 }, { 4, 25 }, { 5, 35 }, { 6, 40 } });
            #endregion

            #region Grindstones
            grindstones.Add(1, new Dictionary<int, (int Min, int Max)>() { { 1, (80, 120) }, { 2, (100, 200) }, { 3, (180, 250) }, { 4, (230, 450) }, { 5, (430, 550) } });
            grindstones.Add(2, new Dictionary<int, (int Min, int Max)>() { { 1, (1, 3) }, { 2, (2, 5) }, { 3, (3, 6) }, { 4, (4, 7) }, { 5, (5, 10) } });
            grindstones.Add(3, new Dictionary<int, (int Min, int Max)>() { { 1, (4, 8) }, { 2, (6, 12) }, { 3, (10, 18) }, { 4, (12, 22) }, { 5, (18, 30) } });
            grindstones.Add(4, new Dictionary<int, (int Min, int Max)>() { { 1, (1, 3) }, { 2, (2, 5) }, { 3, (3, 6) }, { 4, (4, 7) }, { 5, (5, 10) } });
            grindstones.Add(5, new Dictionary<int, (int Min, int Max)>() { { 1, (4, 8) }, { 2, (6, 12) }, { 3, (10, 18) }, { 4, (12, 22) }, { 5, (18, 30) } });
            grindstones.Add(6, new Dictionary<int, (int Min, int Max)>() { { 1, (1, 3) }, { 2, (2, 5) }, { 3, (3, 6) }, { 4, (4, 7) }, { 5, (5, 10) } });

            grindstones.Add(8, new Dictionary<int, (int Min, int Max)>() { { 1, (1, 2) }, { 2, (1, 2) }, { 3, (2, 3) }, { 4, (3, 4) }, { 5, (4, 5) } });
            grindstones.Add(9, new Dictionary<int, (int Min, int Max)>() { { 1, (1, 2) }, { 2, (1, 3) }, { 3, (2, 4) }, { 4, (3, 5) }, { 5, (4, 6) } });
            grindstones.Add(10, new Dictionary<int, (int Min, int Max)>() { { 1, (1, 3) }, { 2, (2, 4) }, { 3, (2, 5) }, { 4, (4, 7) }, { 5, (5, 10) } });
            grindstones.Add(11, new Dictionary<int, (int Min, int Max)>() { { 1, (1, 3) }, { 2, (2, 4) }, { 3, (2, 5) }, { 4, (4, 7) }, { 5, (5, 10) } });
            grindstones.Add(12, new Dictionary<int, (int Min, int Max)>() { { 1, (1, 3) }, { 2, (2, 4) }, { 3, (2, 5) }, { 4, (4, 7) }, { 5, (5, 10) } });
            #endregion

            #region Enchanted Gems
            enchantGems.Add(1, new Dictionary<int, (int Min, int Max)>() { { 1, (100, 150) }, { 2, (130, 220) }, { 3, (200, 310) }, { 4, (290, 420) }, { 5, (400, 580) } });
            enchantGems.Add(2, new Dictionary<int, (int Min, int Max)>() { { 1, (2, 4) }, { 2, (3, 7) }, { 3, (5, 9) }, { 4, (7, 11) }, { 5, (9, 13) } });
            enchantGems.Add(3, new Dictionary<int, (int Min, int Max)>() { { 1, (8, 12) }, { 2, (10, 16) }, { 3, (15, 23) }, { 4, (20, 30) }, { 5, (28, 40) } });
            enchantGems.Add(4, new Dictionary<int, (int Min, int Max)>() { { 1, (2, 4) }, { 2, (3, 7) }, { 3, (5, 9) }, { 4, (7, 11) }, { 5, (9, 13) } });
            enchantGems.Add(5, new Dictionary<int, (int Min, int Max)>() { { 1, (8, 12) }, { 2, (10, 16) }, { 3, (15, 23) }, { 4, (20, 30) }, { 5, (28, 40) } });
            enchantGems.Add(6, new Dictionary<int, (int Min, int Max)>() { { 1, (2, 4) }, { 2, (3, 7) }, { 3, (5, 9) }, { 4, (7, 11) }, { 5, (9, 13) } });

            enchantGems.Add(8, new Dictionary<int, (int Min, int Max)>() { { 1, (1, 3) }, { 2, (2, 4) }, { 3, (3, 6) }, { 4, (5, 8) }, { 5, (7, 10) } });
            enchantGems.Add(9, new Dictionary<int, (int Min, int Max)>() { { 1, (1, 3) }, { 2, (2, 4) }, { 3, (3, 5) }, { 4, (4, 7) }, { 5, (6, 9) } });
            enchantGems.Add(10, new Dictionary<int, (int Min, int Max)>() { { 1, (1, 3) }, { 2, (3, 5) }, { 3, (4, 6) }, { 4, (5, 8) }, { 5, (7, 10) } });
            enchantGems.Add(11, new Dictionary<int, (int Min, int Max)>() { { 1, (2, 4) }, { 2, (3, 6) }, { 3, (5, 8) }, { 4, (6, 9) }, { 5, (8, 11) } });
            enchantGems.Add(12, new Dictionary<int, (int Min, int Max)>() { { 1, (2, 4) }, { 2, (3, 6) }, { 3, (5, 8) }, { 4, (6, 9) }, { 5, (8, 11) } });
            #endregion

            #region Scenario
            scenario.Add(1, "Garen Forest");
            scenario.Add(2, "Mt. Siz");
            scenario.Add(3, "Kabir Ruins");
            scenario.Add(4, "Mt. White Ragon");
            scenario.Add(5, "Telain Forest");
            scenario.Add(6, "Hydeni Ruins");
            scenario.Add(7, "Tamor Desert");
            scenario.Add(8, "Vrofagus Ruins");
            scenario.Add(9, "Faimon Volcano");
            scenario.Add(10, "Aiden Forest");
            scenario.Add(11, "Ferun Castle");
            scenario.Add(12, "Mt Runar");
            scenario.Add(13, "Chiruka Remains");
            #endregion

            #region Dungeons
            dungeons.Add(1001, "Hall of Dark");
            dungeons.Add(1101, "Sanctuary of Dreaming Fairies");
            dungeons.Add(1201, "Ellunia Remains (Fairy)");
            dungeons.Add(1202, "Ellunia Remains (Pixie)");
            dungeons.Add(2001, "Hall of Fire");
            dungeons.Add(2101, "Forest of Roaring Beasts");
            dungeons.Add(2201, "Karzhan Remains (Warbear)");
            dungeons.Add(2202, "Karzhan Remains (Inugami)");
            dungeons.Add(3001, "Hall of Water");
            dungeons.Add(4001, "Hall of Wind");
            dungeons.Add(5001, "Hall of Magic");
            dungeons.Add(6001, "Necropolis");
            dungeons.Add(7001, "Hall of Light");
            dungeons.Add(8001, "Giant\'s Keep");
            dungeons.Add(9001, "Dragon\'s Lair");
            #endregion

            #region Elemental Rift Dungeons
            elementalRiftDungeons.Add(1001, "Rift Dungeon - Ice Beast");
            elementalRiftDungeons.Add(2001, "Rift Dungeon - Fire Beast");
            elementalRiftDungeons.Add(3001, "Rift Dungeon - Wind Beast");
            elementalRiftDungeons.Add(4001, "Rift Dungeon - Light Beast");
            elementalRiftDungeons.Add(5001, "Rift Dungeon - Dark Beast");
            #endregion

            #region Raid Rift Levels
            raidRiftLevels.Add(1, "Rift of Worlds- level 1");
            raidRiftLevels.Add(2, "Rift of Worlds- level 2");
            raidRiftLevels.Add(3, "Rift of Worlds- level 3");
            raidRiftLevels.Add(4, "Rift of Worlds- level 4");
            raidRiftLevels.Add(5, "Rift of Worlds- level 5");
            #endregion

            #region Difficulty
            difficulties.Add(1, "Normal");
            difficulties.Add(2, "Hard");
            difficulties.Add(3, "Hell");
            #endregion

            #region Essence Attributes
            essenceAttributes.Add(1, "Water");
            essenceAttributes.Add(2, "Fire");
            essenceAttributes.Add(3, "Wind");
            essenceAttributes.Add(4, "Light");
            essenceAttributes.Add(5, "Dark");
            essenceAttributes.Add(6, "Magic");
            #endregion

            #region Essence Grades
            essenceGrades.Add(1, "Low");
            essenceGrades.Add(2, "Mid");
            essenceGrades.Add(3, "High");
            #endregion

            #region Craft Materials
            craftMaterials.Add(1001, "Hard Wood");
            craftMaterials.Add(1002, "Tough Leather");
            craftMaterials.Add(1003, "Solid Rock");
            craftMaterials.Add(1004, "Solid Iron Ore");
            craftMaterials.Add(1005, "Shining Mithril");
            craftMaterials.Add(1006, "Thick Cloth");
            craftMaterials.Add(2001, "Rune Piece");
            craftMaterials.Add(3001, "Magic Dust");
            craftMaterials.Add(4001, "Symbol of Harmony");
            craftMaterials.Add(4002, "Symbol of Transcendence");
            craftMaterials.Add(4003, "Symbol of Chaos");
            craftMaterials.Add(5001, "Frozen Water Crystal");
            craftMaterials.Add(5002, "Flaming Fire Crystal");
            craftMaterials.Add(5003, "Whirling Wind Crystal");
            craftMaterials.Add(5004, "Shiny Light Crystal");
            craftMaterials.Add(5005, "Pitch-black Dark Crystal");
            craftMaterials.Add(6001, "Condensed Magic Crystal");
            craftMaterials.Add(7001, "Pure Magic Crystal");
            #endregion

            #region Ranking Arena
            rankingArena.Add(901, "Beginner");

            rankingArena.Add(1001, "Challenger I");
            rankingArena.Add(1002, "Challenger II");
            rankingArena.Add(1003, "Challenger III");

            rankingArena.Add(2001, "Fighter I");
            rankingArena.Add(2002, "Fighter II");
            rankingArena.Add(2003, "Fighter III");

            rankingArena.Add(3001, "Conqueror I");
            rankingArena.Add(3002, "Conqueror II");
            rankingArena.Add(3003, "Conqueror III");

            rankingArena.Add(4001, "Guardian I");
            rankingArena.Add(4002, "Guardian II");
            rankingArena.Add(4003, "Guardian III");

            rankingArena.Add(5001, "Legend");
            #endregion

            #region Ranking Guild
            rankingGuild.Add(1011, "Challenger");

            rankingGuild.Add(2011, "Fighter I");
            rankingGuild.Add(2012, "Fighter II");
            rankingGuild.Add(2013, "Fighter III");

            rankingGuild.Add(3011, "Conqueror I");
            rankingGuild.Add(3012, "Conqueror II");
            rankingGuild.Add(3013, "Conqueror III");

            rankingGuild.Add(4011, "Guardian I");
            rankingGuild.Add(4012, "Guardian II");
            rankingGuild.Add(4013, "Guardian III");

            rankingGuild.Add(5011, "Guardian III");
            #endregion
        }
        #endregion

        #region Fields
        private Dictionary<int, string> monsterAttributes = new Dictionary<int, string>();
        private Dictionary<int, string> monsterNames = new Dictionary<int, string>();
        private Dictionary<int, int> monsterBaseClass = new Dictionary<int, int>(); // base class + 10 for L&D HoH monsters, fuseable L&D 4*+ monsters and fuseable elemental 5* monsters

        private Dictionary<int, string> runeEffectTypes = new Dictionary<int, string>();
        private Dictionary<int, (string Name, byte Amount)> runeSets = new Dictionary<int, (string Name, byte Amount)>();
        private Dictionary<int, string> runeQuality = new Dictionary<int, string>();
        private Dictionary<int, Dictionary<int, int>> runeMainstats = new Dictionary<int, Dictionary<int, int>>();
        private Dictionary<int, Dictionary<int, int>> runeSubstats = new Dictionary<int, Dictionary<int, int>>();

        private Dictionary<int, Dictionary<int, (int Min, int Max)>> grindstones = new Dictionary<int, Dictionary<int, (int Min, int Max)>>();
        private Dictionary<int, Dictionary<int, (int Min, int Max)>> enchantGems = new Dictionary<int, Dictionary<int, (int Min, int Max)>>();

        private Dictionary<int, string> scenario = new Dictionary<int, string>();
        private Dictionary<int, string> dungeons = new Dictionary<int, string>();
        private Dictionary<int, string> elementalRiftDungeons = new Dictionary<int, string>();
        private Dictionary<int, string> raidRiftLevels = new Dictionary<int, string>();
        private Dictionary<int, string> difficulties = new Dictionary<int, string>();

        private Dictionary<int, string> essenceAttributes = new Dictionary<int, string>();
        private Dictionary<int, string> essenceGrades = new Dictionary<int, string>();
        private Dictionary<int, string> craftMaterials = new Dictionary<int, string>();

        private Dictionary<int, string> rankingArena = new Dictionary<int, string>();
        private Dictionary<int, string> rankingGuild = new Dictionary<int, string>();
        #endregion

        #region Properties
        public string Credits { get; set; } = "Xzandro";
        #endregion


        #region Methods
        public string GetMonsterAttribute(int id)
        {
            if(id > 9) { id = id % 10; }
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

            int family = int.Parse(id.ToString().Substring(0, 3));
            if (monsterNames.ContainsKey(family))
            {
                int attribute = int.Parse(id.ToString().Substring(id.ToString().Length - 1));
                return $"{monsterNames[family]} ({monsterAttributes[attribute]})";
            }

            return "Unknown Monster";
        }

        public int GetMonsterBaseClass(int id)
        {
            if (monsterBaseClass.ContainsKey(id))
            {
                return monsterBaseClass[id];
            }

            // unawaken monster, so we need to 'awake' him
            int family = int.Parse(id.ToString().Substring(0, 3));
            if (monsterNames.ContainsKey(family))
            {
                int attribute = int.Parse(id.ToString().Substring(id.ToString().Length - 1));

                if (monsterBaseClass.ContainsKey(family * 100 + 10 + attribute)) // 1A form
                    return monsterBaseClass[family * 100 + 10 + attribute];
                else if(monsterBaseClass.ContainsKey(family * 100 + 30 + attribute)) // 2A form
                    return monsterBaseClass[family * 100 + 30 + attribute];
            }

            return -1;
        }

        public string GetRuneEffectType(int id)
        {
            if (runeEffectTypes.ContainsKey(id))
            {
                return runeEffectTypes[id];
            }
            return "Unknown Rune Effect Type";
        }

        public string GetRuneEffect(Rune rune)
        {
            Dictionary<int, string> effect = new Dictionary<int, string>()
            {
                {0, "" },
                {1, $"HP +{rune.PriEff[1]}" },
                {2, $"HP {rune.PriEff[1]}%" },
                {3, $"ATK +{rune.PriEff[1]}" },
                {4, $"ATK {rune.PriEff[1]}%" },
                {5, $"DEF +{rune.PriEff[1]}" },
                {6, $"DEF {rune.PriEff[1]}%" },
                {8, $"SPD +{rune.PriEff[1]}" },
                {9, $"CRate {rune.PriEff[1]}%" },
                {10, $"CDmg {rune.PriEff[1]}%" },
                {11, $"Res {rune.PriEff[1]}%" },
                {12, $"Acc {rune.PriEff[1]}%" }
            };
            return effect[(int)rune.PriEff[0]];
        }



        public string GetRuneSet(int id)
        {
            if (runeSets.ContainsKey(id))
            {
                return runeSets[id].Name;
            }
            return "Unknown Rune Set";
        }

        public string GetRuneSetAmount(string set)
        {
            foreach (KeyValuePair<int, (string Name, byte Amount)> runeSet in runeSets)
            {
                if (runeSet.Value.Name.ToLower() == set.ToLower()) { return runeSet.Value.Amount.ToString(); }
            }
            return "Unknown Rune Set Amount";
        }

        public string GetRuneQuality(int id)
        {
            if (runeQuality.ContainsKey(id))
            {
                return runeQuality[id];
            }
            return "Unknown Rune Quality";
        }

        public string GetScenario(int id)
        {
            if (scenario.ContainsKey(id))
            {
                return scenario[id];
            }
            return "Unknown Scenario";
        }

        public string GetDungeon(int id)
        {
            if (dungeons.ContainsKey(id))
            {
                return dungeons[id];
            }
            return "Unknown Dungeon";
        }

        public string GetElementalRiftDungeon(int id)
        {
            if (elementalRiftDungeons.ContainsKey(id))
            {
                return elementalRiftDungeons[id];
            }
            return "Unknown Elemental Rift Dungeon";
        }

        public string GetRaidRiftLevel(int id)
        {
            if (raidRiftLevels.ContainsKey(id))
            {
                return raidRiftLevels[id];
            }
            return "Unknown Raid Rift Level";
        }

        public string GetDifficulty(int id)
        {
            if (difficulties.ContainsKey(id))
            {
                return difficulties[id];
            }
            return "Unknown Difficulty";
        }

        private bool IsAncient(Rune rune)
        {
            if(rune.Class > 10) { return true; }
            return false;
        }

        public (double Current, double Max) GetRuneEfficiency(Rune rune)
        {
            double ratio = 0;
            int runeClass = (int)rune.Class;
            // mainstat
            if (IsAncient(rune)) { runeClass -= 10; }


            ratio += runeMainstats[(int)rune.PriEff[0]][runeClass] / runeMainstats[(int)rune.PriEff[0]][6];

            // substats
            foreach (List<long> stat in rune.SecEff)
            {
                double value;
                if (stat.Count > 3 && stat[3] > 0) { value = stat[1] + stat[3]; }
                else { value = stat[1]; }
                ratio += value / runeSubstats[(int)stat[0]][6];
            }

            // innate
            if (rune.PrefixEff.Count > 0 && rune.PrefixEff[0] > 0)
            {
                ratio += rune.PrefixEff[1] / runeSubstats[(int)rune.PrefixEff[0]][6];
            }

            double efficiency = (ratio / 2.8) * 100;

            return (Math.Round(efficiency, 2), Math.Round(efficiency + (Math.Max(Math.Ceiling((12 - (double)rune.UpgradeCurr) / 3), 0) * 0.2 / 2.8 * 100), 2));
        }
        

        public string GetRanking(int id)
        {
            if (rankingArena.ContainsKey(id))
            {
                return rankingArena[id];
            }
            return "Unknown Ranking";
        }

        public string GetGuildRanking(int id)
        {
            if (rankingGuild.ContainsKey(id))
            {
                return rankingGuild[id];
            }
            return "Unknown Guild Ranking";
        }
        #endregion
    }
}
