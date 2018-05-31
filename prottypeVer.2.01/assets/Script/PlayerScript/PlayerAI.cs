using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAI : MonoBehaviour
{

    //ベクトル情報の取得
    private Vector3 vector3;
    //移動速度
    public float moveSpeed = 3.0f;
    //振り向きの速さ
    public float applySpeed = 0.2f;

    //移動方向フラグの初期化（最初は右方向へ移動）
    bool UpFlag = false;
    bool DownFlag = false;
    bool RightFlag = true;
    bool LeftFlag = false;

    //message受信時動作
    //キー入力（ステージからのメッセージ）に応じてフラグを立て直すことで自動で進む方向を変更する
    private void UpMessage()
    {
        Debug.Log("UpMessageを受信しました");
        UpFlag = true; //上方向有効化
        DownFlag = false;
        RightFlag = false;
        LeftFlag = false;
    }
    private void DownMessage()
    {
        Debug.Log("DownMessageを受信しました");
        UpFlag = false;
        DownFlag = true;
        RightFlag = false;
        LeftFlag = false; //左方向有効化
    }
    private void RightMessage()
    {
        Debug.Log("RightMessageを受信しました");
        UpFlag = false;
        DownFlag = false; //下方向有効化
        RightFlag = true;
        LeftFlag = false;
    }
    private void LeftMessage()
    {
        Debug.Log("LeftMessageを受信しました");
        UpFlag = false;
        DownFlag = false;
        RightFlag = false; //右方向有効化
        LeftFlag = true;
    }
    private void StopMessage()
    {
        Debug.Log("StopMessageを受信しました");
        UpFlag = false;
        DownFlag = false;
        RightFlag = false;
        LeftFlag = false;
    }

    
    private void IntegerMessage()
    {
        Mathf.Round(transform.position.x);
        Mathf.Round(transform.position.y);
        Mathf.Round(transform.position.z);
    }

    //更新処理
    void Update() {

        


        vector3 = Vector3.zero;//Vector3(0, 0, 0) と同じ意味
        
        //フラグが真となっている方向へ進み続ける
        if (UpFlag == true)
        {
            vector3.z += 1;
        }
        if (LeftFlag == true)
        {
            vector3.x -= 1;
        }
        if (DownFlag == true)
        {
            vector3.z -= 1;
        }
        if (RightFlag == true)
        {
            vector3.x += 1;
        }

        //速度ベクトルの長さを1秒でmoveSpeedだけ進むように調整する
        vector3 = vector3.normalized * moveSpeed * Time.deltaTime;

        //いずれかの方向に移動している場合
        if (vector3.magnitude > 0)
        {
            //プレイヤーの回転(transform.rotation)の更新
            //無回転状態のプレイヤーのz+方向（後頭部）を、移動の反対方向に回す回転とする
            transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(vector3),applySpeed);
            
            
            //プレイヤーの位置(transform.position)の更新
            //移動方向ベクトル(vector3)を足し込む
            transform.position += vector3;

        }
    }
}