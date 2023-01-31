using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleColor : MonoBehaviour
{
    [SerializeField]
    private Text _titleText = default;
    private void Start()
    {
        _titleText.text = 
            "<size=75><color=red>S</color></size>" +
            "<color=#ffffff>UPER </color>" +
            "<size=75><color=red>S</color></size>" +
            "<color=#ffffff>IMPLE </color>" +
            "<size=75><color=red>S</color></size>" +
            "<color=#ffffff>OKOBAN</color>";
    }
}
