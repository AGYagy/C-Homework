using System;

namespace Homework4._1
{
    public delegate void AlarmclockEventHandler();

    public class Alarmclock
    {
        public event AlarmclockEventHandler SendMessage;
        public void OnSendMessage()
        {
            SendMessage();
        }
    }

    public class Student 
    {
        public void HandlerEvent()
        {
            Console.WriteLine("该开会了");
        }

        public void Register(Alarmclock e)
        {
            Alarmclock alarmclock = new Alarmclock(); 
            alarmclock.SendMessage += new AlarmclockEventHandler(HandlerEvent);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Alarmclock alarmclock = new Alarmclock();
            Student student = new Student();
            student.Register(alarmclock);
            

            if(DateTime.Now.Hour== 6)
            {
                alarmclock.OnSendMessage();
            }
        }
    }

    
    
}
