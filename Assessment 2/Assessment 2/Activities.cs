using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    public enum ActivityType
    {
        Land,
        Water,
        Air
    }
    class Activities : IComparable
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime Date { get; set; }

        public decimal Cost { get; set; }

       public ActivityType TypeofActivity;
        public Activities(string name, string description, DateTime date, decimal cost,ActivityType activityType)
        {
            Name = name;
            Description = description;
            Date = date;
            Cost = cost;
            TypeofActivity = activityType;
        }

        //public static Activities[] activities = new Activities[]
        //{
        //    new Activities("Kayaking","Boat Rowing",new DateTime (2019,6,1),20,ActivityType.Water),
        //     new Activities("Parachuting","Droping from big height with parachute ",new DateTime (2019,6,1),100,ActivityType.Air),
        //      new Activities("Mountain Biking","Going up mountain on bike",new DateTime (2019,6,2),40,ActivityType.Land),
        //       new Activities("Hang Gliding","Flying with a glider",new DateTime (2019,6,2),50,ActivityType.Air),
        //        new Activities("Abseiling","controlled descent off a vertical drop",new DateTime (2019,6,3),65,ActivityType.Land),
        //         new Activities("Sailing","Sailing",new DateTime (2019,6,3),35,ActivityType.Water),
        //          new Activities("Helicopter Tour","sight seeing in helicopter",new DateTime (2019,6,4),92,ActivityType.Air),
        //             new Activities("Treking","hiking up mountains",new DateTime (2019,6,1),92,ActivityType.Land),
        //                new Activities("Surfing","Riding the waves",new DateTime (2019,6,5),92,ActivityType.Water)
        //};

        public int CompareTo(object obj)
        {
            // how to sort book 
            Activities that = obj as Activities;

            return this.Date.CompareTo(that.Date);
        }

        public override string ToString()
        {
            return $"{Name} - {Date.ToShortDateString()} - {Cost:c} ";
        }


    }
}
