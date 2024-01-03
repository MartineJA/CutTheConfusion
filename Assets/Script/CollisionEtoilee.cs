using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEtoilee : MonoBehaviour
{
    public ScoreEtoile etoile;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        etoile.scoreEtoile += 1;
        
    }

}
