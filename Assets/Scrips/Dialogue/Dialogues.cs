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

                        DialogueSystem.lines.Add("������������, ����� ���� � �������?|��������");
                        DialogueSystem.lines.Add("����� �������.|��");

                        DialogueSystem.authorSprite.Add(krips[0]);
                        DialogueSystem.authorSprite.Add(krips[0]);
                        break;
                    case 2:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("�������, ��� ������.|��������");
                        DialogueSystem.lines.Add("����� �������.|��");

                        DialogueSystem.authorSprite.Add(krips[0]);
                        DialogueSystem.authorSprite.Add(krips[0]);
                        DialogueSystem.moneyChange(60);
                        break;
                    case 4:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("������������, ����� ��������?|��������");
                        DialogueSystem.lines.Add("��, ������� ��������.|��");

                        DialogueSystem.authorSprite.Add(krips[1]);
                        DialogueSystem.authorSprite.Add(krips[1]);
                        break;
                    case 6:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("�����.|��"); ;
                        DialogueSystem.lines.Add("�������� �������, �� ��������.|��������");

                        DialogueSystem.authorSprite.Add(krips[1]);
                        DialogueSystem.authorSprite.Add(krips[1]);
                        DialogueSystem.moneyChange(60);
                        break;
                    case 8:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("������������, �� ������ ����� ����������� ���������� ����� ������ - �������� �������...|���������");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd1");

                        DialogueSystem.lines.Add("����� �� �� �������, ��� ���������� ������?|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg5");

                        DialogueSystem.lines.Add("�� �� ������ �������� ���������� � ����������� ����� ���� ��� ��������� ������|���������");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd2");

                        DialogueSystem.lines.Add("��� ���� ��������, �� ��� �������� ����������� �����, ���� �� ������� ������� � ���������� �����, � �� � ��� ����� �������.|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg6");

                        DialogueSystem.lines.Add("� ����� �� ��������, ��� �������� ����������� ��� ������� �������, ������� ������ ���, ���� � ����� �� �� ������������. ��������� �� ��������, ��� ����� �� ����� ���� �����������.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd3");

                        DialogueSystem.lines.Add("�� ��� ������� ������ ������ � �������� ������� ������� � ������ �������� ���, � �� ����������� ������� ������ ������������� ����������.|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg7");

                        for (int i = 0; i < 6; i++)
                        {
                            DialogueSystem.authorSprite.Add(charachters[0]);
                        }

                        DialogueSystem.lines.Add("�� �� ���� �� ������������, � ���� ������� ������ �����. �� � ����� ��, ��� �� �� �������� ����������� � ��������� ������ ���������� ������� - ��-������ ����� �������,��� ���������� ����� 15-��!|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog1");

                        DialogueSystem.lines.Add("�� ������ ����������. �� ���� ������� ��� ������ �� ����� �����.|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg8");

                        DialogueSystem.authorSprite.Add(charachters[1]);
                        DialogueSystem.authorSprite.Add(charachters[1]);

                        DialogueSystem.lines.Add("���-���, �� ������ �� ������? �������, ��� ���� � ������� �� ����� �������, �� � ������-�� �������� �����.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd6");

                        DialogueSystem.lines.Add("������, ������ ������! �� ����� �������� ���. ���� �� ��������.|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg9");

                        DialogueSystem.lines.Add("��� ���������� ���� � �������.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd7");

                        DialogueSystem.lines.Add("����� ���������, ���������� �� ������ ��������, ��� ��������� �����, ��� ���� ������� ��������, �������� ���, ���������������� ����������!|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg10");

                        DialogueSystem.lines.Add("� �������� ����� ������ � ����� �����, ���� �� ��������� � �� ������ ��� ����� ������|���������");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd8");

                        DialogueSystem.lines.Add("���! � ������ �� ���� ���� �������������� ������, ������� ��������� ������ �������� ���������� ��� ���� ������ �� ����� ��������.|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg12");

                        DialogueSystem.lines.Add("������� ��� ���������,������� �� ���������� ���� � ���� ������ �������������� �����,�� �������� ��� ��� ����� � � ���� �� ����� �����.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd9");

                        DialogueSystem.lines.Add("��� �� �����, � ������, ������� �������� � ����� �������, �������� ���������� �� ����� ������.|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg13");

                        DialogueSystem.lines.Add("�� ����� �� ����� ���.|���������");
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

                        DialogueSystem.lines.Add("� �������, ��� �� ����� �� ����� ���, ��������.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd10");

                        DialogueSystem.lines.Add("��� ������?|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg14");

                        DialogueSystem.lines.Add("��-��. ����� ������. ��� ���� ���������|���������");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd11");

                        DialogueSystem.lines.Add("��� ������� ������� ������� ����.|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg15");

                        DialogueSystem.lines.Add("��� ������� ��� ����������.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd12");

                        DialogueSystem.lines.Add("������...|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg16");

                        for (int i = 0; i < 6; i++)
                        {
                            DialogueSystem.authorSprite.Add(charachters[0]);
                        }
                        break;
                    case 12:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("� �������, ��� �������� ��� �������� � ������ ������� ������ ���� ���� � �� ������� � ����� ������ �������, �� ��� ��, ������� ��������, ���� ����� ��������� ����?|���������");
                        DialogueSystem.audios.Add("audio/dialogue/zvezd/zvezd13");
                        DialogueSystem.lines.Add("������! ���������� ������ �������� ��������� ������� ������������ ����!|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg17");
                        DialogueSystem.lines.Add("������� ��� ����� ���������� ���� ������ �������� ���� ����� ��������� ��������|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg18");

                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        break;
                    case 14:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("�������� ���� �������� �����, ����� �� ��������������� �������� ���������.|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg19");

                        DialogueSystem.moneyChange(100);
                        DialogueSystem.authorSprite.Add(charachters[0]);


                        DialogueSystem.lines.Add("����� ������ ������, �� ��� ��� ������� ���������|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg20");

                        DialogueSystem.lines.Add("�������� ����������� ������. ���...|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog2");

                        DialogueSystem.lines.Add("������ �������� ���� ����� ���������� �������� ��� ���������� ����, ���������� ������� - ��-������ ����� �������,��� ���������� ����� 18-��!|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog21");

                        DialogueSystem.lines.Add("� ��� ������������������ ��������� �� - ������� �� �������� �������� � - ����, �������� �� ����������� �������� � �� - ���� ����.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog22");

                        DialogueSystem.lines.Add("����� ����� ���������� �-����� ��-������ ����� �������,��� ���������� ����� 15-��, �������������� �-� ���� ��-�������� �� ��� ��-����:|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog4");

                        DialogueSystem.lines.Add("������� ����� ������, ��� ������ ��� ��� 1000 ������� ��� ����� ����. ����� ���, ��� ����� �����, ���������.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog5");

                        DialogueSystem.lines.Add("��� �����, ��� ������ ���� � ���� ����� ��������� ���� ����, ������� �� ������ ��������� � ������� ������� ��������, ���������.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog6");

                        DialogueSystem.lines.Add("� ��� ��� �����, �� ����� ������ �� ��� ����� ��� �������� ������ ���� �������, ���������, �����.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog7");

                        DialogueSystem.lines.Add("�� ����� ������� ��� ���,� ��� ���� ����� �������, ���������, ��� � ����� ���������� ��� ������, ���� ��, ���������, ������� ��� 100 ������!|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog8");

                        DialogueSystem.lines.Add("�� ���� � �����. ��� �� ������, ���������, � ��� ������� ����� �� ���������! ����� ��|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog9");

                        DialogueSystem.lines.Add("� ������ ����� �������,��� ���������� ����� 15-�� ����� ����� ��� ���� ����� ������ ��������. �������� ������, ��� �-����� ��-���� �������� � ��-���������!|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog10");

                        DialogueSystem.lines.Add("��� ������, � ��� ������ ����� ���, ����� ����������, ������?|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg21");

                        DialogueSystem.lines.Add("�������� �� ��������, ��� ��-���� ����� ��� ����������, ����� ��������� ��� ������������� ������, �� � ������� ��� ��� ������ ����.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog11");

                        DialogueSystem.lines.Add("��� ������ �� �� ������ ������� � ����� � ���. ������ �� ������, � ��� ����� ������?|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg22");

                        DialogueSystem.lines.Add("�� �� ������ ����� ���, ���� �� ����� � ���� ���, ��� �����������. � ���������� 1000 �������. ������ ������ �� ������, �� � ��� ��������� ��� ���� �����.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog12");

                        DialogueSystem.lines.Add("������� ���������, �� ���� ������ ����� ��������|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog13");

                        DialogueSystem.lines.Add("��� ��� ����������� ��� ������������, �� ����� ����������� ��� ����� ������ � ����� ������.|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg23");

                        DialogueSystem.lines.Add("��� �-����� ����� � ��������� ��������, �� � ��������, ����� ��� �� ����������.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog14");

                        DialogueSystem.lines.Add("� ��������� ��� ������, �� ������ ��� ������������� ����� �� ����� �������.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog15");

                        DialogueSystem.lines.Add("� ������� ������, � � ����� ������, � ����� �������� ��������� ���������, �� �������� ��� ������� ������, ������� �� ��������. � ������ ������ ������, ������ ������ ��� � ��� ��� ���.|���������");
                        DialogueSystem.audios.Add("audio/dialogue/nalog/nalog16");

                        DialogueSystem.lines.Add("�� ���� � ������, �������� ���� ������.|��");
                        DialogueSystem.audios.Add("audio/dialogue/gg/gg24");


                        DialogueSystem.lines.Add("������, ��� � ��� ��� ������ �������.|��������");
                        DialogueSystem.audios.Add("audio/dialogue/traider/traider1");
                        DialogueSystem.lines.Add("���� �� ���������� ��� ������� ��������� ��� ������ ���������?|��������");
                        DialogueSystem.audios.Add("audio/dialogue/traider/traider2");
                        DialogueSystem.lines.Add("����� ����������, � � ����� �����������, ��������, ������� ����� ���� ������ �����������, ����� �� �����.|��������");
                        DialogueSystem.audios.Add("audio/dialogue/traider/traider3");

                        DialogueSystem.lines.Add("�� ���������|��");
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
                        DialogueSystem.lines.Add("������ � ��� ��������� ����� � ��������, ����� ��� ����?|��������");
                        DialogueSystem.lines.Add("������|��");

                        DialogueSystem.authorSprite.Add(krips[2]);
                        DialogueSystem.authorSprite.Add(krips[2]);
                        break;
                    case 2:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("��������� ��������|��");

                        DialogueSystem.authorSprite.Add(krips[2]);
                        DialogueSystem.moneyChange(75);
                        break;
                    case 4:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("���� � �������|��������");
                        DialogueSystem.lines.Add("������, ������ �����|��");

                        DialogueSystem.authorSprite.Add(krips[3]);
                        DialogueSystem.authorSprite.Add(krips[3]);
                        break;
                    case 6:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("׸��, � ����� ��� ����?|��������");
                        DialogueSystem.lines.Add("������� �����|��");
                        DialogueSystem.authorSprite.Add(krips[3]);
                        DialogueSystem.authorSprite.Add(krips[3]);
                        break;
                    case 8:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();
                        DialogueSystem.lines.Add("��� �� ��� ������, �����!|��������");
                        DialogueSystem.authorSprite.Add(krips[3]);
                        DialogueSystem.moneyChange(120);
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Show();
                        break;
                    case 10:
                        DialogueSystem.lines.Add("����, ��� ���������� ������ ���� ������.|������");
                        DialogueSystem.audios.Add("audio/dialogue/biduin/biduin1");
                        DialogueSystem.lines.Add("����� ����� ��������� ���, �� ������ �� ����� �� ������.|������");
                        DialogueSystem.audios.Add("audio/dialogue/biduin/biduin2");

                        DialogueSystem.authorSprite.Add(charachters[2]);
                        DialogueSystem.authorSprite.Add(charachters[2]);
                        break;
                    case 12:
                        DialogueSystem.lines.Add("������������, ���! ������� �� ������ ������ ��� ���� ������|���������");
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