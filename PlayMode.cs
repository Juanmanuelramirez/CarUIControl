using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMode : MonoBehaviour
{
    public CarController carController;

    public bool isPositiveTorque;
    private bool _isPositiveTorque;

    public bool isNegativeTorque;
    private bool _isNegativeTorque;

    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void ChangePositiveMotorTorque(bool value)
    {
        isPositiveTorque = value;
    }
    public void ChangeNegativeMotorTorque(bool value)
    {
        isNegativeTorque = value;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPositiveTorque != _isPositiveTorque)
        {
            carController.SetPositiveTorque(isPositiveTorque);
            _isPositiveTorque = isPositiveTorque;
        }
        if (isNegativeTorque != _isNegativeTorque)
        {
            carController.SetNegativeTorque(isNegativeTorque);
            _isNegativeTorque = isNegativeTorque;
        }
    }
}
