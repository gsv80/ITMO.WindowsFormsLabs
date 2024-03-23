using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClass
{
    class Magazine : Item, IPubs
    //Magazine(Title, Volume, Topic, Language, Year, Month);
    {
        private String title;
        private String volume;    // том
        private String topic;        // номер
        private String language;

        private int year;      // дата выпуска
        private int month;

        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(String title, String volume, String topic, String language, int year, int month, long invNumber, bool taken): base(invNumber, taken)
            
        {
            this.title = title;
            this.volume = volume;
           
            this.topic = topic;
            this.language = language;
            this.year = year;
            this.month = month;

        }
        public Magazine() { }


       public override void Return()    // операция "вернуть"
       {
           taken = true;
       }

        // реализация интерфейса

      

      public void Subs()
      {
          // действия при оформлении подписки на журнал
      }


       public override string ToString()
       {
           if (IfSubs)
           return "\nЖурнал:\n Название: " + title + "\nТом: " + volume + "\n Topic: " + topic +
           "\n lang: " + language + "\nГод выпуска: " + year + "\nTopic: " + topic+  "\nПодписка оформлена" + "\nInvNum: " + invNumber;
           else
               return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n lang: " + language + "\nГод выпуска: " + year + "\n Подписка не оформлена" + "\nInvNum: "+ invNumber ;
       }
    }
}
