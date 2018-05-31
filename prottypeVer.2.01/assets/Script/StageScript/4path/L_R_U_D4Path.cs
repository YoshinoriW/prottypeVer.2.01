using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_R_U_D4Path : MonoBehaviour
{
    GameObject MainScript;
    StageState stageState;
    public GameObject PseudoPlayer;


    public GameObject RightArrow;
    public GameObject LeftArrow;
    public GameObject UpArrow;
    public GameObject DownArrow;

    void Start()
    {
        MainScript = GameObject.Find("Main Script");
        stageState = MainScript.GetComponent<StageState>();
        PseudoPlayer = GameObject.Find("Pseudo-player");

        RightArrow = GameObject.Find("RightArrow");
        LeftArrow = GameObject.Find("LeftArrow");
        UpArrow = GameObject.Find("UpArrow");
        DownArrow = GameObject.Find("DownArrow");


    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "AIPlayer")
        {
            RightArrow.SetActive(true);
            LeftArrow.SetActive(true);
            UpArrow.SetActive(true);
            PseudoPlayer.SendMessage("StopMessage");
        }
        Debug.Log("Centorで当たり判定が発生しました。");
    }
}
