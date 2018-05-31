using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftArrowAction : MonoBehaviour {
    GameObject MainScript;
    StageState stageState;
    public GameObject PseudoPlayer;


    public GameObject RightArrow;
    public GameObject LeftArrow;
    public GameObject UpArrow;
    public GameObject DownArrow;

    void OnSortiePointClick()
    {


        MainScript = GameObject.Find("Main Script");
        stageState = MainScript.GetComponent<StageState>();
        PseudoPlayer = GameObject.Find("Pseudo-player");

        RightArrow = GameObject.Find("RightArrow");
        LeftArrow = GameObject.Find("LeftArrow");
        UpArrow = GameObject.Find("UpArrow");
        DownArrow = GameObject.Find("DownArrow");

        if (stageState.DownFlag == true)
        {
            PseudoPlayer.SendMessage("LeftMessage");
        }
        else if(stageState.UpFlag == true)
        {
            PseudoPlayer.SendMessage("RightMessage");
        }
        else if(stageState.RightFlag == true)
        {
            PseudoPlayer.SendMessage("DownMessage");
        }
        else if(stageState.LeftFlag == true)
        {
            PseudoPlayer.SendMessage("UpMessage");
        }
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        UpArrow.SetActive(false);
    }
}
