using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyMove : MonoBehaviour
{
    public Camera _cam;
    public float _minY, _maxY;
    public float _minX, _maxX;
     public Rigidbody _rb;
    public float _speed;
    public bool _isGameEnded = false;
    // Start is called before the first frame update
    void Start()
    {
        _cam = Camera.main;
        //_rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            ChangeScale();
        }
        if(!_isGameEnded)
        {
            _rb.velocity = Vector3.forward * _speed*Time.deltaTime;
        }
        
    }

    public void ChangeScale()
    {
        Vector3 _mousePos = Input.mousePosition;
        _mousePos.z = 10;
        Vector3 _moveVec = _cam.ScreenToWorldPoint(_mousePos);
        float _x = transform.localScale.x;
        _moveVec.z = transform.localScale.z;
        _moveVec.y *=2f;
        _moveVec.y = Mathf.Clamp(_moveVec.y, _minY, _maxY);
        _x = _maxY/_moveVec.y;
        _moveVec.x = Mathf.Clamp(_x, _minX, _maxX);
        transform.localScale = _moveVec;
        GhostJelly.instance.ChangeScaleofTheGhost(_moveVec);
    }


}
