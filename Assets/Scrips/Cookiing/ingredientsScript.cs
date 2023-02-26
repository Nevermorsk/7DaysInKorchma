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
            addedIngredient = "€блоки";
        }
    }    
    public void nutella()
    {
        if (canAdd)
        {
            Debug.Log("nutella");
            addedIngredient = "паста";
        }
    }    
    public void sgushenka()
    {
        if (canAdd)
        {
            Debug.Log("sgushenka");
            addedIngredient = "сгущенка";
        }
    }    
    public void starberry()
    {
        if (canAdd)
        {
            Debug.Log("starberry");
            addedIngredient = "клубника";
        }
    }   
    public void salomon()
    {
        if (canAdd)
        {
            Debug.Log("salomon");
            addedIngredient = "сЄмга";
        }
    }    
    public void sugar()
    {
        if (canAdd)
        {
            Debug.Log("sugar");
            addedIngredient = "сахар";
        }
    }

    void Update()
    {
    }
}
