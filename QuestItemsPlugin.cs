using BepInEx;
using DrakesWorkshopLibs;
using DrakesItemForge;

namespace DrakesQuestItems;

[BepInPlugin(GUID, ModName, Version)]
[BepInDependency(CustomizeLibsPlugin.GUID, BepInDependency.DependencyFlags.HardDependency)]
[BepInDependency(ItemForgePlugin.GUID, BepInDependency.DependencyFlags.HardDependency)]
public partial class QuestItemsPlugin : BaseUnityPlugin
{
    private void Awake() => Logger.LogInfo($"{ModName} {Version} loaded (Phase 1 stub).");
}
