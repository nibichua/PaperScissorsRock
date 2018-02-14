using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	/*source from: https://unity3d.com/learn/tutorials/topics/user-interface-ui/creating-main-menu*/
	public void restart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
