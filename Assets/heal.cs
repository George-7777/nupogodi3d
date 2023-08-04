using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class heal : MonoBehaviour
{
    public Slider healthbar;
    int health_value = 3;
    public GameObject babah;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "egg")
        {
            health_value -= 1;
            healthbar.value = health_value;
            Instantiate(babah, col.gameObject.transform.position, Quaternion.identity);
            Destroy(col.gameObject);
        }
        

    }
}
