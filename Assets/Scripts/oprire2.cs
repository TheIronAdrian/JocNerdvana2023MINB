using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oprire2 : MonoBehaviour
{
    [SerializeField] BoxCollider2D bc;
    public static int stop = 1;
    float tmp;
    // Update is called once per frame
    void Update()
    {
        if (movers2.endTime2 == 1)
        {
            tmp += Time.deltaTime;
            if (tmp > 0.2)
                bc.enabled = true;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.position.y > 0.03f)
            stop = 1;
    }
}