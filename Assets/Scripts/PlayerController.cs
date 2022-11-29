using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private PlayerModel _playerModel;
    private Transform _playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        _playerModel = GetComponent<PlayerModel>();
        _playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(float h)
    {

        if ((_playerTransform.position.x < 1.50f && h > 0f) || (_playerTransform.position.x > -1.50f && h < 0f))
        {
            _playerTransform.Translate(h * _playerModel.Speed, 0f, 0f);
        }

        if (_playerTransform.position.x < -1.55f)
        {
            _playerTransform.Translate(-0.05f * _playerModel.Speed, 0f, 0f);
        }

    }
}
