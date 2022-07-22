using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballooncontrol : MonoBehaviour
{
    public GameObject explotion;
    gamecontrol gamecontrolscript;
    void Start()
    {
        gamecontrolscript = GameObject.Find("_scripts").GetComponent<gamecontrol>();
    }



    private void OnMouseDown()
    {
        GameObject go= Instantiate(explotion, transform.position,transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.333f);
        gamecontrolscript.AddBalloon(); 
    }
}
