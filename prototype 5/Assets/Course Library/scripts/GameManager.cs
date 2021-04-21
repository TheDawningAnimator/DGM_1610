using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    private float spawnRate = 1.0f;

    private int score;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
    }

    // Update is called once per frame
    IEnumerable SpawnTarget()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
    public void UpdateScore(int scoreTotal)
    {
        score += scoreTotal;
        scoreText.text = "score" + score;
    }
    public void GameOver()
    {
        gameOverText.gameobject.SetActive(true);
    }
}
