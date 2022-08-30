using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject CannonBall; //Cannon ball prefab
    public GameObject CannonBallSpawnPoint; 

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // cannon ball spawn codes
            GameObject _newCannonBall = Instantiate(CannonBall, CannonBallSpawnPoint.transform.position, CannonBallSpawnPoint.transform.rotation);
            Rigidbody2D _rb = _newCannonBall.GetComponent<Rigidbody2D>();
            _rb.AddForce(new Vector2(2f, 0f) * 10f, ForceMode2D.Impulse);
            // cannon ball spawn codes end
        }        
    }
}
