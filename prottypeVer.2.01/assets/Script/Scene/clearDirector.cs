using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //LoadScene

public class clearDirector : MonoBehaviour {

    int i;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () { 

        //i==10000をクリアー条件に変更してくだせぇ
        if (i==10000){
            SceneManager.LoadScene("GameScene");
        }
	}
}
