using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColourChanger : MonoBehaviour{

    [SerializeField] [Range(0f, 1f)] float lerpTime;
    [SerializeField] int coloursLen;
    int colourIndex = 0;
    [SerializeField] private Camera cam;
    float t = 0f;
    int len;

    Color[] colours;

    void Start() {
        cam.backgroundColor = new Color(0, 0, 0);
        len = coloursLen;
        colours = new Color[len];
        for(int i = 0; i < len; i++) {
            colours[i].r = Random.Range(0f, 1f);
            colours[i].g = Random.Range(0f, 1f);
            colours[i].r = Random.Range(0f, 1f);
        }
    }

    void Update(){
        cam.backgroundColor = Color.Lerp (cam.backgroundColor, colours[colourIndex], lerpTime*Time.deltaTime);

        t = Mathf.Lerp(t, 1f, lerpTime*Time.deltaTime);
        if(t > .9f) {
            t = 0f;
            colourIndex ++;
            colourIndex = (colourIndex >= len) ? 0 : colourIndex;
        }
    }
}