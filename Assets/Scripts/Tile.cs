using System;
using UnityEngine;
namespace Assets.Scripts
{
    [Serializable]
    public struct Tile
    {
        public string name;
        public TileTexture[] textures;
    }
    [Serializable]
    public struct TileTexture
    {
        public Sprite sprite;
        public int weight;
    }
}
