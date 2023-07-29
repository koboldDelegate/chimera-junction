using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class SaveLoad : MonoBehaviour
{
    /* Original Creator: Brian Harney
     * Creation Date: 7/29/2023
     * Additional Collaborators: 
     * Last Updated: 7/29/2023
     * Last Updator: Brian Harney
     * 
     * Description: Save to Json /  Load from Json
     * 
     * Usage: 
     */


    string currentSaveFile = "DemoChar01";

    public string fileNameTest;
    public string filePathTest;
    TestDataStorage testData = new TestDataStorage();
    public bool testing = false;

    private void Update() //Testing, remove later
    {
        if(testing)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("Attempting a save!");
                WriteFile(fileNameTest, filePathTest, JsonUtility.ToJson(testData));
            }


            if (Input.GetKeyDown(KeyCode.L))
            {
                JsonUtility.FromJsonOverwrite(LoadFile(Application.persistentDataPath + "/Save Data/" + currentSaveFile + "/" + filePathTest + "/" + fileNameTest), testData);

                Debug.Log("Random seed is: " + testData.randomSeed);
            }
        }
       
    }

    //Call to save appropriate data to file at Path/Name
    public void SaveFile(string fileName, string filePath, object objectToSave)
    {
        WriteFile(fileName, filePath, JsonUtility.ToJson(objectToSave));
    }
    //Overload for quick save of object.
    public void SaveFile(object objectToSave)
    {
        //Need to write a lookup to determine where to save, then save it there
    }


        //Call with: Name of File (including File Extension), Full Path to file folder (not including local directory), Data Stream)
    private void WriteFile(string fileName, string filePath, string jsonData)
    {

        if (!Directory.Exists( Application.persistentDataPath + "/Save Data/" + currentSaveFile + "/" + filePath + "/"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Save Data/" + currentSaveFile + "/" + filePath + "/");
        }

        FileStream savingFileStream = new FileStream(Application.persistentDataPath + "/Save Data/" + currentSaveFile + "/" + filePath + "/" +fileName, FileMode.Create);

        using (StreamWriter savingStreamWriter = new StreamWriter(savingFileStream))
        {
            savingStreamWriter.Write(jsonData);
        }
    }



    //Call with FULL directory and name of file. Returns the Json data as a string. Remember to call JsonUtility.FromJsonOverwrite(YourObjectHere) to use it
    private string LoadFile(string filePathAndName)
    {
        if (File.Exists(filePathAndName))
        {
            using (StreamReader loadingStreamWriter = new StreamReader(filePathAndName))
            {
                return loadingStreamWriter.ReadToEnd();
            }
        }
        return null;
    }


}

public class TestDataStorage
{
    [SerializeField]
    public int randomSeed = 10;
    public int someValue;

}

