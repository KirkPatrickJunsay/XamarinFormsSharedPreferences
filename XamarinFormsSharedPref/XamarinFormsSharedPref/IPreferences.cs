using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFormsSharedPref
{
    public interface IPreferences
    {
        bool InsertColorSetting(string setting);
        string RetrieveColorSetting();
    }
}
