using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    [Serializable] 
    public struct Biome : HasWeight, HoldsWeighted<TileInstance>
    {
        public string name;
        public TileInstance[] tiles;
        public int weight { get; set; }
        public readonly TileInstance[] GetWeighted() => tiles;
    }
    [Serializable]
    public struct TileInstance : HasWeight
    {
        public Tile tile;
        public int weight { get; set; }
    }
}
