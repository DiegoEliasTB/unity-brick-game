using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickView : MonoBehaviour
{
    private BrickController _brickController;
    // Start is called before the first frame update
    void Start()
    {
        _brickController = GetComponent<BrickController>();
    }

    public void PerformTakeDamage(float damage)
    {
        _brickController.TakeDamage(damage);
    }
}
