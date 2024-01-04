using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class TextUpdate : MonoBehaviour
{
    private TextMeshProUGUI m_text;

   

    [SerializeField]
    private ScoreEtoile score;

    private void Awake()
    {
        m_text = GetComponent<TextMeshProUGUI>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_text.text = score.scoreEtoile.ToString();
        
      
    }
}
