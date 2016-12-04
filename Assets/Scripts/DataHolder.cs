using UnityEngine;
using System.Collections;

public class DataHolder : MonoBehaviour
{

    static int LevelsCleared = 0;

    public void LevelCleared()
    {
        LevelsCleared++;
        Debug.Log("LEVEL CLEARED");
        Debug.Log("SCORE " + LevelsCleared);
    }

}