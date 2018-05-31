using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D_L_2PathStageCreateEditor : MonoBehaviour {

    public int CreateX;
    public int CreateZ;

    public GameObject StageGround;
    public GameObject DownSensor;
    public GameObject LeftSensor;
    public GameObject CenterCollider;

    [ContextMenu("CreateStage")]

    private void CreateStage()
    {
        Instantiate(StageGround, position: new Vector3(CreateX * 5, 0, CreateZ * 5), rotation: Quaternion.identity);
        Instantiate(DownSensor, position: new Vector3(CreateX * 5, 0, CreateZ * 5 - 2), rotation: Quaternion.identity);
        Instantiate(LeftSensor, position: new Vector3(CreateX * 5 - 2, 0, CreateZ * 5), rotation: Quaternion.identity);
        Instantiate(CenterCollider, position: new Vector3(CreateX * 5, 0, CreateZ * 5), rotation: Quaternion.identity);
    }
}
