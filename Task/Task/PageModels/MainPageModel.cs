using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using FreshMvvm;
using Task.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Task.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {
        public ObservableCollection<Script> ScriptsList { get; set; } = new ObservableCollection<Script> {
            new Script { Name = "First Script", Code = "First Code", Type = "First Type" },
            new Script { Name = "Second Script", Code = "Second Code", Type =  "Second Type" },
            new Script { Name = "Third Script", Code = "Third Code", Type =  "Third Type" },
            new Script { Name = "First Script", Code = "First Code", Type =  "First Type" },
            new Script { Name = "Second Script", Code = "Second Code", Type =  "Second Type" },
            new Script { Name = "Third Script", Code = "Third Code", Type =  "Third Type" },
            new Script { Name = "First Script", Code = "First Code", Type =  "First Type" },
            new Script { Name = "Second Script", Code = "Second Code", Type =  "Second Type" },
            new Script { Name = "Third Script", Code = "Third Code", Type =  "Third Type" },
        };

        public Command AddScriptCommand => new Command(async () =>
        {
            await CoreMethods.PushPageModel<AddScriptPageModel>(null, modal: true);

        });

        public Command DeleteScriptCommand => new Command<Script>(async (script) =>
        {
            if (script != null && ScriptsList.Contains(script))
            {
                var confirm = await CoreMethods.DisplayAlert("Delete", "Are you sure you want to delete this item?", "Yes", "No");
                if (confirm)
                {
                    ScriptsList.Remove(script);
                }
            }

        });
        public override void ReverseInit(object value)
        {
            if (value != null)
            {
                var script = value as Script;
                ScriptsList.Add(script);
            }
        }


    }
}
