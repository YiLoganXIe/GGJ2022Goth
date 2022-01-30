using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timing : MonoBehaviour
{
    private Slider slider;
    private bool left = true;
    [SerializeField] float speed = 0.01f;
    private bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) start = true;
        else if (Input.GetMouseButtonUp(1))
        {
            start = false;
            Debug.Log("Reading:" + slider.value);
        }

        if (start)
        {

            if (left)
            {
                slider.value += speed;
            }
            else
            {
                slider.value -= speed;
            }

            if (slider.value >= 1 || slider.value <= 0)
            {
                left = !left;
            }

        }
    }

}
