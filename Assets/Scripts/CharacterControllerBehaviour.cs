using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CharacterControllerBehaviour : MonoBehaviour
{

    private CharacterController _charContrl;

	void Start ()
    {
        _charContrl = GetComponent<CharacterController>();

#if DEBUG

        //if (_charContrl == null)
        //{
        //    Debug.LogError("charcontrolbeghaviour needs a charactercontrolcompoment");
        //}

        Assert.IsNotNull(_charContrl, "uhm test, der is geen charcontroller  pls fix");

#endif

    }
	
	void Update ()
    {
		
	}

}
