using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public GameObject Inventory;
    private int counter;


    private void Start()
    {
        Inventory.gameObject.SetActive(false);
    }

    public void showHideByButton()
    {
        counter++;

        if (counter % 2 == 0)
        {
            Inventory.gameObject.SetActive(false);
        }
        else
        {
            Inventory.gameObject.SetActive(true);
        }
    }
}
