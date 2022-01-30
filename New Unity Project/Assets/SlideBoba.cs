using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideBoba : MonoBehaviour
{
    // Start is called before the first frame update
    private int state = 0;
    private Animator animator;
    private bool left = true;
    private bool start = false;
    [SerializeField] float speed = 0.01f;
    [SerializeField] private Slider slider;
    [SerializeField] private GameObject LeftButton;
    [SerializeField] private GameObject RightButton;
    [SerializeField] private Animator CatAnimator;
    [SerializeField] private Animator ButtonGroup;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && state != 0) start = true;
        else if (Input.GetKeyUp("space"))
        {
            start = false;
            if(slider.value>0.33333 && slider.value < 0.66666)
            {
                m_Switch();
            }
            slider.value = 0;
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

    public void Left()
    {
        if (state == 0)
        {
            animator.Play("PanLeft");
            CatAnimator.Play("CatLeft");
            ButtonGroup.Play("ButtonFolding");
            state = 1;
        }
    }

    public void Right()
    {
        if (state == 0)
        {
            animator.Play("PanRight");
            ButtonGroup.Play("ButtonFolding");
            state = 2;
        }
    }

    public void m_Switch()
    {
        if (state == 1)
        {
            animator.Play("Right2Left");
            state = 2;
        }else if (state == 2)
        {
            animator.Play("Left2Right");
            CatAnimator.Play("CatRight");
            state = 1;
        }
    }

}
