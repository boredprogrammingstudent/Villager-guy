using System;
using UnityEngine;
namespace Assets.Scripts
{
    [Serializable]
    public struct Tile : HoldsWeighted<TileTexture>
    {
        public string name;
        public TileTexture[] textures;
        public readonly TileTexture[] GetWeighted() => textures;
    }
    [Serializable]
    public struct TileTexture : HasWeight
    {
        public Sprite sprite;
        public int weight { get; set; }
    }
}
