using System;
using ICities;
using ColossalFramework.UI;
using UnityEngine;

namespace Service_and_Goods
{

    public class Service_and_Goods : IUserMod
    {

        public string Name { get { return "Service_and_Goods"; } }

        //TODO define
        public string Description { get { return "Here is where I define my mod"; } }

        public void OnSettingsUI(UIHelperBase helper)
        {
            SettingUI settingUI = new SettingUI();
            settingUI.CreateUI(helper);
        }
    }
}

