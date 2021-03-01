using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientFace : MonoBehaviour
{
    public Material smile1, smile2, smile3;

    // Start is called before the first frame update
    void Start()
    {
        smile1.mainTextureScale = new Vector2(0.03f, 0.3f);
        smile2.mainTextureScale = new Vector2(0.03f, -0.4f);
        smile3.mainTextureScale = new Vector2(0.03f, -0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
