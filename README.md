# Summoners War Statistics

This tool will give you an information about your Summoner's War account, like amount of monsters, friends list and dimension hole calculator. In the first published version you are able to check some currency stuff, extended info about your monsters (as a group, e.g. amount of elemental monsters or days since last **usable** (non-feeded) nat5), some info about runes (min, max, mean, median, standard deviation efficiency; amount of runes: total, maxed and in inventory), dimension hole caculator (when you will be able to 2A next monster), friends list (their reps, since when they are offline) and guild stuff (members, best rank, defense monsters). The very first version is static (in terms of resolution), but I'm planning to do it more dynamic (once I learn how to).

## Future features
* Dynamic window
* More information in Monsters tab (probably list with filters similar to Rune tab)
* Advanced Rune tab (my main objective here is to make some plots and checker if your runes comply with the normal distribution rules [for fun])
* Decks tab
* Dimension hole calculator, which takes into consideration fail rate, time and floor just to decide which floor is best to farm
* Move Guild info from Other tab to new Guild tab, which means adding more guild stuff
* Other tab fullfiled with less important info

![screen]

[screen]: https://i.imgur.com/dh2sD3n.png

I understand that other tools have more options than mine. I respect the creators of them. I'll try my best to develop it as long as possible, because it's a nice experience for a young (in terms of experience) programmers.

## Getting Started
* For users
Check **Installing** section
* For developers
You just need to download (clone) this repo and open **Summoners War Statistics.sln** file in any IDE (recommended **Visual Studio**)

### Prerequisites

[Microsoft .Net Framework 4.7.2 or higher](https://dotnet.microsoft.com/download/dotnet-framework)

### Installing

1. Download **Summoners War Statistics Setup.exe** file from **Release** tab
2. Run installer
3. Follow steps
4. Run **Summoners War Statistics.exe** from your Desktop

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
