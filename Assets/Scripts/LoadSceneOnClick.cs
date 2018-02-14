using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadSceneOnClick : MonoBehaviour {

    //public MyTimer t;
	/*source from: https://unity3d.com/learn/tutorials/topics/user-interface-ui/creating-main-menu*/
	public void LoadByIndex()
    {
        //t.timerIsActive = true;
        SceneManager.LoadScene("MainScene");
    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
