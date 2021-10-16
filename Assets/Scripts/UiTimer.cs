using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiTimer : MonoBehaviour
{
    public GameObject gm;
    private Text _text;
    private GameManager _gm;
    void Start()
    {
        _gm = gm.GetComponent<GameManager>();
        _text = gameObject.GetComponent<Text>();
    }

    private void Update()
    {
        _text.text = _gm.GetTime().ToString();
    }

}
