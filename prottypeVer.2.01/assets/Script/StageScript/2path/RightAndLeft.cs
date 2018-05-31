using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightAndLeft : MonoBehaviour {

    GameObject MainScript;
    StageState stageState;
    public GameObject PseudoPlayer;
    void Start()
    {
        MainScript = GameObject.Find("Main Script");
        stageState = MainScript.GetComponent<StageState>();
        PseudoPlayer = GameObject.Find("Pseudo-player");

    }

    private void OnTriggerEnter(Collider collider)
    {
        PseudoPlayer.SendMessage("IntegerMessage");

        if (stageState.LeftFlag == true)
        {
            PseudoPlayer.SendMessage("RightMessage");
        }
        else if (stageState.RightFlag == true)
        {
            PseudoPlayer.SendMessage("LeftMessage");
        }

        Debug.Log("Centorで当たり判定が発生しました。");
    }
}
