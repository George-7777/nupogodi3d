using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    score gameControll;
    Spawner game;
    public GameObject babah;
    public void Start()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "plate")
        {
            Debug.Log("������");
            gameControll = GameObject.Find("wolf").GetComponent<score>();
            game = GameObject.Find("spawner").GetComponent<Spawner>();
            gameControll.Add();
            game.spawnDelay -= 0.01f;
            
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "a")
        {
            Debug.Log("���");
            Instantiate(babah, gameObject.transform);
            Destroy(gameObject);
        }
    }
}
