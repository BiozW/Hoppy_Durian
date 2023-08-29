using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public int score;
    public int hp;

    public TMPro.TMP_Text hpText;
    public TMPro.TMP_Text scoreText;

    public void GameOver()
    {
        SceneManager.LoadScene("PlayerScene");
    }
    public void Obstacle()
    {
        hp--;
    }
    public void Killzone()
    {
        hp = 0;
    }

    public void IncreaseScore()
    {
        score++;
    }

    private void Update()
    {
        hpText.text = hp.ToString();
        scoreText.text = score.ToString();
        if (hp == 0)
        {
            SceneManager.LoadScene("PlayerScene");
        }
    }

}