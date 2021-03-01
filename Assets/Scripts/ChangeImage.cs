using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage : MonoBehaviour
{
    public Material smile;
    public bool rightWay;
    public AudioSource audioSound;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown()
    {
        float tileY = smile.GetTextureScale("_MainTex").y;
        smile.mainTextureScale = new Vector2(0.03f, tileY * -1);
        rightWay = !rightWay;
        audioSound.Play();
        // this object was clicked - do something
    }

}
