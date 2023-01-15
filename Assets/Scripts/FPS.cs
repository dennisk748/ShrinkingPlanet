using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FPS : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI fps;
    [SerializeField] private float refresh;

    private float time;
    private int framecount;

    void Update()
    {
        time += Time.deltaTime; 

        framecount++;

        if(time > refresh)
        {
            int framerate = Mathf.RoundToInt(framecount / time);
            fps.text = framerate.ToString() + " FPS";

            time -= refresh;
            framecount = 0;
        }
    }
}
