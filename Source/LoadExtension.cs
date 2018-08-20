using System;
using System.IO;
using System.Reflection;
using ICities;
using ColossalFramework.Plugins;
using UnityEngine;

namespace Service_and_Goods
{
    public class LoadExtension : ThreadingExtensionBase
    {
        Service_and_GoodsConfiguration Config = Configuration<Service_and_GoodsConfiguration>.Load();
        public static LoadExtension Instance { get; protected set; }

        public override void OnCreated(IThreading threading)
        {
            Instance = this;
            base.OnCreated(threading);
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "on created");
        }

        public override void OnReleased()
        {
            base.OnReleased();
            Instance = null;
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "on released");
        }

        public override void OnAfterSimulationFrame()
        {
            //TODO logic

            if (Config.RemovePollutionGround)
            {
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Remove Ground on");
            }
            base.OnAfterSimulationFrame();
        }
    }
}


