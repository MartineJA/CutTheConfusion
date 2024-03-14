using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEtoilee : MonoBehaviour
{
    public ScoreEtoile etoile;
    public GameObject etoileImage;
    public ParticleSystem etoileSprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bonbon"))
        {

            etoileSprite.Play();
            Destroy(gameObject);
            etoile.scoreEtoile += 1;
            etoileImage.SetActive(true);
            
        }

    }

}
