using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainconrroller : MonoBehaviour
{
    [SerializeField] private GameObject rainprefab;
    private void Start()
    {
        InvokeRepeating("SpawnRain", 60, 120);
    }

    private void SpawnRain()
    {
        Instantiate(rainprefab, new Vector3(Random.Range(-10, 10), 10, 0), Quaternion.identity);
        Invoke("stopRain", 60);
    }

    private void stopRain()
    {
        Destroy(GameObject.FindWithTag("rain"));
    }
}
