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
        private readonly MonsterPresenter monsterPresenter;
        // runes tab presenter here
        private readonly DimHolePresenter dimHolePresenter;
        private readonly OtherPresenter otherPresenter;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            summaryPresenter = new SummaryPresenter(this.view.SummaryView, model);
            monsterPresenter = new MonsterPresenter(this.view.MonstersView, model);
            dimHolePresenter = new DimHolePresenter(this.view.DimHoleView, model);
            otherPresenter = new OtherPresenter(this.view.OtherView, model);

            this.view.SelectFileButtonClicked += View_SelectFileButtonClicked;

            this.view.MenuView.ButtonClicked += MenuView_ButtonClicked;
        }

        private void MenuView_ButtonClicked(object obj)
        {
            if (obj.GetType() != typeof(PictureBox)) { return; }
            var buttonClicked = (PictureBox)obj;

            view.HideViews();
            switch (buttonClicked.Name.Remove(0, 10).ToLower())
            {
                case "summary":
                    view.SummaryViewVisibility = true;
                    break;
                case "monsters":
                    view.MonstersViewVisibility = true;
                    break;
                case "runes":
                    view.RunesViewVisibility = true;
                    break;
                case "dimhole":
                    view.DimHoleViewVisibility = true;
                    break;
                case "other":
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
            if (view.OpenFile.ShowDialog() == DialogResult.OK)
            {
                if (view.OpenFile.FileName.Contains(".json"))
                {
                    var json = JsonSwex.FromJson(File.ReadAllText($"{view.OpenFile.FileName}"));

                    try
                    {
                        view.SummaryView.Init(json.WizardInfo, json.DimensionHoleInfo, json.UnitList, json.UnitLockList, json.Runes, File.GetLastWriteTime($"{view.OpenFile.FileName}"), json.Country);
                        view.MonstersView.MonstersListView.Items.Clear();
                        view.MonstersView.Init(json.UnitList, json.UnitLockList);
                        // here Runes tabs
                        view.DimHoleView.DimHoleMonstersListView.Items.Clear();
                        view.DimHoleView.Init(json.DimensionHoleInfo, json.UnitList);
                        view.OtherView.SummonerFriendsList.Items.Clear();
                        view.OtherView.Init(json.FriendList);
                    }
                    catch (NullReferenceException e)
                    {
                        view.ShowMessage("You picked the wrong JSON file. Probably exported from SWOP or before Dimensional Hole update.", MessageBoxIcon.Error);
                        Console.WriteLine(e);
                    }
                    catch (InvalidJSONException e)
                    {
                        view.ShowMessage("You picked the wrong JSON file. Probably exported from SWOP or before Dimensional Hole update.", MessageBoxIcon.Error);
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    view.ShowMessage("Why didn't you choose the JSON file? Nothing's gonna happen, because of you.", MessageBoxIcon.Information);
                }
            }
        }
    }
}
