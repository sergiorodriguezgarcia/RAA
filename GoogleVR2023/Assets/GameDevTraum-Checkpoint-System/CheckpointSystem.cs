using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public Checkpoint[] checkpoints;

    public int currentCheckpointIndex=0;

    void Start()
    {
        currentCheckpointIndex = -1;
        GetCheckpointsReferences();
        //LoadData();
        

    }

    void GetCheckpointsReferences()
    {
        int checkpointCount = transform.childCount;
        checkpoints = new Checkpoint[checkpointCount];

        for (int i = 0; i < checkpointCount; i++)
        {          
            checkpoints[i] = transform.GetChild(i).GetComponent<Checkpoint>();
            checkpoints[i].SetIndex(i);
            checkpoints[i].SetCheckpointSystem(this);
        }

    }

    void SaveData()
    {
        PlayerPrefs.SetInt(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name,currentCheckpointIndex);
    }

    void LoadData()
    {
        currentCheckpointIndex = PlayerPrefs.GetInt(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name,-1);
        if (currentCheckpointIndex > -1)
        {
            for (int i = 0; i < currentCheckpointIndex; i++)
            {
                checkpoints[i].Activate();
            }

            PlayerControl player = FindObjectOfType<PlayerControl>();
            player.SetPosition(checkpoints[currentCheckpointIndex].GetCheckpointPosition());
        }
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }


    public bool CheckpointAvailable()
    {
        return currentCheckpointIndex > -1;
    }

    public Vector3 GetCurrentCheckpointPosition()
    {
        return checkpoints[currentCheckpointIndex].GetCheckpointPosition();
    }

    public void CheckpointActivated(int i)
    {
        if (i > currentCheckpointIndex)
        {
            currentCheckpointIndex = i;
            SaveData();
        }
    }

}
