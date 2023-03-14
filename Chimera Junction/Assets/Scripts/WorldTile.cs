using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTile : MonoBehaviour
{
    /* Original Creator: Brian Harney
     * Creation Date: 3/13/2023
     * Additional Collaborators: 
     * Last Updated: 3/13/2023
     * Last Updator: Brian Harney
     * 
     * Description: Container for the information within a World Tile
     * 
     * Usage: Instantiated for each world tile. DO not rotate a world tile; instead change their boundry types.
     */

        /*
         *                  All boundries assume that forwards is "away" from the camera, back is "towards". These objects should never be rotated.
         */

    public string uType;    //Upwards Boundry Type
    public string dType;    //Downwards Boundry Type
    public string rType;    //Right Boundry Type
    public string lType;    //Left Boundry Type
    public string fType;    //Forward Boundry Type
    public string bType;    //Back Boundry Type

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
