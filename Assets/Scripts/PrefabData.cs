using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabData : MonoBehaviour
{
    [Tooltip("The lowest difficulty this building will be generated at")]
    public float MininalDifficult;

    [Tooltip("The tiles tilebase, use TilePosition for positing")]
    public WorldTile[] WorldTiles;

    [Tooltip("The tile's placement")]
    public Vector3Int[] TilePositions;

}
