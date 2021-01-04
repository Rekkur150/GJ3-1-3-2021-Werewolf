using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldTile : MonoBehaviour 
{
    public Vector3Int LocalPlace { get; set; }

    public Vector3 WorldLocation { get; set; }

    public TileBase TileBase { get; set; }

    public Tilemap TilemapMember { get; set; }

    public string Name { get; set; }

    //Useful tile information

    public float Health { get; set; }
}
