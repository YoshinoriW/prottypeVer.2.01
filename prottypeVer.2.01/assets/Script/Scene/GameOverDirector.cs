using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverDirector : MonoBehaviour
{

public void RetryButton()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }

public void EndBotton()
    {
        SceneManager.LoadScene("title");

    }

    // リトライボタンを格納する変数
    public GameObject panelGameOver;

    // ボタンをクリックした時に実行する処理
    public void StartScene()
    {
        // ゲームオーバー画面を非表示にする
        panelGameOver.SetActive(false);
    }



}
