using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    private BrickModel _brickModel;
    private SpriteRenderer _currentColor;
    ////Audio
    //private AudioSource _audioSource;

    void Start()
    {
        _brickModel = GetComponent <BrickModel>();
        _currentColor = GetComponent<SpriteRenderer>();
        //_audioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage(float damage)
    {
        _brickModel.Health = _brickModel.Health - damage;

        if (_brickModel.Health == 1)
        {
            //mudar cor
            _currentColor.color = (Color)(new Color32(43, 173, 51, 255));
        } else if (_brickModel.Health == 2)
        {
            _currentColor.color = (Color)(new Color32(192, 143, 79, 255));
        }

        if (_brickModel.Health <= 0)
        {
            //_audioSource.Play();
            Destroy(gameObject, 0.05f);
        }
    }
}
