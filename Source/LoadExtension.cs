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
                //DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "HI");
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


