using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoruSpawn : MonoBehaviour
{
    public Bird bird;
    public GameObject Borular;
    public float yukseklik;

    private void Start()
    {
        StartCoroutine(SpawnBoru());
    }
    
    public IEnumerator SpawnBoru()
    {
        while (!bird.isDead)
        {
            Instantiate(Borular, new Vector3(3, Random.Range(-yukseklik, yukseklik), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
