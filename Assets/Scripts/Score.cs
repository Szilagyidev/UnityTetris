using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Board board;
    void Update()
    {
            scoreText.text = board.score.ToString();
    }
}
