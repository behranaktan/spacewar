using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;

    [SerializeField]
    GameObject explosionPrefab;

    GameControl gamecontrol;

    const float hareketGucu = 7;
    // Start is called before the first frame update
    void Start()
    {
        gamecontrol= Camera.main.GetComponent<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 position = transform.position;

        float yatayInput = Input.GetAxis("Horizontal");
        float dikeyInput = Input.GetAxis("Vertical");
        
        if (yatayInput != 0)
        {
            position.x += yatayInput * hareketGucu * Time.deltaTime;
        }
        if (dikeyInput != 0)
        {
            position.y += dikeyInput * hareketGucu * Time.deltaTime;
        }
        transform.position = position;
        if (Input.GetButtonDown("Jump"))
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SoundControl>().fire();
            Vector3 bulletPosition = gameObject.transform.position;

            bulletPosition.y += 1;
            Instantiate(bulletPrefab, bulletPosition, Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SoundControl>().shipexpo();
            gamecontrol.GameOver();
            Instantiate(explosionPrefab,gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }



}
