using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballrespawn : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            this.transform.position = new Vector3((float)0, 0, 2f);

        }
    }
}
