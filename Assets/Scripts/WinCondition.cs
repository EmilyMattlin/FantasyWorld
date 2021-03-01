using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    private GameObject top, mid, bottom;
    private ChangeImage changeImageScript1, changeImageScript2, changeImageScript3;
    public GameObject winText;
    private bool hasTaxes;
    // Start is called before the first frame update
    void Start()
    {
         top = GameObject.Find("TopSmile");
         mid = GameObject.Find("MidSmile");
         bottom = GameObject.Find("BottomSmile");
         changeImageScript1 = top.GetComponent<ChangeImage>();
         changeImageScript2 = mid.GetComponent<ChangeImage>();
         changeImageScript3 = bottom.GetComponent<ChangeImage>();
        hasTaxes = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (changeImageScript1.rightWay && changeImageScript2.rightWay && changeImageScript3.rightWay)
        {
            winText.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("gold"))
        {
            hasTaxes = true;
        }
    }
}
