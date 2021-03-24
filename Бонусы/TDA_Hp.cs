using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TDA_Hp : MonoBehaviour
{
    public Image UIHP; //Картинка здоровья
    public float HP = 1f;  //значение здоровья = 100
    //public Image UIOxy;  //значение кислорода
    //public float Oxy = 1f; // Значение кислорода = 100
    public GameObject Ragdoll;
    public Text HPBottleT;
    public float HPBottle = 0f;
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) & HPBottle > 0f & HP < 1f)
        {
            HP = HP + 0.15f;
        }
        if(HP > 1f)
        {
            HP = 1f;
        }
        if (HP < 0)
        {
            gameObject.SetActive(false);
            Instantiate(Ragdoll, transform.position, transform.rotation);
        }
        //HPBottleT.text = "" + HPBottle;
        UIHP.fillAmount = HP;
        //UIOxy.fillAmount = Oxy;
    }
     void OnTriggerStay(Collider other) //Обновляется каждый кадр
    {
        if (other.tag == "Dead") //Если песронаж заходит в зону с обозначением Dead 
        {
            HP -= Time.deltaTime / 14f; //Мы отнимаем значение хп деленое на 4
        }
        //if (other.tag == "Water") //Если песронаж заходит в зону с обозначением Water
        //{
        //    Oxy -= Time.deltaTime / 7f; //Мы отнимаем значение кислорода деленое на 7
        //}
        if (HP < 0) // Чтобы хп не заходило за минус, мы задаем параметр, если здоровье меньше нуля, то оно равно нулю
        {
            HP = 0;
        }
        //if (Oxy < 0) //Тот же принцип что и со здоровьем
        //{
        //    Oxy = 0;
        //}
        ////if (Oxy == 0) //Если кислород = 0
        {
            HP -= Time.deltaTime / 4f; //Начинаем отнимать наше хп
        }
        if (other.tag =="HPBottle" & Input.GetKeyDown(KeyCode.F))
        {
            HPBottle = HPBottle + 1f;
        }
    }
}

