using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ball.GetComponent<Ball>().speed += 1;
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.PlayOneShot(audio.clip);
        }
        ResetPosition();
     }

        public void Player2Scored()
        {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ball.GetComponent<Ball>().speed += 1;
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.PlayOneShot(audio.clip);
        }
        ResetPosition();
        }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
}