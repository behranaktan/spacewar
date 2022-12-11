using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    GameObject spaceShipPrefab;

    [SerializeField]
    List<GameObject> asteroidPrefabs = new List<GameObject>();

    GameObject spaceShip;
    List<GameObject> asteroidList = new List<GameObject>();
    [SerializeField]
    int difficulty = 1;
    [SerializeField]
    int mult = 5;

    UIControl uicontrol;


    // Start is called before the first frame update
    void Start()
    {
        uicontrol= GetComponent<UIControl>();
        
    }

    public void StartGame()
    {

        spaceShip = Instantiate(spaceShipPrefab);
        spaceShip.transform.position = new Vector3(0, DisplayCalculator.Bottom + 1.2f);
        SpawnAsteroid(5);
    }





    void SpawnAsteroid(int a)
    {
        Vector3 position = new Vector3();
        for (int i = 0; i < a; i++)
        {
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            position.x = Random.Range(DisplayCalculator.Left, DisplayCalculator.Right);
            position.y = DisplayCalculator.Top - 1;

           GameObject asteroid = Instantiate(asteroidPrefabs[Random.Range(0, 3)],position, Quaternion.identity);
            asteroidList.Add(asteroid);
        }
    }

    public void AsteroidDs(GameObject asteroid)
    {
        uicontrol.DsAsteroid(asteroid);
        asteroidList.Remove(asteroid);
        if(asteroidList.Count <= difficulty)
        {
            difficulty++;
            SpawnAsteroid(difficulty * mult);
        }

    }

    public void GameOver()
    {
        foreach (GameObject asteroid in asteroidList)
        {
            asteroid.GetComponent<Asteroids>().DsAsteroid();
        }
        asteroidList.Clear();
        difficulty = 1;
        uicontrol.GameOver();
    }



}
