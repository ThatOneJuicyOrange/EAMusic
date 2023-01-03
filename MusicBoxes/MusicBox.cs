using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace EAMusic.MusicBoxes
{
    public class AncientsBox : MusicBoxTile { }
    public class AncientsBoxItem : MusicBoxItem { public AncientsBoxItem() : base("The Ancients", TileType<AncientsBox>()) { } }

    public class AqueousBox : MusicBoxTile { }
    public class AqueousBoxItem : MusicBoxItem { public AqueousBoxItem() : base("Aqueous", TileType<AqueousBox>()) { } }

    public class AstraBox : MusicBoxTile { }
    public class AstraBoxItem : MusicBoxItem { public AstraBoxItem() : base("Astra", TileType<AstraBox>()) { } }

    public class CelestialNebulaBox : MusicBoxTile { }
    public class CelestialNebulaBoxItem : MusicBoxItem { public CelestialNebulaBoxItem() : base("Carina", TileType<CelestialNebulaBox>()) { } }

    public class CelestialSolarBox : MusicBoxTile { }
    public class CelestialSolarBoxItem : MusicBoxItem { public CelestialSolarBoxItem() : base("Ember", TileType<CelestialSolarBox>()) { } }

    public class CelestialStardustBox : MusicBoxTile { }
    public class CelestialStardustBoxItem : MusicBoxItem { public CelestialStardustBoxItem() : base("Nova", TileType<CelestialStardustBox>()) { } }

    public class CelestialVortexBox : MusicBoxTile { }
    public class CelestialVortexBoxItem : MusicBoxItem { public CelestialVortexBoxItem() : base("Aquila", TileType<CelestialVortexBox>()) { } }

    public class InfernaceBox : MusicBoxTile { }
    public class InfernaceBoxItem : MusicBoxItem { public InfernaceBoxItem() : base("Infernace", TileType<InfernaceBox>()) { } }

    public class ObserverBox : MusicBoxTile { }
    public class ObserverBoxItem : MusicBoxItem { public ObserverBoxItem() : base("Cosmic Observer", TileType<ObserverBox>()) { } }

    public class ObsidiousBox : MusicBoxTile { }
    public class ObsidiousBoxItem : MusicBoxItem { public ObsidiousBoxItem() : base("Obsidious", TileType<ObsidiousBox>()) { } }

    public class PermafrostBox : MusicBoxTile { }
    public class PermafrostBoxItem : MusicBoxItem { public PermafrostBoxItem() : base("Permafrost", TileType<PermafrostBox>()) { } }

    public class RegarothBox : MusicBoxTile { }
    public class RegarothBoxItem : MusicBoxItem { public RegarothBoxItem() : base("Regaroth", TileType<RegarothBox>()) { } }

    public class ScourgeFighterBox : MusicBoxTile { }
    public class ScourgeFighterBoxItem : MusicBoxItem { public ScourgeFighterBoxItem() : base("Scourge Fighter", TileType<ScourgeFighterBox>()) { } }

    public class ToySlimeBox : MusicBoxTile { }
    public class ToySlimeBoxItem : MusicBoxItem { public ToySlimeBoxItem() : base("Toy Slime", TileType<ToySlimeBox>()) { } }

    public class VoidLeviathanBox : MusicBoxTile { }
    public class VoidLeviathanBoxItem : MusicBoxItem { public VoidLeviathanBoxItem() : base("Void Leviathan", TileType<VoidLeviathanBox>()) { } }

    public class VolcanoxBox : MusicBoxTile { }
    public class VolcanoxBoxItem : MusicBoxItem { public VolcanoxBoxItem() : base("Volcanox", TileType<VolcanoxBox>()) { } }

    public class WastelandBox : MusicBoxTile { }
    public class WastelandBoxItem : MusicBoxItem { public WastelandBoxItem() : base("Wasteland", TileType<WastelandBox>()) { } }

    // VOLCANIC PLATEAU
    public class PlateauPreHMBox : MusicBoxTile { }
    public class PlateauPreHMBoxItem : MusicBoxItem { public PlateauPreHMBoxItem() : base("Dormant Plateaus", TileType<PlateauPreHMBox>()) { } }

    public class PlateauSulfuricBox : MusicBoxTile { }
    public class PlateauSulfuricBoxItem : MusicBoxItem { public PlateauSulfuricBoxItem() : base("Toxic Dunes", TileType<PlateauSulfuricBox>()) { } }
    
    public class PlateauNormalBox : MusicBoxTile { }
    public class PlateauNormalBoxItem : MusicBoxItem { public PlateauNormalBoxItem() : base("Volcanic Plateau", TileType<PlateauNormalBox>()) { } }
    
    public class PlateauLakeBox : MusicBoxTile { }
    public class PlateauLakeBoxItem : MusicBoxItem { public PlateauLakeBoxItem() : base("Infernal Lake", TileType<PlateauLakeBox>()) { } }

    public class PlateauEruptionBox : MusicBoxTile { }
    public class PlateauEruptionBoxItem : MusicBoxItem { public PlateauEruptionBoxItem() : base("Eruption", TileType<PlateauEruptionBox>()) { } }

    public class PlateauRiftingBox : MusicBoxTile { }
    public class PlateauRiftingBoxItem : MusicBoxItem { public PlateauRiftingBoxItem() : base("Rifting", TileType<PlateauRiftingBox>()) { } }

    public class EriusBox : MusicBoxTile { }
    public class EriusBoxItem : MusicBoxItem { public EriusBoxItem() : base("Erius", TileType<EriusBox>()) { } }

    public class AutomatronBox : MusicBoxTile { }
    public class AutomatronBoxItem : MusicBoxItem { public AutomatronBoxItem() : base("AbandonedAutomatron", TileType<AutomatronBox>()) { } }
    public abstract class MusicBoxTile : ModTile
    {
        public override string Texture
        {
            get
            {
                if (!HasAsset("EAMusic/MusicBoxes/" + GetType().Name)) return "EAMusic/MusicBoxes/MusicBoxPlaceholder";
                return base.Texture;
            }
        }
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;

            TileID.Sets.DisableSmartCursor[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Music Box");
            AddMapEntry(new Color(200, 200, 200), name);

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 48, Mod.Find<ModItem>(GetType().Name + "Item").Type);
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.cursorItemIconEnabled = true;
            player.cursorItemIconID = Mod.Find<ModItem>(GetType().Name + "Item").Type;
        }
    }
    public abstract class MusicBoxItem : ModItem
    {
        private int tileID;
        private string name;
        protected MusicBoxItem(string name, int tileID)
        {
            this.name = name;
            this.tileID = tileID;
        }
        public override string Texture
        {
            get
            {
                if (!HasAsset("EAMusic/MusicBoxes/" + GetType().Name)) return "EAMusic/MusicBoxes/MusicBoxItemPlaceholder";
                return base.Texture;
            }
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (" + name + ")");
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;

            Item.useStyle = 1;
            Item.useAnimation = 15;
            Item.useTime = 10;

            Item.autoReuse = true;
            Item.consumable = true;
            Item.useTurn = true;
            Item.accessory = true;

            Item.createTile = tileID;

            Item.rare = 4;
            Item.value = 100000;
        }
    }
}
