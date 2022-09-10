using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    [SerializeField] private float _damagePower = 20f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("InteractiveBoxes"))
        {
            collision.gameObject.GetComponent<InteractiveBoxes>().TakeDamage(_damagePower);
            Destroy(gameObject);

            //GetComponent<CircleCollider2D>().isTrigger = false;
        }
    }
}
