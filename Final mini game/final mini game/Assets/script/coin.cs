using System.Collections;
using System.Collections.Generic;
using System
using UnityEngine;

public class coin : MonoBehaviour
{
    private AudioSource _coinAudio;

    private void Start()
    {
        _coinAudio = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collected the coin.");
            GameObject.Find("Canvas").GetComponent<UIManager>().UpdateCoinCount();
            Destroy(this.gameObject);
        }
    }
}
