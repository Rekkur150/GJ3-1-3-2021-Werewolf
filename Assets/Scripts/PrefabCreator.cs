using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class PrefabCreator : MonoBehaviour
{
    public Vector2Int MaxSize;

    public GameObject[] tilePrefabs;

    private Tilemap Tilemap;

    void Start()
    {
        Tilemap = gameObject.GetComponent<Tilemap>();

        CreatePrefab();
    }

    void CreatePrefab()
    {

        PrefabData data = gameObject.AddComponent<PrefabData>();

        List<WorldTile> worldTiles = new List<WorldTile>();
        List<Vector3Int> positions = new List<Vector3Int>();

        for (int i = -MaxSize.x; i < MaxSize.x; i++)
        {
            for (int j = -MaxSize.y; j < MaxSize.y; j++)
            {
                foreach (GameObject obj in tilePrefabs)
                {
                    if (obj.GetComponent<WorldTile>().TileBaseStates[0] == Tilemap.GetTile(new Vector3Int(i, j, 0)))
                    {
                        worldTiles.Add(obj.GetComponent<WorldTile>());
                        positions.Add(new Vector3Int(i, j, 0));
                    }
                }
            }
        }

        data.WorldTiles = new WorldTile[worldTiles.Count];
        data.TilePositions = new Vector3Int[positions.Count];

        for (int i = 0; i < worldTiles.Count; i++)
        {
            data.WorldTiles[i] = worldTiles[i];
            data.TilePositions[i] = positions[i];
        }

    }



}
