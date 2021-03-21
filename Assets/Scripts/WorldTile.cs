using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldTile : MonoBehaviour
{

    public Vector3Int LocalPlace { get; set; }

    public TileBase TileBase { get; set; }

    public TileBase[] TileBaseStates;

    public Tilemap TilemapMember { get; set; }

    public string Name { get; set; }

    public string ID;

    public string Type;

    //Useful tile information

    public float Health;

    public WorldTile(WorldTile oldTile)
    {
        LocalPlace = oldTile.LocalPlace;
        TileBase = oldTile.TileBase;
        TileBaseStates = oldTile.TileBaseStates;
        TilemapMember = oldTile.TilemapMember;
        Name = oldTile.Name;
        Type = oldTile.Type;
        Health = oldTile.Health;
        ID = oldTile.ID;
    }

    public TileBase AddTile(Vector3Int position, Tilemap tileMap)
    {
        TilemapMember = tileMap;
        LocalPlace = position;

        Name = LocalPlace.x + "," + LocalPlace.y;
        TileBase = TileBaseStates[0];

        MapController.instance.SetTileData(new WorldTile(this));

        return TileBase;
    }
    
    /// <summary>
    /// Adds or removes health to the tile
    /// </summary>
    /// <param name="addedHealth"></param>
    public void AddHealth(float addedHealth)
    {
        Health += addedHealth;
    }

    public void Destroyed()
    {
        TileBase = TileBaseStates[TileBaseStates.Length - 1];
        TilemapMember.SetTile(LocalPlace, TileBase);
        TilemapMember.RefreshAllTiles();

        MapNavigation.instance.UpdateNavMesh();
    }

}
