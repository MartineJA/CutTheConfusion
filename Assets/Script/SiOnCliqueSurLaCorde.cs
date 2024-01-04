using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiOnCliqueSurLaCorde : MonoBehaviour
{

    [SerializeField]
    private ParticleSystem trail;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PositionSouris();
    }
    void OnMouseDown()
    {
        trail.Play();
        Debug.Log("La corde est coupée");


        Destroy(gameObject);
        

    }



    void PositionSouris()
    {
        Vector2 mousePos = Input.mousePosition;
        

        if (Input.GetMouseButtonDown(0)) // 0 = left, 1 = right, 2 = middle
        {
            
            Debug.Log(mousePos.x);
            Debug.Log(mousePos.y);

          

        }
    }
}
