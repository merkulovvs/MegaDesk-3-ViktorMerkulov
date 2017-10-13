using System;


namespace MegaDesk_3_ViktorMerkulov
{
    class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
        public SurfaceMaterials materials;
    }

    enum SurfaceMaterials
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    };
}
