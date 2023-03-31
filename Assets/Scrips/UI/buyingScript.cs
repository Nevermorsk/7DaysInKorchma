using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class buyingScript : MonoBehaviour
{
    [SerializeField] private Button apple;
    [SerializeField] private Button vine;
    [SerializeField] private Button sgushenka;    
    [SerializeField] private Button salmon;
    [SerializeField] private Button strawberry;
    [SerializeField] private Button chocolatepaste;

    [SerializeField] private TextMeshProUGUI itemName;

    [SerializeField] private AudioSource buySound;

    [SerializeField] private Image background;
    
    void Start()
    {
        background.sprite = Resources.Load<Sprite>($"ui/trading/{DontDestroy.Day}day_menu");

        switch (DontDestroy.Day)
        {
            case 1:
                apple.gameObject.SetActive(true);
                if (DontDestroy.byedItems["apple"]) apple.interactable = false;
                break;           
            case 2:
                apple.gameObject.SetActive(true);
                if (DontDestroy.byedItems["apple"]) apple.interactable = false;
                vine.gameObject.SetActive(true);
                if (DontDestroy.byedItems["vine"]) vine.interactable = false;
                break;           
            case 3:
                apple.gameObject.SetActive(true);
                if (DontDestroy.byedItems["apple"]) apple.interactable = false;
                vine.gameObject.SetActive(true);
                if (DontDestroy.byedItems["vine"]) vine.interactable = false;                
                sgushenka.gameObject.SetActive(true);
                if (DontDestroy.byedItems["sguxa"]) sgushenka.interactable = false;
                break;            
            case 4:
                apple.gameObject.SetActive(true);
                if (DontDestroy.byedItems["apple"]) apple.interactable = false;
                vine.gameObject.SetActive(true);
                if (DontDestroy.byedItems["vine"]) vine.interactable = false;                
                sgushenka.gameObject.SetActive(true);
                if (DontDestroy.byedItems["sguxa"]) sgushenka.interactable = false;                
                salmon.gameObject.SetActive(true);
                if (DontDestroy.byedItems["salmon"]) salmon.interactable = false;
                strawberry.gameObject.SetActive(true);
                if (DontDestroy.byedItems["strawberries"]) strawberry.interactable = false;
                break;            
            case 5:
                apple.gameObject.SetActive(true);
                if (DontDestroy.byedItems["apple"]) apple.interactable = false;
                vine.gameObject.SetActive(true);
                if (DontDestroy.byedItems["vine"]) vine.interactable = false;                
                sgushenka.gameObject.SetActive(true);
                if (DontDestroy.byedItems["sguxa"]) sgushenka.interactable = false;                
                salmon.gameObject.SetActive(true);
                if (DontDestroy.byedItems["salmon"]) salmon.interactable = false;  
                strawberry.gameObject.SetActive(true);
                if (DontDestroy.byedItems["strawberries"]) strawberry.interactable = false;
                chocolatepaste.gameObject.SetActive(true);
                if (DontDestroy.byedItems["chocolatepaste"]) chocolatepaste.interactable = false;
                break;            
        }
    }

    public void buyAppleClc() {

        if (DontDestroy.moneyChange(-40))
        {
            buySound.Play();
            apple.interactable = false;
            DontDestroy.byedItems["apple"] = true;
        }  
    }
    public void buyVineClc() {
        
        if (DontDestroy.moneyChange(-300))
        {
            buySound.Play();
            vine.interactable = false;
            DontDestroy.byedItems["vine"] = true;
        }
    }    
    public void buySgushenkaClc() {
 
        if (DontDestroy.moneyChange(-60))
        {
            buySound.Play();
            sgushenka.interactable = false;
            DontDestroy.byedItems["sguxa"] = true;
        }
    }
    public void buySalomonClc() {
 
        if (DontDestroy.moneyChange(-130))
        {
            buySound.Play();
            salmon.interactable = false;
            DontDestroy.byedItems["salmon"] = true;
        }
    }    
    public void buyStrawberryClc() {
 
        if (DontDestroy.moneyChange(-100))
        {
            buySound.Play();
            strawberry.interactable = false;
            DontDestroy.byedItems["strawberries"] = true;
        }
    }    
    public void buyChocolatepasteClc() {
 
        if (DontDestroy.moneyChange(-85))
        {
            buySound.Play();
            chocolatepaste.interactable = false;
            DontDestroy.byedItems["chocolatepaste"] = true;
        }
    }

    public void close() {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }
}
