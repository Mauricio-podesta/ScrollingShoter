using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject[] obstaculo;
    [SerializeField] public Vector3 PositionSpawn;
    public float enemigos = 0;
    [SerializeField] float Tiempo = 0;
    private void Update()
    {

    }
    private void Start()
    {
        InvokeRepeating("spawn", 4f, 2f);
    }
    void spawn()
        {
            int Randomindex = Random.Range(0, obstaculo.Length);
            GameObject obstaculoaleatorio = obstaculo[Randomindex];
            Instantiate(obstaculoaleatorio, PositionSpawn, obstaculoaleatorio.transform.rotation);
        }
    
}
