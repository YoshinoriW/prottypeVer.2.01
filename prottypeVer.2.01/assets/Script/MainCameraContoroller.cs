using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraContoroller : MonoBehaviour {

    //変数の定義
    public Transform target;
    public float baseDistance = 5f; //停止時のカメラープレイヤー間の距離[m]
    public float baseCameraHeight = 2f; //停止時のカメラの高さ[m]
    public float chaseDamper = 3f; //カメラの追跡スピード
    public float smoothing = 5f;

    void Strat()
    {
        
    }

    //各フレームで、Updateの後にLateUpdateが呼び出されます。
    void LateUpdate()
    {
        //カメラのtransform位置をプレイヤーのものと等しく設定します。
        Vector3 targetCamPos = new Vector3(target.position.x, transform.position.y, 0);
        transform.position = Vector3.Lerp(transform.position, targetCamPos, Time.deltaTime * smoothing);
    }

}
