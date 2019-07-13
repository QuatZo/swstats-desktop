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

        private readonly SummaryPresenter summaryPresenter;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            summaryPresenter = new SummaryPresenter(this.view.SummaryView, model);

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
                        view.SummaryView.Init(json.WizardInfo, json.DimensionHoleInfo, json.UnitList, json.UnitLockList, json.Runes);
                        Console.WriteLine(json.UnitList.Count);
                    }
                    catch (NullReferenceException e)
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

        private void View_FormOnLoad()
        {
            
        }
    }
}
