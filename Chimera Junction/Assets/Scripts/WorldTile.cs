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
     * Usage: Instantiated for each world tile. Do not rotate a world tile; instead change their boundry types.
     */

    /*
     *                  All boundries assume that forwards is "away" from the camera, back is "towards". These objects should never be rotated.
     */


    List<string> validNeighbors = new List<string> { "Land", "Air", "Water" }; //Valid Neighbor strings. Other strings will "work", but may cause issues

    [SerializeField] string UType { set { UType = value; } get { if (validNeighbors.Contains(UType)) {Debug.Log("Invalid Neighbor! At: " + this.gameObject.name);} return UType;  } }    //Upwards Boundry Type
    [SerializeField] string DType { set { DType = value; } get { if (validNeighbors.Contains(UType)) { Debug.Log("Invalid Neighbor! At: " + this.gameObject.name); } return DType; } }     //Downwards Boundry Type
    [SerializeField] string RType { set { RType = value; } get { if (validNeighbors.Contains(UType)) { Debug.Log("Invalid Neighbor! At: " + this.gameObject.name); } return RType; } }     //Right Boundry Type
    [SerializeField] string LType { set { LType = value; } get { if (validNeighbors.Contains(UType)) { Debug.Log("Invalid Neighbor! At: " + this.gameObject.name); } return LType; } }     //Left Boundry Type
    [SerializeField] string FType { set { FType = value; } get { if (validNeighbors.Contains(UType)) { Debug.Log("Invalid Neighbor! At: " + this.gameObject.name); } return FType; } }     //Forward Boundry Type
    [SerializeField] string BType { set { BType = value; } get { if (validNeighbors.Contains(UType)) { Debug.Log("Invalid Neighbor! At: " + this.gameObject.name); } return BType; } }     //Back Boundry Type

    List<string> validShapes = new List<string> { "Square", "Round", "LargeRound" }; //Valid Shape strings. Other strings will "work", but may cause issues
    [SerializeField] string Shape { set { Shape = value; } get { if (validShapes.Contains(Shape)) { Debug.Log("Invalid Shape! At: " + this.gameObject.name); } return Shape; } } 
    // Shape type

 


}
