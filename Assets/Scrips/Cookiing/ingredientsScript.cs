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
            addedIngredient = "������";
        }
    }    
    public void nutella()
    {
        if (canAdd)
        {
            Debug.Log("nutella");
            addedIngredient = "�����";
        }
    }    
    public void sgushenka()
    {
        if (canAdd)
        {
            Debug.Log("sgushenka");
            addedIngredient = "��������";
        }
    }    
    public void starberry()
    {
        if (canAdd)
        {
            Debug.Log("starberry");
            addedIngredient = "��������";
        }
    }   
    public void salomon()
    {
        if (canAdd)
        {
            Debug.Log("salomon");
            addedIngredient = "����";
        }
    }    
    public void sugar()
    {
        if (canAdd)
        {
            Debug.Log("sugar");
            addedIngredient = "�����";
        }
    }

    void Update()
    {
    }
}
