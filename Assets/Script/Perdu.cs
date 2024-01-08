using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perdu : MonoBehaviour
{
    [SerializeField]
    private GameObject _text;
     

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bonbon"))
        {
            Debug.Log("perdu");
            _text.SetActive(true);
            Time.timeScale = 0f;
        }
    }


}
