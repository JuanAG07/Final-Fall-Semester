using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody _zombieRb;
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _zombieRb = GetComponent<Rigidbody>();
        _player = GameObject.Find("PLayer");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 lookDirection = (_player.transform.position - transform.position).normalized;
        _zombieRb.AddForce(lookDirection);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("The zombie hit the player!");
        }
    }
}
