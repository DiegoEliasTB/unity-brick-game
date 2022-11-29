using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    private BrickModel _brickModel;
    ////Audio
    ////private AudioSource _audioSource;

    void Start()
    {
        _brickModel = GetComponent <BrickModel>();
        ////_audioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage(float damage)
    {
        _brickModel.Health = _brickModel.Health - damage;

        if (_brickModel.Health <= 0)
        {
            ////_audioSource.Play();
            Destroy(gameObject, 0.05f);
        }
    }
}
