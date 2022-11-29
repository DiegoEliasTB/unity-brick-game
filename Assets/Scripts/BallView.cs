using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallView : MonoBehaviour
{
    public BallController _ballController;

    void Start()
    {
        _ballController = GetComponent<BallController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //reflex�o de angulo player
            //_ballController.PerfectAngleReflect(collision);
            //Do ballController acionar ?reflex�o de angulo
            _ballController.CalcBallAngleReflect(collision);
        }
        else
        {
            _ballController.PerfectAngleReflect(collision);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            //reflex�o de angulo com Enemy
            //_ballController.PerfectAngleReflect(collision);

            BrickView _brickView = collision.gameObject.GetComponent<BrickView>();
            _brickView.PerformTakeDamage(1f);
        }

    }
}
