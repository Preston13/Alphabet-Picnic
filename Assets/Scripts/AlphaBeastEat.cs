using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaBeastEat : MonoBehaviour
{
    public Animator beastAnim;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "letter")
        {
            beastAnim.Play("AlphaBeastAnim");
        }
    }
}
