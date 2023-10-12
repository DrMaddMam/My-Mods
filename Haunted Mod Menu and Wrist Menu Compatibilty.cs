// Haunted compatiblity
public class HauntedModMenu : BaseUnityPlugin
{
    void OnEnable()
    {
        // Enable or disable the Wrist Mod Menu here
        ModifyWristModMenuConfig();
    }

    void ModifyWristModMenuConfig()
    {
        // Access the configuration of the Wrist Mod Menu
        ConfigFile wristMenuConfig = new ConfigFile("path/to/wristmenu.cfg");

        // Modify the configuration settings to enable or disable features
        wristMenuConfig.Bind<bool>("General", "EnableWristMenu", false); // Disable Wrist Menu
    }
}
