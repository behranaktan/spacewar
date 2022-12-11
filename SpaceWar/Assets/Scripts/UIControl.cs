using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{

    [SerializeField]
    GameObject gameNameText;

    [SerializeField]
    GameObject gameOverText;

    [SerializeField]
    Text pointText;

    [SerializeField]
    GameObject playButton;

    [SerializeField]
    Text gamePointText;


    int point;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        pointText.gameObject.SetActive(false);
        gamePointText.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        point = 0;
        gameNameText.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
        pointText.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(false);
        gamePointText.gameObject.SetActive(false);
        UpdatePoint();
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        playButton.gameObject.SetActive(true);
        gamePointText.gameObject.SetActive(true);
        pointText.gameObject.SetActive(false);
    }

    void UpdatePoint()
    {
        pointText.text = "POINT: " + point;
        gamePointText.text = "POINT: " + point;
    }

    public void DsAsteroid(GameObject asteroid)
    {
        switch (asteroid.gameObject.name[8])
        {
            case 'B':
                point += 5;
                UpdatePoint();
                break;
            case 'M':
                point += 8;
                UpdatePoint();
                break;
            case 'S':
                point += 10;
                UpdatePoint();
                break;
            default:
                break;
        }
    }

}
