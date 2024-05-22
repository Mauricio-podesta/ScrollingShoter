using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    private void OnTriggerEnter( Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Lose.show();
            Time.timeScale = 0;
            Lose.lose = true;
        }
    }
}
