using BepInEx;
using System;
using TimberbornAPI;
using TimberbornAPI.Common;

namespace Hytone.Timberborn.Mods.CustomTopBar
{
    [BepInPlugin(PluginId, PluginName, PluginVersion)]
    [BepInDependency("com.timberapi.timberapi")]
    public class CustomTopBarPlugin : BaseUnityPlugin
    {
        public const string PluginId = "hytone.plugins.customtopbar";
        public const string PluginName = "FoodMaterialsTopBar";
        public const string PluginVersion = "0.0.1";

        public void Awake()
        {
            TimberAPI.AssetRegistry.AddSceneAssets(PluginName, SceneEntryPoint.Global);
            Logger.LogInfo($"Loaded {PluginName}.");
        }

    }
}
