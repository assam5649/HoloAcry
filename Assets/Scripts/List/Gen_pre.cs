using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrefab : MonoBehaviour
{
    // �v���n�u�i�[�p
    public GameObject HolePrefab;
    public GameObject WallPrefab;
    public GameObject canvas;

    public int n = 4;//�K���ɓ���Đ�������邩�e�X�g����B���xml�Ȃǂɂ��鐔�l���Q�Ƃ���B

    // Start is called before the first frame update
    void Start()
    {
        n += 1;//n�̌��|����̒l�Ǝ��ۂɐ��������prefab�̍���1�A�߂�l��ݒ肷��ꍇ��-1����B

        GameObject Obj;


        if (n == 0)
        {
            Vector3 vec = new Vector3(0.0f, 0.0f, 0.0f);
            Vector3 vec2 = new Vector3(830.0f, 0.0f, 0.0f);

            for (int i = 1; i < 30; i++) //30�Ƃ������l�͓K����ŕς���
            {
                if ((i % 2) == 1)
                {
                    Obj = Instantiate(WallPrefab, vec, Quaternion.identity);
                    Obj.transform.SetParent(canvas.transform, false);
                    vec.y -= 880.0f;
                }

                if ((i % 2) == 0)
                {
                    Obj = Instantiate(WallPrefab, vec2, Quaternion.identity);
                    Obj.transform.SetParent(canvas.transform, false);
                    vec2.y -= 880.0f;
                }
                
            }
        }

        if (0 < n)
        {
            Vector3 vec = new Vector3(0.0f, 0.0f, 0.0f);
            Vector3 vec2 = new Vector3(830.0f, 0.0f, 0.0f);

            for (int i = 1; i < n; i++) //30�Ƃ������l�͓K����ŕς���
            {
                if ((i % 2) == 1)
                {
                    Obj = Instantiate(HolePrefab, vec, Quaternion.identity);
                    Obj.transform.SetParent(canvas.transform, false);
                    vec.y -= 880.0f;
                }

                if ((i % 2) == 0)
                {
                    Obj = Instantiate(HolePrefab, vec2, Quaternion.identity);
                    Obj.transform.SetParent(canvas.transform, false);
                    vec2.y -= 880.0f;
                }
                if ((n - 1) == i)//�Ō�̃��[�v�ł����
                {
                    for (; i < 30; i++) //30�Ƃ������l�͓K����ŕς���
                    {
                        vec2.x = 900.0f;
                        if ((i % 2) == 1)
                        {
                            Obj = Instantiate(WallPrefab, vec, Quaternion.identity);
                            Obj.transform.SetParent(canvas.transform, false);
                            vec.y -= 880.0f;
                        }

                        if ((i % 2) == 0)
                        {
                            Obj = Instantiate(WallPrefab, vec2, Quaternion.identity);
                            Obj.transform.SetParent(canvas.transform, false);
                            vec2.y -= 880.0f;
                        }

                    }
                }
                
            }
            
        }


    }
}

    // Update is called once per frame
