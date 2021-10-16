using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject larva;
    public GameObject orbiter;
    public GameObject usSniper;

    bool _isActive=true;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnLarva());
        StartCoroutine(SpawnSniper());
        StartCoroutine(SpawnOrbiter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnLarva()
    {
        while (_isActive)
        {
            Instantiate(larva, transform.position + (Vector3)Random.insideUnitCircle *20,transform.rotation);
            yield return new WaitForSeconds(15);
        }
    }IEnumerator SpawnSniper()
    {
        while (_isActive)
        {
            Instantiate(usSniper, transform.position + (Vector3)Random.insideUnitCircle *20,transform.rotation);
            yield return new WaitForSeconds(7);
        }
    }IEnumerator SpawnOrbiter()
    {
        while (_isActive)
        {
            Instantiate(orbiter, transform.position + (Vector3)Random.insideUnitCircle *20,transform.rotation);
            yield return new WaitForSeconds(10);
        }
    }
}
