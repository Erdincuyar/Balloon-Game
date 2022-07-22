using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontrol : MonoBehaviour
{
    public UnityEngine.UI.Text timeText, balloonText;
    public float time = 60;
    public GameObject explotions;
    int exploded = 0;
    void Start()
    {
        balloonText.text = "Balloon" + exploded;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            timeText.text = "Time: " + (int)time;
        }else{
            GameObject[] go = GameObject.FindGameObjectsWithTag ("balloon");
            for (int i = 0; i < go.Length; i++){
                Instantiate(explotions, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
        }
    }
    public void AddBalloon()
    {
        exploded += 1;
        balloonText.text = "Balloon" + exploded;
    }
}
