using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MyTimer : MonoBehaviour {


    public HandControls r;
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    public GameObject popUp;
    public bool timerIsActive = false;

	public float timespeed = 1f;
    public float myCoolTimer;
    public Text timerText;

	// Use this for initialization
	void Start () {
        timerIsActive = true;
        timerText = GetComponent<Text>();
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
        scenePaths = myLoadedAssetBundle.GetAllScenePaths();

    }

    // Update is called once per frame
    void Update () {
        if (timerIsActive)
        {
            if (myCoolTimer > 0)
            {
                
                myCoolTimer -= Time.deltaTime * timespeed;
                if(myCoolTimer < 0) //for sure only 0 will be place on screen
                {
                    timerText.text = "0.00";
                }
                else
                {
                    timerText.text = myCoolTimer.ToString("f2");
                }
                
                Debug.Log(myCoolTimer);
            }
			/*stops the timer and game over*/
            if (myCoolTimer <= 0)
            {
                if (r.isRock == false && r.isPaper == false && r.isScissors == false)
                {
                    myCoolTimer = 0;
                    timerIsActive = false;
                    popUp.SetActive(true);
					r.t.timerIsActive = false;
					r.br.interactable = false;
					r.bp.interactable = false;
					r.bs.interactable = false;
					r.isLose = true;
                }
            }
        }
        
        
	}
}
