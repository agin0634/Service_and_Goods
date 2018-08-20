using ICities;

namespace Service_and_Goods
{
    class SettingUI
    {
        // Load the configuration
        Service_and_GoodsConfiguration Config = Configuration<Service_and_GoodsConfiguration>.Load();

        public void CreateUI(UIHelperBase helper)
        {

            UIHelperBase Service = helper.AddGroup("Service Remove");


            UIHelperBase PollutionRemove = helper.AddGroup("Pollution Remove");
            PollutionRemove.AddCheckbox("Ground", Config.RemovePollutionGround, (Sel) =>
            {
                Config.RemovePollutionGround = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            }
            );
            PollutionRemove.AddCheckbox("Water", Config.RemovePollutionWater, (Sel) =>
            {
                Config.RemovePollutionWater = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });
            PollutionRemove.AddCheckbox("Noise", Config.RemovePollutionNoise, (Sel) =>
            {
                Config.RemovePollutionNoise = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            }
            );






        }


    }
}

