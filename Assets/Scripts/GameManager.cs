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
        if (score > 0)
        {
            Debug.Log(score);
        }
    }
    /*
    private Player player;
    private SpawnerPipe spawner;

    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public int score { get; private set; }

    private void Awake()
    {
        Application.targetFrameRate = 60;

        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<SpawnerPipe>();

        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;
        
    }

    public void GameOver()
    {
        playButton.SetActive(true);
        gameOver.SetActive(true);

        Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    */

}