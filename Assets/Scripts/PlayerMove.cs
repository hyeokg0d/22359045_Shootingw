using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float spd = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //Vector3 dir = Vector3.right * h + Vector3.up * v;
        Vector3 dir = new Vector3(h, v, 0);
        //transform.Translate(dir * spd * Time.deltaTime);
        transform.position = transform.position + dir * spd * Time.deltaTime;
    }
}