using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            LeanTween.move(gameObject, new Vector3(-3, 0, 3), 0.3f).setEase(LeanTweenType.easeOutQuad);
            LeanTween.rotate(gameObject, new Vector3(0, 20, 0), 0.3f).setEase(LeanTweenType.easeOutQuad);
        }
    }
}
