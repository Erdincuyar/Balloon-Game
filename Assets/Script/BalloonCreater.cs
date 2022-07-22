using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonCreater : MonoBehaviour
{
    public GameObject balloon;
    float ballooncreatingtime=1f;
    float time = 0f;
    gamecontrol gamecontrolsc;

    void Start()
    {
        gamecontrolsc = this.gameObject.GetComponent<gamecontrol>() ;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0 && gamecontrolsc.time > 0)
        {
            GameObject go = Instantiate(balloon, new Vector3(Random.Range(137f,1307f), -231f, 0), Quaternion.Euler(0, 0, 0));
            go.GetComponent<Rigidbody2D>().AddForce (new Vector3(0, Random.Range(17000f,33000f), 0));
            time = ballooncreatingtime;
        }

    }
}
