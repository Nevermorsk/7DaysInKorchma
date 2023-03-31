using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ingredientsScript : MonoBehaviour
{
    public static bool canAdd = false;
    public static string addedIngredient;
 
    public void apple()
    {
        if (canAdd)
        {
            Debug.Log("apple");
            addedIngredient = "apple";
        }
    }    
    public void nutella()
    {
        if (canAdd)
        {
            Debug.Log("chocolatepaste");
            addedIngredient = "chocolatepaste";
        }
    }    
    public void sgushenka()
    {
        if (canAdd)
        {
            Debug.Log("sguxa");
            addedIngredient = "sguxa";
        }
    }    
    public void starberry()
    {
        if (canAdd)
        {
            Debug.Log("strawberries");
            addedIngredient = "strawberries";
        }
    }   
    public void salomon()
    {
        if (canAdd)
        {
            Debug.Log("salmon");
            addedIngredient = "salmon";
        }
    }    
    public void sugar()
    {
        if (canAdd)
        {
            Debug.Log("sugar");
            addedIngredient = "sugar";
        }
    }   
    public void bag(Button btn)
    {
        Debug.Log("bag");
        DontDestroy.moneyModifyer *= 2f;
        DontDestroy.byedItems["bag"] = false;
        btn.gameObject.SetActive(false);
    }
}
