using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private BallModel _ballModel;
    private Rigidbody2D _ballRigidbody;

    void Start()
    {
        _ballModel = GetComponent<BallModel>();
        _ballRigidbody = GetComponent<Rigidbody2D>();

        _ballRigidbody.velocity = _ballModel.Direction * _ballModel.Speed * _ballModel.Power;
    }

    public void AngleChange(Vector2 direction)
    {
        _ballModel.Direction = direction;
        _ballRigidbody.velocity = _ballModel.Direction * _ballModel.Speed * _ballModel.Power;
    }

    public void PerfectAngleReflect(Collision2D collision)
    {
        Vector2 direction = Vector2.Reflect(_ballModel.Direction, collision.contacts[0].normal);

        AngleChange(direction);
    }

    public void CalcBallAngleReflect(Collision2D collision)
    {
        //Calculo de angulo de reflex�o para o player.

        //Quantidade de pixels do player
        float playerPixels = 240f;

        //Achar a metade do gameObject e colocar na escala de 0 a 100 do Unity.
        float unitScaleHalfPlayerPixels = playerPixels / 2 / 100;

        //Escala de convers�o 0 a 100 da Unity para 0 a 180� de angulo.
        float scaleFactorPut1dot180Range = 180 / playerPixels;

        //Calcular o �ngulo de reflex�o na escala do Unity 0 > 180.
        float angleDegUnityScale = ((collision.transform.position.x - transform.position.x) + unitScaleHalfPlayerPixels) * scaleFactorPut1dot180Range;

        //Converter o �ngulo encontrado para graus(Degree)
        float angleDeg = angleDegUnityScale * 100f;

        //Converter o �ngulo de Degree para radianos
        float angleRad = angleDeg * Mathf.PI / 180f;

        //Montando o vetor de posi��es x, y
        Vector2 vetorRetorno = new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad));

        //Carregando o novo valor para o vetor de dire��es.
        AngleChange(vetorRetorno);
    }
}
