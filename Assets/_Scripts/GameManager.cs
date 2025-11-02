using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
        public static int winScore = 10;
        public TMP_Text player1text;
        public TMP_Text player2text;
        public TMP_Text winMessage;

        private static int player1score;
        private static int player2score;

       public static bool playing;

    void Start()
    {
        winMessage.transform.parent.gameObject.SetActive(false);

        player1score = 0;
        
        player2score = 0;
        
        playing = true;
    }

    void Update()
    {
        player1text.text = player1score.ToString();
        player2text.text = player2score.ToString();

        if (player1score >= winScore)
        {
            winMessage.text = "Player 1\nWins!";
            winMessage.transform.parent.gameObject.SetActive(true);
        }
        else if (player2score >= winScore)
        {
            winMessage.text = "Player 2\nWins!";
            winMessage.transform.parent.gameObject.SetActive(true);
        }
    }


    public static void AddScore(int player)
    {
        if (player == 1)
        {
            player1score++;
            if (player1score == winScore)
            {
                playing = false;
            }
        }
        else if (player == 2)
        {
            player2score++;
            if (player2score == winScore)
            {
                playing = false;
            }
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
