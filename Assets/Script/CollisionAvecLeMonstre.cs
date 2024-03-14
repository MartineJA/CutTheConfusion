using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAvecLeMonstre : MonoBehaviour
{
    [SerializeField] 
    private GameObject m_gameObject;

    [SerializeField]
    private GameObject m_text;

    [SerializeField]
    private GameObject m_text02;

    [SerializeField]
    private ScoreEtoile m_scoreEtoile;

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
        if (collision.CompareTag("Bonbon")) 
        
        {
            Debug.Log("Collision entre bonbon et monstre");
            Destroy(m_gameObject);
            m_text.SetActive(true);
            Time.timeScale = 0f;

        }

        if (collision.CompareTag("Bonbon") && m_scoreEtoile.scoreEtoile <= 0)
        {
            Debug.Log("Essaie de gagner l'étoile!");
            Destroy(m_gameObject);
            m_text02.SetActive(true);
            Time.timeScale = 0f;

        }


    }


}
