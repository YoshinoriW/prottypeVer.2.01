using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class ButtonDirector : MonoBehaviour
{
    Button 続ける;
    Button タイトルへ;

    void Start()
    {
        // ボタンコンポーネントの取得
        続ける = GameObject.Find("/Canvas/Button1").GetComponent<Button>();
        タイトルへ = GameObject.Find("/Canvas/Button2").GetComponent<Button>();
        

        // 最初に選択状態にしたいボタンの設定
        続ける.Select();
    }
}