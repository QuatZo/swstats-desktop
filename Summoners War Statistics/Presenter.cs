using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    class Presenter
    {
        private readonly IView view;
        private readonly Model model;

        private readonly SummaryPresenter introductionPresenter;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            introductionPresenter = new SummaryPresenter(this.view.IntroductionView, model);

            this.view.FormOnLoad += View_FormOnLoad;
            this.view.SelectFileButtonClicked += View_SelectFileButtonClicked;
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
                        view.IntroductionView.SummonerName = json.WizardInfo.WizardName;
                        view.IntroductionView.SummonerLevel = json.WizardInfo.WizardLevel;
                        view.IntroductionView.SummonerMana = json.WizardInfo.WizardMana;
                        view.IntroductionView.SummonerCrystals = json.WizardInfo.WizardCrystal;

                        view.IntroductionView.SummonerArenaEnergy = json.WizardInfo.ArenaEnergy;
                        view.IntroductionView.SummonerArenaEnergyMax = json.WizardInfo.ArenaEnergyMax;

                        view.IntroductionView.SummonerDimensionalCrystals = json.WizardInfo.DarkportalEnergy;
                        view.IntroductionView.SummonerDimensionalCrystalsMax = json.WizardInfo.DarkportalEnergyMax;

                        view.IntroductionView.SummonerDimensionalHoleEnergy = json.DimensionHoleInfo.Energy;
                        view.IntroductionView.SummonerDimensionalHoleEnergyMax = json.DimensionHoleInfo.EnergyMax;

                        view.IntroductionView.SummonerEnergy = json.WizardInfo.WizardEnergy;
                        view.IntroductionView.SummonerEnergyMax = json.WizardInfo.EnergyMax;

                        view.IntroductionView.SummonerGloryPoints = json.WizardInfo.HonorPoint;
                        view.IntroductionView.SummonerGuildPoints = json.WizardInfo.GuildPoint;
                        view.IntroductionView.SummonerRTAMedals = json.WizardInfo.HonorMedal;

                        view.IntroductionView.SummonerShapeshiftingStones = json.WizardInfo.CostumePoint;
                    }
                    catch (NullReferenceException e)
                    {
                        view.ShowMessage("You picked the wrong JSON file. Probably exported from SWOP.", MessageBoxIcon.Error);
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    view.ShowMessage("Why didn't you choose the JSON file? Nothing's gonna happen, because of you.", MessageBoxIcon.Information);
                }
            }
        }

        private void View_FormOnLoad()
        {
            
        }
    }
}
