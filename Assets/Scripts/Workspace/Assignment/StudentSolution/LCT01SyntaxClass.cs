using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    
    public class Car
    {
        public string Name;
        public float Speed;
        public string Color;

        public void Move() 
        {
            Debug.Log("Car is moving");
        }
        public void Turn()
        {
            Debug.Log("Car is Turn");
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            // Student code start HERE ...
            Car car1 = new Car(); //ดึงของจาก classอื่นมาใช้
            car1.Name = "Lambogini";
            Debug.Log(car1.Name);
            car1.Turn();
            car1.Move();

            Car car2 = new();//เหมือนสร้างออกมาอีกตัว
            car2.Name = "Toyota";
            // Student code ends HERE 
        }
    }
}
