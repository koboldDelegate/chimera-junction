using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTile : MonoBehaviour
{
    /* Original Creator: Brian Harney
     * Creation Date: 3/13/2023
     * Additional Collaborators: 
     * Last Updated: 3/14/2023
     * Last Updator: Brian Harney
     * 
     * Description: Container for the information within a World Tile
     * 
     * Usage: Instantiated for each world tile. DO not rotate a world tile; instead change their boundry types.
     */

    /*
     *                  All boundries assume that forwards is "away" from the camera, back is "towards". These objects should never be rotated.
     */


    List<string> validNeighbors = new List<string> { "Land", "Air", "Water" }; //Valid Neighbor strings. Other strings will "work", but may cause issues

    [SerializeField] string uType { set { uType = value; } get { if (validNeighbors.Contains(uType)) {Debug.Log("Invalid Neighbor! At: " + this.gameObject.name);} return uType;  } }    //Upwards Boundry Type
    [SerializeField] string dType { set { dType = value; } get { if (validNeighbors.Contains(uType)) { Debug.Log("Invalid Neighbor! At: " + this.gameObject.name); } return dType; } }     //Downwards Boundry Type
    [SerializeField] string rType { set { rType = value; } get { if (validNeighbors.Contains(uType)) { Debug.Log("Invalid Neighbor! At: " + this.gameObject.name); } return rType; } }     //Right Boundry Type
    [SerializeField] string lType { set { lType = value; } get { if (validNeighbors.Contains(uType)) { Debug.Log("Invalid Neighbor! At: " + this.gameObject.name); } return lType; } }     //Left Boundry Type
    [SerializeField] string fType { set { fType = value; } get { if (validNeighbors.Contains(uType)) { Debug.Log("Invalid Neighbor! At: " + this.gameObject.name); } return fType; } }     //Forward Boundry Type
    [SerializeField] string bType { set { bType = value; } get { if (validNeighbors.Contains(uType)) { Debug.Log("Invalid Neighbor! At: " + this.gameObject.name); } return bType; } }     //Back Boundry Type




}
