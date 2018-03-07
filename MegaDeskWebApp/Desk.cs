using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk2_MelissaMoakeChrisBrown
{
    public enum MaterialType
    {
        Pine = 50,
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 125
    };
  
    class Desk
    {
        public decimal Width;
        public decimal Depth;
        public int NumOfDrawers;
        public MaterialType MaterialType;
        public string MaterialName { get { return this.MaterialType.ToString(); } set { } }

        public const decimal MIN_WIDTH = 24;
        public const decimal MAX_WIDTH = 96;
        public const decimal MIN_DEPTH = 12;
        public const decimal MAX_DEPTH = 48;
        public const int DRAWERS_MIN = 0;
        public const int DRAWERS_MAX = 7;
    }
}
