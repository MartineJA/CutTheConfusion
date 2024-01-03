using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiOnCliqueSurLaCorde : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {

        Debug.Log("La corde est coupée");
        Destroy(gameObject);

    }

}
