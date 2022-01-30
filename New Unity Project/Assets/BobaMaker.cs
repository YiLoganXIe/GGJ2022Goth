using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BobaMaker : MonoBehaviour
{
    [SerializeField] private Button PestelPitcher1;
    [SerializeField] private Button PestelPitcher2;
    [SerializeField] private Button PestelPitcher3;
    [SerializeField] private Button PestelPitcher4;
    [SerializeField] private Button PestelBowl1;
    [SerializeField] private Button PestelBowl2;
    [SerializeField] private Button PestelBowl3;
    [SerializeField] private Button PestelBowl4;
    [SerializeField] private Button GothPitcher1;
    [SerializeField] private Button GothPitcher2;
    [SerializeField] private Button GothPitcher3;
    [SerializeField] private Button GothPitcher4;
    [SerializeField] private Button GothBowl1;
    [SerializeField] private Button GothBowl2;
    [SerializeField] private Button GothBowl3;
    [SerializeField] private Button GothBowl4;

    [SerializeField]private Slider slider;
    private bool left = true;
    [SerializeField] float speed = 0.01f;
    private bool start = false;
    private int CurrentButtonID = 0;
    public List<int> ingredients;
    // Start is called before the first frame update
    void Start()
    {
        ingredients = new List<int>();
    }

    // Update is called once per frame
    void Update()
    {

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

    public void m_PestelPitcher1Down()
    {
        start = true;
    }

    public void m_PestelPitcher1Up()
    {
        start = false;
        if (slider.value < 0.666666666 && slider.value>0.3333333333)
        {
            ingredients.Add(1);
        }
        slider.value = 0;

    }

    public void m_PestelPitcher2Down()
    {
        start = true;
    }

    public void m_PestelPitcher2Up()
    {
        start = false;
        if (slider.value < 0.666666666 && slider.value > 0.3333333333)
        {
            ingredients.Add(2);
        }
        slider.value = 0;

    }
    public void m_PestelPitcher3Down()
    {
        start = true;
    }

    public void m_PestelPitcher3Up()
    {
        start = false;
        if (slider.value < 0.666666666 && slider.value > 0.3333333333)
        {
            ingredients.Add(3);
        }
        slider.value = 0;

    }
    public void m_PestelPitcher4Down()
    {
        start = true;
    }

    public void m_PestelPitcher4Up()
    {
        start = false;
        if (slider.value < 0.666666666 && slider.value > 0.3333333333)
        {
            ingredients.Add(4);
        }
        slider.value = 0;

    }


    public void m_PestelBowl1Down()
    {
        start = true;
    }

    public void m_PestelBowl1Up()
    {
        start = false;
        if (slider.value < 0.666666666 && slider.value > 0.3333333333)
        {
            ingredients.Add(11);
        }
        slider.value = 0;

    }


    public void m_PestelBowl2Down()
    {
        start = true;
    }

    public void m_PestelBowl2Up()
    {
        start = false;
        if (slider.value < 0.666666666 && slider.value > 0.3333333333)
        {
            ingredients.Add(12);
        }
        slider.value = 0;

    }

    public void m_PestelBowl3Down()
    {
        start = true;
    }

    public void m_PestelBowl3Up()
    {
        start = false;
        if (slider.value < 0.666666666 && slider.value > 0.3333333333)
        {
            ingredients.Add(13);
        }
        slider.value = 0;

    }

    public void m_PestelBowl4Down()
    {
        start = true;
    }

    public void m_PestelBowl4Up()
    {
        start = false;
        if (slider.value < 0.666666666 && slider.value > 0.3333333333)
        {
            ingredients.Add(14);
        }
        slider.value = 0;

    }


}
