using UnityEngine;
using System.Collections;

public class MovePlayerBottom : MonoBehaviour {

    GameObject Canvas;

    GameObject Player;

    void Start () {

        Player = GameObject.Find("Player");
        
    }

    void Update()
    {
        if (Input.anyKey)
        {

        Player.GetComponent<Win>().SendMessage("MoveDown");

        }
    }

}
