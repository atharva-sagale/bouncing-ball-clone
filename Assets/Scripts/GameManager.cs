using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    int score;
    public TextMeshProUGUI scoreText;
    public GameObject gamestartUI;
    public GameObject scoreboard;



    private void Awake()
    {
        instance = this;
    }

    public void Reset()
    {
        SceneManager.LoadScene("game");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
