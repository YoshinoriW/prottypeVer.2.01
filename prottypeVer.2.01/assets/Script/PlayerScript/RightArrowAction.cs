using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightArrowAction : MonoBehaviour {
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
            PseudoPlayer.SendMessage("RightMessage");
        }
        else if(stageState.UpFlag == true)
        {
            PseudoPlayer.SendMessage("LeftMessage");
        }
        else if(stageState.RightFlag == true)
        {
            PseudoPlayer.SendMessage("UpMessage");
        }
        else if(stageState.LeftFlag == true)
        {
            PseudoPlayer.SendMessage("DownMessage");
        }
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        UpArrow.SetActive(false);
    }
}
