using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;

    private void Start()
    {
        UpdateScoreText(); // Opdater scoreteksten ved start
    }

    public void addScore()
    {
        playerScore++;
        Debug.Log("Score increased to: " + playerScore); // Tilføj en debug-meddelelse
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = playerScore.ToString();
    }

    public void SubtractScore()
    {
        playerScore--;
        Debug.Log("Score decreased to: " + playerScore);
        UpdateScoreText(); // Opdater scoreteksten
    }

}
