using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogues : MonoBehaviour
{
    public static void DefineDialogue(int day, int counter, Sprite[] krips, Sprite[] charachters)
    {
        switch (day) { 
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

                        DialogueSystem.lines.Add("�����.|��");
                        DialogueSystem.lines.Add("�������� �������, ����������.|��������");
                        DialogueSystem.authorSprite.Add(krips[1]);
                        DialogueSystem.authorSprite.Add(krips[1]);
                        DialogueSystem.moneyChange(60);
                        break;
                    case 8:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("������������, �� ������ ����� ����������� ���������� ����� ������, �������� �������...|���������");
                        DialogueSystem.lines.Add("����� �� �� �������, ��� ���������� ������.|��");
                        DialogueSystem.lines.Add("�� �� ������ �������� ���������� � ����������� ����� ���� ��� ��������� ������|���������");
                        DialogueSystem.lines.Add("��� ���� ��������, �� ��� �������� ����������� �����, ���� �� ������� ������� � ���������� �����, � �� � ��� ����� �������.|��");
                        DialogueSystem.lines.Add("� ����� �� ��������, ��� �������� ����������� ��� ������� �������, ������� ������ ���, ���� � ����� �� �� ������������. ��������� �� ��������, ��� ����� �� ����� ���� �����������.|���������");
                        DialogueSystem.lines.Add("�� ��� ������� ������ ������ � �������� ������� ������� � ������ �������� ���, � �� ����������� ������� ������ ������������ ����������.|��");
                        for (int i = 0; i < 6; i++)
                        {
                            DialogueSystem.authorSprite.Add(charachters[0]);
                        }

                        DialogueSystem.lines.Add("�� �� ���� �� ������������, � ���� ������� ������ �����. �� � ����� ��, ��� �� �� �������� ����������� � ��������� ������ ���������� �������, ��-������ ����� �������,��� ���������� ����� 15-��!|���������");
                        DialogueSystem.lines.Add("�� ������ ����������. �� ���� ������� ��� ������ �� ����� �����.|��");
                        DialogueSystem.authorSprite.Add(charachters[1]);
                        DialogueSystem.authorSprite.Add(charachters[1]);

                        DialogueSystem.lines.Add("���-���, �� ������ �� ������? �������, ��� ���� � ������� �� ����� �������, �� � ������ �� �������� �����.|���������");
                        DialogueSystem.lines.Add("������, ������ ������! �� ����� �������� ���. ���� �� ��������.|��");
                        DialogueSystem.lines.Add("��� ���������� ���� � �������.|���������");
                        DialogueSystem.lines.Add("����� ���������, ���������� �� ������ ��������, ��� ��������� �����, ��� ���� ������� ��������, �������� ���, ���������������� ����������!|��");
                        DialogueSystem.lines.Add("� �������� ����� ������ � ����� �����, ���� �� ��������� � �� ������ ��� ����� ������|���������");
                        DialogueSystem.lines.Add("���! � ������ �� ���� ���� �������������� ������, ������� ��������� ������ �������� ���������� ��� ���� ������ �� ����� ��������.|��");
                        DialogueSystem.lines.Add("������� ��� ���������,������� �� ��������� ���� � ���� ������ �������������� �����,�� �������� ��� ��� ����� � � ���� �� ����� �����.|���������");
                        DialogueSystem.lines.Add("��� �� �����, � ������, ������� �������� � ����� �������, �������� ���������� �� ����� ������.|��");
                        DialogueSystem.lines.Add("� ������ ������ �� ����� ���|���������");
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
                        DialogueSystem.lines.Add("��� ������?|��");
                        DialogueSystem.lines.Add("��-��. ����� ������. ��� ���� ���������|���������");
                        DialogueSystem.lines.Add("��� ������� ������� ������� ����.|��");
                        DialogueSystem.lines.Add("��� ������� ��� ����������.|���������");
                        DialogueSystem.lines.Add("������...|��");
                        for (int i = 0; i < 6; i++)
                        {
                            DialogueSystem.authorSprite.Add(charachters[0]);
                        }
                        break;
                    case 12:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("� �������, ��� �������� ��� �������� � ������ ������� ������ ���� ���� � �� ������� � ����� ������ �������, �� ��� ��, ������� ��������, ���� ����� ��������� ����?|���������");
                        DialogueSystem.lines.Add("������, ���������� ������ �������� ��������� ������� ������������ ����! ������� ��� ����� ���������� ���� ������ �������� ���� ����� ��������� ��������|��");
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        DialogueSystem.authorSprite.Add(charachters[0]);
                        break;
                    case 14:
                        GameObject.FindWithTag("dialog").GetComponent<DialogueSystem>().Hide();

                        DialogueSystem.lines.Add("�������� ���� ��������� �����, ����� �� ��������������� �������� ���������.|��");
                        DialogueSystem.moneyChange(100);
                        DialogueSystem.authorSprite.Add(charachters[0]);

                        DialogueSystem.lines.Add("������� � �� ���� ����� �������.|���������");
                        DialogueSystem.lines.Add("����� ������ ������, �� ��� ��� ������� ���������|��");
                        DialogueSystem.lines.Add("�������� ����������� �����. ���.. ������ �������� ���� ����� ���������� �������� ��� ���������� ����, ���������� �������, ��-������ ����� �������,��� ���������� ����� 15-��!|���������");
                        DialogueSystem.lines.Add("� ��� ������������������ ��������� ��-������� �� �������� �������� �-����, �������� �� ����������� �������� � ��-���� ����.|���������");
                        DialogueSystem.lines.Add("������ ����� ���������� �-����� ��-������ ����� �������,��� ���������� ����� 15-��, �������������� �-� ���� ��-�������� �� ��� ��-����:|���������");
                        DialogueSystem.lines.Add("�������� ����� ������, ��� ������ ��� ��� 1000 ������� ��� ����� ����. ����� ���, ��� ����� �����, ���������.|���������");
                        DialogueSystem.lines.Add("��� �����, ��� ������ ���� � ���� ����� ��������� ���� ����, ������� �� ������ ��������� � ������� ������� ��������, ���������.|���������");
                        DialogueSystem.lines.Add("� ��� ��� �����, �� ����� ������ �� ��� ����� ��� �������� ������ ���� �������, ���������, �����.|���������");
                        DialogueSystem.lines.Add("�� ����� ������� ��� ���,� ��� ���� ����� �������, ���������, ��� � ����� ���������� ��� ������, ���� ��, ���������, ������� ��� 100 ������!|���������");
                        DialogueSystem.lines.Add("�� ���� � �����. ��� �� ������, ���������, � ��� ������� ����� �� ���������! ����� ��|���������");
                        DialogueSystem.lines.Add("� ������ ����� �������,��� ���������� ����� 15-�� ����� ����� ��� ���� ����� ������ ��������. �������� ������, ��� �-����� ��-���� �������� � ��-���������!|���������");
                        DialogueSystem.lines.Add("��� ������, � ��� ������ ����� ���, ����� ����������, ������?|��");
                        DialogueSystem.lines.Add("�������� �� ��������, ��� ��-���� ����� ��� ����������, ����� ��������� ��� ������������� ������, �� � ������� ��� ��� ������ ����.|���������");
                        DialogueSystem.lines.Add("��� ������ �� �� ������ ������� � ����� � ���. ������ �� ������, � ��� ������ �����?|��");
                        DialogueSystem.lines.Add("�� �� ������ ����� ���, ���� �� ����� � ���� ��� ��� �����������. � ���������� 1000 �������. ������ ������ �� ������, �� � ��� ��������� ��� ���� �����, ������� ���������, �� ���� ������ ����� ��������|���������");
                        DialogueSystem.lines.Add("��� ��� ����������� ��� ������������, �� ����� ����������� ��� ����� ������ � ����� ������|��");
                        DialogueSystem.lines.Add("��� �-����� ����� � ��������� ��������, �� � ��������, ����� ��� �� ����������.|���������");
                        DialogueSystem.lines.Add("� ��������� ��� ������, �� ������ ��� ������������� ����� �� �����  ������� � ������� ������, � � ����� ������, � ����� �������� ��������� ���������, �� �������� ��� ������� ������, ������� �� ��������.|���������");
                        DialogueSystem.lines.Add("� ������ ������ ������, ������ ������ ��� � ��� ��� ���.|���������");
                        DialogueSystem.lines.Add("�� ���� � ������, �������� ���� ������.|��");
                        DialogueSystem.lines.Add("� ���� �� ����� ������� ����� ����, �� ��� ��� �� ������ � ���������|���������");
                        DialogueSystem.lines.Add("������, ��� � ��� ��� ������ �������. ���� �� ���������� ��� ������� ��������� ��� ������ ���������? ����� ����������, � � ����� �����������, ��������, ������� ����� ���� ������ �����������, ����� �� �����.|��������");
                        DialogueSystem.lines.Add("�� ���������|��");
                        for (int i = 0; i < 21; i++)
                        {
                            DialogueSystem.authorSprite.Add(charachters[1]);
                        }
                        DialogueSystem.authorSprite.Add(charachters[3]);
                        DialogueSystem.authorSprite.Add(charachters[3]);
                        DialogueSystem.canNextDay = true;
                        break;
                }
                break;
            case 1:
                switch(counter)
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
                            DialogueSystem.lines.Add("����, ��� ���������� ������ ���� ������. ����� ����� ��������� ���, �� ������ �� ����� �� ������.|������");
                            DialogueSystem.authorSprite.Add(charachters[2]);
                            break;
                        case 12:
                            DialogueSystem.lines.Add("������������, ���! ������� �� ������ ������ ��� ���� ������");
                            DialogueSystem.authorSprite.Add(charachters[1]);
                            DialogueSystem.moneyChange(100, false);
                            break;
                }
                break;
        }
    }
}
