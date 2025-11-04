using System;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int _moneyAmmount;
    public event Action<int> OnCanvasUpdate;


    public void AddMoney()
    {
        _moneyAmmount++;
        OnCanvasUpdate?.Invoke(_moneyAmmount);
    }
}
