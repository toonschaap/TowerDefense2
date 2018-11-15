using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class placementlimit : MonoBehaviour {
    public Text ScoreText;
    private int currentScore;
	// Use this for initialization
	void Start () {
        currentScore = 0;
	}
	
	// Update is called once per frame
	private void HandleScore () {
		
        {
            ScoreText.text = "Towers on map:" + currentScore;
        }
	}
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentScore ++;
            HandleScore();
        }
    }
}
