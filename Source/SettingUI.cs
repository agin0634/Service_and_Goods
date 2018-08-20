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
            Service.AddCheckbox("Garbage", Config.RemoveServiceGarbage, (Sel) =>
            {
                Config.RemoveServiceGarbage = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });
            Service.AddCheckbox("Health Care", Config.RemoveServiceHealth, (Sel) =>
            {
                Config.RemoveServiceHealth = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });
            Service.AddCheckbox("Death Care", Config.RemoveServiceDeath, (Sel) =>
            {
                Config.RemoveServiceDeath = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });
            Service.AddCheckbox("Crime", Config.RemoveServiceCrime, (Sel) =>
            {
                Config.RemoveServiceCrime = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });
            Service.AddCheckbox("Fire Safety", Config.RemoveServiceFireSafety, (Sel) =>
            {
                Config.RemoveServiceFireSafety = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });
            Service.AddCheckbox("Education", Config.RemoveServiceEducation, (Sel) =>
            {
                Config.RemoveServiceEducation = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });
            
            UIHelperBase OtherOption = helper.AddGroup("Other");
            OtherOption.AddCheckbox("Land Value", Config.OtherOptionLandValue, (Sel) =>
            {
                Config.OtherOptionLandValue = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });
            OtherOption.AddCheckbox("Atractiveness", Config.OtherOptionAtractiveness, (Sel) =>
            {
                Config.OtherOptionAtractiveness = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });
            OtherOption.AddCheckbox("Entertainment", Config.OtherOptionEntertainment, (Sel) =>
            {
                Config.OtherOptionEntertainment = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });

            UIHelperBase PollutionRemove = helper.AddGroup("Pollution Remove");
            PollutionRemove.AddCheckbox("Ground", Config.RemovePollutionGround, (Sel) =>
            {
                Config.RemovePollutionGround = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });
            PollutionRemove.AddCheckbox("Water", Config.RemovePollutionWater, (Sel) =>
            {
                Config.RemovePollutionWater = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });
            PollutionRemove.AddCheckbox("Noise", Config.RemovePollutionNoise, (Sel) =>
            {
                Config.RemovePollutionNoise = Sel;
                Configuration<Service_and_GoodsConfiguration>.Save();
            });






        }


    }
}

