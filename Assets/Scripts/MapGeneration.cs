using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Assets.Scripts.Utils;
public class MapGeneration : MonoBehaviour
{
    [SerializeField] GameObject TilePrefab;
    [SerializeField] Vector2 MapSize;
    [SerializeField] Biome[] biomes;
    public void Generate()
    {
        
    }
    public void GenerateTile(Biome biome, Vector2 position)
    {
        Tile tile = GetRandomFromWeight(biome.tiles).tile;
        Sprite sprite = GetRandomFromWeight(tile.textures).sprite;
        var instance = Instantiate(TilePrefab, position, Quaternion.Euler(0, 0, 90 * Random.Range(1, 4)));
        instance.GetComponent<SpriteRenderer>().sprite = sprite;
    }

}
