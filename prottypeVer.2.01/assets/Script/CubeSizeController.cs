using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    //拡大処理、試験的にとりあえず+1
    int plusHeight = 1;
    //ゲームオブジェクト
    private GameObject GCube;
    //サイズとポジション
    private Vector3 startlcs;
    private Vector3 startpos;

    // Use this for initialization
    void Start () {
        //緑キューブのオブジェクト取得
        this.GCube = GameObject.Find("GCube");
        //緑キューブの初期座標保存。必ずサイズ情報、初期位置の2つ取る。
        startlcs = this.GCube.transform.localScale;
        startpos = this.GCube.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        //ボタンクリック時
        if (Input.GetMouseButtonDown(0))
        {
            //オブジェクトのローカルサイズ変更
            //new Vector3(x軸,y軸,z軸)
            transform.localScale += new Vector3(plusHeight, plusHeight, plusHeight);
            //y軸上下に+1されてしまうので2で割る。
            transform.position += new Vector3(0, plusHeight / 2f, 0);

        }
        //ボタンを離した時
        if (Input.GetMouseButtonUp(0))
        {
            //サイズと座標を初期値に戻す。片方だけ戻すと座標がずれる。
            transform.localScale = startlcs;
            transform.position = startpos;
            
        }
    }
}
