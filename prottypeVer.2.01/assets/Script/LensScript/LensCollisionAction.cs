using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensCollisionAction : MonoBehaviour
{

    //拡大処理、試験的にとりあえず+1
    int plusHeight = 1;

    //ゲームオブジェクト
    private GameObject Sphere;

    //サイズとポジションの初期座標保存。必ずサイズ情報、初期位置の2つ取る。
    private Vector3 startlcs;
    private Vector3 startpos;


    void Start()
    {
        //カプセルのオブジェクト取得
        this.Sphere = GameObject.Find("SphereTag");
        //テストキューブの初期座標保存。必ずサイズ情報、初期位置の2つ取る。
        startlcs = this.Sphere.transform.localScale;
        startpos = this.Sphere.transform.position;
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "LensTag")
        {
            //オブジェクトのローカルサイズ変更
            //new Vector3(x軸,y軸,z軸)
            //Debug.Log("当たったよ");
            this.transform.localScale += new Vector3(plusHeight, plusHeight, plusHeight);

            //y軸上下に+1されてしまうので2で割る。
            this.transform.position += new Vector3(0, plusHeight / 2f, 0);


        }
    }

    void OnTriggerExit(Collider other)
    {
        //サイズと座標を初期値に戻す。片方だけ戻すと座標がずれる。
        transform.localScale = startlcs;
        transform.position = startpos;

    }
}
