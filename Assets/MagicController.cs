using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MagicController : MonoBehaviour
{
    [SerializeField] private int fireMana;
    [SerializeField] private int waterMana;
    [SerializeField] private int earthMana;
    [SerializeField] private int airMana;

    [SerializeField] private TextMeshProUGUI fireManaUI;
    [SerializeField] private TextMeshProUGUI waterManaUI;
    [SerializeField] private TextMeshProUGUI earthManaUI;
    [SerializeField] private TextMeshProUGUI airManaUI;
    void Update()
    {
        UpdateUI();
    }
    public void AddMana(int amount)
    {
        fireMana += amount;
    }

    public int GetFireMana()
    {
        return fireMana;
    }

    private void UpdateUI()
    {
        fireManaUI.text = fireMana.ToString();
    }
}
