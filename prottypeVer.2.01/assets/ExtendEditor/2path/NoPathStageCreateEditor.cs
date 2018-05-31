using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPathStageCreateEditor : MonoBehaviour {

    public int CreateX;
    public int CreateZ;

    public GameObject StageGround;

    [ContextMenu("CreateStage")]

    private void CreateStage()
    {
        //for (CreateZ = 0; CreateZ <= 100; CreateZ++)
        //{
            Instantiate(StageGround, position: new Vector3(CreateX * 5, 0, CreateZ * 5), rotation: Quaternion.identity);
        //}
    }

}