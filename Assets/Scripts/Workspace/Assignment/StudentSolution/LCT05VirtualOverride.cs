using UnityEngine;


namespace Assignment.StudentSolution.LCT05
{
    public class Animal
    {
        // 0. make MakeSound method to virtual method
        public virtual void MakeSound()
        {
            Debug.Log("Generic animal sound");
        }
    }

    public class Dog:Animal
    {
        public override void MakeSound()
        {
            Debug.Log("woffd");
        }
    }

    public class Cat:Animal
    {
        public override void MakeSound()
        {
            Debug.Log("Meow");
        }
        // student code ends ...    
    }



    public class LCT05VirtualOverride
    {
        public void Start()
        {
            // 3. create instance of Dog and call MakeSound()

            // 4. create instance of Cat and call MakeSound()

            // 5. create instance of Animal and call MakeSound()
        }
    }
}
