using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownSensor: MonoBehaviour {
    GameObject MainScript;
    StageState stageState;

    void Start()
    {
        MainScript = GameObject.Find("Main Script");
        stageState = MainScript.GetComponent<StageState>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (stageState.RightFlag == false && stageState.UpFlag == false && stageState.DownFlag == false && stageState.LeftFlag == false)
        {
            stageState.DownFlag = true;
        }
        else
        {
            stageState.RightFlag = false;
            stageState.UpFlag = false;
            stageState.DownFlag = false;
            stageState.LeftFlag = false;
        }

        Debug.Log("DownSensorで当たり判定が発生しました。");
    }

}
