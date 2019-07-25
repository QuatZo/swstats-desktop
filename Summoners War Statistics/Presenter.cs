using Summoners_War_Statistics.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    class Presenter
    {
        private readonly IView view;
        private readonly Model model;

        private readonly SummaryPresenter summaryPresenter;
        private readonly MonstersPresenter monsterPresenter;
        private readonly RunesPresenter runesPresenter;
        private readonly DimHolePresenter dimHolePresenter;
        private readonly OtherPresenter otherPresenter;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            summaryPresenter = new SummaryPresenter(this.view.SummaryView, model);
            monsterPresenter = new MonstersPresenter(this.view.MonstersView, model);
            runesPresenter = new RunesPresenter(this.view.RunesView, model);
            dimHolePresenter = new DimHolePresenter(this.view.DimHoleView, model);
            otherPresenter = new OtherPresenter(this.view.OtherView, model);

            this.view.Loaded += View_Loaded;

            this.view.SelectFileButtonClicked += View_SelectFileButtonClicked;

            this.view.MenuView.ButtonClicked += MenuView_ButtonClicked;
        }

        private void View_Loaded()
        {
            foreach (var control in view.SummaryView.Cntrls)
            {
                if (control.Name.Contains("SummonerName"))
                {
                    control.Font = new Font(view.FF, 32, FontStyle.Regular);
                    continue;
                }

                if (control.Name.Contains("Country") || control.Name.Contains("Language") || control.Name.Contains("Level"))
                {
                    control.Font = new Font(view.FF, 20, FontStyle.Regular);
                    continue;
                }
                control.Font = new Font(view.FF, 14, FontStyle.Regular);
            }

            foreach (var control in view.MonstersView.Cntrls)
            {
                if (control.Name.Contains("Stats") || control.Name == "labelMonsters")
                {
                    control.Font = new Font(view.FF, 24, FontStyle.Regular);
                    continue;
                }
                if (control.Name.Contains("ListView"))
                {
                    control.Font = new Font(view.FF, 10, FontStyle.Regular);
                    continue;
                }
                control.Font = new Font(view.FF, 14, FontStyle.Regular);
            }

            foreach (var control in view.RunesView.Cntrls)
            {
                if (control.Name.Contains("ListView"))
                {
                    control.Font = new Font(view.FF, 10, FontStyle.Regular);
                    continue;
                }
                if (control.Name == "labelRunes")
                {
                    control.Font = new Font(view.FF, 24, FontStyle.Regular);
                    continue;
                }
                control.Font = new Font(view.FF, 14, FontStyle.Regular);
            }

            foreach (var control in view.DimHoleView.Cntrls)
            {
                if (control.Name.Contains("ListView"))
                {
                    control.Font = new Font(view.FF, 10, FontStyle.Regular);
                    continue;
                }
                if (control.Name.Contains("DimHole"))
                {
                    control.Font = new Font(view.FF, 24, FontStyle.Regular);
                    continue;
                }
                control.Font = new Font(view.FF, 14, FontStyle.Regular);
            }

            foreach (var control in view.OtherView.Cntrls)
            {
                if (control.Name.Contains("ListView"))
                {
                    control.Font = new Font(view.FF, 10, FontStyle.Regular);
                    continue;
                }
                if (control.Name.Contains("Other"))
                {
                    control.Font = new Font(view.FF, 24, FontStyle.Regular);
                    continue;
                }
                control.Font = new Font(view.FF, 14, FontStyle.Regular);
            }
        }

        private void MenuView_ButtonClicked(object obj)
        {
            if (obj.GetType() != typeof(PictureBox)) { return; }
            var buttonClicked = (PictureBox)obj;

            view.HideViews();

            var buttonClickedName = buttonClicked.Name.Remove(0, 10);
            Logger.log.Info($"Changing tab to {buttonClickedName}");
            switch (buttonClickedName.ToLower())
            {
                case "summary":
                    view.SummaryView.Front();
                    view.SummaryViewVisibility = true;
                    break;
                case "monsters":
                    view.MonstersView.Front();
                    view.MonstersViewVisibility = true;
                    break;
                case "runes":
                    view.RunesView.Front();
                    view.RunesViewVisibility = true;
                    break;
                case "dimhole":
                    view.DimHoleView.Front();
                    view.DimHoleViewVisibility = true;
                    break;
                case "other":
                    view.OtherView.Front();
                    view.OtherViewVisibility = true;
                    break;
                default:
                    break;
            }

            foreach (var button in view.MenuView.Buttons)
            {
                string resourceName;
                string buttonName = button.Name.Remove(0, 10).ToLower();

                if (button == buttonClicked) { resourceName = "menu_" + buttonName + "_on"; }
                else { resourceName = "menu_" + buttonName + "_off"; }

                ResourceManager rm = Resources.ResourceManager;
                button.Image = (Image)rm.GetObject(resourceName);
            }
        }

        private void View_SelectFileButtonClicked()
        {
            Logger.log.Info("Selecting file...");
            if (view.OpenFile.ShowDialog() == DialogResult.OK)
            {
                Logger.log.Info($"Selected file {view.OpenFile.FileName}");
                if (view.OpenFile.FileName.Contains(".json"))
                {
                    Logger.log.Info($"Reading file {view.OpenFile.FileName}");
                    var json = JsonSwex.FromJson(File.ReadAllText($"{view.OpenFile.FileName}"));

                    Logger.log.Info($"Initializing...");
                    try
                    {
                        Logger.log.Info($"Summary tab");
                        view.SummaryView.Init(json.Summoner, json.DimensionHoleInfo, json.MonsterList, json.LockedMonstersList, json.Runes, File.GetLastWriteTime($"{view.OpenFile.FileName}"), json.Country);
                        Logger.log.Info("[Summary] DONE");

                        Logger.log.Info($"Monsters tab");
                        view.MonstersView.MonstersListView.Items.Clear();
                        view.MonstersView.Init(json.MonsterList, json.LockedMonstersList);
                        Logger.log.Info("[Monsters] DONE");

                        Logger.log.Info($"Runes tab");
                        view.RunesView.Init(model.RunesEvenEquipped(json.Runes, json.MonsterList), model.MonstersMasterId(json.MonsterList));
                        Logger.log.Info("[Runes] DONE");

                        Logger.log.Info($"Dimension Hole tab");
                        view.DimHoleView.DimHoleMonstersListView.Items.Clear();
                        view.DimHoleView.Init(json.DimensionHoleInfo, json.MonsterList);
                        Logger.log.Info("[Dimension Hole] DONE");

                        Logger.log.Info($"Other tab");
                        view.OtherView.SummonerFriendsList.Items.Clear();
                        view.OtherView.GuildMembersList.Items.Clear();
                        view.OtherView.Init(json.FriendList, json.Guild, json.GuildWarParticipationInfo, json.GuildWarMemberList, json.GuildMemberDefenseList, json.GuildWarRankingStat);
                        Logger.log.Info("[Other] DONE");
                    }
                    catch (NullReferenceException e)
                    {
                        Logger.log.Error($"Initializer encountered a problem. It won't load more data.");
                        view.ShowMessage("You picked incomplete JSON file. You won't see all data, unless you redownload your JSON file using SWEX.", MessageBoxIcon.Error);
                        Logger.log.Error(e.StackTrace);
                    }
                    catch (InvalidJSONException e)
                    {
                        Logger.log.Error($"Initializer encountered a problem. It won't load more data.");
                        view.ShowMessage("You picked incomplete JSON file. You won't see all data, unless you redownload your JSON file using SWEX.", MessageBoxIcon.Error);
                        Logger.log.Error(e.StackTrace);
                    }
                    finally
                    {
                        Logger.log.Info("Initializing has ended");
                    }
                }
                else
                {
                    Logger.log.Warn($"User didn't choose any file.");
                    view.ShowMessage("Why didn't you choose the JSON file? Nothing's gonna happen, because of you.", MessageBoxIcon.Information);
                }
            }
        }
    }
}
