using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    [Serializable] 
    public struct Biome
    {
        public string name;
        public TileInstance[] tiles;
        public int weight;
    }
    [Serializable]
    public struct TileInstance
    {
        public Tile tile;
        public int weight;
    }
}
