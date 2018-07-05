using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {

    public SceneChanger changeScene;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            changeScene.NextScene();
        }
    }
}
