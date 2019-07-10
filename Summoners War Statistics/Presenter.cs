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

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

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
                        Console.WriteLine(json.WizardInfo.WizardName);
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("You picked the wrong JSON file. Probably exported from SWOP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Why didn't you choose the JSON file? Nothing's gonna happen, because of you.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void View_FormOnLoad()
        {
            view.Test = model.Test();
        }
    }
}
