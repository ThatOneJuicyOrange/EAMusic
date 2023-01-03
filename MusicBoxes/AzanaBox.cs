using Terraria;
using static Terraria.ModLoader.ModContent;

namespace EAMusic.MusicBoxes
{
    public class AzanaBox : MusicBoxTile { public AzanaBox() { } }
    public class AzanaBoxItem : MusicBoxItem { public AzanaBoxItem() : base("Azana (Phase 2)", TileType<AzanaBox>()) { } }

    public class AzanaEyeBox : MusicBoxTile { public AzanaEyeBox() { } }
    public class AzanaEyeBoxItem : MusicBoxItem { public AzanaEyeBoxItem() : base("Azana (Phase 1)", TileType<AzanaEyeBox>()) { } }

    // jank jank jhank - should never be used
    public class AzanaBoxTemp1 : MusicBoxTile { public AzanaBoxTemp1() { } } 
    public class AzanaBoxTemp2 : MusicBoxTile { public AzanaBoxTemp2() { } } 
    public class AzanaBoxTemp3 : MusicBoxTile { public AzanaBoxTemp3() { } } 
    public class AzanaBoxTemp4 : MusicBoxTile { public AzanaBoxTemp4() { } } 
    public class AzanaBoxTemp1Item : AzanaBosTempItem { }
    public class AzanaBoxTemp2Item : AzanaBosTempItem { }
    public class AzanaBoxTemp3Item : AzanaBosTempItem { }
    public class AzanaBoxTemp4Item : AzanaBosTempItem { }

    public abstract class AzanaBosTempItem : MusicBoxItem
    {
        public AzanaBosTempItem() : base("Azana", TileType<AzanaBox>()) { }
        public override bool OnPickup(Player player)
        {
            Item.type = ItemType<AzanaBoxItem>(); // wankily jankily 
            return true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            Item.type = ItemType<AzanaBoxItem>(); // wankily jankily 
        }
    }
}
