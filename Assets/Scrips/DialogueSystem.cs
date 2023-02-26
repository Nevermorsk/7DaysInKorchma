using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
<<<<<<< Updated upstream
=======
using System.Linq;
using UnityEngine.SceneManagement;
using System.Timers;
>>>>>>> Stashed changes

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
<<<<<<< Updated upstream
    [SerializeField] string[] lines;
    [SerializeField] string[] authors;
    [SerializeField] float TextSpeed;
    [SerializeField] private GameObject SceneSwitcher;
    [SerializeField] private TextMeshProUGUI nameField;
=======
    private string [] lines = new string[30];
    private Sprite [] authorSprite = new Sprite[30];
    [SerializeField] float TextSpeed;
    [SerializeField] private GameObject SceneSwitcher;
    [SerializeField] private TextMeshProUGUI nameField;
    [SerializeField] private Sprite[] krips;
    [SerializeField] private Sprite[] charachters;
>>>>>>> Stashed changes

    private int index;
    private void Start()
    {
        SceneSwitcher.SetActive(false);
<<<<<<< Updated upstream
=======

        switch (counter)
        {
            case 0:
                lines[0] = "Здравствуйте, можно блин с сахаром?|Заказчик";
                lines[1] = "Будет сделано.|Вы";
                authorSprite[0] = krips[0];
                authorSprite[1] = krips[0];
                break;
            case 2:
                lines[0] = "Спасибо, вот деньги.|Заказчик";
                lines[1] = "Всего доброго.|Вы";
                authorSprite[0] = krips[0];
                authorSprite[1] = krips[0];
                GameObject.FindWithTag("DontDestroy").GetComponent<DontDestroy>().money += 60;
                break;
            case 4:
                lines[0] = "Здравствуйте, блины остались?|Заказчик";
                lines[1] = "Да, конечно остались.|Вы";
                authorSprite[0] = krips[1];
                authorSprite[1] = krips[1];
                break;
            case 6:
                lines[0] = "Прошу.|Вы";
                lines[1] = "Огромное спасибо, досвидание.|Заказчик";
                authorSprite[0] = krips[1];
                authorSprite[1] = krips[1];
                GameObject.FindWithTag("DontDestroy").GetComponent<DontDestroy>().money += 60;
                break;
            case 8:
                lines[0] = "Здравствуйте, вы имеете честь обслуживать Звездочёта всего Бофора, Франсиса светлей...|Звездочёт";
                lines[1] = "Какой же ты умничка, что заказывать будете.|Вы";
                lines[2] = "Вы не имеете никакого морального и физического права меня так бестактно переби…|Звездочёт";
                lines[3] = "Так если подумать, то нет никакого физического права, если ты конечно говорил о нормальном праве, а не о твоё праве космоса.|Вы";
                lines[4] = "Я хотел бы отметить, что изучение космических тел требует особого, острого склада ума, коим я думаю вы не располагаете. Поскольку вы считаете, что права не могут быть физическими.|Звездочёт";
                lines[5] = "Ну мне хватает мозгов прийти в ресторан поздним вечером и просто заказать еду, а не задерживать очередь своими нарциссичный монологами.|Вы";
                for (int i = 0; i < 5; i++)
                {
                    authorSprite[i] = charachters[0];
                }

                lines[6] = "Вы за меня не беспокойтесь, у меня времени полным полно. Но я хотел бы, что бы вы относили уважительно к Зведочёту самого посланника божьего, ко-короля всего Бофрора,его величества Карла 15-го!|Налоговик";
                lines[7] = "Ты вообще помалкивай. До тебя очередь ещё видимо не скоро дойдёт.|Вы";
                authorSprite[6] = charachters[1];
                authorSprite[7] = charachters[1];

                lines[8] = "Кхе-кхе, вы никого не забыли? Понимаю, что мозг у Дворфов не особо большой, но я вообще то заказать хотел.|Звездочёт";
                lines[9] = "Дожили, друзья родные! Он готов заказать еду. Весь во внимании.|Вы";
                lines[10] = "Мне пожалуйста блин с сахаром.|Звездочёт";
                lines[11] = "Будет исполнено, светлейший ум нашего общества, это настоящая честь, для меня низшего существа, готовить вам, высокоуважаемому звездочёту!|Вы";
                lines[12] = "Я чувствую некую иронию в ваших слова, хотя вы наверняка и не знаете что такое ирония|Звездочёт";
                lines[13] = "ОГО! Я просто не знаю всех геометрических формул, поэтому понимание вашего богатого вокабуляра для меня секрет за семью печатями.|Вы";
                lines[14] = "Давайте без наглостей,которую вы позваляет себе в силу вашего слаборазвитого мозга,вы сделаете мне мой заказ и я уйду из вашей кухни.|Звездочёт";
                lines[15] = "Это не кухня, а Корчма, попрошу уважения с вашей стороны, господин светлейший ум нашей страны.|Вы";
                lines[16] = "я больше ничего не скажу вам|Звездочёт";
                authorSprite[8] = charachters[0];
                authorSprite[9] = charachters[0];
                authorSprite[10] = charachters[0];
                authorSprite[11] = charachters[0];
                authorSprite[12] = charachters[0];
                authorSprite[13] = charachters[0];
                authorSprite[14] = charachters[0];
                authorSprite[15] = charachters[0];
                authorSprite[16] = charachters[0];

                break;
            case 10:
                lines[0] = "Я говорил, что ни слова не скажу вам, забудьте.|Звездочёт";
                lines[1] = "Что забыть?|Вы";
                lines[2] = "ХА-ХА. ОЧЕНЬ СМЕШНО. Ваш блин пережарен|Звездочёт";
                lines[3] = "Мне кажется хороший обычный блин.|Вы";
                lines[4] = "Вам следует это переделать.|Звездочёт";
                lines[5] = "хорошо...|Вы";
                for(int i = 0; i < 5; i++)
                {
                    authorSprite[i] = charachters[0];
                }
                break;
            case 12:
                lines[0] = "Я понимаю, что рождённые для раскопок в шахтах выучены делать одно дело и не вникать в более тонкие материи, но как ты, каменно рождённый, смог опять испортить блин?|Звездочёт";
                lines[1] = "ХОРОШО, ПЕРЕДЕЛАЕМ НАШЕМУ ВЕЛИКОМУ ТЕОРЕТИКУ РЕАЛЬНО СУЩЕСТВУЮЩИЙ БЛИН! Надеюсь его остро наточенный мозг сможет осознать наши тупые стандарты качества|Вы";
                authorSprite[0] = charachters[0];
                authorSprite[1] = charachters[0];
                break;
            case 14:
                lines[0] = "Вкушайте наши дуратские блины, никак не соответствующие правилам геометрии.|Вы";
                GameObject.FindWithTag("DontDestroy").GetComponent<DontDestroy>().money += 100;
                authorSprite[0] = charachters[0];

                lines[1] = "Наконец и до меня дошла очередь.|Налоговик";
                lines[2] = "Давай только быстро, не как тот великий математик|Вы";
                lines[3] = "Попробую максимально кратк. Кхм.. король отправил меня своим господским приказом для изъявления воли, посланника божьего, ко-короля всего Бофрора,его величества Карла 15-го!|Налоговик";
                lines[4] = "Я как высококачественный посланник ру-ручаюсь за верность передачи с-слов, несмотря на объективные недочёты в мо-моей речи.|Налоговик";
                lines[5] = "Дальше будут излагаться с-слова ко-короля всего Бофрора,его величества Карла 15-го, соответственно я-я буду го-говорить от его ли-лица:|Налоговик";
                lines[6] = "“Передай этому дворфу, что должен нам или 1000 золотых или жизнь свою. Скажи там, что налог такой, понимаешь.|Налоговик";
                lines[7] = "Ещё скажи, что каждый день к нему будут приходить наши люди, которых он должен обслужить с высоким уровнем почтения, понимаешь.|Налоговик";
                lines[8] = "А что про налог, то может отдать их или сразу или отдавать каждый день сколько, понимаешь, может.|Налоговик";
                lines[9] = "Но самое главное для нас,а для него самое удобное, понимаешь, что я готов отодвинуть его должок, если он, понимаешь, сделает мне 100 блинов!|Налоговик";
                lines[10] = "Да кого я смешу. Это же дворфы, понимаешь, у них столько денег не наберется! Чернь же”|Налоговик";
                lines[11] = "И король всего Бофрора,его величества Карла 15-го начал после эти слов очень громко смеяться. Уверенно говорю, что с-слова бы-были переданы с то-точностью!|Налоговик";
                lines[12] = "Так обожди, я что теперь денег вам, шайке шарлатанов, должен?|Вы";
                lines[13] = "Хотелось бы отметить, что ва-ваши слова про шарлатанов, можно расценить как дискредитацию власти, но я расценю это как фигуру речи.|Налоговик";
                lines[14] = "Вот любите же вы языком трепать к месту и без. ОТВЕТЬ НА ВОПРОС, Я ВАМ ДОЛЖЕН ДЕНЕГ?|Вы";
                lines[15] = "Да вы должны денег нам, если вы имели в виду нас как государство. В количестве 1000 золотых. Можете отдать их сейчас, но у вас наверняка нет этих денег, поэтому предлагаю, от лица короля всего Бофрора…|Налоговик";
                lines[16] = "Еще раз произнесешь эту формулировку, то будут докладывать уже твоей матери о твоей смерти|Вы";
                lines[17] = "Это о-очень грубо и некрасиво угрожать, но я продолжу, чтобы вас не раздражать.|Налоговик";
                lines[18] = "Я предлагаю вам сделку, вы отдаёте мне фиксированную сумму от ваших  доходов в течении недели, а в конце недели, в канун великого праздника Масленицы, вы испечете нам столько блинов, сколько мы попросим.|Налоговик";
                lines[19] = "В случае вашего отказа, Король скинет вас в яму без дна.|Налоговик";
                lines[20] = "Ну куда я денусь, принимаю твою сделку.|Вы";
                lines[21] = "С вами не очень приятно иметь дело, но рад что мы пришли к пониманию|Налоговик";
                for (int i = 0; i < 21; i++)
                {
                    authorSprite[i] = charachters[1];
                }
                break;

        }

        lines = lines.Where(x => x != null).ToArray();
>>>>>>> Stashed changes
        text.text = string.Empty;
        nameField.text = lines[index].Split("|")[1];
        StartDialogue();
    }

    private void Update()
    {
            if(Input.GetMouseButtonDown(0))
            {
                if (text.text == lines[index].Split("|")[0])
                {
                    IsNextLine();
                }
                else
                {
                    StopAllCoroutines();
                    text.text = lines[index].Split("|")[0];
                }
            }
        
    }

    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
<<<<<<< Updated upstream
        nameField.text = authors[index];
        foreach (char c in lines[index].ToCharArray())
        {
            text.text += c;
            yield return new WaitForSeconds(TextSpeed);
        }
=======
        GameObject.FindWithTag("Speaker").GetComponent<SpriteRenderer>().sprite = authorSprite[index];
        string[] splitted = lines[index].Split("|");
        nameField.text = splitted[1];
        foreach (char c in splitted[0].ToCharArray())
            {
                text.text += c;
                yield return new WaitForSeconds(TextSpeed);
            }
        
>>>>>>> Stashed changes
    }

    private void IsNextLine()
    {
        if (index < lines.Length - 1 )
        {
            index++;
            text.text = string.Empty;
            StartCoroutine(TypeLine());
        } else
        {
            gameObject.SetActive(false);
            SceneSwitcher.SetActive(true);
        }
    }
}
