using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Template.Core.CustomTrigger
{
    public class ValidationTrigger : TriggerAction<Entry>
    {
        private string _prevValue = string.Empty;
        protected override void Invoke(Entry entry)
        {
            if (entry.Text == "")
            {
                entry.Text = "0";
                return;
            }
            //int n;
            //var isNumeric = int.TryParse(entry.Text, out n);

            //if (!string.IsNullOrWhiteSpace(entry.Text) && (entry.Text.Length > 9 || !isNumeric))
            //{
            //    entry.Text = _prevValue;
            //    return;
            //}

            //_prevValue = entry.Text;
        }
    }
}
