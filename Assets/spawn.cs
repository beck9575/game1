using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    void Start()
    {
        spawnenemy();
    }

    // Update is called once per frame
    void spawnenemy()
    {
        Instantiate(enemy, randompos(), enemy.transform.rotation);

    }
    Vector3 randompos()
    {
        float xpos = Random.Range(-10, 10);
        float zpos = Random.Range(-10, 10);
        Vector3 ret = new Vector3(xpos, 0, zpos);
        return ret;

    }
    void Update()
    {
    }
}
