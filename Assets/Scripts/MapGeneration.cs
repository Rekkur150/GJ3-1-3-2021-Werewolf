using System.Collections;
using System.Collections.Generic;
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

    /// <summary>
    /// Clears the map
    /// </summary>
    public void ClearMap()
    {

    }

    /// <summary>
    /// Generates a new map, based on difficulty
    /// </summary>
    public void GenerateMap()
    {

    }

    /// <summary>
    /// Checks to see if a prefab can fit before placement
    /// </summary>
    /// <param name="position">Prospected position</param>
    /// <param name="prefab">Prefab</param>
    /// <returns></returns>
    public bool IsPrefabValidPlacement(Vector2 position, PrefabData prefab)
    {
        return new bool();
    }
}
