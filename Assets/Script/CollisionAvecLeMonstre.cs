using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAvecLeMonstre : MonoBehaviour
{
    [SerializeField] 
    private GameObject m_gameObject;

    [SerializeField]
    private GameObject m_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision entre bonbon et monstre");
        Destroy(m_gameObject);
        m_text.SetActive(true);

    }


}
