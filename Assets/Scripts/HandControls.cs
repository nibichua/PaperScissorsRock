using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HandControls : MonoBehaviour
{
    public GameObject handPrefab;
    public GameObject newHand;
    public Sprite[] handSprites;
    private GameObject clone;
    public GameObject r;
    public GameObject p;
    public GameObject s;
    public GameObject popUp;
	public Button br;
	public Button bp;
	public Button bs;
    public Text Score;
    public bool isRock = false;
    public bool isPaper = false;
    public bool isScissors = false;
    public bool isAction = false;
    public MyTimer t;
	private int time = 10;

	public bool isLose = false;
    int type = 0;
    int numHand = 3;
    public int score;
    // Use this for initialization
    void Start()
    {
		br.interactable = true;
		bp.interactable = true;
		bs.interactable = true;
        score = 0;
        UpdateScore();
        MakeRandomHand();
    }

	void Update(){
		/*Able to use arrow keys to choose a hand*/
		if (isLose == false) {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				rock();
			}
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				paper();
			}
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				scissors();
			}
		}

	}

    public void MakeRandomHand()
    {
		/*the computer can randomize what hand to choose */
        type = Random.Range(0, numHand);
        if(type == 0) //rock
        {
            clone = Instantiate(r, transform.position, transform.rotation);
        }
        if (type == 1) //paper
        {
            clone = Instantiate(p, transform.position, transform.rotation);
        }
        if (type == 2) //scissors
        {
            clone = Instantiate(s, transform.position, transform.rotation);
        }


    }

    public void rock()
    {
		/*type 1 meaning paper, if rock is click or chosen, player passes that round*/
        isRock = true;
        if (isRock == true && type == 1)
        {
            Destroy(clone);
            isRock = false;
            score++;
			/*decreases time every 5th score*/
			if ((score % 5) == 0) {
				t.timespeed = t.timespeed + .75f;
			}
            t.myCoolTimer = time;
            UpdateScore();
            MakeRandomHand();
        }
        else
        {
			/*so player cannot click the buttons*/
            popUp.SetActive(true);
            t.timerIsActive = false;
			br.interactable = false;
			bp.interactable = false;
			bs.interactable = false;
			isLose = true; //player cannot presses and increase score
            //Restart();
        }

        Debug.Log("ROCK");

    }
    public void paper()
    {
		/*type 2 meaning scissors, if paper is click or chosen, player passes that round*/
        isPaper = true;
        if (isPaper == true && type == 2)
        {
            Destroy(clone);
            isPaper = false;
            score++;
			/*decreases time every 5th score*/
			if ((score % 5) == 0) {
				t.timespeed = t.timespeed + .25f;
			}
            t.myCoolTimer = time;
            UpdateScore();
            MakeRandomHand();
        }
        else
        {
			/*so player cannot click the buttons*/
            popUp.SetActive(true);
            t.timerIsActive = false;
			br.interactable = false;
			bp.interactable = false;
			bs.interactable = false;
			isLose = true;//player cannot presses and increase score
            
        }
        Debug.Log("PAPER");
    }
    public void scissors()
    {
		/*type 0 meaning rock, if scissors is click or chosen, player passes that round*/
        isScissors = true;
        if (isScissors == true && type == 0)
        {
            Destroy(clone);
            isScissors = false;
            score++;
			/*decreases time every 5th score*/
			if ((score % 5) == 0) {
				t.timespeed = t.timespeed + .75f;
			}
            t.myCoolTimer = time;
            UpdateScore();
            MakeRandomHand();
        }
        else
        {
			/*so player cannot click the buttons*/
            popUp.SetActive(true);
            t.timerIsActive = false;
			br.interactable = false;
			bp.interactable = false;
			bs.interactable = false;
			isLose = true; //player cannot presses and increase score
            
        }
        Debug.Log("SCISSORS");
    }

    public void UpdateScore()
    {
        Score.text = "Score: " + score.ToString();
    }
		
}
