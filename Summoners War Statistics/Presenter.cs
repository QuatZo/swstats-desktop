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

        private readonly MenuPresenter menuPresenter;

        private readonly SummaryPresenter summaryPresenter;
        private readonly MonstersPresenter monsterPresenter;
        private readonly RunesPresenter runesPresenter;
        private readonly DimHolePresenter dimHolePresenter;
        private readonly GuildPresenter guildPresenter;
        private readonly OtherPresenter otherPresenter;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            menuPresenter = new MenuPresenter(this.view.MenuView, model);

            summaryPresenter = new SummaryPresenter(this.view.SummaryView, model);
            monsterPresenter = new MonstersPresenter(this.view.MonstersView, model);
            runesPresenter = new RunesPresenter(this.view.RunesView, model);
            dimHolePresenter = new DimHolePresenter(this.view.DimHoleView, model);
            guildPresenter = new GuildPresenter(this.view.GuildView, model);
            otherPresenter = new OtherPresenter(this.view.OtherView, model);

            this.view.Loaded += View_Loaded;

            this.view.SelectFileButtonClicked += View_SelectFileButtonClicked;

            this.view.MenuView.ButtonClicked += MenuView_ButtonClicked;

            this.view.InitFailed += View_InitFailed;
        }

        private void View_InitFailed()
        {
            view.SummaryView.ResetOnFail();
            view.MonstersView.ResetOnFail();
            view.RunesView.ResetOnFail();
            view.DimHoleView.ResetOnFail();
            view.GuildView.ResetOnFail();
            view.OtherView.ResetOnFail();
        }

        private void View_Loaded()
        {
            List<List<Control>> controlList = new List<List<Control>>()
            {
                view.SummaryView.Cntrls,
                view.MonstersView.Cntrls,
                view.RunesView.Cntrls,
                view.DimHoleView.Cntrls,
                view.GuildView.Cntrls,
                view.OtherView.Cntrls
            };
            foreach(var controls in controlList)
            {
                foreach(var control in controls)
                {
                    if (control.Name.Contains("SummonerName"))
                    {
                        control.Font = new Font(view.FF, 32, FontStyle.Regular);
                        continue;
                    }
                    if (control.Name.Contains("ListView") || control.Name.Contains("TextBox"))
                    {
                        control.Font = new Font(view.FF, 12, FontStyle.Regular);
                        continue;
                    }
                    if (control.Name.Contains("checkedListBox"))
                    {
                        control.Font = new Font(view.FF, 10, FontStyle.Regular);
                        continue;
                    }
                    if (control.Name.Contains("Level"))
                    {
                        control.Font = new Font(view.FF, 20, FontStyle.Regular);
                        continue;
                    }
                    if (control.Name.Contains("Stats") || control.Name == "labelMonsters" || control.Name == "labelRunes" || control.Name.Contains("DimHole") || control.Name.Contains("Other") || control.Name.Contains("Guild"))
                    {
                        control.Font = new Font(view.FF, 24, FontStyle.Regular);
                        continue;
                    }
                    
                    control.Font = new Font(view.FF, 14, FontStyle.Regular);
                }
            }
        }

        private void MenuView_ButtonClicked(object obj)
        {
            if (obj.GetType() != typeof(PictureBox)) { return; }
            var buttonClicked = (PictureBox)obj;

            view.HideViews();

            var buttonClickedName = buttonClicked.Name.Remove(0, 10);
            Logger.log.Info($"Changing tab to [{buttonClickedName}]");
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
                case "guild":
                    view.GuildView.Front();
                    view.GuildViewVisibility = true;
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
            if (view.SummaryViewVisibility) { view.SummaryView.Summary_Resize(null, EventArgs.Empty); }
            else if (view.MonstersViewVisibility) { view.MonstersView.Monsters_Resize(null, EventArgs.Empty); }
            else if (view.RunesViewVisibility) { view.RunesView.Runes_Resize(null, EventArgs.Empty); }
            else if (view.DimHoleViewVisibility) { view.DimHoleView.DimHole_Resize(null, EventArgs.Empty); }
            else if (view.GuildViewVisibility) { view.GuildView.Guild_Resize(null, EventArgs.Empty); }
            else if (view.OtherViewVisibility) { view.OtherView.Other_Resize(null, EventArgs.Empty); }
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
                    string jsonErrorMessage = "You picked incomplete JSON file. You won't see all data, unless you redownload your JSON file using SWEX.";
                    try
                    {
                        var json = JsonSwex.FromJson(File.ReadAllText($"{view.OpenFile.FileName}"));
                        Logger.log.Info($"Initializing...");
                    
                        Logger.log.Info($"Summary tab");
                        view.SummaryView.Init(json.Summoner, json.DimensionHoleInfo, json.MonsterList, json.LockedMonstersList, json.Runes, File.GetLastWriteTime($"{view.OpenFile.FileName}"), json.Country, json.Decks);
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

                        Logger.log.Info($"Guild tab");
                        view.GuildView.GuildMembersList.Items.Clear();
                        view.GuildView.Init(json.GuildMap, json.GuildWarParticipationInfo, json.GuildWarMemberList, json.GuildMemberDefenseList, json.GuildWarRankingStat, json.GuildSiegeDefenseUnitList, json.MonsterList);
                        Logger.log.Info("[Guild] DONE");

                        Logger.log.Info($"Other tab");
                        view.OtherView.SummonerFriendsList.Items.Clear();
                        view.OtherView.Init(json.FriendList, json.DecorationList, json.GuildWarRankingStat, json.ArenaStats["rating_id"]);
                        Logger.log.Info("[Other] DONE");
                    }
                    catch (FormatException e)
                    {
                        view.InitFail();
                        view.ShowMessage(jsonErrorMessage, MessageBoxIcon.Error, e);
                    }
                    catch (NullReferenceException e)
                    {
                        view.InitFail();
                        view.ShowMessage(jsonErrorMessage, MessageBoxIcon.Error, e);
                    }
                    catch (InvalidJSONException e)
                    {
                        view.InitFail();
                        view.ShowMessage(jsonErrorMessage, MessageBoxIcon.Error, e);
                    }
                    finally
                    {
                        Logger.log.Info("Initializing has ended");
                    }
                }
                else
                {
                    Logger.log.Warn($"User didn't choose JSON file.");
                    view.ShowMessage("Why didn't you choose the JSON file? Nothing's gonna happen, because of you.", MessageBoxIcon.Information);
                }
            }
        }
    }
}
