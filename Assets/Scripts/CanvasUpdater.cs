using TMPro;
using UnityEngine;

public class CanvasUpdater : MonoBehaviour
{
    [SerializeField] private Inventory inventoryPlayer;
    [SerializeField] private TMP_Text _textMoney;


    private void OnEnable()
    {
        inventoryPlayer.OnCanvasUpdate += InventoryPlayer_OnCanvasUpdate;
    }
    private void OnDisable()
    {
        inventoryPlayer.OnCanvasUpdate -= InventoryPlayer_OnCanvasUpdate;
    }

    private void InventoryPlayer_OnCanvasUpdate(int obj)
    {
        _textMoney.text = obj.ToString();
    }
}
