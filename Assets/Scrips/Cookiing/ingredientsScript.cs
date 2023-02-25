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
            Debug.Log("apples");
            addedIngredient = "apples";
        }
    }    
    public void nutella()
    {
        if (canAdd)
        {
            Debug.Log("nutella");
            addedIngredient = "apples";
        }
    }    
    public void sgushenka()
    {
        if (canAdd)
        {
            Debug.Log("sgushenka");
            addedIngredient = "sgushenka";
        }
    }    
    public void starberry()
    {
        if (canAdd)
        {
            Debug.Log("starberry");
            addedIngredient = "starberry";
        }
    }   
    public void salomon()
    {
        if (canAdd)
        {
            Debug.Log("salomon");
            addedIngredient = "salomon";
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

    void Update()
    {
    }
}
