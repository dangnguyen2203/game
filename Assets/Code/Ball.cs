using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    GameCotroller m_gc;
    private void Start()
    {
        m_gc = FindObjectOfType<GameCotroller>();
    }
    //B?t va ch?m c?a ??i t??ng này v?i ??i t??ng khác
    private void OnCollisionEnter2D(Collision2D col)
    {
        //CompareTag: so sánh xem nó có ch?a cái Tag ?ó k
        if (col.gameObject.CompareTag("Player"))
        {
            m_gc.IncrementScore();
            //H?y ??i t??ng ball
            Destroy(gameObject);

            Debug.Log("Qua bong da va cham voi gia do");
        }else if (col.gameObject.CompareTag("DeathZone"))
        {
            Debug.Log("Game Over!");
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("DeathZone"))
        {
            m_gc.SetGameoverState(true);
            Destroy(gameObject);

            Debug.Log("Game Over!");
        }
    }

}
