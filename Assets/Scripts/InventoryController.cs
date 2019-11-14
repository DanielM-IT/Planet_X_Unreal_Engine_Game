using UnityEngine;

// Will have more functionality as I develop my inventory system. For now I can show and hide it in the UI using a counter algorithm.
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
