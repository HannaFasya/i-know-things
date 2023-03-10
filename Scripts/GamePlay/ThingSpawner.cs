using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] things;

    private BoxCollider2D col;
    float x1, x2;

    void Awake()
    {
        col = GetComponent<BoxCollider2D>(); 
        
        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;

    }

    void Start()
    {
        StartCoroutine(SpawnThing(1f));
    }

    IEnumerator SpawnThing(float time)
    {
        yield return new WaitForSecondsRealtime(time);

        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);

        Instantiate(things[Random.Range(0, things.Length)], temp, Quaternion.identity);

        StartCoroutine(SpawnThing(Random.Range(1f, 2f)));
    }
} // End
