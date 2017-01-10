using UnityEngine;
using System.Collections;

public class DataHolder : MonoBehaviour
{

    public static int LevelsCleared = 0;

    public void LevelCleared()
    {
        LevelsCleared += 100;
        Debug.Log("LEVEL CLEARED");
        Debug.Log("SCORE " + LevelsCleared);
    }

}