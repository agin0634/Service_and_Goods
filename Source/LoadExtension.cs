using System;
using System.IO;
using System.Reflection;
using ICities;
using ColossalFramework;
using ColossalFramework.Plugins;
using UnityEngine;

namespace Service_and_Goods
{
    public class LoadExtension : ThreadingExtensionBase
    {
        Service_and_GoodsConfiguration Config = Configuration<Service_and_GoodsConfiguration>.Load();
        //public static LoadExtension instance { get; protected set; }

        private uint PreviousFrameIndex = 0;
        private uint FrameIndexThreshold = 60;
        

        public override void OnCreated(IThreading threading)
        {
            //instance = this;
            base.OnCreated(threading);
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "on created");
        }

        public override void OnReleased()
        {
            base.OnReleased();
           // instance = null;
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "on released");
        }
        /*
        public static bool InGame
        {
            get
            {
                var loading = instance.managers.loading;
                if (loading == null) return false;
                return loading.loadingComplete && (loading.currentMode == AppMode.Game);
            }
        }*/

        public override void OnAfterSimulationFrame()
        {
           /* if (!InGame) {
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "HI");
                return;
            }*/
           

            if (Singleton<DistrictManager>.exists &&
                !SimulationManager.instance.SimulationPaused &&
                SimulationManager.instance.m_currentFrameIndex - PreviousFrameIndex > FrameIndexThreshold)
            {
                if (Config.RemoveServiceGarbage)
                {
                    //ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.)
                    
                }
                if (Config.RemoveServiceHealth)
                {
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.HealthCare, 100000);
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.Health, 100000);
                }
                if (Config.RemoveServiceDeath)
                {
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.DeathCare, 100000);
                }
                if (Config.RemoveServiceCrime)
                {
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.PoliceDepartment, 100000);
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.CrimeRate, -100000);
                }
                if (Config.RemoveServiceFireSafety)
                {
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.FireDepartment, 100000);
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.FireHazard, -100000);
                }
                if (Config.RemoveServiceEducation)
                {
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.EducationElementary, 100000);
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.EducationHighSchool, 100000);
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.EducationUniversity, 100000);

                   

                    DistrictManager dm = Singleton<DistrictManager>.instance;
                    District city = dm.m_districts.m_buffer[0];
                    city.m_productionData.m_tempEducation1Capacity += 1000000u;
                    city.m_productionData.m_tempEducation2Capacity += 1000000u;
                    city.m_productionData.m_tempEducation3Capacity += 1000000u;
                }    

                if (Config.OtherOptionLandValue)
                {
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.LandValue, 100000);
                }
                if (Config.OtherOptionAtractiveness)
                {
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.Attractiveness, 100000);
                }
                if (Config.OtherOptionEntertainment)
                {
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.Entertainment, 100000);
                }


                if (Config.RemovePollutionGround)
                {
                    Singleton<NaturalResourceManager>.instance.AddPollutionDisposeRate(10000);
                }
                if (Config.RemovePollutionWater)
                {
                    Singleton<TerrainManager>.instance.WaterSimulation.AddPollutionDisposeRate(10000);
                }
                if (Config.RemovePollutionNoise)
                {
                    ImmaterialResourceManager.instance.AddResource(ImmaterialResourceManager.Resource.NoisePollution, -10000);
                }
                PreviousFrameIndex = SimulationManager.instance.m_currentFrameIndex;
            };


            base.OnAfterSimulationTick();
        }
    }
}


