# Deprecated
I decided to deprecate give up the current technology for this project. This doesn't mean that the subject of the project has fallen. Slowly (due to the number of projects in my studies) I'm creating an online version of this project. Thanks to this I will be able to do more things I wanted to do at the very beginning, plus - you will be able to use it regardless of whether you are using Windows or not.

# Summoners War Statistics

This tool will give you an information about your Summoner's War account, like amount of monsters, friends list and dimension hole calculator. In the first published version you were able to check some currency stuff, extended info about your monsters (as a group, e.g. amount of elemental monsters or days since last **usable** (non-feeded) nat5), some info about runes (min, max, mean, median, standard deviation efficiency; amount of runes: total, maxed and in inventory), dimension hole caculator (when you will be able to 2A next monster), friends list (their reps, since when they are offline) and guild stuff (members, best rank, defense monsters). Now it's more complex, with addition of Dynamic UI.

![summary]

[summary]: https://i.imgur.com/5VfXA5d.png
## v1.0.0 Changelog
* Increased the minimum (and standard) resolution from ~800x600 to 1024x768
* Added TEST JSON Button
  * If you installed the app on the system drive, you need admin privileges to use Test file
  * If admin privileges not provided, you'll see proper information
  * It basically contains my private JSON w/o any personal information (yeah, my account is bad lol)
* Added list of monsters (with their avatars) connected with Collection checkboxes
  * It's ordered by Attribute, then by natural star, then by monster (f.e. Lushen next to dupe Lushen) and finally by acquiration date
* Merged Monsters To Lock list with Monsters List (the one with avatars)
  * It still takes care of devilmons in the first place, then the old 5* option is checked as the default
  * Monster, which should be locked will have their avatars in grayscale
  * When you hover the grayscale avatar, the ToolTip will tell you that you should lock this monster
* Added Ranking feature, which consists of stats like "#3 Fastest Monster" and "#273 Tankiest Monster"
  * It is affected by "Monsters Collection" panel (the one with checkboxes in Monsters tab)
  * It contains the overall rank based on positions in other categories;
  * Formula: 1 - rank / rank_last + value / value_best for every category, sum for whole ranking
* Added new window, which occurs when you click on the monster in Monsters List
  * It uses the Ranking feature mentioned above
  * At the current state, you can check the rank for only few categories (SPD, ATK, CDMG, DEF, HP, Rune Efficiency)
  * If you checked anything in Monsters Collection (in other words, if you filtered out some monsters), the info you see is for actual Monsters List; it means, if you choose only wind monsters and click on f.e. Bernard, it'll say you how fast he is, compared to other wind monsters
* Added amount of days needed to 2A a monster, next to the date of 2A (Dim Hole Calculator)
* Fixed UI for some tabs
* Improved UI
* Fixed the Towers & Flags list not being refreshed while changing JSON file
* Added better Decks recognition for Lab stages (Com2Us changed it in 5.1.1. update)
* Added info where the app failed to init given json file to the Error Message
* Changed Wings Per Day Dropdown List to Numeric Value box in Towers & Flags Calculator
* Added adjustable Siege Contribution for every Siege battle, instead of constant 5% contribution
  * Worth noting, that it still uses 20k points for 1st place, 15k points for 2nd and 10k for 3rd
* Updated README of Summoners War Statistics project, which means updated info while checking project GitHub page

## Future features
* Advanced Sorting for Monsters List (sort by rank, name, element, stars) being user-dependent, not hard-coded
* Wages in specific ranking based on monster type (like Lushen's rank won't be downgraded because of being ATK type monster and having total of 10k HP, 500 DEF & 110 SPD)
* More stuff for any user-dependent options
* Transmog tab (or at least some info in Monsters/Other tab, but I need more JSON files with in-game info [like who has which aura/wings])
* Make a Linux version (?)

I understand that other tools have more options than mine. I respect the creators of them. I'll try my best to develop it as long as possible, because it's a nice experience for a young (in terms of experience) programmers.

## Getting Started
* For users
Check **Installing** section
* For developers
You just need to download (clone) this repo and open **Summoners War Statistics.sln** file in any IDE (recommended **Visual Studio**)

### Prerequisites

[Microsoft .Net Framework 4.7.2 or higher](https://dotnet.microsoft.com/download/dotnet-framework)

### Installing

1. Download **Summoners War Statistics Setup.exe** file from [Release](https://github.com/QuatZo/Summoners-War-Statistics/releases) tab
2. Run installer
3. Follow steps
4. Run **Summoners War Statistics.exe** from your Desktop

## Screenshots
[Here, IMGUR link](https://imgur.com/a/Bh01XHa)

## Running the tests

Nothing. For now.

## Deployment

Open previously mentioned Visual Studio Solution file then use Summoners War Statistics Setup project

## Built With

* [Microsoft .Net Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework)
* [Model-View-Presenter (MVP)](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93presenter) - Software design pattern
* [Visual Studio 2019](https://visualstudio.microsoft.com/pl) - IDE

## Authors

* **QuatZo** - [GitHub Profile](https://github.com/QuatZo) - [Reddit profile](http://reddit.com/u/quatzo)

## License

This project is licensed under the Apache 2.0 License - see the [LICENSE](https://choosealicense.com/licenses/apache-2.0/) for details

## Acknowledgments

* [Xzandro](https://github.com/Xzandro/) - for doing [SW Exporter](https://github.com/Xzandro/), because without JSON file it generates, I wouldn't be able to do anything; and for shared mapping
* [Porksmash](https://github.com/PeteAndersen) - for doing [SWARFARM](https://github.com/PeteAndersen/swarfarm), this tools helped me with some mapping
