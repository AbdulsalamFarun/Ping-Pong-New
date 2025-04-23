using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject Ball;

    [Header("Player1")]
    public GameObject Player1Paddle;
    public GameObject Player1Goal;

    [Header("Player2")]
    public GameObject Player2Paddle;
    public GameObject Player2Goal;

    [Header("Text UI")]
    public GameObject ScoreTextRight;
    public GameObject ScoreTextLeft;

    private int Player1Score;
    private int Player2Score;

    public void Player1score()
    {
        Player1Score++;
        ScoreTextLeft.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
    }
    public void Player2score()
    {
        Player2Score++;
        ScoreTextRight.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
    }
}
