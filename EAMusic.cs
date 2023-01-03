using EAMusic.MusicBoxes;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace EAMusic
{
    public class EAMusic : Mod
    {
        public EAMusic() { }
        public override void Load()
        {
            if (!Main.dedServ)
            {
                QuickMusicBox("AncientsTheme", ItemType<AncientsBoxItem>(), TileType<AncientsBox>());
                QuickMusicBox("AqueousTheme", ItemType<AqueousBoxItem>(), TileType<AqueousBox>());
                QuickMusicBox("CelestialThemeSolar", ItemType<CelestialSolarBoxItem>(), TileType<CelestialSolarBox>());
                QuickMusicBox("CelestialThemeStardust", ItemType<CelestialStardustBoxItem>(), TileType<CelestialStardustBox>());
                QuickMusicBox("CelestialThemeVortex", ItemType<CelestialVortexBoxItem>(), TileType<CelestialVortexBox>());
                QuickMusicBox("CelestialThemeNebula", ItemType<CelestialNebulaBoxItem>(), TileType<CelestialNebulaBox>());
                QuickMusicBox("AstraTheme", ItemType<AstraBoxItem>(), TileType<AstraBox>());
                QuickMusicBox("InfernaceTheme", ItemType<InfernaceBoxItem>(), TileType<InfernaceBox>());
                QuickMusicBox("ObserverTheme", ItemType<ObserverBoxItem>(), TileType<ObserverBox>());
                QuickMusicBox("ObsidiousTheme", ItemType<ObsidiousBoxItem>(), TileType<ObsidiousBox>());
                QuickMusicBox("PermafrostTheme", ItemType<PermafrostBoxItem>(), TileType<PermafrostBox>());
                QuickMusicBox("RegarothTheme", ItemType<RegarothBoxItem>(), TileType<RegarothBox>());
                QuickMusicBox("ScourgeFighterTheme", ItemType<ScourgeFighterBoxItem>(), TileType<ScourgeFighterBox>());
                QuickMusicBox("ToySlimeTheme", ItemType<ToySlimeBoxItem>(), TileType<ToySlimeBox>());
                QuickMusicBox("VoidLeviathanTheme", ItemType<VoidLeviathanBoxItem>(), TileType<VoidLeviathanBox>());
                QuickMusicBox("VolcanoxTheme", ItemType<VolcanoxBoxItem>(), TileType<VolcanoxBox>());
                QuickMusicBox("WastelandTheme", ItemType<WastelandBoxItem>(), TileType<WastelandBox>());

                QuickMusicBox("PlateauPreHM", ItemType<PlateauPreHMBoxItem>(), TileType<PlateauPreHMBox>());
                QuickMusicBox("PlateauSulfuric", ItemType<PlateauSulfuricBoxItem>(), TileType<PlateauSulfuricBox>());
                QuickMusicBox("PlateauNormal", ItemType<PlateauNormalBoxItem>(), TileType<PlateauNormalBox>());
                QuickMusicBox("PlateauLake", ItemType<PlateauLakeBoxItem>(), TileType<PlateauLakeBox>());
                QuickMusicBox("PlateauEruption", ItemType<PlateauEruptionBoxItem>(), TileType<PlateauEruptionBox>());
                QuickMusicBox("PlateauRifting", ItemType<PlateauRiftingBoxItem>(), TileType<PlateauRiftingBox>());
                QuickMusicBox("EriusTheme", ItemType<EriusBoxItem>(), TileType<EriusBox>());
                QuickMusicBox("AutomatronTheme", ItemType<AutomatronBoxItem>(), TileType<AutomatronBox>());

                QuickMusicBox("AzanaEye", ItemType<AzanaEyeBoxItem>(), TileType<AzanaEyeBox>());
                QuickMusicBox("AzanaBox", ItemType<AzanaBoxItem>(), TileType<AzanaBox>());
                QuickMusicBox("Azana1", ItemType<AzanaBoxTemp1Item>(), TileType<AzanaBoxTemp1>());
                QuickMusicBox("Azana2", ItemType<AzanaBoxTemp2Item>(), TileType<AzanaBoxTemp2>());
                QuickMusicBox("Azana3", ItemType<AzanaBoxTemp3Item>(), TileType<AzanaBoxTemp3>());
                QuickMusicBox("Azana4", ItemType<AzanaBoxTemp4Item>(), TileType<AzanaBoxTemp4>());
            }
        }
        public void QuickMusicBox(string name, int item, int tile) => MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(this, "Sounds/Music/" + name), item, tile);
    }
}
