using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallModel : MonoBehaviour
{
    [ContextMenuItem("Resetar Valores", "Reset")]
    [Multiline(5)]
    public string derrubado;

    [Tooltip("Velocidade empregada na bola")]
    [Range(0, 10)]
    [SerializeField] private float _speed;

    [Tooltip("Força aplicada na bola")]
    [Range(0, 10)]
    [SerializeField] private float _power;

    [Space(10)]
    [Header("Vetor de direções")]
    [SerializeField] private Vector2 _direction;//

    public Vector2 Direction { get => _direction; set => _direction = value; }
    public float Power { get => _power; set => _power = value; }
    public float Speed { get => _speed; set => _speed = value; }

    private void Reset()
    {
        Power = 0;
        Speed = 0;
        derrubado = "";
        Direction = Vector2.zero;
    }
}
