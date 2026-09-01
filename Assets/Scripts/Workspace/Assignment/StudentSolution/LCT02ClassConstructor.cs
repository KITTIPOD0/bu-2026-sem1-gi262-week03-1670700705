using UnityEngine;



// SKIP Lecture ...
namespace Assignment.StudentSolution.LCT02
{
    public class Dog
    {
        // properties including name, breed, age ...

        public string name;
        public string breed;
        public int age;

        // end of properties ...

        // สร้าง constructor ที่รับ parameter 3 ตัว และกำหนดค่าให้กับ properties ของ class
        // โดยทั้ง 3 parameter คือ name, breed, age ตามลำดับ
        public Dog(string name1,string bread1)//ต้องสร้างคอนสตักเตอร์ชื่อเดียวกับชื่อคลาส
        {
            name = name1;//ทุกตัวที่ถูกสร้างจะเป็นชื่อDog
            breed = bread1;
        }

        /// behaviors ...

        public void Bark()
        {

        }

        public void WagTail()
        {

        }

        public void StopBarking()
        {

        }

        // end of behaviors ...
    }

    public class LCT02ClassConstructor
    {
        Dog dog1;

        public void Start()
        {
            dog1 = new Dog("Dog1","Golden");
            dog1.Bark();
            dog1.WagTail();
            dog1.StopBarking();
        }
    }
}
