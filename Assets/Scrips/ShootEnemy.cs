using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    [SerializeField] GameObject Bulletprefab;
    [SerializeField] Transform SpawnPotition;
    [SerializeField] float BulletForce = 50f;
    [SerializeField] float Timeshoot = 0f;
    [SerializeField] float TimeDestroy = 0f;
    void Start()
    {

    }
    void Update()
    {
        Timeshoot += Time.deltaTime;
        if (Timeshoot >= 2)
        {
            shoot();
            Timeshoot = 0;
        }

    }
    private void shoot()
    {

        GameObject NewBullet = Instantiate(Bulletprefab, SpawnPotition.position, Quaternion.identity);
        Rigidbody NewBulletRb = NewBullet.GetComponent<Rigidbody>();
        NewBulletRb.AddRelativeForce(transform.forward * BulletForce, ForceMode.Impulse);
        Destroy(NewBullet, TimeDestroy);
    }
}
