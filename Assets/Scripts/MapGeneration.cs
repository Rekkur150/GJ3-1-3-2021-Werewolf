using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    [Tooltip("How difficult the level is")]
    public float difficulty;

    [Tooltip("The number of buildings to generate")]
    public int Buildings;

    public List<PrefabData> BuildingPrefabs;

    [Tooltip("The number of humans to generate")]
    public int Humans;

    [Tooltip("The number of guards to generate")]
    public int Guards;

    [Tooltip("The number animals to generate")]
    public int Animals;

    private Tilemap MapTileMap;

    void Start()
    {
        MapTileMap = gameObject.GetComponent<Tilemap>();

        ClearMap();

        GenerateMap(new Vector2(20, 20));
            
        MapNavigation.instance.UpdateNavMesh();

    }

    /// <summary>
    /// Clears the map
    /// </summary>
    public void ClearMap()
    {
        MapTileMap.ClearAllTiles();
    }

    private Vector3Int GenerateRandomPosition(Vector2 PlayArea)
    {
        return new Vector3Int(Random.Range(-Mathf.FloorToInt(PlayArea.x / 2), Mathf.FloorToInt(PlayArea.x / 2)), Random.Range(-Mathf.FloorToInt(PlayArea.y / 2), Mathf.FloorToInt(PlayArea.y / 2)), 0);
    }

    private PrefabData PickRandomBuilding()
    {
        return BuildingPrefabs[Random.Range(0, BuildingPrefabs.Count)];
    }

    /// <summary>
    /// Generates a new map, based on difficulty
    /// </summary>
    public void GenerateMap(Vector2 PlayArea)
    {
        for (int i = 0; i < Buildings; i++)
        {
            Vector3Int randomPosition = GenerateRandomPosition(PlayArea);
            PrefabData randomBuilding = PickRandomBuilding();

            //Limits the number of attempts to generate a building
            int attempt = 200;

            while (!IsPrefabValidPlacement(randomPosition, randomBuilding) && attempt > 0) 
            {
                attempt--;
                randomPosition = GenerateRandomPosition(PlayArea);
                randomBuilding = PickRandomBuilding();
            }

            //Assumes that it is unlikely to get another building in the play area, so it just stops generating buildings
            if (attempt <= 0)
            {
                break;
            }

            PlacePrefab(randomPosition, randomBuilding);

        }
    }

    public void PlacePrefab(Vector3Int relativePosition, PrefabData prefab)
    {
        for (int i = 0; i < prefab.TilePositions.Length; i++)
        {
            PlaceTile(prefab.TilePositions[i] + relativePosition, prefab.WorldTiles[i]);
        }
    }

    /// <summary>
    /// Places a singular cell
    /// </summary>
    /// <param name="position">Position of the cell</param>
    /// <param name="WorldTileData">The worldData for a while</param>
    public void PlaceTile(Vector3Int position, WorldTile WorldTileData)
    {   
        MapTileMap.SetTile(position, WorldTileData.AddTile(position, MapTileMap));
    }

    /// <summary>
    /// Checks to see if a prefab can fit before placement
    /// </summary>
    /// <param name="position">Prospected position</param>
    /// <param name="prefab">Prefab</param>
    /// <returns></returns>
    public bool IsPrefabValidPlacement(Vector3Int relativePosition, PrefabData prefab)
    {

        foreach (Vector3Int pos in prefab.TilePositions)
        {
            
            if (MapTileMap.HasTile(pos + relativePosition))
            {
                return false;
            }
        }

        return true;
    }
}
