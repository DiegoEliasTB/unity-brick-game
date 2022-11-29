using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _life;

    //public int Life { get => _life; set => _life => _life = value; }
    public float Speed { get => _speed; set => _speed = value; }
}
