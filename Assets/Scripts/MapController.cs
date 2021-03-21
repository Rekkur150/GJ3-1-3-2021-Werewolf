using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{

    static public MapController instance;



    /// <summary>
    /// List of all tile data
    /// </summary>
    private Dictionary<Vector3Int, WorldTile> TileData = new Dictionary<Vector3Int, WorldTile>();

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
    }

    public WorldTile GetTileData(Vector3Int position)
    {
        return TileData[position];
    }

    public void SetTileData(WorldTile worldTile)
    {
        TileData.Add(worldTile.LocalPlace, worldTile);
    }

    public void RefreshTile(Vector3Int position)
    {
        gameObject.GetComponent<UnityEngine.Tilemaps.Tilemap>().RefreshTile(position);
    }
}
