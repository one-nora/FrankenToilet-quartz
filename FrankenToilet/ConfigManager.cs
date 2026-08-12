using PluginConfig.API;
using PluginConfig.API.Fields;

namespace FrankenToilet;

public static class ConfigManager
{
    public static PluginConfigurator config = null;
    
    public static void Initialize()
    {
        if (config != null)
            return;

        config = PluginConfigurator.Create(MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_GUID);
        
        ConfigPanel almaPanel = new ConfigPanel(config.rootPanel, "alma", "alma_panel");
        ConfigPanel BananastudioPanel = new ConfigPanel(config.rootPanel, "Bananastudio", "Bananastudio_panel");
        ConfigPanel BlaixenUPanel = new ConfigPanel(config.rootPanel, "BlaixenU", "BlaixenU_panel");
        ConfigPanel bobthecornPanel = new ConfigPanel(config.rootPanel, "bobthecorn", "bobthecorn_panel");
        ConfigPanel BryanPanel = new ConfigPanel(config.rootPanel, "Bryan", "Bryan_panel");
        //ConfigPanel CorePanel = new ConfigPanel(config.rootPanel, "Core", "Core_panel");
        ConfigPanel dolfelivePanel = new ConfigPanel(config.rootPanel, "dolfelive", "dolfelive_panel");
        ConfigPanel doomahrealPanel = new ConfigPanel(config.rootPanel, "doomahreal", "doomahreal_panel");
        ConfigPanel duvizPanel = new ConfigPanel(config.rootPanel, "duviz", "duviz_panel");
        ConfigPanel earthlingPanel = new ConfigPanel(config.rootPanel, "earthling", "earthling_panel");
        ConfigPanel flazhikPanel = new ConfigPanel(config.rootPanel, "flazhik", "flazhik_panel");
        ConfigPanel greycsontPanel = new ConfigPanel(config.rootPanel, "greycsont", "greycsont_panel");
        ConfigPanel lakeullPanel = new ConfigPanel(config.rootPanel, "lakeull", "lakeull_panel");
        ConfigPanel mercyPanel = new ConfigPanel(config.rootPanel, "mercy", "mercy_panel");
        ConfigPanel PlonkPanel = new ConfigPanel(config.rootPanel, "Plonk", "Plonk_panel");
        ConfigPanel prideuniquePanel = new ConfigPanel(config.rootPanel, "prideunique", "prideunique_panel");
        ConfigPanel somebillyPanel = new ConfigPanel(config.rootPanel, "somebilly", "somebilly_panel");
        ConfigPanel triggeredidiotPanel = new ConfigPanel(config.rootPanel, "triggeredidiot", "triggeredidiot_panel");
        
        Plonk.FillPanel(PlonkPanel);
    }
    
    
    public static class Plonk
    {
        public static BoolField EnableGravitySwapOnJump;
        public static BoolField EnableRandomGravitySwapOnTime;
        public static FloatField RandomGravitySwapMinTime;
        public static FloatField RandomGravitySwapMaxTime;
        
        public static void FillPanel(ConfigPanel configPanel)
        {
            EnableGravitySwapOnJump = new BoolField(configPanel, "Enable random gravity swap on jump", "Plonk.EnableGravitySwapOnJump", true);
            EnableRandomGravitySwapOnTime = new BoolField(configPanel, "Enable random gravity swap on time", "Plonk.EnableRandomGravitySwapOnTime", true);
            RandomGravitySwapMinTime = new FloatField(configPanel, "Random gravity swap minimum time (in seconds)", "Plonk.RandomGravitySwapMinTime", 1f);
            RandomGravitySwapMaxTime = new FloatField(configPanel, "Random gravity swap maximum time (in seconds)", "Plonk.RandomGravitySwapMaxTime", 10f);
        }
    }
}