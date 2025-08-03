using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using FreshMvvm;
using Task.Models;
using Xamarin.Forms;

namespace Task.PageModels
{
    public class AddScriptPageModel : FreshBasePageModel

    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string SelectedType { get; set; }
        public List<string> Types { get; set; } = new List<string> { "First Type", "Second Type", "Third Type" };

        public Command SaveScriptCommand => new Command(async () =>
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Code) || string.IsNullOrWhiteSpace(SelectedType))
            {
                await CoreMethods.DisplayAlert("Validation", "Please fill all fields.", "OK");
                return;
            }
            var newScript = new Script
            {
                Name = Name,
                Code = Code,
                Type = SelectedType
            };

            await CoreMethods.PopPageModel(newScript, modal: true);

        });

        public Command CancelCommand => new Command(async () =>
        {
            await CoreMethods.PopPageModel(null, modal: true);

        });
    }
}
