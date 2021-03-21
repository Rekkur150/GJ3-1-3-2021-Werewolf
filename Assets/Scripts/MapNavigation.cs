using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapNavigation : MonoBehaviour
{

    public static MapNavigation instance;

    private UnityEngine.AI.NavMeshSurface2d NavMesh;

    private UnityEngine.Tilemaps.TilemapCollider2D TileMapCollider;

    // Start is called before the first frame update
    void Start()
    {

        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(this);
        }

        NavMesh = GameObject.Find("NavMesh").GetComponent<UnityEngine.AI.NavMeshSurface2d>();
        TileMapCollider = gameObject.GetComponent<UnityEngine.Tilemaps.TilemapCollider2D>();
    }

    public void UpdateNavMesh()
    {
        TileMapCollider.enabled = false;
        TileMapCollider.enabled = true;

        NavMesh.BuildNavMesh();
    }

}
