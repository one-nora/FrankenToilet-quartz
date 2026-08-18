using System;
using PluginConfig.API;
using PluginConfig.API.Decorators;
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
        
        alma.FillPanel(almaPanel);
        Bananastudio.FillPanel(BananastudioPanel);
        BlaixenU.FillPanel(BlaixenUPanel);
        bobthecorn.FillPanel(bobthecornPanel);
        Bryan.FillPanel(BryanPanel);
        Plonk.FillPanel(PlonkPanel);
    }
    
    public static class alma
    {
        public static FloatSliderField LevelJumpscareChance;

        public static void FillPanel(ConfigPanel configPanel)
        {
            LevelJumpscareChance = new FloatSliderField(configPanel, "Level jumpscare chance", "alma.LevelJumpscareChance", new Tuple<float, float>(0f, 100f), 15f, 0);
        }
    }

    public static class Bananastudio
    {
        public static BoolField EnableAchievements;
        public static BoolField EnableAdsOnDeath;
        public static BoolField EnablePlushiesFalling;
        public static BoolField EnablePlayerBuffs;
        public static BoolField EnableSpecialBossHealthBars;

        public static FloatSliderField ReplaceDoorTexturesWithMemesChance;
        public static FloatSliderField MinosOverrideChance;
        
        public static BoolField EnableEVILV1;
        public static FloatSliderField EvilV1SpawnChance;

        public static BoolField EnableImplosionsOnEnemyDeath;
        public static FloatField ImplosionRadius;
        
        public static void FillPanel(ConfigPanel configPanel)
        {
            EnableAchievements = new BoolField(configPanel, "Enable minecraft style achievements", "Bananastudio.EnableAchievements", true);
            EnableAdsOnDeath = new BoolField(configPanel, "Enable ads on death", "Bananastudio.EnableAdsOnDeath", true);
            EnablePlushiesFalling = new BoolField(configPanel, "Enable plushies falling on the main menu", "Bananastudio.EnablePlushiesFalling", true);
            EnablePlayerBuffs = new BoolField(configPanel, "Enable player buffs", "Bananastudio.EnablePlayerBuffs", true);
            EnableSpecialBossHealthBars = new BoolField(configPanel, "Enable special boss health bars", "Bananastudio.EnableSpecialBossHealthBars", true);

            ReplaceDoorTexturesWithMemesChance = new FloatSliderField(configPanel, "Chance to replace door with meme textures", "Bananastudio.ReplaceDoorTexturesWithMemesChance", new Tuple<float, float>(0f, 100f), 75f, 0);
            MinosOverrideChance = new FloatSliderField(configPanel, "Override boss with minos chance", "Bananastudio.MinosOverrideChance", new Tuple<float, float>(0f, 100f), 55f, 0);
            
            new ConfigHeader(configPanel, "Evil v1 Settings");
            EnableEVILV1 = new BoolField(configPanel, "Enable evil V1", "Bananastudio.EnableEVILV1", true);
            EvilV1SpawnChance = new FloatSliderField(configPanel, "Evil v1 spawn chance (the rest of the chance is used for player buffs)", "Bananastudio.EVILV1SpawnChance", new Tuple<float, float>(0f, 100f), 35f, 0);
            
            new ConfigHeader(configPanel, "Implosion Settings");
            EnableImplosionsOnEnemyDeath = new BoolField(configPanel, "Enable implosions on enemy death", "Bananastudio.EnableImplosionsOnEnemyDeath", true);
            ImplosionRadius = new FloatField(configPanel, "Implosion radius", "Bananastudio.ImplosionRadius", 30f);
        }
    }
    
    public static class BlaixenU
    {
        public static BoolField EnablePopups;
        public static IntField PopupsMinSpawnTime;
        public static IntField PopupsMaxSpawnTime;
        
        public static void FillPanel(ConfigPanel configPanel)
        {
            EnablePopups = new BoolField(configPanel, "Enable popups on screen", "BlaixenU.EnablePopups", true);
            PopupsMinSpawnTime = new IntField(configPanel, "Popups min spawn time", "BlaixenU.PopupsMinSpawnTime", 5);
            PopupsMaxSpawnTime = new IntField(configPanel, "Popups max spawn time", "BlaixenU.PopupsMaxSpawnTime", 15);
        }
    }
    
    public static class bobthecorn
    {
        public static BoolField EnableUltraClicker;

        public static void FillPanel(ConfigPanel configPanel)
        {
            EnableUltraClicker = new BoolField(configPanel, "Enable ultra clicker (available on sandbox)", "bobthecorn.EnableUltraClicker", true);
        }
    }

    public static class Bryan
    {
        public static BoolField EnableBridgeBurnerTransLighting;
        public static FloatSliderField TextChaosChance;
        public static BoolField ReplaceTextFonts;
        public static BoolField EnableTF2HeavySkulls;
        public static BoolField EnableTF2HeavyParryFlash;
        public static BoolField EnableCustomStyles;
        public static BoolField EnableCustomSkullDeathScreen;
        public static FloatSliderField TransFlagOnDeathScreenChance;
        public static BoolField ReplaceSomethingWickedWithTF2Heavy;
        public static BoolField ReplaceMauriceModel;
        public static BoolField ReplaceHUDTabName;
        public static BoolField ReplaceUltrakillTitleImages;

        public static BoolField DuplicateProjectiles;
        public static FloatField DuplicateProjectilesTime;
        
        public static void FillPanel(ConfigPanel configPanel)
        {
            EnableBridgeBurnerTransLighting = new BoolField(configPanel, "Enable bridge burner trans lighting", "Bryan.EnableBridgeBurnerTransLighting", true);
            TextChaosChance = new FloatSliderField(configPanel, "Chance for text chaos to occur", "Bryan.TextChaosChance", new Tuple<float, float>(0f, 100f), 25f, 0);
            ReplaceTextFonts = new BoolField(configPanel, "Replace text fonts", "Bryan.ReplaceTextFonts");
            EnableTF2HeavySkulls = new BoolField(configPanel, "Enable TF2 Heavy skulls", "Bryan.EnableTF2HeavySkulls");
            EnableTF2HeavyParryFlash = new BoolField(configPanel, "Enable TF2 Heavy parry flash", "Bryan.EnableTF2HeavyParryFlash");
            EnableCustomStyles = new BoolField(configPanel, "Enable custom styles", "Bryan.EnableCustomStyles");
            EnableCustomSkullDeathScreen = new BoolField(configPanel, "Enable custom skull death screen", "Bryan.EnableCustomSkullDeathScreen");
            TransFlagOnDeathScreenChance = new FloatSliderField(configPanel, "Trans flag on death screen chance", "Bryan.TransFlagOnDeathScreenChance", new Tuple<float, float>(0f, 100f), 25f, 0);
            ReplaceSomethingWickedWithTF2Heavy = new BoolField(configPanel, "Replace Something Wicked with TF2 Heavy", "Bryan.ReplaceSomethingWickedWithTF2Heavy");
            ReplaceMauriceModel = new BoolField(configPanel, "Replace Maurice model", "Bryan.ReplaceMauriceModel");
            ReplaceHUDTabName = new BoolField(configPanel, "Replace HUD tab name", "Bryan.ReplaceHUDTabName");
            ReplaceUltrakillTitleImages = new BoolField(configPanel, "Replace ULTRAKILL title images", "Bryan.ReplaceUltrakillTitleImages");
            DuplicateProjectiles = new BoolField(configPanel, "Duplicate projectiles", "Bryan.DuplicateProjectiles");
            DuplicateProjectilesTime = new FloatField(configPanel, "Duplicate projectiles time", "Bryan.DuplicateProjectilesTime", 0.5f);
        }
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