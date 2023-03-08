/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogues : MonoBehaviour
{
    public static void DefineDialogue(int day, int counter, Sprite[] krips, Sprite[] charachters)
    {
        switch (day)
        {
            case 0:
                switch (counter)
                {
                    case 0:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("Здравствуйте, можно блин с сахаром?|Заказчик");
                        DialogueSystem.lines.Add("Будет сделано.|Вы");

                        DialogueSystem.authorSprite.Add(krips[0]);
                        DialogueSystem.authorSprite.Add(krips[0]);
                        break;
                    case 2:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("Спасибо, вот деньги.|Заказчик");
                        DialogueSystem.lines.Add("Всего доброго.|Вы");

                        DialogueSystem.authorSprite.Add(krips[0]);
                        DialogueSystem.authorSprite.Add(krips[0]);
                        DialogueSystem.moneyChange(60);
                        break;
                    case 4:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("Здравствуйте, блины остались?|Заказчик");
                        DialogueSystem.lines.Add("Да, конечно остались.|Вы");

                        DialogueSystem.authorSprite.Add(krips[1]);
                        DialogueSystem.authorSprite.Add(krips[1]);
                        break;
                    case 6:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("Прошу.|Вы"); ;
                        DialogueSystem.lines.Add("Огромное спасибо, до свидания.|Заказчик");

                        DialogueSystem.authorSprite.Add(krips[1]);
                        DialogueSystem.authorSprite.Add(krips[1]);
                        DialogueSystem.moneyChange(60);
                        break;
                    case 8:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("Здравствуйте, вы имеете честь обслуживать Звездочёта всего Бофора - Франсиса светлей...|Звездочёт");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd1");

                        DialogueSystem.lines.Add("Какой же ты умничка, что заказывать будете?|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg5");

                        DialogueSystem.lines.Add("Вы не имеете никакого морального и физического права меня так бестактно переби…|Звездочёт");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd2");

                        DialogueSystem.lines.Add("Так если подумать, то нет никакого физического права, если ты конечно говорил о нормальном праве, а не о твоё праве космоса.|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg6");

                        DialogueSystem.lines.Add("Я хотел бы отметить, что изучение космических тел требует особого, острого склада ума, коим я думаю вы не располагаете. Поскольку вы считаете, что права не могут быть физическими.|Звездочёт");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd3");

                        DialogueSystem.lines.Add("Ну мне хватает мозгов прийти в ресторан поздним вечером и просто заказать еду, а не задерживать очередь своими нарциссичными монологами.|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg7");

                        for (int i = 0; i < 6; i++)
                        {
                            DialogueSystem.authorSprite.Add(charachters[0]);
                        }

                        DialogueSystem.lines.Add("Вы за меня не беспокойтесь, у меня времени полным полно. Но я хотел бы, что бы вы относили уважительно к Зведочёту самого посланника божьего - ко-короля всего Бофрора,его величества Карла 15-го!|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog1");

                        DialogueSystem.lines.Add("Ты вообще помалкивай. До тебя очередь ещё видимо не скоро дойдёт.|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg8");

                        DialogueSystem.authorSprite.Add(charachters[1]);
                        DialogueSystem.authorSprite.Add(charachters[1]);

                        DialogueSystem.lines.Add("Кхе-кхе, вы никого не забыли? Понимаю, что мозг у Дворфов не особо большой, но я вообще-то заказать хотел.|Звездочёт");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd6");

                        DialogueSystem.lines.Add("Дожили, друзья родные! Он готов заказать еду. Весь во внимании.|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg9");

                        DialogueSystem.lines.Add("Мне пожалуйста блин с сахаром.|Звездочёт");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd7");

                        DialogueSystem.lines.Add("Будет исполнено, светлейший ум нашего общества, это настоящая честь, для меня низшего существа, готовить вам, высокоуважаемому звездочёту!|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg10");

                        DialogueSystem.lines.Add("Я чувствую некую иронию в ваших слова, хотя вы наверняка и не знаете что такое ирония|Звездочёт");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd8");

                        DialogueSystem.lines.Add("ОГО! Я просто не знал всех геометрических формул, поэтому понимание вашего богатого вокабуляра для меня секрет за семью печатями.|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg12");

                        DialogueSystem.lines.Add("Давайте без наглостей,которую вы позваляете себе в силу вашего слаборазвитого мозга,вы сделаете мне мой заказ и я уйду из вашей кухни.|Звездочёт");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd9");

                        DialogueSystem.lines.Add("Это не кухня, а Корчма, попрошу уважения с вашей стороны, господин светлейший ум нашей страны.|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg13");

                        DialogueSystem.lines.Add("Ни слова не скажу вам.|Звездочёт");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd14");

                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);


                        break;
                    case 10:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("Я говорил, что ни слова не скажу вам, забудьте.|Звездочёт");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd10");

                        DialogueSystem.lines.Add("Что забыть?|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg14");

                        DialogueSystem.lines.Add("ХА-ХА. ОЧЕНЬ СМЕШНО. Ваш блин пережарен|Звездочёт");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd11");

                        DialogueSystem.lines.Add("Мне кажется хороший обычный блин.|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg15");

                        DialogueSystem.lines.Add("Вам следует это переделать.|Звездочёт");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd12");

                        DialogueSystem.lines.Add("хорошо...|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg16");

                        for (int i = 0; i < 6; i++)
                        {
                            DialogueSystem.authorSprite.Add(charachters[0]);
                        }
                        break;
                    case 12:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("Я понимаю, что рождённые для раскопок в шахтах выучены делать одно дело и не вникать в более тонкие материи, но как ты, каменно рождённый, смог опять испортить блин?|Звездочёт");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd13");
                        DialogueSystem.lines.Add("ХОРОШО! ПЕРЕДЕЛАЕМ НАШЕМУ ВЕЛИКОМУ ТЕОРЕТИКУ РЕАЛЬНО СУЩЕСТВУЮЩИЙ БЛИН!|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg17");
                        DialogueSystem.lines.Add("Надеюсь его остро наточенный мозг сможет осознать наши тупые стандарты качества|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg18");

                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        break;
                    case 14:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("Вкушайте наши дурацкие блины, никак не соответствующие правилам геометрии.|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg19");

                        DialogueSystem.moneyChange(100);
                        DialogueSystem.authorSprite.Add(charachters[0]);


                        DialogueSystem.lines.Add("Давай только быстро, не как тот великий математик|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg20");

                        DialogueSystem.lines.Add("Попробую максимально кратко. Кхм...|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog2");

                        DialogueSystem.lines.Add("Король отправил меня своим господским приказом для изъявления воли, посланника божьего - ко-короля всего Бофрора,его величества Карла 18-го!|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog21");

                        DialogueSystem.lines.Add("Я как высококачественный посланник ру - ручаюсь за верность передачи с - слов, несмотря на объективные недочёты в мо - моей речи.|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog22");

                        DialogueSystem.lines.Add("Далее будут излагаться с-слова ко-короля всего Бофрора,его величества Карла 15-го, соответственно я-я буду го-говорить от его ли-лица:|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog4");

                        DialogueSystem.lines.Add("Передай этому дворфу, что должен нам или 1000 золотых или жизнь свою. Скажи там, что налог такой, понимаешь.|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog5");

                        DialogueSystem.lines.Add("Ещё скажи, что каждый день к нему будут приходить наши люди, которых он должен обслужить с высоким уровнем почтения, понимаешь.|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog6");

                        DialogueSystem.lines.Add("А что про налог, то может отдать их или сразу или отдавать каждый день сколько, понимаешь, может.|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog7");

                        DialogueSystem.lines.Add("Но самое главное для нас,а для него самое удобное, понимаешь, что я готов отодвинуть его должок, если он, понимаешь, сделает мне 100 блинов!|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog8");

                        DialogueSystem.lines.Add("Да кого я смешу. Это же дворфы, понимаешь, у них столько денег не наберется! Чернь же”|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog9");

                        DialogueSystem.lines.Add("И король всего Бофрора,его величества Карла 15-го начал после эти слов очень громко смеяться. Уверенно говорю, что с-слова бы-были переданы с то-точностью!|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog10");

                        DialogueSystem.lines.Add("Так обожди, я что теперь денег вам, шайке шарлатанов, должен?|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg21");

                        DialogueSystem.lines.Add("Хотелось бы отметить, что ва-ваши слова про шарлатанов, можно расценить как дискредитацию власти, но я расценю это как фигуру речи.|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog11");

                        DialogueSystem.lines.Add("Вот любите же вы языком трепать к месту и без. ОТВЕТЬ НА ВОПРОС, Я ВАМ ДЕНЕГ ДОЛЖЕН?|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg22");

                        DialogueSystem.lines.Add("Да вы должны денег нам, если вы имели в виду нас, как государство. В количестве 1000 золотых. Можете отдать их сейчас, но у вас наверняка нет этих денег.|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog12");

                        DialogueSystem.lines.Add("Поэтому предлагаю, от лица короля всего Бофрора…|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog13");

                        DialogueSystem.lines.Add("Еще раз произнесешь эту формулировку, то будут докладывать уже твоей матери о твоей смерти.|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg23");

                        DialogueSystem.lines.Add("Это о-очень грубо и некрасиво угрожать, но я продолжу, чтобы вас не раздражать.|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog14");

                        DialogueSystem.lines.Add("Я предлагаю вам сделку, вы отдаёте мне фиксированную сумму от ваших доходов.|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog15");

                        DialogueSystem.lines.Add("в течение недели, а в конце недели, в канун великого праздника Масленицы, вы испечете нам столько блинов, сколько мы попросим. В случае вашего отказа, Король скинет вас в яму без дна.|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog16");

                        DialogueSystem.lines.Add("Ну куда я денусь, принимаю твою сделку.|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg24");


                        DialogueSystem.lines.Add("Слышал, что к вам сам Король заходил.|Продавец");
                        DialogueSystem.audios.Add("audio/dialogue/traider/traider1");
                        DialogueSystem.lines.Add("Могу ли предложить вам парочку улучшений для вашего ресторана?|Продавец");
                        DialogueSystem.audios.Add("audio/dialogue/traider/traider2");
                        DialogueSystem.lines.Add("Любые сковородки, и в любых количествах, продукты, которые думаю тебе завтра понадобятся, ценой не обижу.|Продавец");
                        DialogueSystem.audios.Add("audio/dialogue/traider/traider3");

                        DialogueSystem.lines.Add("Ну показывай|Вы");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg25");

                        for (int i = 0; i < 21; i++)
                        {
                            DialogueSystem.authorSprite.Add(charachters[1]);
                        }
                        DialogueSystem.authorSprite.Add(charachters[3]);
                        DialogueSystem.authorSprite.Add(charachters[3]);
                        DialogueSystem.authorSprite.Add(charachters[3]);
                        DialogueSystem.authorSprite.Add(charachters[3]);
                        DialogueSystem.canNextDay = true;
                        break;
                }
                break;
            case 1:
                switch (counter)
                {
                    case 0:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.canNextDay = false;
                        DontDestroy.byedItems["apples"] = true;
                        DialogueSystem.lines.Add("Слышал у вас появились блины с яблоками, можно мне один?|Заказчик");
                        DialogueSystem.lines.Add("Момент|Вы");

                        DialogueSystem.authorSprite.Add(krips[2]);
                        DialogueSystem.authorSprite.Add(krips[2]);
                        break;
                    case 2:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("Приятного аппетита|Вы");

                        DialogueSystem.authorSprite.Add(krips[2]);
                        DialogueSystem.moneyChange(75);
                        break;
                    case 4:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("Один с сахаром|Заказчик");
                        DialogueSystem.lines.Add("Хорошо, сейчас будет|Вы");

                        DialogueSystem.authorSprite.Add(krips[3]);
                        DialogueSystem.authorSprite.Add(krips[3]);
                        break;
                    case 6:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("Чёрт, а можно ещё один?|Заказчик");
                        DialogueSystem.lines.Add("Конечно можно|Вы");
                        DialogueSystem.authorSprite.Add(krips[3]);
                        DialogueSystem.authorSprite.Add(krips[3]);
                        break;
                    case 8:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();
                        DialogueSystem.lines.Add("КАК ЖЕ ЭТО ВКУСНО, держи!|Заказчик");
                        DialogueSystem.authorSprite.Add(krips[3]);
                        DialogueSystem.moneyChange(120);
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Show();
                        break;
                    case 10:
                        DialogueSystem.lines.Add("Друг, дай пожалуйста поесть чего нибудь.|Бедуин");
                        DialogueSystem.audios.Add("audio/dialogue/biduin/biduin1");
                        DialogueSystem.lines.Add("Денег ваших заморских нет, но уверяю не обижу по оплате.|Бедуин");
                        DialogueSystem.audios.Add("audio/dialogue/biduin/biduin2");

                        DialogueSystem.authorSprite.Add(charachters[2]);
                        DialogueSystem.authorSprite.Add(charachters[2]);
                        break;
                    case 12:
                        DialogueSystem.lines.Add("Здравствуйте, сэр! Надеюсь вы готовы отдать мне свои деньги|Налоговик");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog17");

                        DialogueSystem.authorSprite.Add(charachters[1]);
                        DialogueSystem.moneyChange(100, false);
                        break;
                }
                break;
        }
    }
}
*/