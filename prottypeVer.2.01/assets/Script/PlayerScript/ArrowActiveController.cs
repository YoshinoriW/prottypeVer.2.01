using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowActiveController : MonoBehaviour {

    public GameObject RightArrow;
    public GameObject LeftArrow;
    public GameObject UpArrow;
    public GameObject DownArrow;

    void Start()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        UpArrow.SetActive(false);
        DownArrow.SetActive(false);
    }


    //void RightArrow()
    //{

    //}

}
