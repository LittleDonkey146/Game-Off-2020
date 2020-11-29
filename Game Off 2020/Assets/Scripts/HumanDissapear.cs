using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanDissapear : MonoBehaviour
{

    private SpriteRenderer m_spriteRenderer;

    private void Awake()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        gameObject.transform.parent = null;
    }

    private void Update()
    {
        if(gameObject.transform.parent == null)
        {
            m_spriteRenderer.enabled = true;
        }
        else if(gameObject.transform.parent != null)
        {
            m_spriteRenderer.enabled = false;
        }
    }
}
