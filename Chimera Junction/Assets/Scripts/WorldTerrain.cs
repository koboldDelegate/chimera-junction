using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTerrain : MonoBehaviour
{
    /* Original Creator: Brian Harney
     * Creation Date: 3/20/2023
     * Additional Collaborators: 
     * Last Updated: 3/23/2023
     * Last Updator: Brian Harney
     * 
     * Description: Script that creates and manages WorldTiles. 
     * 
     * Usage: call GetTile and SetTile to get reference to or overwrite the reference to a specific tile.
     */

    static WorldTerrain instance;
    static GameObject worldMap;
    public GameObject mapPrefab;
    public static List<Grid> grid;

    List<List<List<GameObject>>> xyzList;

    private void Awake()
    {
        xyzList = new List<List<List<GameObject>>>();
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
        if (worldMap == null)
        {
            worldMap = Instantiate(mapPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            worldMap.gameObject.transform.SetParent(this.gameObject.transform);
            worldMap.gameObject.name = "InstantiatedWorldMap";
        }
        if (grid == null)
        {
            Debug.Log("Grid missing!!");
        }
    }

    public void GenerateWorld()     //Run this to generate the entire village map, randomized.
    {

    }

    void RandomizeTiles(int seed)   //Creates a 3d tilemap of random map tiles
    {


    }

    public void RefreshTile(Vector3Int coords) //(Re)initalizes the cell. Would have called it Update but...yeah. Creates the terrain at its location, checking neighbors to make sure it's right.
    {
        if (coords.x+1 <= xyzList.Count) //Update +x neighbor
        {

        }
        if (coords.x-1 <= xyzList.Count && coords.x-1>=0) //Update -x neighbor
        {

        }
        if (coords.y+1 <= xyzList[coords.x].Count ) //Update +y neighbor
        {

        }
        if (coords.y - 1 <= xyzList[coords.x].Count && coords.y-1 >=0) //Update -y neighbor
        {

        }
        if (coords.z+1 <= xyzList[coords.x][coords.y].Count)    //update +z neighbor
        {
 
        }
        if (coords.z - 1 <= xyzList[coords.x][coords.y].Count && coords.z-1 >=0)    //update -z neighbor
        {

        }
    }


    public GameObject GetTile(Vector3Int tile)  //Returns the X/Y/Z tile, if it exists, or null if it does not. Note: "Empty" cells should have 'air' in them, not be null!
    {
        if (tile.x > xyzList.Count)
        {
            Debug.Log("X too big for grid!");
            return null;
        }
        else if (tile.y > xyzList[tile.x].Count)
        {
            Debug.Log("Y too big for grid!");
            return null;
        }
        else if (tile.z > xyzList[tile.x][tile.y].Count)
        {
            Debug.Log("Z too big for grid!");
            return null;
        }
        return xyzList[tile.x][tile.y][tile.z];
    }

    public void SetTile(Vector3Int tile, GameObject type)  //Sets the X/Y/Z tile, if it exists, or fails. Note: "Empty" cells should have 'air' in them, not be null! Destroys the old reference, but doesn't make a new one!
    {
        if (tile.x > xyzList.Count)
        {
            Debug.Log("X too big for grid!");
            return;
        }
        else if (tile.y > xyzList[tile.x].Count)
        {
            Debug.Log("Y too big for grid!");
            return;
        }
        else if (tile.z > xyzList[tile.x][tile.y].Count)
        {
            Debug.Log("Z too big for grid!");
            return;
        }
        Destroy(xyzList[tile.x][tile.y][tile.z].gameObject);
        xyzList[tile.x][tile.y][tile.z] = type;
    }

    public void SetTile(Vector3Int tile, string typeName)   //Works like the the GameObject version, but calls a valid cell type string instead.
    {
        if (tile.x > xyzList.Count)
        {
            Debug.Log("X too big for grid!");
            return;
        }
        else if (tile.y > xyzList[tile.x].Count)
        {
            Debug.Log("Y too big for grid!");
            return;
        }
        else if (tile.z > xyzList[tile.x][tile.y].Count)
        {
            Debug.Log("Z too big for grid!");
            return;
        }
        Destroy(xyzList[tile.x][tile.y][tile.z].gameObject);
        xyzList[tile.x][tile.y][tile.z] = new GameObject();     //Make the gameboject empty
        WorldTile tempTileRef = xyzList[tile.x][tile.y][tile.z].AddComponent<WorldTile>(); //add a tile to it
        // SET THE TILE TYPE HERE!!!!
        RefreshTile(tile);      //Initalize the tile, and update neighbor tiles.

    }
}
