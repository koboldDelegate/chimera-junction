using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTerrain : MonoBehaviour
{
    /* Original Creator: Brian Harney
     * Creation Date: 3/20/2023
     * Additional Collaborators: 
     * Last Updated: 3/20/2023
     * Last Updator: Brian Harney
     * 
     * Description: Script that creates and manages WorldTiles. Doesn't work. New lead: Grid???
     * 
     * Usage: 
     */

    static WorldTerrain instance;
    static GameObject worldMap;
    public GameObject mapPrefab;
    public static Grid grid;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
        if(worldMap == null)
        {
            worldMap =  Instantiate(mapPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            worldMap.gameObject.transform.SetParent(this.gameObject.transform);
            worldMap.gameObject.name = "InstantiatedWorldMap";
        }
    }

    public void GenerateWorld()     //Run this to generate the entire village map, randomized.
    {
        
    }

    void RandomizeTiles(int seed)   //Creates a 3d tilemap of random map tiles
    {

        
    }

    void SetTile(Vector3Int pos, GameObject tile)
    {


    }

}
