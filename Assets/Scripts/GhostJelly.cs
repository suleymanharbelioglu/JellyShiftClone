using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostJelly : MonoBehaviour
{
    public static GhostJelly instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public Transform[] _ghostPoses;
    public int _index = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScaleofTheGhost(Vector3 _scale)
    {
        _scale.y *=1.5f;
        transform.localScale = _scale;
    }
    public void ChangePosOfTheGhost()
    {
        _index++;
        if(_ghostPoses.Length > _index)
        {
            transform.position = _ghostPoses[_index].transform.position;
        }
    }
}
