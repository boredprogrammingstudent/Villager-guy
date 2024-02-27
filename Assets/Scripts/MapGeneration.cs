using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    [SerializeField] Vector2 MapSize;
    [SerializeField] Biome[] biomes;
    public void Generate()
    {
        
    }
    public void GenerateTile(Biome biome)
    {

    }
    public int IndexFromWeights(List<int> weights)
    {
        return 0;
    }
}
