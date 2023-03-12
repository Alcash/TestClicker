using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BussinesItem : MonoBehaviour
{
    [SerializeField] private Text _titleText;
    [SerializeField] private Slider _progressValueSlider;
    [SerializeField] private Text _lvlValueText;
    [SerializeField] private Text _incomeValueText;
    [SerializeField] private Text _lvlUpCostText;
    [Header("Upgrades")]
    [SerializeField] private BussinesUpgradeButton _upgrade1Button;
    [SerializeField] private BussinesUpgradeButton _upgrade2Button;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
