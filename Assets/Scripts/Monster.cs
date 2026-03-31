using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    public float spd = 1.0f;
    Vector3 direct = Vector3.down;

    private void Start()
    {
        int rndNum = Random.Range(0, 10);

        //==============
        //30퍼 확률
        //==============
        if(rndNum % 3 == 0)
        {
            GameObject target = GameObject.Find("Player");
            direct = target.transform.position - transform.position;
            direct.Normalize();
        }
    }

    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

}
